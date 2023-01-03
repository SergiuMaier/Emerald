using SuperSimpleTcp;
using System.Globalization;
using System.Text;

namespace TCPClient
{
    public partial class FormClient : Form
    {
        SimpleTcpClient client;
        FunctionCodes fc = new FunctionCodes();
        System.Diagnostics.Stopwatch executionTime = new System.Diagnostics.Stopwatch();

        public static string addMessageToHistory = "";

        private int counterNoOfRegisters; // counter for btnMinus & btnPlus
        public int counterTransactionId;
        public byte functionCode, slaveId;

        enum Header
        {
            TransactionId = 0,
            ProtocolId = 2,
            SlaveId = 6
        }

        enum MessageStructure 
        { 
            FunctionCode = 7,
            ExceptionCode = 8
        }

        public const short protocolId = 0x0000;
        public const byte COM100Id = 0xFF;
        public const byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x10;
        public const byte header_Length = 0x06;
        public const byte slaveId_Length = 0x01;
        public const byte functionCode_Length = 0x01;
        public const byte dataAddress_Length = 0x02;
        public const byte dataRegisters_Length = 0x02;
        public const byte numberOfBytesToFollow_Length = 0x01;

        public byte[] bufferRequest;
        public byte[] bufferResponse;

        bool selected03, selected06, selected16;
        
        byte bufferLength03 = header_Length + slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte bufferLength06 = header_Length + slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length;
        byte bufferLength16 = header_Length + slaveId_Length + functionCode_Length + dataAddress_Length + dataRegisters_Length + numberOfBytesToFollow_Length;

        public FormClient()
        {
            InitializeComponent();

            toolTipForm.SetToolTip(btnConnect, "Connect to the device");
            toolTipForm.SetToolTip(btnSend, "Send a request");
            toolTipForm.SetToolTip(btnClear, "Clear request and response messages from text boxes");
            toolTipForm.SetToolTip(btnHistory, "View message history");
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            panelMessage.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new SimpleTcpClient(richtxtIP.Text + ":" + richtxtPort.Text);

                client.Events.Connected += Connected;
                client.Events.DataReceived += DataReceived;

                client.Connect();

                comboFunctionCode.SelectedIndexChanged += comboFunctionCode_SelectedIndexChanged;
            }
            catch
            {
                if ((richtxtIP.Text == "") && (richtxtPort.Text == ""))
                    MessageBox.Show("Please enter an IP Address and a Port Number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Please enter a correct IP Address and Port Number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connected(object sender, ConnectionEventArgs e)
        {
            labelStatus2.Text = "Connected";
            labelStatus2.ForeColor = Color.Green;
            panelMessage.Enabled = true;
            btnSend.Enabled = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Events.Disconnected += Disconnected;
                //client.Disconnect(); //crash

                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnSend.Enabled = false;

                richtxtIP.Enabled = true;
                richtxtPort.Enabled = true;

                labelStatus2.Text = "Not connected";
                labelStatus2.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnected(object sender, ConnectionEventArgs e)
        {
            labelStatus2.Text = "Not connected";
            labelStatus2.ForeColor = Color.Red;
            btnConnect.Enabled = true;
            richtxtIP.Enabled = true;
            richtxtPort.Enabled = true;
        }

        private void comboSlave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSlave.SelectedIndex == 0)
            {
                slaveId = COM100Id;
                richtxtSlaveId.Visible = false;
            }
            else
                richtxtSlaveId.Visible = true;
        }

        private void comboFunctionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected03 = (comboFunctionCode.SelectedIndex == 0);
            selected06 = (comboFunctionCode.SelectedIndex == 1);
            selected16 = (comboFunctionCode.SelectedIndex == 2);

            if (selected03)
            {
                functionCode = fc03;
                
                panelValues.Enabled = false;
                panelRegsNumber.Enabled = true;
                richtxtValues.Width = 62;
                richtxtValues.Height = 26;
                richtxtValues.MaxLength = 4;
            }
            else if (selected06)
            {
                functionCode = fc06;
                
                panelRegsNumber.Enabled = false;
                panelValues.Enabled = true;
                richtxtValues.Width = 62;
                richtxtValues.Height = 26;
                richtxtValues.MaxLength = 4;
            }
            else if (selected16)
            {
                functionCode = fc16;
                
                panelRegsNumber.Enabled = true;
                panelValues.Enabled = true;
                richtxtValues.Width = 439;
                richtxtValues.Height = 52;
            } 
        }

        public void BuildRequest()
        {
            counterTransactionId++;
            richtxtTransactionId.Text = counterTransactionId.ToString("X4");

            if(comboSlave.SelectedIndex != 0)
                slaveId = byte.Parse(richtxtSlaveId.Text, NumberStyles.HexNumber);

            if (selected03)
            {
                bufferRequest = new byte[bufferLength03];
                fc.ReadHoldingRegisters(bufferRequest, richtxtTransactionId.Text, protocolId, slaveId, functionCode, richtxtAddress.Text, richtxtNumberRegs.Text);
            }
            else if (selected06)
            {
                bufferRequest = new byte[bufferLength06];
                fc.PresetSingleRegister(bufferRequest, richtxtTransactionId.Text, protocolId, slaveId, functionCode, richtxtAddress.Text, richtxtValues.Text);
            }
            else if (selected16)
            {
                bufferRequest = new byte[bufferLength16 + (2 * counterNoOfRegisters)];
                fc.PresetMultipleRegisters(bufferRequest, richtxtTransactionId.Text, protocolId, slaveId, functionCode, richtxtAddress.Text, richtxtNumberRegs.Text, richtxtValues.Text);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                richtxtRequest.Text = String.Empty;
                richtxtResponse.Text = String.Empty;

                try
                {
                    BuildRequest();
                    client.Send(bufferRequest);

                    addMessageToHistory += $"[{DateTime.Now}]{Environment.NewLine}->";
                    foreach (byte element in bufferRequest)
                    {
                        richtxtRequest.Text += $" {element:X2}";
                        addMessageToHistory += $" {element:X2}";
                    }
                    addMessageToHistory += $"{Environment.NewLine}";
                }
                catch
                {
                    MessageBox.Show("Invalid format", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                bufferResponse = new byte[e.Data.Count];

                //labelException.Text = String.Empty;

                int indexBuffer = 0;
                foreach (byte element in e.Data)
                {
                    bufferResponse[indexBuffer] = element;
                    indexBuffer++;
                }

                AnalyzeResponse();

                addMessageToHistory += $"<-"; 
                foreach (byte element in bufferResponse)
                {
                    richtxtResponse.Text += $" {element:X2}";
                    addMessageToHistory += $" {element:X2}";
                }
                addMessageToHistory += $"{Environment.NewLine}{Environment.NewLine}";
            });
        }
        
        private void AnalyzeResponse()
        {
            labelException.Visible = true;

            if ((bufferResponse[(int)Header.TransactionId] == bufferRequest[(int)Header.TransactionId]) && (bufferResponse[(int)Header.ProtocolId] == bufferRequest[(int)Header.ProtocolId]))
            {
                if (bufferResponse[(int)Header.SlaveId] == bufferRequest[(int)Header.SlaveId])
                {
                    if (bufferResponse[(int)MessageStructure.FunctionCode] == bufferRequest[(int)MessageStructure.FunctionCode]) 
                    { 
                        labelException.Text = "Correct response.";
                        // +++
                    }
                    else
                    {
                        labelException.Text = "Function Code with the highest bit set.";
                        switch (bufferResponse[(int)MessageStructure.ExceptionCode])
                        {
                            case 0x02:  labelException.Text += "\nException Code 02: Illegal Data Address " +
                                                               "\nThe data address received in the query is not an allowable address for the slave.";
                                        break;
                            
                            case 0x03:  labelException.Text += "\nException Code 03: Illegal Data Value " +
                                                               "\nA value contained in the query data field is not an allowable value for the slave.";
                                        break;
                            
                            case 0x0A:  labelException.Text += "\nException Code 0A: Gateway Path Unavailable " +
                                                               "\nThe gateway was unable to allocate an internal communication path from " +
                                                               "the input port to the output port for processing the request.";
                                        break;
                            
                            default:    labelException.Text = "\nException code in response.";
                                        break;
                        }

                        //if (bufferResponse[(int)MessageStructure.ExceptionCode] == 0x02)
                        //    labelException.Text += "Exception Code 02: Illegal Data Address \nThe data address received in the query is not an allowable address for the slave.";
                        //else if (bufferResponse[(int)MessageStructure.ExceptionCode] == 0x03)
                        //    labelException.Text += "Exception Code 03: Illegal Data Value \nA value contained in the query data field is not an allowable value for the slave.";
                        //else if (bufferResponse[(int)MessageStructure.ExceptionCode] == 0x0A)
                        //    labelException.Text += "Exception Code 0A: Gateway Path Unavailable \nThe gateway was unable to allocate an internal communication path from " +
                        //                            "the input port to the output port for processing the request.";
                    }
                }
                else
                {
                    labelException.Text = "Different Slave ID.";

                }
            }
            else
            {
                labelException.Text = "Incorrect response.";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (counterNoOfRegisters > 0)
            {
                counterNoOfRegisters--;
                richtxtNumberRegs.Text = counterNoOfRegisters.ToString("X4");
            }
            else
                btnMinus.Enabled = false;

            if (selected16)
                richtxtValues.MaxLength = 5 * counterNoOfRegisters - 1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (counterNoOfRegisters > 0)
                btnMinus.Enabled = true;

            counterNoOfRegisters++;
            richtxtNumberRegs.Text = counterNoOfRegisters.ToString("X4");

            if (selected16)
                richtxtValues.MaxLength = 5 * counterNoOfRegisters - 1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            richtxtRequest.Text = String.Empty;
            richtxtResponse.Text = String.Empty;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //if (client.IsConnected)
            //{
                try
                {
                    FormHistory formHistory = new FormHistory();
                    formHistory.Show();
                }
                catch
                {
                    MessageBox.Show("Device disconnected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //}
        }
    }
}
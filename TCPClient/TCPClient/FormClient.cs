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

        public static string messageToHistory = "";

        private int numberOfRegisters; // counter for btnMinus & btnPlus
        public int transactionNumber;
        public byte functionCode, slaveId;

        private int functionCodeInResponse = 7;
        private int exceptionInResponse = 8;

        public const short protocolId = 0x0000;
        public const byte COM100Id = 0xFF;
        public const byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x10;
        public const byte headerLength = 0x06;
        public const byte slaveIdLength = 0x01;
        public const byte functionCodeLength = 0x01;
        public const byte firstAddressLength = 0x02;
        public const byte numberOfRegistersLength = 0x02;
        public const byte numberBytesToFollow = 0x01;

        public byte[] bufferRequest;
        public byte[] bufferResponse;

        bool selected03, selected06, selected16;
        
        byte bufferLength03 = headerLength + slaveIdLength + functionCodeLength + firstAddressLength + numberOfRegistersLength;
        byte bufferLength06 = headerLength + slaveIdLength + functionCodeLength + firstAddressLength + numberOfRegistersLength;
        byte bufferLength16 = headerLength + slaveIdLength + functionCodeLength + firstAddressLength + numberOfRegistersLength + numberBytesToFollow;

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
            transactionNumber++;
            richtxtTransactionId.Text = transactionNumber.ToString("X4");

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
                bufferRequest = new byte[bufferLength16 + (2 * numberOfRegisters)];
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

                    messageToHistory += $"[{DateTime.Now}]{Environment.NewLine}->";
                    foreach (byte element in bufferRequest)
                    {
                        richtxtRequest.Text += $" {element:X2}";
                        messageToHistory += $" {element:X2}";
                    }
                    messageToHistory += $"{Environment.NewLine}";
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

                int indexBuffer = 0;
                foreach (byte element in e.Data)
                {
                    bufferResponse[indexBuffer] = element;
                    indexBuffer++;
                }

                AnalyzeResponse();

                messageToHistory += $"<-"; 
                foreach (byte element in bufferResponse)
                {
                    richtxtResponse.Text += $" {element:X2}";
                    messageToHistory += $" {element:X2}";
                }
                messageToHistory += $"{Environment.NewLine}{Environment.NewLine}";
            });
        }
        
        private void AnalyzeResponse()
        {
            if ((bufferResponse[functionCodeInResponse] == 0x83) || (bufferResponse[functionCodeInResponse] == 0x86) || (bufferResponse[functionCodeInResponse] == 0x90))
            {
                labelException.Visible = true;

                if (bufferResponse[exceptionInResponse] == 0x02)
                    labelException.Text = "Exception Code 02: Illegal Data Address";
                else if (bufferResponse[exceptionInResponse] == 0x03)
                    labelException.Text = "Exception Code 03: Illegal Data Value";
                else if (bufferResponse[exceptionInResponse] == 0x0A)
                    labelException.Text = "Exception Code 0A: Gateway Path Unavailable";
            }
            else
            {
                labelException.Text = "-";
                labelException.Visible = false;
            }
        }

        //private void btnAnalyze_Click(object sender, EventArgs e)
        //{
            //if ((bufferResponse[functionCodeInResponse] == 0x83) || (bufferResponse[functionCodeInResponse] == 0x86) || (bufferResponse[functionCodeInResponse] == 0x90))
            //{
            //    if (bufferResponse[exceptionInResponse] == 0x02)
            //    {
            //        MessageBox.Show("Exception Code 02: Illegal Data Address \nThe data address received in the query is not an allowable address for the slave." +
            //            "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else if (bufferResponse[exceptionInResponse] == 0x03)
            //    {
            //        MessageBox.Show("Exception Code 03: Illegal Data Value \nA value contained in the query data field is not an allowable value for the slave." +
            //            "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else if (bufferResponse[exceptionInResponse] == 0x0A)
            //    {
            //        MessageBox.Show("Exception Code 0A: Gateway Path Unavailable \nThe gateway was unable to allocate an internal communication path from the input port" +
            //            " to the output port for processing the request.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //}
            //}
        //}

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (numberOfRegisters > 0)
            {
                numberOfRegisters--;
                richtxtNumberRegs.Text = numberOfRegisters.ToString("X4");
            }
            else
                btnMinus.Enabled = false;

            if (selected16)
                richtxtValues.MaxLength = 5 * numberOfRegisters - 1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (numberOfRegisters > 0)
                btnMinus.Enabled = true;

            numberOfRegisters++;
            richtxtNumberRegs.Text = numberOfRegisters.ToString("X4");

            if (selected16)
                richtxtValues.MaxLength = 5 * numberOfRegisters - 1;
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
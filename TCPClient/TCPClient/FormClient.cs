using SuperSimpleTcp;
using System.Globalization;
using System.Text;
using TCPClient.FunctionCode;

namespace TCPClient
{
    public partial class FormClient : Form 
    {     
        private int numberOfRegisters, numberOfRegisters16; // counter for btnMinus & btnPlus
        private int functionCodeInResponse = 7;
        private int exceptionInResponse = 8;

        public byte functionCode, salveID;
        public byte slaveCOM100 = 0xFF;
        public byte fc03 = 0x03, fc06 = 0x06, fc16 = 0x16;

        public const byte headerLength = 0x06;
        public const byte slaveIdLength = 0x01;
        public const byte functionCodeLength = 0x01;
        public const byte dataAddressLength = 0x02;
        public const byte dataRegisterLength = 0x02;
        public const byte numberBytesToFollow = 0x01;

        byte bufferRequest03Length = headerLength + slaveIdLength + functionCodeLength + dataAddressLength + dataRegisterLength;
        byte bufferRequest06Length = headerLength + slaveIdLength + functionCodeLength + dataAddressLength + dataRegisterLength;
        byte bufferRequest16Length = headerLength + slaveIdLength + functionCodeLength + dataAddressLength + dataRegisterLength + numberBytesToFollow;

        byte[] bufferRequest;
        byte[] bufferResponse;

        bool selectedItem03, selectedItem06, selectedItem16;
        
        SimpleTcpClient client;
        System.Diagnostics.Stopwatch executionTime = new System.Diagnostics.Stopwatch();

        List<Panel> listPanel = new List<Panel>();

        public FormClient()
        {
            InitializeComponent();
        }
        
        private void FormClient_Load(object sender, EventArgs e)
        {
            txtAddress03.CharacterCasing = CharacterCasing.Upper;

            btnDisconnect.Enabled = false;

            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel[0].BringToFront();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new SimpleTcpClient(txtIP.Text + ":" + txtPort.Text);

                client.Events.Connected += Connected;
                client.Events.DataReceived += DataReceived;

                client.Connect();

                comboFunctionCode.SelectedIndexChanged += comboFunctionCode_SelectedIndexChanged;
            }
            catch
            {
                if((txtIP.Text == "") && (txtPort.Text == ""))
                    MessageBox.Show("Please enter an IP Address and a Port Number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Please enter a correct IP Address and Port Number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                labelStatus2.Text = "Connected";
                labelStatus2.ForeColor = Color.Green;
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            });
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

                txtIP.Enabled = true;
                txtPort.Enabled = true;

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
            this.Invoke((MethodInvoker)delegate
            {
                labelStatus2.Text = "Not connected";
                labelStatus2.ForeColor = Color.Red;
                btnConnect.Enabled = true;
                txtIP.Enabled = true;
                txtPort.Enabled = true;
            });
        }

        public static void addTwoBytesToBuffer(short number, byte[] buffer, int indexBuffer)
        {
            buffer[indexBuffer] = (byte)(number >> 8);
            buffer[indexBuffer + 1] = (byte)(number);
        }

        private void comboFunctionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem03 = (comboFunctionCode.SelectedIndex == 0);
            selectedItem06 = (comboFunctionCode.SelectedIndex == 1);
            selectedItem16 = (comboFunctionCode.SelectedIndex == 2);

            if (selectedItem03)
            {
                listPanel[0].BringToFront();
                functionCode = fc03;
            }
            else if (selectedItem06)
            {
                listPanel[1].BringToFront();
                functionCode = fc06;
            }
            else if (selectedItem16)
            {
                listPanel[2].BringToFront();
                functionCode = fc16;
            }
        }
        private void comboSlave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSlave.SelectedIndex == 0)
                salveID = slaveCOM100;
        }

        private void buildFrame()
        {
            short transactionId = short.Parse(txtTransactionId.Text, NumberStyles.HexNumber);
            short protocolId = short.Parse(txtProtocolId.Text, NumberStyles.HexNumber);
            //byte slaveId = byte.Parse(txtBoxUnitId.Text, NumberStyles.HexNumber);
            //byte functionCode = byte.Parse(txtBoxFunctionCode.Text, NumberStyles.HexNumber);

            if (selectedItem03)
            {
                short dataAddress03 = short.Parse(txtAddress03.Text, NumberStyles.HexNumber);
                short dataRegisters03 = short.Parse(txtNrRegisters03.Text, NumberStyles.HexNumber);
                short lengthOfMessage03 = (short)(slaveIdLength + functionCodeLength + dataAddressLength + dataRegisterLength);

                bufferRequest = new byte[bufferRequest03Length];

                addTwoBytesToBuffer(transactionId, bufferRequest, 0);
                addTwoBytesToBuffer(protocolId, bufferRequest, 2);
                addTwoBytesToBuffer(lengthOfMessage03, bufferRequest, 4);
                bufferRequest[6] = salveID;
                bufferRequest[7] = functionCode;
                addTwoBytesToBuffer(dataAddress03, bufferRequest, 8);
                addTwoBytesToBuffer(dataRegisters03, bufferRequest, 10);
            }
            else if (selectedItem06)
            {
                short dataAddress06 = short.Parse(txtAddress06.Text, NumberStyles.HexNumber);
                short dataValue06 = short.Parse(txtValue06.Text, NumberStyles.HexNumber);                    
                short lengthOfMessage06 = (short)(slaveIdLength + functionCodeLength + dataAddressLength + dataRegisterLength);

                bufferRequest = new byte[bufferRequest06Length];

                addTwoBytesToBuffer(transactionId, bufferRequest, 0);
                addTwoBytesToBuffer(protocolId, bufferRequest, 2);
                addTwoBytesToBuffer(lengthOfMessage06, bufferRequest, 4);
                bufferRequest[6] = salveID;
                bufferRequest[7] = functionCode;
                addTwoBytesToBuffer(dataAddress06, bufferRequest, 8);
                addTwoBytesToBuffer(dataValue06, bufferRequest, 10);
            }
            else if (selectedItem16)
            {
                short dataAddress16 = short.Parse(txtAddress16.Text, NumberStyles.HexNumber);
                short dataRegisters16 = short.Parse(txtNrRegisters16.Text, NumberStyles.HexNumber);
                short[] dataValues16 = txtValues16.Text.Split(' ')
                        .Select(hex => short.Parse(hex, NumberStyles.HexNumber))
                        .ToArray();
                short lengthOfMessage16 = (short)(slaveIdLength + functionCodeLength + dataAddressLength + dataRegisterLength + numberBytesToFollow + 2 * dataValues16.Length);
                
                bufferRequest = new byte[bufferRequest16Length + 2 * dataValues16.Length];

                addTwoBytesToBuffer(transactionId, bufferRequest, 0);
                addTwoBytesToBuffer(protocolId, bufferRequest, 2);
                addTwoBytesToBuffer(lengthOfMessage16, bufferRequest, 4);
                bufferRequest[6] = salveID;
                bufferRequest[7] = functionCode;
                addTwoBytesToBuffer(dataAddress16, bufferRequest, 8);
                addTwoBytesToBuffer(dataRegisters16, bufferRequest, 10);

                int indexNumber = 13;
                byte nrOfBytesMore = 0;
                foreach (short element in dataValues16)
                {
                    addTwoBytesToBuffer(element, bufferRequest, indexNumber);
                    indexNumber += 2;
                    nrOfBytesMore += 2;
                }

                bufferRequest[12] = nrOfBytesMore;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                try
                {
                    txtRequest.Text = String.Empty;
                    txtResponse.Text = String.Empty;

                    buildFrame();
                    client.Send(bufferRequest);

                    txtInfo.Text += $"[{DateTime.Now}] ->";
                    foreach (byte element in bufferRequest)
                    {
                        txtRequest.Text += $" {element:X2}";
                        txtInfo.Text += $" {element:X2}";
                    }
                    txtInfo.Text += $"{Environment.NewLine}";
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

                txtInfo.Text += $"[{DateTime.Now}] <-";
                foreach (byte element in bufferResponse)
                {
                    txtResponse.Text += $" {element:X2}";
                    txtInfo.Text += $" {element:X2}";
                }
                txtInfo.Text += $"{Environment.NewLine}{Environment.NewLine}";
            });
        }

        private void AnalyzeResponse()
        {
            if ((bufferResponse[functionCodeInResponse] == 0x83) || (bufferResponse[functionCodeInResponse] == 0x86) || (bufferResponse[functionCodeInResponse] == 0x90))
            {
                if (bufferResponse[exceptionInResponse] == 0x02)
                    labelInfoFrame.Text = "Exception Code 02: Illegal Data Address";
                else if (bufferResponse[exceptionInResponse] == 0x03)
                    labelInfoFrame.Text = "Exception Code 03: Illegal Data Value";
                else if (bufferResponse[exceptionInResponse] == 0x0A)
                    labelInfoFrame.Text = "Exception Code 0A: Gateway Path Unavailable";
                else
                    labelInfoFrame.Text = "-";
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if ((bufferResponse[functionCodeInResponse] == 0x83) || (bufferResponse[functionCodeInResponse] == 0x86) || (bufferResponse[functionCodeInResponse] == 0x90))
            {
                if (bufferResponse[exceptionInResponse] == 0x02)
                {
                    MessageBox.Show("Exception Code 02: Illegal Data Address \nThe data address received in the query is not an allowable address for the slave." +
                        "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (bufferResponse[exceptionInResponse] == 0x03)
                {
                    MessageBox.Show("Exception Code 03: Illegal Data Value \nA value contained in the query data field is not an allowable value for the slave." +
                        "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (bufferResponse[exceptionInResponse] == 0x0A)
                {
                    MessageBox.Show("Exception Code 0A: Gateway Path Unavailable \nThe gateway was unable to allocate an internal communication path from the input port" +
                        " to the output port for processing the request.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRequest.Text = String.Empty;
            txtResponse.Text = String.Empty;
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            txtInfo.SelectionStart = txtInfo.TextLength;
            txtInfo.ScrollToCaret();
        }

        private void btnMinus16_Click(object sender, EventArgs e)
        {
            if (numberOfRegisters16 > 0)
            {
                numberOfRegisters16--;
                txtNrRegisters16.Text = numberOfRegisters16.ToString("X4");
            }
            else
                btnMinus16.Enabled = false;
        }

        private void btnPlus16_Click(object sender, EventArgs e)
        {
            if (numberOfRegisters16 > 0)
                btnMinus16.Enabled = true;

            numberOfRegisters16++;
            txtNrRegisters16.Text = numberOfRegisters16.ToString("X4");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (numberOfRegisters > 0)
            {
                numberOfRegisters--;
                txtNrRegisters03.Text = numberOfRegisters.ToString("X4");
            }
            else
                btnMinus.Enabled = false;
        }

        private void bntPlus_Click(object sender, EventArgs e)
        {
            if (numberOfRegisters > 0)
                btnMinus.Enabled = true;

            numberOfRegisters++;
            txtNrRegisters03.Text = numberOfRegisters.ToString("X4");
        }
    }
}
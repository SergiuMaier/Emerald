using SuperSimpleTcp;
using System.Globalization;
using System.Text;

namespace TCPClient
{
    public partial class FormClient : Form
    {     
        SimpleTcpClient client;
        System.Diagnostics.Stopwatch executionTime = new System.Diagnostics.Stopwatch();

        public const byte unitIdLength = 0x01;
        public const byte functionCodeLength = 0x01;
        public const byte dataAddressLength = 0x02;
        byte[] bufferRequest;
        byte[] bufferResponse;

        int functionCodeInResponse = 8;

        public FormClient()
        {
            InitializeComponent();
        }
        
        private void FormClient_Load(object sender, EventArgs e)
        {
            txtBoxUnitId.CharacterCasing = CharacterCasing.Upper;
            txtBoxFunctionCode.CharacterCasing = CharacterCasing.Upper;
            txtDataAddress.CharacterCasing = CharacterCasing.Upper;

            btnDisconnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new SimpleTcpClient(txtIP.Text + ":" + txtPort.Text);

                client.Events.Connected += Connected;
                client.Events.DataReceived += DataReceived;

                client.Connect();

                txtIP.Enabled = false;
                txtPort.Enabled = false;
                txtBoxFunctionCode.Enabled = true;
                txtBoxUnitId.Enabled = true;
                comboFunctionCode.Enabled = true;
                txtDataAddress.Enabled = true;
                txtDataRegisters.Enabled = true;

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
                txtBoxFunctionCode.Enabled = false;
                txtBoxUnitId.Enabled = false;
                comboFunctionCode.Enabled = false;
                txtDataAddress.Enabled = false;
                txtDataRegisters.Enabled = false;

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

        private void comboFunctionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFunctionCode.SelectedIndex == 0)
            {
                txtBoxFunctionCode.Text = "03";
                groupBox03.Visible = true;
                groupBox06.Visible = false;
                groupBox16.Visible = false;

            }
            else if (comboFunctionCode.SelectedIndex == 1)
            {
                txtBoxFunctionCode.Text = "06";
                groupBox03.Visible = false;
                groupBox06.Visible = true;
                groupBox16.Visible = false;

            }
            else if (comboFunctionCode.SelectedIndex == 2)
            {
                txtBoxFunctionCode.Text = "16";
                groupBox03.Visible = false;
                groupBox06.Visible = false;
                groupBox16.Visible = true;

            }
        }

        public static void addTwoBytesToBuffer(short number, byte[] buffer, int indexBuffer)
        {
            buffer[indexBuffer] = (byte)(number >> 8);
            buffer[indexBuffer + 1] = (byte)(number);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                try
                {
                    txtRequest.Text = String.Empty;
                    txtResponse.Text = String.Empty;

                    short transactionId = 0x0001;
                    short protocolId = 0x0000;
                    
                    byte unitId = byte.Parse(txtBoxUnitId.Text, NumberStyles.HexNumber);
                    byte functionCode = byte.Parse(txtBoxFunctionCode.Text, NumberStyles.HexNumber);
                    short dataAddress = short.Parse(txtDataAddress.Text, NumberStyles.HexNumber);
                    short[] dataRegisters = txtDataRegisters.Text.Split(' ')
                            .Select(hex => short.Parse(hex, NumberStyles.HexNumber))
                            .ToArray();
                    short lengthOfMessage = (short)(unitIdLength + functionCodeLength + dataAddressLength + 2 * dataRegisters.Length); //vf asta pe site la FC 

                    bufferRequest = new byte[10 + 2 * dataRegisters.Length]; //256 e mai corect si apoi tin cont de indexul unde
                                                                                    //se termina mesajul in dataFrame
                    addTwoBytesToBuffer(transactionId, bufferRequest, 0);
                    addTwoBytesToBuffer(protocolId, bufferRequest, 2);
                    addTwoBytesToBuffer(lengthOfMessage, bufferRequest, 4);
                    bufferRequest[6] = unitId;
                    bufferRequest[7] = functionCode;
                    addTwoBytesToBuffer(dataAddress, bufferRequest, 8);

                    int indexNumber = 10;
                    foreach (short element in dataRegisters)
                    {
                        addTwoBytesToBuffer(element, bufferRequest, indexNumber);
                        indexNumber += 2;
                    }

                    //-------Sending the request------//

                    client.Send(bufferRequest);

                    //-------Printing the request in text boxes------//

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

                txtInfo.Text += $"[{DateTime.Now}] <-";
                foreach (byte element in bufferResponse)
                {
                    txtResponse.Text += $" {element:X2}";
                    txtInfo.Text += $" {element:X2}";
                }
                txtInfo.Text += $"{Environment.NewLine}{Environment.NewLine}";
            });
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (bufferResponse[functionCodeInResponse] == 0x02)
                MessageBox.Show("Exception Code 02: Illegal Data Address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (bufferResponse[functionCodeInResponse] == 0x03)
                MessageBox.Show("Exception Code 03: Illegal Data Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (bufferResponse[functionCodeInResponse] == 0x0A)
                MessageBox.Show("Exception Code 0A: Gateway Path Unavailable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
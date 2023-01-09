using SuperSimpleTcp;
using System.Globalization;
using System.Text;

namespace TCPClient
{
    public partial class FormClient : Form
    {
        SimpleTcpClient client;
       
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
            comboFunctionCode.SelectedIndex = 0;
            comboSlave.SelectedIndex = 0;
            panelMessage.Enabled = true;
            btnSend.Enabled = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                richtxtPrintRequest.Text = String.Empty;
                richtxtPrintResponse.Text = String.Empty;
                richtxtPrintAnalyze.Text = String.Empty;

                try
                {
                    counterTransactionId++;
                    richtxtTransactionId.Text = counterTransactionId.ToString("X4"); //testeaza daca e buna pusa

                    requestBuffer = new byte[bufferLength];

                    BuildRequest(requestBuffer, richtxtTransactionId.Text, protocolId, slaveId, functionCode, richtxtDataAddress.Text, richtxtDataRegisters.Text, richtxtDataValues.Text);
                    client.Send(requestBuffer);

                    foreach (byte element in requestBuffer)
                        richtxtPrintRequest.Text += $" {element:X2}";

                    //richtxtPrintRequest.Text = $"{BitConverter.ToString(requestBuffer)}";
                }
                catch
                {
                    MessageBox.Show("Invalid format.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richtxtPrintAnalyze.Text = "Invalid format.";
                }
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                responseBuffer = new byte[e.Data.Count];

                int indexBuffer = 0;
                foreach (byte element in e.Data)
                {
                    responseBuffer[indexBuffer] = element;
                    indexBuffer++;
                }

                foreach (byte element in responseBuffer)
                    richtxtPrintResponse.Text += $" {element:X2}";
                //richtxtPrintResponse.Text = $"{BitConverter.ToString(responseBuffer)}";

                AnalyzeResponse(responseBuffer, requestBuffer);
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
            else  //test si aici 
            {
                richtxtSlaveId.Visible = true;
                slaveId = byte.Parse(richtxtSlaveId.Text, NumberStyles.HexNumber);
            }
        }

        private void comboFunctionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected03 = (comboFunctionCode.SelectedIndex == 0);
            selected06 = (comboFunctionCode.SelectedIndex == 1);
            selected16 = (comboFunctionCode.SelectedIndex == 2);

            if (selected03)
            {
                functionCode = fc03;
                bufferLength = lengthCase03;

                richtxtDataValues.Text = String.Empty;
                richtxtPrintRequest.Text = String.Empty;
                richtxtPrintResponse.Text = String.Empty;
                richtxtPrintAnalyze.Text = String.Empty;    
                panelValues.Enabled = false;
                panelRegsNumber.Enabled = true;
                richtxtDataValues.MaxLength = 4;
            }
            else if (selected06)
            {
                functionCode = fc06;
                bufferLength = lengthCase06;

                richtxtDataValues.Text = String.Empty;
                richtxtPrintRequest.Text = String.Empty;
                richtxtPrintResponse.Text = String.Empty;
                richtxtPrintAnalyze.Text = String.Empty;
                panelRegsNumber.Enabled = false;
                panelValues.Enabled = true;
                richtxtDataValues.MaxLength = 4;
            }
            else if (selected16)
            {
                functionCode = fc16;
                richtxtDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));

                richtxtDataValues.Text = String.Empty;
                richtxtPrintRequest.Text = String.Empty;
                richtxtPrintResponse.Text = String.Empty;
                richtxtPrintAnalyze.Text = String.Empty;
                panelRegsNumber.Enabled = true;
                panelValues.Enabled = true;
            } 
        }
        
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (counterNoOfRegisters > 1)
            {
                counterNoOfRegisters--;
                richtxtDataRegisters.Text = counterNoOfRegisters.ToString("X4");
            }
            else
                btnMinus.Enabled = false;

            if (selected16)
            {
                richtxtDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (counterNoOfRegisters > 1)
                btnMinus.Enabled = true;

            counterNoOfRegisters++;
            richtxtDataRegisters.Text = counterNoOfRegisters.ToString("X4");

            if (selected16)
            {
                richtxtDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richtxtPrintRequest.Text = String.Empty;
            richtxtPrintResponse.Text = String.Empty;
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
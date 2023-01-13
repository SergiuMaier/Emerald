using SuperSimpleTcp;
using System.Globalization;
using System.Text;
using TCPClient.CustomControls;

namespace TCPClient
{
    public partial class FormClient : Form
    {
        SimpleTcpClient client;

        public FormClient()
        {
            InitializeComponent();

            toolTipForm.SetToolTip(buttonConnect, "Connect to a device");
            toolTipForm.SetToolTip(buttonSend, "Send a request");
            toolTipForm.SetToolTip(buttonClear, "Clear text boxes");
            toolTipForm.SetToolTip(buttonHistory, "View message history");

            comboSlave.Enabled = true;
            comboSlave.SelectedIndex = 0; //load with COM100 by default
            customTextBoxSlaveId.Texts = "FF";
            buttonHistory.ForeColor = Color.White;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!connectionStatus)
            {
                connectionStatus = true;

                try
                {
                    client = new SimpleTcpClient(customTextBoxIP.Texts + ":" + customTextBoxPort.Texts);

                    client.Events.Connected += Connected;
                    client.Events.DataReceived += DataReceived;

                    client.Connect();

                    comboFunctionCode.SelectedIndexChanged += comboFunctionCode_SelectedIndexChanged;
                }
                catch
                {   
                    if ((customTextBoxIP.Texts == String.Empty) && (customTextBoxPort.Text == String.Empty))
                        MessageBox.Show("Please enter an IP Address and a Port Number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Please enter a correct IP Address and Port Number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                connectionStatus = false;

                try
                {
                    client.Events.Disconnected += Disconnected;
                    client.DisconnectAsync(); //crash
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //panel Connection
                panelConnect.Enabled = false;
                comboSlave.Enabled = false;
                customTextBoxSlaveId.Enable = false;
                buttonConnect.Text = "Disconnect";
                labelStatus2.Text = "   Connected";

                //panel Message
                comboFunctionCode.SelectedIndex = 0;
                panelMessage.Enabled = true;

                //panel Options
                buttonHistory.Enabled = true;
                buttonSend.Enabled = true;
                buttonClear.Enabled = true;
            });
        }

        private void Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                //panel Connection
                panelConnect.Enabled = true;
                comboSlave.Enabled = true;
                buttonConnect.Text = "   Connect";
                labelStatus2.Text = "Disonnected";

                //panel Message
                panelMessage.Enabled = false;

                //panel Options
                buttonHistory.Enabled = false;
                buttonSend.Enabled = false;
                buttonClear.Enabled = false;
            });
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                customTextBoxPrintRequest.Texts = String.Empty;
                customTextBoxPrintResponse.Texts = String.Empty;
                customTextBoxPrintAnalyze.Texts = String.Empty;

                counterTransactionId++;
                customTextBoxTransactionId.Texts = counterTransactionId.ToString("X4");

                try
                {
                    requestBuffer = new byte[bufferLength];

                    BuildRequest(requestBuffer, customTextBoxTransactionId.Texts, protocolId, slaveId, functionCode, customTextBoxDataAddress.Texts, NumberOfRegisters, customTextBoxDataValues.Texts);
                    client.Send(requestBuffer);

                    foreach (byte element in requestBuffer)
                        customTextBoxPrintRequest.Texts += $" {element:X2}";
                }
                catch
                {
                    MessageBox.Show("Fill in all required text boxes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    customTextBoxPrintResponse.Texts += $" {element:X2}";

                AnalyzeResponse(responseBuffer, requestBuffer);
            });
        }

        private void comboSlave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSlave.SelectedIndex == 0)
            {
                slaveId = COM100Id;
                customTextBoxSlaveId.Texts = "FF";
                customTextBoxSlaveId.Enable = false;
            }
            else
            {
                customTextBoxSlaveId.Texts = "00";
                customTextBoxSlaveId.Enable = true;
                slaveId = byte.Parse(customTextBoxSlaveId.Texts, NumberStyles.HexNumber);
            }
        }

        private void comboFunctionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //falgs
            selected03 = (comboFunctionCode.SelectedIndex == 0);
            selected06 = (comboFunctionCode.SelectedIndex == 1);
            selected16 = (comboFunctionCode.SelectedIndex == 2);

            //clear the fields every time a new command is selected
            customTextBoxPrintRequest.Texts = String.Empty;
            customTextBoxPrintResponse.Texts = String.Empty;
            customTextBoxPrintAnalyze.Texts = String.Empty;

            if (selected03)
            {
                functionCode = fc03;
                bufferLength = lengthCase03;

                panelRegsNumber.Enabled = true;
                customTextBoxDataRegisters.BorderColor = Color.FromArgb(0, 153, 153);

                panelValues.Enabled = false;
                customTextBoxDataValues.BorderColor = Color.Gray;
                customTextBoxDataValues.Texts = String.Empty;
            }
            else if (selected06)
            {
                functionCode = fc06;
                bufferLength = lengthCase06;

                panelRegsNumber.Enabled = false;
                customTextBoxDataRegisters.BorderColor = Color.Gray;

                panelValues.Enabled = true;
                customTextBoxDataValues.BorderColor = Color.FromArgb(0, 153, 153);
                customTextBoxDataValues.MaxLength = 4;
                customTextBoxDataValues.Texts = String.Empty;
            }
            else if (selected16)
            {
                functionCode = fc16;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));

                panelRegsNumber.Enabled = true;
                customTextBoxDataRegisters.BorderColor = Color.FromArgb(0, 153, 153);

                panelValues.Enabled = true;
                customTextBoxDataValues.BorderColor = Color.FromArgb(0, 153, 153);
                customTextBoxDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                customTextBoxDataValues.Texts = String.Empty;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (counterNoOfRegisters > 1)
            {
                counterNoOfRegisters--;
                customTextBoxDataRegisters.Texts = counterNoOfRegisters.ToString(); //Showing the counter in int
                NumberOfRegisters = counterNoOfRegisters.ToString("X4"); //using the counter in short/hex
            }
            else
                btnMinus.Enabled = false;

            if (selected16)
            {
                customTextBoxDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //enableing the button
            if (counterNoOfRegisters > 1)
                btnMinus.Enabled = true;

            counterNoOfRegisters++;
            customTextBoxDataRegisters.Texts = counterNoOfRegisters.ToString();
            NumberOfRegisters = counterNoOfRegisters.ToString("X4");    //using the counter in short/hex

            //changeing text box property and buffer lenght depending on the selected command
            if (selected16)
            {
                customTextBoxDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            customTextBoxPrintRequest.Texts = String.Empty;
            customTextBoxPrintResponse.Texts = String.Empty;
            customTextBoxPrintAnalyze.Texts = String.Empty;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            try
            {
                FormHistory formHistory = new FormHistory();
                formHistory.Show();
            }
            catch
            {
                MessageBox.Show("An error occurred while opening the history", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
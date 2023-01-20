using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient.Modbus
{
    public partial class ModbusPage : UserControl
    {
        SimpleTcpClient client;

        public ModbusPage()
        {
            InitializeComponent();

            comboFunctionCode.DataSource = Enum.GetValues(typeof(Commands));
            comboSlave.DataSource = Enum.GetValues(typeof(Devices));

            comboSlave.SelectedIndex = 0;    //load with COM100 by default
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
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
                buttonConnect.Text = " Disconnect";
                labelStatus2.Text = "   Connected";

                //panel Message
                comboFunctionCode.SelectedIndex = 0;
                panelMessage.Enabled = true;
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
            });
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            if (connectionStatus) 
            {
                customTextBoxPrintRequest.Texts = String.Empty;
                customTextBoxPrintResponse.Texts = String.Empty;
                customTextBoxPrintAnalyze.Texts = String.Empty;

                //some parapeters need to be loaded when the button is clicked
                counterTransactionId++;
                customTextBoxTransactionId.Texts = counterTransactionId.ToString("X4");
                NumberOfRegisters = counterNoOfRegisters.ToString("X4"); 

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
                    MessageBox.Show($"You must fill in all required text boxes for the command '{comboFunctionCode.SelectedItem}'.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //flags
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

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            if (counterNoOfRegisters > 1)
            {
                counterNoOfRegisters--;
                customTextBoxDataRegisters.Texts = counterNoOfRegisters.ToString(); //Showing the counter in int
            }
            else
                btnMinus.Enabled = false;

            if (selected16)
            {
                customTextBoxDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));
            }
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            //enableing the button
            if (counterNoOfRegisters > 1)
                btnMinus.Enabled = true;

            counterNoOfRegisters++;
            customTextBoxDataRegisters.Texts = counterNoOfRegisters.ToString();

            //changeing text box property and buffer lenght depending on the selected command
            if (selected16)
            {
                customTextBoxDataValues.MaxLength = 5 * counterNoOfRegisters - 1;
                bufferLength = (byte)(lengthCase16 + (2 * counterNoOfRegisters));
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            customTextBoxPrintRequest.Texts = String.Empty;
            customTextBoxPrintResponse.Texts = String.Empty;
            customTextBoxPrintAnalyze.Texts = String.Empty;
        }

        private void buttonHistory_Click_1(object sender, EventArgs e)
        {
            if (connectionStatus)
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
}

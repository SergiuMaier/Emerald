using SuperSimpleTcp;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TCPClient.Classes;
using TCPClient.CustomControls;
using TCPClient.Modbus;
using TCPClient.Profinet;

namespace TCPClient
{
    public partial class FormClient : Form
    {
        ProfinetPage profinetPage = new ProfinetPage();
        ModbusPage modbusPage = new ModbusPage();

        public FormClient()
        {
            InitializeComponent();

            addPage(modbusPage);

            buttonModbus.Enabled = false;    //load with Modbus page enabled
            buttonModbus.BackColor = Color.WhiteSmoke; 
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
        }

        private void addPage(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(userControl);
            userControl.Visible = true;
            userControl.BringToFront();
        }

        private void buttonModbus_Click(object sender, EventArgs e)
        {
            addPage(modbusPage);
            
            //Menu
            buttonModbus.Enabled = false;
            panelModbusSelected.Visible = true;
            buttonModbus.BackColor = Color.WhiteSmoke;
            buttonModbus.ForeColor = Color.FromArgb(0, 153, 153);

            buttonProfinet.Enabled = true;
            panelProfinetSelected.Visible = false;
            buttonProfinet.BackColor = Color.Transparent;
            buttonProfinet.ForeColor = Color.White;
        }

        private void buttonProfinet_Click(object sender, EventArgs e)
        {
            if (modbusPage.connectionStatus)
            {
                MessageBox.Show("You are connected.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addPage(profinetPage);
                //Transitions.Animate(modbusPage, Transitions.Effect.Slide, 450, 90);

                //Menu
                buttonModbus.Enabled = true;
                panelModbusSelected.Visible = false;
                buttonModbus.BackColor = Color.Transparent;
                buttonModbus.ForeColor = Color.White;

                buttonProfinet.Enabled = false;
                panelProfinetSelected.Visible = true;
                buttonProfinet.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
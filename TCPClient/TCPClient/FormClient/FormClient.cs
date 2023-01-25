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
        ModbusPage modbusPage = new ModbusPage();
        ProfinetPage profinetPage = new ProfinetPage();

        public FormClient()
        {
            InitializeComponent();

            addPage(modbusPage);
            buttonModbus.Enabled = false;
            buttonModbus.BackColor = Color.WhiteSmoke;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
        }

        private void addPage(UserControl userControl)
        {
            //switch between pages in the same panel

            userControl.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(userControl);
            userControl.Visible = true;
            userControl.BringToFront();
        }

        private void buttonModbus_Click(object sender, EventArgs e)
        {
            addPage(modbusPage);
            
            //Menu properties
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
                MessageBox.Show("You cannot change the page when you are connected to a device.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                addPage(profinetPage);

                //Menu properties
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
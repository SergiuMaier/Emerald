using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPClient.Modbus;

namespace TCPClient
{
    public partial class FormExceptionCode : Form
    {
        public FormExceptionCode()
        {
            InitializeComponent();

            labelExceptionTitle.Text = ModbusPage.ExceptionTitle; //FormClient.ExceptionTitle;
            labelExceptionMessage.Text = ModbusPage.ExceptionMessage;//FormClient.ExceptionMessage;
        }

        private void FormExceptionCode_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ModbusPage.ExceptionTitle = String.Empty; //FormClient.ExceptionTitle = String.Empty;
            ModbusPage.ExceptionMessage = String.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class FormExceptionCode : Form
    {
        public FormExceptionCode()
        {
            InitializeComponent();

            labelException.Text = FormClient.exceptionMessage;
        }

        private void FormExceptionCode_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FormClient.exceptionMessage = String.Empty;
        }
    }
}

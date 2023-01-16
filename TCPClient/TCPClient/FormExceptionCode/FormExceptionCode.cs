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
           
            labelExceptionTitle.Text = FormClient.ExceptionTitle;
            labelExceptionMessage.Text = FormClient.ExceptionMessage;
        }

        private void FormExceptionCode_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FormClient.ExceptionTitle = String.Empty;
            FormClient.ExceptionMessage = String.Empty;
        }
    }
}

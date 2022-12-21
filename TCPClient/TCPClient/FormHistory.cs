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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            textBoxHistory.Text = FormClient.textToHistory;
        }

        public void FormHistory_Load(object sender, EventArgs e)
        {
        }

        public void textHistory_TextChanged(object sender, EventArgs e)
        {
            textBoxHistory.SelectionStart = textBoxHistory.TextLength;
            textBoxHistory.ScrollToCaret();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

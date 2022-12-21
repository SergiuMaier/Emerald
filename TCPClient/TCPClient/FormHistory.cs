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
            txtBoxHistory.Text = FormClient.textToHistory;
        }

        public void FormHistory_Load(object sender, EventArgs e)
        {
        }

        public void textHistory_TextChanged(object sender, EventArgs e)
        {
            txtBoxHistory.SelectionStart = txtBoxHistory.TextLength;
            txtBoxHistory.ScrollToCaret();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete the history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtBoxHistory.Text = String.Empty;
                FormClient.textToHistory = String.Empty;
            }
        }
    }
}

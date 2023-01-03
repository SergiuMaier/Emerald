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
        string path = @"C:\Users\sergi\OneDrive\Desktop\cercetare\history.txt";

        public FormHistory()
        {
            InitializeComponent();

            txtBoxHistory.Text = FormClient.addMessageToHistory;
            
            toolTipHistory.SetToolTip(btnClear, "Clear the history");
            toolTipHistory.SetToolTip(btnSave, "Save the history to a file");
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
                FormClient.addMessageToHistory = String.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.AppendAllText(path, txtBoxHistory.Text, Encoding.UTF8);
                MessageBox.Show("The history was successfully saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

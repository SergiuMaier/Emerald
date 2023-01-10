using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class FormHistory : Form
    {
        readonly string path = @"C:\Users\sergi\OneDrive\Desktop\cercetare\history.txt";

        public FormHistory()
        {
            InitializeComponent();

            txtBoxHistory.Text = FormClient.AddMessageToHistory;
            
            toolTipHistory.SetToolTip(btnClear, "Clear the history");
            toolTipHistory.SetToolTip(btnSave, "Save the history to a file");
            toolTipHistory.SetToolTip(btnOpenFile, "Open the file");
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
                FormClient.AddMessageToHistory = String.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.AppendAllText(path, txtBoxHistory.Text, Encoding.UTF8);
                MessageBox.Show("The history was successfully saved to file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(0, 153, 153);
            btnClose.BackColor = Color.Black;
        }
    }
}

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
using TCPClient.Modbus;

namespace TCPClient
{
    public partial class FormHistory : Form
    {
        readonly string path = @"C:\Users\sergi\OneDrive\Desktop\cercetare\history.txt";

        public FormHistory()
        {
            InitializeComponent();

            customTextBoxHistory.Texts = ModbusPage.AddMessageToHistory;//FormClient.AddMessageToHistory;
            customTextBoxHistory.SelectionStartIndex = 0; //overrided SelectionStart property for customTextBox. Fixed text highlighted bug when the form is displayed
            
            toolTipHistory.SetToolTip(buttonClear, "Clear the history");
            toolTipHistory.SetToolTip(buttonSave, "Save the history to a file");
            toolTipHistory.SetToolTip(buttonOpenFile, "Open the file");
        }

        public void FormHistory_Load(object sender, EventArgs e)
        {
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customTextBoxHistory.Texts = String.Empty;
                ModbusPage.AddMessageToHistory = String.Empty;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (customTextBoxHistory.Texts != String.Empty)
            {
                if (File.Exists(path))
                {
                    File.AppendAllText(path, customTextBoxHistory.Texts, Encoding.UTF8);
                    MessageBox.Show("The history was successfully saved to file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The history can't be saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No data recorded in the history.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }
    }
}

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
        public string toHistory { get; set; }

        public FormHistory()
        {
            InitializeComponent();
        }

        public void FormHistory_Load(object sender, EventArgs e)
        {
            textHistory.Text += toHistory;
        }

        public void textHistory_TextChanged(object sender, EventArgs e)
        {
            textHistory.SelectionStart = textHistory.TextLength;
            textHistory.ScrollToCaret();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

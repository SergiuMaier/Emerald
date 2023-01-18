namespace TCPClient.Profinet
{
    partial class ProfinetPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfinetPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonConnect = new TCPClient.CustomControls.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelConnect = new System.Windows.Forms.Panel();
            this.customTextBoxPort = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxIP = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxSlaveId = new TCPClient.CustomControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSlave = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "test";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.buttonConnect);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 733);
            this.panel7.TabIndex = 53;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(11, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(170, 1);
            this.panel9.TabIndex = 58;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonConnect.BorderColor = System.Drawing.Color.White;
            this.buttonConnect.BorderRadius = 10;
            this.buttonConnect.BorderSize = 1;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.Location = new System.Drawing.Point(16, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(160, 45);
            this.buttonConnect.TabIndex = 43;
            this.buttonConnect.Text = "   Connect";
            this.buttonConnect.TextColor = System.Drawing.Color.White;
            this.buttonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panelConnect);
            this.panel3.Location = new System.Drawing.Point(220, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 66);
            this.panel3.TabIndex = 54;
            // 
            // panelConnect
            // 
            this.panelConnect.BackColor = System.Drawing.Color.White;
            this.panelConnect.Controls.Add(this.customTextBoxPort);
            this.panelConnect.Controls.Add(this.customTextBoxIP);
            this.panelConnect.Controls.Add(this.customTextBoxSlaveId);
            this.panelConnect.Controls.Add(this.label2);
            this.panelConnect.Controls.Add(this.label3);
            this.panelConnect.Controls.Add(this.comboSlave);
            this.panelConnect.Controls.Add(this.label7);
            this.panelConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panelConnect.Location = new System.Drawing.Point(0, 0);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(609, 63);
            this.panelConnect.TabIndex = 30;
            // 
            // customTextBoxPort
            // 
            this.customTextBoxPort.BackColor = System.Drawing.Color.White;
            this.customTextBoxPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPort.BorderFocusColor = System.Drawing.Color.Orange;
            this.customTextBoxPort.BorderSize = 2;
            this.customTextBoxPort.Enable = true;
            this.customTextBoxPort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPort.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPort.Location = new System.Drawing.Point(306, 19);
            this.customTextBoxPort.MaxLength = 5;
            this.customTextBoxPort.Multiline = false;
            this.customTextBoxPort.Name = "customTextBoxPort";
            this.customTextBoxPort.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPort.SelectionStartIndex = 0;
            this.customTextBoxPort.Size = new System.Drawing.Size(65, 33);
            this.customTextBoxPort.TabIndex = 42;
            this.customTextBoxPort.Texts = "102";
            this.customTextBoxPort.UnderlinedStyle = true;
            // 
            // customTextBoxIP
            // 
            this.customTextBoxIP.BackColor = System.Drawing.Color.White;
            this.customTextBoxIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxIP.BorderFocusColor = System.Drawing.Color.Orange;
            this.customTextBoxIP.BorderSize = 2;
            this.customTextBoxIP.Enable = true;
            this.customTextBoxIP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxIP.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxIP.Location = new System.Drawing.Point(95, 19);
            this.customTextBoxIP.MaxLength = 15;
            this.customTextBoxIP.Multiline = false;
            this.customTextBoxIP.Name = "customTextBoxIP";
            this.customTextBoxIP.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxIP.SelectionStartIndex = 0;
            this.customTextBoxIP.Size = new System.Drawing.Size(160, 33);
            this.customTextBoxIP.TabIndex = 45;
            this.customTextBoxIP.Texts = "192.168.88.100";
            this.customTextBoxIP.UnderlinedStyle = true;
            // 
            // customTextBoxSlaveId
            // 
            this.customTextBoxSlaveId.BackColor = System.Drawing.Color.White;
            this.customTextBoxSlaveId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxSlaveId.BorderFocusColor = System.Drawing.Color.Orange;
            this.customTextBoxSlaveId.BorderSize = 2;
            this.customTextBoxSlaveId.Enable = false;
            this.customTextBoxSlaveId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxSlaveId.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxSlaveId.Location = new System.Drawing.Point(556, 19);
            this.customTextBoxSlaveId.MaxLength = 2;
            this.customTextBoxSlaveId.Multiline = false;
            this.customTextBoxSlaveId.Name = "customTextBoxSlaveId";
            this.customTextBoxSlaveId.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxSlaveId.SelectionStartIndex = 0;
            this.customTextBoxSlaveId.Size = new System.Drawing.Size(36, 33);
            this.customTextBoxSlaveId.TabIndex = 43;
            this.customTextBoxSlaveId.Texts = "00";
            this.customTextBoxSlaveId.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(263, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // comboSlave
            // 
            this.comboSlave.BackColor = System.Drawing.Color.White;
            this.comboSlave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSlave.ForeColor = System.Drawing.Color.Black;
            this.comboSlave.FormattingEnabled = true;
            this.comboSlave.Items.AddRange(new object[] {
            "COM100",
            "New Device"});
            this.comboSlave.Location = new System.Drawing.Point(439, 21);
            this.comboSlave.Name = "comboSlave";
            this.comboSlave.Size = new System.Drawing.Size(111, 28);
            this.comboSlave.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(380, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Device:";
            // 
            // ProfinetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Name = "ProfinetPage";
            this.Size = new System.Drawing.Size(850, 730);
            this.Load += new System.EventHandler(this.ProfinetPage_Load);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel7;
        private Panel panel9;
        private CustomControls.CustomButton buttonConnect;
        private Panel panel3;
        private Panel panelConnect;
        private CustomControls.CustomTextBox customTextBoxPort;
        private CustomControls.CustomTextBox customTextBoxIP;
        private CustomControls.CustomTextBox customTextBoxSlaveId;
        private Label label2;
        private Label label3;
        private ComboBox comboSlave;
        private Label label7;
    }
}

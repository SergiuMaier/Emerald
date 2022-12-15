namespace TCPClient
{
    partial class FormClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.txtBoxFunctionCode = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBoxFrame = new System.Windows.Forms.GroupBox();
            this.labelInfoFrame = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxUnitId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboFunctionCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataRegisters = new System.Windows.Forms.TextBox();
            this.txtDataAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxRq = new System.Windows.Forms.GroupBox();
            this.groupBoxRsp = new System.Windows.Forms.GroupBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.groupBox03 = new System.Windows.Forms.GroupBox();
            this.bntPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.groupBox06 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxFrame.SuspendLayout();
            this.groupBoxRq.SuspendLayout();
            this.groupBoxRsp.SuspendLayout();
            this.groupBoxHistory.SuspendLayout();
            this.groupBox03.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIP.Location = new System.Drawing.Point(107, 31);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(140, 29);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.88.100";
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRequest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRequest.Location = new System.Drawing.Point(11, 28);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ReadOnly = true;
            this.txtRequest.Size = new System.Drawing.Size(617, 29);
            this.txtRequest.TabIndex = 3;
            this.txtRequest.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // txtBoxFunctionCode
            // 
            this.txtBoxFunctionCode.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxFunctionCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxFunctionCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxFunctionCode.Location = new System.Drawing.Point(116, 66);
            this.txtBoxFunctionCode.MaxLength = 2;
            this.txtBoxFunctionCode.Name = "txtBoxFunctionCode";
            this.txtBoxFunctionCode.Size = new System.Drawing.Size(35, 29);
            this.txtBoxFunctionCode.TabIndex = 4;
            this.txtBoxFunctionCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(293, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(71, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnect.Location = new System.Drawing.Point(107, 102);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(71, 29);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPort.Location = new System.Drawing.Point(107, 67);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 29);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "502";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelStatus2);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus2.ForeColor = System.Drawing.Color.DarkGray;
            this.labelStatus2.Location = new System.Drawing.Point(45, 151);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(94, 17);
            this.labelStatus2.TabIndex = 11;
            this.labelStatus2.Text = "Not connected";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.labelStatus.Location = new System.Drawing.Point(5, 151);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 17);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "status: ";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisconnect.Location = new System.Drawing.Point(184, 102);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(63, 29);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disc";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBoxFrame
            // 
            this.groupBoxFrame.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFrame.Controls.Add(this.labelInfoFrame);
            this.groupBoxFrame.Controls.Add(this.label9);
            this.groupBoxFrame.Controls.Add(this.label7);
            this.groupBoxFrame.Controls.Add(this.textBox2);
            this.groupBoxFrame.Controls.Add(this.txtBoxFunctionCode);
            this.groupBoxFrame.Controls.Add(this.textBox1);
            this.groupBoxFrame.Controls.Add(this.label2);
            this.groupBoxFrame.Controls.Add(this.label8);
            this.groupBoxFrame.Controls.Add(this.txtBoxUnitId);
            this.groupBoxFrame.Controls.Add(this.label6);
            this.groupBoxFrame.Controls.Add(this.comboFunctionCode);
            this.groupBoxFrame.Controls.Add(this.btnSend);
            this.groupBoxFrame.Enabled = false;
            this.groupBoxFrame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxFrame.Location = new System.Drawing.Point(278, 10);
            this.groupBoxFrame.Name = "groupBoxFrame";
            this.groupBoxFrame.Size = new System.Drawing.Size(374, 176);
            this.groupBoxFrame.TabIndex = 10;
            this.groupBoxFrame.TabStop = false;
            this.groupBoxFrame.Text = "Frame";
            // 
            // labelInfoFrame
            // 
            this.labelInfoFrame.AutoSize = true;
            this.labelInfoFrame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoFrame.ForeColor = System.Drawing.Color.DarkGray;
            this.labelInfoFrame.Location = new System.Drawing.Point(38, 151);
            this.labelInfoFrame.Name = "labelInfoFrame";
            this.labelInfoFrame.Size = new System.Drawing.Size(25, 17);
            this.labelInfoFrame.TabIndex = 23;
            this.labelInfoFrame.Text = " -  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(6, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Info: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Slave ID:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(269, 31);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 29);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "0000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(116, 31);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 29);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0001";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Function Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(181, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Protocol ID:";
            // 
            // txtBoxUnitId
            // 
            this.txtBoxUnitId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxUnitId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUnitId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxUnitId.Location = new System.Drawing.Point(116, 101);
            this.txtBoxUnitId.MaxLength = 2;
            this.txtBoxUnitId.Name = "txtBoxUnitId";
            this.txtBoxUnitId.Size = new System.Drawing.Size(35, 29);
            this.txtBoxUnitId.TabIndex = 10;
            this.txtBoxUnitId.Text = "FF";
            this.txtBoxUnitId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Transaction ID:";
            // 
            // comboFunctionCode
            // 
            this.comboFunctionCode.FormattingEnabled = true;
            this.comboFunctionCode.Items.AddRange(new object[] {
            "Read Holding Registers ",
            "Preset Single Register",
            "Preset Multiple Registers"});
            this.comboFunctionCode.Location = new System.Drawing.Point(157, 66);
            this.comboFunctionCode.Name = "comboFunctionCode";
            this.comboFunctionCode.Size = new System.Drawing.Size(207, 29);
            this.comboFunctionCode.TabIndex = 18;
            this.comboFunctionCode.SelectedIndexChanged += new System.EventHandler(this.comboFunctionCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nr. of Registers:";
            // 
            // txtDataRegisters
            // 
            this.txtDataRegisters.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDataRegisters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataRegisters.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataRegisters.Location = new System.Drawing.Point(120, 66);
            this.txtDataRegisters.MaxLength = 100;
            this.txtDataRegisters.Name = "txtDataRegisters";
            this.txtDataRegisters.Size = new System.Drawing.Size(73, 29);
            this.txtDataRegisters.TabIndex = 19;
            this.txtDataRegisters.Text = "0001";
            // 
            // txtDataAddress
            // 
            this.txtDataAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDataAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataAddress.Location = new System.Drawing.Point(120, 31);
            this.txtDataAddress.MaxLength = 100;
            this.txtDataAddress.Name = "txtDataAddress";
            this.txtDataAddress.Size = new System.Drawing.Size(73, 29);
            this.txtDataAddress.TabIndex = 16;
            this.txtDataAddress.Text = "0097";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(62, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adress:";
            // 
            // groupBoxRq
            // 
            this.groupBoxRq.Controls.Add(this.txtRequest);
            this.groupBoxRq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxRq.Location = new System.Drawing.Point(14, 192);
            this.groupBoxRq.Name = "groupBoxRq";
            this.groupBoxRq.Size = new System.Drawing.Size(638, 70);
            this.groupBoxRq.TabIndex = 11;
            this.groupBoxRq.TabStop = false;
            this.groupBoxRq.Text = "Request";
            // 
            // groupBoxRsp
            // 
            this.groupBoxRsp.Controls.Add(this.txtResponse);
            this.groupBoxRsp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxRsp.Location = new System.Drawing.Point(14, 268);
            this.groupBoxRsp.Name = "groupBoxRsp";
            this.groupBoxRsp.Size = new System.Drawing.Size(638, 70);
            this.groupBoxRsp.TabIndex = 12;
            this.groupBoxRsp.TabStop = false;
            this.groupBoxRsp.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResponse.Location = new System.Drawing.Point(11, 28);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(617, 29);
            this.txtResponse.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(571, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHistory.Controls.Add(this.txtInfo);
            this.groupBoxHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxHistory.Location = new System.Drawing.Point(14, 372);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(638, 223);
            this.groupBoxHistory.TabIndex = 14;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "History";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInfo.Location = new System.Drawing.Point(11, 28);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(617, 181);
            this.txtInfo.TabIndex = 4;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalyze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnalyze.Location = new System.Drawing.Point(486, 344);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(71, 29);
            this.btnAnalyze.TabIndex = 15;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // groupBox03
            // 
            this.groupBox03.Controls.Add(this.bntPlus);
            this.groupBox03.Controls.Add(this.btnMinus);
            this.groupBox03.Controls.Add(this.label5);
            this.groupBox03.Controls.Add(this.label4);
            this.groupBox03.Controls.Add(this.txtDataRegisters);
            this.groupBox03.Controls.Add(this.txtDataAddress);
            this.groupBox03.Enabled = false;
            this.groupBox03.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox03.Location = new System.Drawing.Point(658, 10);
            this.groupBox03.Name = "groupBox03";
            this.groupBox03.Size = new System.Drawing.Size(265, 176);
            this.groupBox03.TabIndex = 21;
            this.groupBox03.TabStop = false;
            this.groupBox03.Text = "Data (FC=03)";
            // 
            // bntPlus
            // 
            this.bntPlus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntPlus.Location = new System.Drawing.Point(229, 67);
            this.bntPlus.Name = "bntPlus";
            this.bntPlus.Size = new System.Drawing.Size(28, 28);
            this.bntPlus.TabIndex = 22;
            this.bntPlus.Text = "+";
            this.bntPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntPlus.UseVisualStyleBackColor = true;
            this.bntPlus.Click += new System.EventHandler(this.bntPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(199, 67);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 28);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // groupBox06
            // 
            this.groupBox06.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox06.Location = new System.Drawing.Point(658, 192);
            this.groupBox06.Name = "groupBox06";
            this.groupBox06.Size = new System.Drawing.Size(265, 176);
            this.groupBox06.TabIndex = 22;
            this.groupBox06.TabStop = false;
            this.groupBox06.Text = "Data (FC=06)";
            this.groupBox06.Visible = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox16.Location = new System.Drawing.Point(658, 372);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(265, 176);
            this.groupBox16.TabIndex = 23;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Data (FC=16)";
            this.groupBox16.Visible = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(933, 606);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox06);
            this.Controls.Add(this.groupBox03);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.groupBoxHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxRsp);
            this.Controls.Add(this.groupBoxRq);
            this.Controls.Add(this.groupBoxFrame);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODBUS TCP Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFrame.ResumeLayout(false);
            this.groupBoxFrame.PerformLayout();
            this.groupBoxRq.ResumeLayout(false);
            this.groupBoxRq.PerformLayout();
            this.groupBoxRsp.ResumeLayout(false);
            this.groupBoxRsp.PerformLayout();
            this.groupBoxHistory.ResumeLayout(false);
            this.groupBoxHistory.PerformLayout();
            this.groupBox03.ResumeLayout(false);
            this.groupBox03.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private TextBox txtRequest;
        private TextBox txtBoxFunctionCode;
        private Button btnSend;
        private Button btnConnect;
        private TextBox txtPort;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnDisconnect;
        private GroupBox groupBoxFrame;
        private Label label2;
        private Label label5;
        private TextBox txtBoxUnitId;
        private Label label7;
        private TextBox txtDataAddress;
        private GroupBox groupBoxRq;
        private Label labelStatus2;
        private Label labelStatus;
        private GroupBox groupBoxRsp;
        private TextBox txtResponse;
        private ComboBox comboFunctionCode;
        private Button btnClear;
        private GroupBox groupBoxHistory;
        private TextBox txtInfo;
        private Label label4;
        private TextBox txtDataRegisters;
        private Button btnAnalyze;
        private GroupBox groupBox03;
        private GroupBox groupBox06;
        private GroupBox groupBox16;
        private Label label8;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button bntPlus;
        private Button btnMinus;
        private Label labelInfoFrame;
        private Label label9;
    }
}
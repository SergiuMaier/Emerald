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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.comboSlave = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProtocolId = new System.Windows.Forms.TextBox();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfoFrame = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboFunctionCode = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntPlus = new System.Windows.Forms.Button();
            this.txtAddress03 = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtNrRegisters03 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValue06 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress06 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtValues16 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddress16 = new System.Windows.Forms.TextBox();
            this.btnPlus16 = new System.Windows.Forms.Button();
            this.txtNrRegisters16 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnMinus16 = new System.Windows.Forms.Button();
            this.groupBoxRq = new System.Windows.Forms.GroupBox();
            this.groupBoxRsp = new System.Windows.Forms.GroupBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxRq.SuspendLayout();
            this.groupBoxRsp.SuspendLayout();
            this.groupBoxHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.White;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIP.Location = new System.Drawing.Point(85, 27);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(162, 26);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.88.100";
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.Color.White;
            this.txtRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequest.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRequest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRequest.Location = new System.Drawing.Point(7, 25);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ReadOnly = true;
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequest.Size = new System.Drawing.Size(395, 23);
            this.txtRequest.TabIndex = 3;
            this.txtRequest.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(437, 63);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(367, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 26);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseCompatibleTextRendering = true;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPort.Location = new System.Drawing.Point(290, 27);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 26);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "502";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(253, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelStatus2);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus2.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus2.Location = new System.Drawing.Point(605, 31);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(94, 17);
            this.labelStatus2.TabIndex = 11;
            this.labelStatus2.Text = "Not connected";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus.Location = new System.Drawing.Point(565, 31);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 17);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "status: ";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(455, 27);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 26);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseCompatibleTextRendering = true;
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMessage.Controls.Add(this.comboSlave);
            this.groupBoxMessage.Controls.Add(this.label7);
            this.groupBoxMessage.Controls.Add(this.txtProtocolId);
            this.groupBoxMessage.Controls.Add(this.txtTransactionId);
            this.groupBoxMessage.Controls.Add(this.label2);
            this.groupBoxMessage.Controls.Add(this.labelInfoFrame);
            this.groupBoxMessage.Controls.Add(this.label8);
            this.groupBoxMessage.Controls.Add(this.label9);
            this.groupBoxMessage.Controls.Add(this.label6);
            this.groupBoxMessage.Controls.Add(this.btnSend);
            this.groupBoxMessage.Controls.Add(this.comboFunctionCode);
            this.groupBoxMessage.Enabled = false;
            this.groupBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxMessage.Location = new System.Drawing.Point(14, 79);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(672, 159);
            this.groupBoxMessage.TabIndex = 10;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Message";
            // 
            // comboSlave
            // 
            this.comboSlave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSlave.FormattingEnabled = true;
            this.comboSlave.Items.AddRange(new object[] {
            "COM100"});
            this.comboSlave.Location = new System.Drawing.Point(378, 24);
            this.comboSlave.Name = "comboSlave";
            this.comboSlave.Size = new System.Drawing.Size(119, 28);
            this.comboSlave.TabIndex = 24;
            this.comboSlave.SelectedIndexChanged += new System.EventHandler(this.comboSlave_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(332, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Slave:";
            // 
            // txtProtocolId
            // 
            this.txtProtocolId.BackColor = System.Drawing.Color.White;
            this.txtProtocolId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProtocolId.Enabled = false;
            this.txtProtocolId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProtocolId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProtocolId.Location = new System.Drawing.Point(262, 26);
            this.txtProtocolId.MaxLength = 4;
            this.txtProtocolId.Name = "txtProtocolId";
            this.txtProtocolId.Size = new System.Drawing.Size(54, 26);
            this.txtProtocolId.TabIndex = 22;
            this.txtProtocolId.Text = "0000";
            this.txtProtocolId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.BackColor = System.Drawing.Color.White;
            this.txtTransactionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionId.Enabled = false;
            this.txtTransactionId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTransactionId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTransactionId.Location = new System.Drawing.Point(114, 26);
            this.txtTransactionId.MaxLength = 4;
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(54, 26);
            this.txtTransactionId.TabIndex = 21;
            this.txtTransactionId.Text = "0001";
            this.txtTransactionId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Command:";
            // 
            // labelInfoFrame
            // 
            this.labelInfoFrame.AutoSize = true;
            this.labelInfoFrame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoFrame.ForeColor = System.Drawing.Color.Gray;
            this.labelInfoFrame.Location = new System.Drawing.Point(39, 130);
            this.labelInfoFrame.Name = "labelInfoFrame";
            this.labelInfoFrame.Size = new System.Drawing.Size(25, 17);
            this.labelInfoFrame.TabIndex = 23;
            this.labelInfoFrame.Text = " -  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(175, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Protocol ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(7, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Info: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Transaction ID:";
            // 
            // comboFunctionCode
            // 
            this.comboFunctionCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFunctionCode.FormattingEnabled = true;
            this.comboFunctionCode.Items.AddRange(new object[] {
            "Read Holding Registers ",
            "Preset Single Register",
            "Preset Multiple Registers"});
            this.comboFunctionCode.Location = new System.Drawing.Point(113, 60);
            this.comboFunctionCode.Name = "comboFunctionCode";
            this.comboFunctionCode.Size = new System.Drawing.Size(203, 28);
            this.comboFunctionCode.TabIndex = 18;
            this.comboFunctionCode.SelectedIndexChanged += new System.EventHandler(this.comboFunctionCode_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bntPlus);
            this.panel1.Controls.Add(this.txtAddress03);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.txtNrRegisters03);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(469, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 92);
            this.panel1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(144, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "regs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adress:";
            // 
            // bntPlus
            // 
            this.bntPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.bntPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.bntPlus.FlatAppearance.BorderSize = 0;
            this.bntPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bntPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntPlus.ForeColor = System.Drawing.Color.Black;
            this.bntPlus.Location = new System.Drawing.Point(269, 14);
            this.bntPlus.Name = "bntPlus";
            this.bntPlus.Size = new System.Drawing.Size(20, 18);
            this.bntPlus.TabIndex = 22;
            this.bntPlus.Text = "+";
            this.bntPlus.UseCompatibleTextRendering = true;
            this.bntPlus.UseVisualStyleBackColor = false;
            this.bntPlus.Click += new System.EventHandler(this.bntPlus_Click);
            // 
            // txtAddress03
            // 
            this.txtAddress03.BackColor = System.Drawing.Color.White;
            this.txtAddress03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress03.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress03.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress03.Location = new System.Drawing.Point(71, 11);
            this.txtAddress03.MaxLength = 4;
            this.txtAddress03.Name = "txtAddress03";
            this.txtAddress03.Size = new System.Drawing.Size(54, 26);
            this.txtAddress03.TabIndex = 16;
            this.txtAddress03.Text = "0097";
            this.txtAddress03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.Location = new System.Drawing.Point(247, 14);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(20, 18);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Text = "-";
            this.btnMinus.UseCompatibleTextRendering = true;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtNrRegisters03
            // 
            this.txtNrRegisters03.BackColor = System.Drawing.Color.White;
            this.txtNrRegisters03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrRegisters03.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNrRegisters03.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNrRegisters03.Location = new System.Drawing.Point(190, 11);
            this.txtNrRegisters03.MaxLength = 4;
            this.txtNrRegisters03.Name = "txtNrRegisters03";
            this.txtNrRegisters03.Size = new System.Drawing.Size(54, 26);
            this.txtNrRegisters03.TabIndex = 19;
            this.txtNrRegisters03.Text = "0001";
            this.txtNrRegisters03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(138, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "No. of";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValue06);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtAddress06);
            this.panel2.Location = new System.Drawing.Point(469, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 92);
            this.panel2.TabIndex = 26;
            // 
            // txtValue06
            // 
            this.txtValue06.BackColor = System.Drawing.Color.White;
            this.txtValue06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue06.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue06.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValue06.Location = new System.Drawing.Point(71, 51);
            this.txtValue06.MaxLength = 4;
            this.txtValue06.Name = "txtValue06";
            this.txtValue06.Size = new System.Drawing.Size(54, 26);
            this.txtValue06.TabIndex = 24;
            this.txtValue06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Adress:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(23, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Value:";
            // 
            // txtAddress06
            // 
            this.txtAddress06.BackColor = System.Drawing.Color.White;
            this.txtAddress06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress06.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress06.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress06.Location = new System.Drawing.Point(71, 15);
            this.txtAddress06.MaxLength = 4;
            this.txtAddress06.Name = "txtAddress06";
            this.txtAddress06.Size = new System.Drawing.Size(54, 26);
            this.txtAddress06.TabIndex = 17;
            this.txtAddress06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtValues16);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtAddress16);
            this.panel3.Controls.Add(this.btnPlus16);
            this.panel3.Controls.Add(this.txtNrRegisters16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.btnMinus16);
            this.panel3.Location = new System.Drawing.Point(469, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 92);
            this.panel3.TabIndex = 27;
            // 
            // txtValues16
            // 
            this.txtValues16.BackColor = System.Drawing.Color.White;
            this.txtValues16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValues16.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValues16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValues16.Location = new System.Drawing.Point(71, 53);
            this.txtValues16.MaxLength = 100;
            this.txtValues16.Name = "txtValues16";
            this.txtValues16.Size = new System.Drawing.Size(314, 26);
            this.txtValues16.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(14, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Adress:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(17, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Values:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(196, -11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(144, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "regs:";
            // 
            // txtAddress16
            // 
            this.txtAddress16.BackColor = System.Drawing.Color.White;
            this.txtAddress16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress16.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress16.Location = new System.Drawing.Point(71, 17);
            this.txtAddress16.MaxLength = 4;
            this.txtAddress16.Name = "txtAddress16";
            this.txtAddress16.Size = new System.Drawing.Size(54, 26);
            this.txtAddress16.TabIndex = 25;
            this.txtAddress16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus16
            // 
            this.btnPlus16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPlus16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnPlus16.FlatAppearance.BorderSize = 0;
            this.btnPlus16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPlus16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus16.ForeColor = System.Drawing.Color.Black;
            this.btnPlus16.Location = new System.Drawing.Point(269, 21);
            this.btnPlus16.Name = "btnPlus16";
            this.btnPlus16.Size = new System.Drawing.Size(20, 17);
            this.btnPlus16.TabIndex = 31;
            this.btnPlus16.Text = "+";
            this.btnPlus16.UseCompatibleTextRendering = true;
            this.btnPlus16.UseVisualStyleBackColor = false;
            this.btnPlus16.Click += new System.EventHandler(this.btnPlus16_Click);
            // 
            // txtNrRegisters16
            // 
            this.txtNrRegisters16.BackColor = System.Drawing.Color.White;
            this.txtNrRegisters16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrRegisters16.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNrRegisters16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNrRegisters16.Location = new System.Drawing.Point(190, 17);
            this.txtNrRegisters16.MaxLength = 4;
            this.txtNrRegisters16.Name = "txtNrRegisters16";
            this.txtNrRegisters16.Size = new System.Drawing.Size(54, 26);
            this.txtNrRegisters16.TabIndex = 28;
            this.txtNrRegisters16.Text = "0001";
            this.txtNrRegisters16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(138, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "No. of";
            // 
            // btnMinus16
            // 
            this.btnMinus16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnMinus16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnMinus16.FlatAppearance.BorderSize = 0;
            this.btnMinus16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMinus16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus16.ForeColor = System.Drawing.Color.Black;
            this.btnMinus16.Location = new System.Drawing.Point(247, 21);
            this.btnMinus16.Name = "btnMinus16";
            this.btnMinus16.Size = new System.Drawing.Size(20, 17);
            this.btnMinus16.TabIndex = 30;
            this.btnMinus16.Text = "-";
            this.btnMinus16.UseCompatibleTextRendering = true;
            this.btnMinus16.UseVisualStyleBackColor = false;
            this.btnMinus16.Click += new System.EventHandler(this.btnMinus16_Click);
            // 
            // groupBoxRq
            // 
            this.groupBoxRq.Controls.Add(this.txtRequest);
            this.groupBoxRq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxRq.Location = new System.Drawing.Point(14, 307);
            this.groupBoxRq.Name = "groupBoxRq";
            this.groupBoxRq.Size = new System.Drawing.Size(413, 56);
            this.groupBoxRq.TabIndex = 11;
            this.groupBoxRq.TabStop = false;
            this.groupBoxRq.Text = "Request";
            // 
            // groupBoxRsp
            // 
            this.groupBoxRsp.Controls.Add(this.txtResponse);
            this.groupBoxRsp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxRsp.Location = new System.Drawing.Point(14, 364);
            this.groupBoxRsp.Name = "groupBoxRsp";
            this.groupBoxRsp.Size = new System.Drawing.Size(413, 56);
            this.groupBoxRsp.TabIndex = 12;
            this.groupBoxRsp.TabStop = false;
            this.groupBoxRsp.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.Color.White;
            this.txtResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponse.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResponse.Location = new System.Drawing.Point(6, 25);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(396, 23);
            this.txtResponse.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(188, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHistory.Controls.Add(this.txtInfo);
            this.groupBoxHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxHistory.Location = new System.Drawing.Point(14, 471);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(451, 101);
            this.groupBoxHistory.TabIndex = 14;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "History";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.White;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInfo.Location = new System.Drawing.Point(6, 26);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(437, 69);
            this.txtInfo.TabIndex = 4;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnAnalyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalyze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnalyze.Location = new System.Drawing.Point(111, 426);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(71, 29);
            this.btnAnalyze.TabIndex = 15;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHistory.Location = new System.Drawing.Point(271, 426);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(71, 29);
            this.btnHistory.TabIndex = 24;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(915, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.groupBoxHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxRsp);
            this.Controls.Add(this.groupBoxRq);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODBUS TCP Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxRq.ResumeLayout(false);
            this.groupBoxRq.PerformLayout();
            this.groupBoxRsp.ResumeLayout(false);
            this.groupBoxRsp.PerformLayout();
            this.groupBoxHistory.ResumeLayout(false);
            this.groupBoxHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private TextBox txtRequest;
        private Button btnSend;
        private Button btnConnect;
        private TextBox txtPort;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnDisconnect;
        private GroupBox groupBoxMessage;
        private Label label2;
        private Label label5;
        private Label label7;
        private TextBox txtAddress03;
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
        private TextBox txtNrRegisters03;
        private Button btnAnalyze;
        private Label label8;
        private Label label6;
        private TextBox txtProtocolId;
        private TextBox txtTransactionId;
        private Button bntPlus;
        private Button btnMinus;
        private Label labelInfoFrame;
        private Label label9;
        private TextBox txtValue06;
        private Label label11;
        private TextBox txtAddress06;
        private Label label10;
        private Label label12;
        private TextBox txtAddress16;
        private Label label14;
        private Label label13;
        private Label label16;
        private Button btnPlus16;
        private Button btnMinus16;
        private Label label17;
        private TextBox txtNrRegisters16;
        private TextBox txtValues16;
        private Label label18;
        private ComboBox comboSlave;
        private Button btnHistory;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
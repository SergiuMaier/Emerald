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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.btnSend = new System.Windows.Forms.Button();
            this.comboSlave = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFunctionCode = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richtxtIP = new System.Windows.Forms.RichTextBox();
            this.richtxtPort = new System.Windows.Forms.RichTextBox();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonDisconnect = new TCPClient.CustomControls.CustomButton();
            this.buttonConnect = new TCPClient.CustomControls.CustomButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.richtxtTransactionId = new System.Windows.Forms.RichTextBox();
            this.richtxtDataAddress = new System.Windows.Forms.RichTextBox();
            this.richtxtDataRegisters = new System.Windows.Forms.RichTextBox();
            this.panelRegsNumber = new System.Windows.Forms.Panel();
            this.panelValues = new System.Windows.Forms.Panel();
            this.richtxtDataValues = new System.Windows.Forms.RichTextBox();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.richtxtSlaveId = new System.Windows.Forms.RichTextBox();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.richtxtPrintResponse = new System.Windows.Forms.RichTextBox();
            this.richtxtPrintRequest = new System.Windows.Forms.RichTextBox();
            this.panelResponse = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richtxtPrintAnalyze = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelRegsNumber.SuspendLayout();
            this.panelValues.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.panelRequest.SuspendLayout();
            this.panelResponse.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(606, 139);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseCompatibleTextRendering = true;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // comboSlave
            // 
            this.comboSlave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSlave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.comboSlave.FormattingEnabled = true;
            this.comboSlave.Items.AddRange(new object[] {
            "COM100",
            "New Device"});
            this.comboSlave.Location = new System.Drawing.Point(261, 15);
            this.comboSlave.Name = "comboSlave";
            this.comboSlave.Size = new System.Drawing.Size(103, 28);
            this.comboSlave.TabIndex = 24;
            this.comboSlave.SelectedIndexChanged += new System.EventHandler(this.comboSlave_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(204, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(408, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Command:";
            // 
            // comboFunctionCode
            // 
            this.comboFunctionCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFunctionCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.comboFunctionCode.FormattingEnabled = true;
            this.comboFunctionCode.Items.AddRange(new object[] {
            "Read Holding Registers ",
            "Preset Single Register",
            "Preset Multiple Registers"});
            this.comboFunctionCode.Location = new System.Drawing.Point(489, 15);
            this.comboFunctionCode.Name = "comboFunctionCode";
            this.comboFunctionCode.Size = new System.Drawing.Size(192, 28);
            this.comboFunctionCode.TabIndex = 18;
            this.comboFunctionCode.SelectedIndexChanged += new System.EventHandler(this.comboFunctionCode_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(1, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "No. of regs:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.label18.Location = new System.Drawing.Point(1, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 18);
            this.label18.TabIndex = 33;
            this.label18.Text = "Values:";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.btnPlus.Location = new System.Drawing.Point(167, 12);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(15, 15);
            this.btnPlus.TabIndex = 31;
            this.btnPlus.Text = "+";
            this.btnPlus.UseCompatibleTextRendering = true;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.btnMinus.Location = new System.Drawing.Point(151, 12);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(15, 15);
            this.btnMinus.TabIndex = 30;
            this.btnMinus.Text = "-";
            this.btnMinus.UseCompatibleTextRendering = true;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(63, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Transaction ID:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(606, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(22, 11);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 29);
            this.btnHistory.TabIndex = 24;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 50);
            this.panel4.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.label15.Location = new System.Drawing.Point(10, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Connection";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.label16.Location = new System.Drawing.Point(16, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Message";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 50);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(0, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(119, 50);
            this.panel6.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Request";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.label17.Location = new System.Drawing.Point(26, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Request";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.label19.Location = new System.Drawing.Point(12, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "Response";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(0, 282);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(119, 50);
            this.panel7.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel8.Controls.Add(this.label20);
            this.panel8.Location = new System.Drawing.Point(0, 511);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(119, 50);
            this.panel8.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.label20.Location = new System.Drawing.Point(18, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(278, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // richtxtIP
            // 
            this.richtxtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtIP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtIP.Location = new System.Drawing.Point(107, 13);
            this.richtxtIP.MaxLength = 15;
            this.richtxtIP.Name = "richtxtIP";
            this.richtxtIP.Size = new System.Drawing.Size(160, 26);
            this.richtxtIP.TabIndex = 25;
            this.richtxtIP.Text = "192.168.88.100";
            // 
            // richtxtPort
            // 
            this.richtxtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtPort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtPort.Location = new System.Drawing.Point(314, 13);
            this.richtxtPort.MaxLength = 5;
            this.richtxtPort.Name = "richtxtPort";
            this.richtxtPort.Size = new System.Drawing.Size(61, 26);
            this.richtxtPort.TabIndex = 26;
            this.richtxtPort.Text = "502";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.labelStatus2.Location = new System.Drawing.Point(598, 19);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(90, 15);
            this.labelStatus2.TabIndex = 11;
            this.labelStatus2.Text = "Not connected";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel9.Controls.Add(this.buttonDisconnect);
            this.panel9.Controls.Add(this.buttonConnect);
            this.panel9.Controls.Add(this.labelStatus2);
            this.panel9.Controls.Add(this.richtxtPort);
            this.panel9.Controls.Add(this.richtxtIP);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(122, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(745, 50);
            this.panel9.TabIndex = 30;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonDisconnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonDisconnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonDisconnect.BorderRadius = 25;
            this.buttonDisconnect.BorderSize = 0;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDisconnect.ForeColor = System.Drawing.Color.White;
            this.buttonDisconnect.Location = new System.Drawing.Point(489, 8);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(96, 34);
            this.buttonDisconnect.TabIndex = 41;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.TextColor = System.Drawing.Color.White;
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonConnect.BorderRadius = 25;
            this.buttonConnect.BorderSize = 0;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(387, 8);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 34);
            this.buttonConnect.TabIndex = 43;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.TextColor = System.Drawing.Color.White;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.panel11.Location = new System.Drawing.Point(119, -2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(3, 565);
            this.panel11.TabIndex = 31;
            // 
            // richtxtTransactionId
            // 
            this.richtxtTransactionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtTransactionId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtTransactionId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtTransactionId.Location = new System.Drawing.Point(128, 17);
            this.richtxtTransactionId.MaxLength = 4;
            this.richtxtTransactionId.Name = "richtxtTransactionId";
            this.richtxtTransactionId.ReadOnly = true;
            this.richtxtTransactionId.Size = new System.Drawing.Size(63, 26);
            this.richtxtTransactionId.TabIndex = 27;
            this.richtxtTransactionId.Text = "0001";
            // 
            // richtxtDataAddress
            // 
            this.richtxtDataAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtDataAddress.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtDataAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtDataAddress.Location = new System.Drawing.Point(128, 60);
            this.richtxtDataAddress.MaxLength = 4;
            this.richtxtDataAddress.Name = "richtxtDataAddress";
            this.richtxtDataAddress.Size = new System.Drawing.Size(63, 26);
            this.richtxtDataAddress.TabIndex = 32;
            this.richtxtDataAddress.Text = "0097";
            // 
            // richtxtDataRegisters
            // 
            this.richtxtDataRegisters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtDataRegisters.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtDataRegisters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtDataRegisters.Location = new System.Drawing.Point(86, 6);
            this.richtxtDataRegisters.MaxLength = 4;
            this.richtxtDataRegisters.Name = "richtxtDataRegisters";
            this.richtxtDataRegisters.Size = new System.Drawing.Size(60, 26);
            this.richtxtDataRegisters.TabIndex = 36;
            this.richtxtDataRegisters.Text = "0001";
            // 
            // panelRegsNumber
            // 
            this.panelRegsNumber.Controls.Add(this.label12);
            this.panelRegsNumber.Controls.Add(this.richtxtDataRegisters);
            this.panelRegsNumber.Controls.Add(this.btnMinus);
            this.panelRegsNumber.Controls.Add(this.btnPlus);
            this.panelRegsNumber.Location = new System.Drawing.Point(218, 54);
            this.panelRegsNumber.Name = "panelRegsNumber";
            this.panelRegsNumber.Size = new System.Drawing.Size(206, 42);
            this.panelRegsNumber.TabIndex = 37;
            // 
            // panelValues
            // 
            this.panelValues.Controls.Add(this.richtxtDataValues);
            this.panelValues.Controls.Add(this.label18);
            this.panelValues.Location = new System.Drawing.Point(72, 97);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(528, 81);
            this.panelValues.TabIndex = 38;
            // 
            // richtxtDataValues
            // 
            this.richtxtDataValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtDataValues.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtDataValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtDataValues.Location = new System.Drawing.Point(56, 7);
            this.richtxtDataValues.MaxLength = 4;
            this.richtxtDataValues.Name = "richtxtDataValues";
            this.richtxtDataValues.Size = new System.Drawing.Size(466, 64);
            this.richtxtDataValues.TabIndex = 39;
            this.richtxtDataValues.Text = "";
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.White;
            this.panelMessage.Controls.Add(this.richtxtSlaveId);
            this.panelMessage.Controls.Add(this.btnSend);
            this.panelMessage.Controls.Add(this.label6);
            this.panelMessage.Controls.Add(this.panelValues);
            this.panelMessage.Controls.Add(this.richtxtTransactionId);
            this.panelMessage.Controls.Add(this.panelRegsNumber);
            this.panelMessage.Controls.Add(this.label7);
            this.panelMessage.Controls.Add(this.richtxtDataAddress);
            this.panelMessage.Controls.Add(this.comboFunctionCode);
            this.panelMessage.Controls.Add(this.label10);
            this.panelMessage.Controls.Add(this.label2);
            this.panelMessage.Controls.Add(this.comboSlave);
            this.panelMessage.Location = new System.Drawing.Point(122, 50);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(745, 228);
            this.panelMessage.TabIndex = 39;
            // 
            // richtxtSlaveId
            // 
            this.richtxtSlaveId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.richtxtSlaveId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtSlaveId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtSlaveId.Location = new System.Drawing.Point(368, 15);
            this.richtxtSlaveId.MaxLength = 2;
            this.richtxtSlaveId.Name = "richtxtSlaveId";
            this.richtxtSlaveId.Size = new System.Drawing.Size(36, 28);
            this.richtxtSlaveId.TabIndex = 40;
            this.richtxtSlaveId.Text = "00";
            this.richtxtSlaveId.Visible = false;
            // 
            // panelRequest
            // 
            this.panelRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelRequest.Controls.Add(this.richtxtPrintResponse);
            this.panelRequest.Controls.Add(this.btnClear);
            this.panelRequest.Location = new System.Drawing.Point(0, 54);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(745, 50);
            this.panelRequest.TabIndex = 40;
            // 
            // richtxtPrintResponse
            // 
            this.richtxtPrintResponse.BackColor = System.Drawing.Color.White;
            this.richtxtPrintResponse.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtPrintResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtPrintResponse.Location = new System.Drawing.Point(22, 13);
            this.richtxtPrintResponse.MaxLength = 4;
            this.richtxtPrintResponse.Name = "richtxtPrintResponse";
            this.richtxtPrintResponse.Size = new System.Drawing.Size(572, 26);
            this.richtxtPrintResponse.TabIndex = 43;
            this.richtxtPrintResponse.Text = "";
            // 
            // richtxtPrintRequest
            // 
            this.richtxtPrintRequest.BackColor = System.Drawing.Color.White;
            this.richtxtPrintRequest.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtPrintRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtPrintRequest.Location = new System.Drawing.Point(22, 13);
            this.richtxtPrintRequest.MaxLength = 4;
            this.richtxtPrintRequest.Name = "richtxtPrintRequest";
            this.richtxtPrintRequest.Size = new System.Drawing.Size(572, 26);
            this.richtxtPrintRequest.TabIndex = 42;
            this.richtxtPrintRequest.Text = "";
            // 
            // panelResponse
            // 
            this.panelResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelResponse.Controls.Add(this.richtxtPrintRequest);
            this.panelResponse.Location = new System.Drawing.Point(0, 2);
            this.panelResponse.Name = "panelResponse";
            this.panelResponse.Size = new System.Drawing.Size(745, 50);
            this.panelResponse.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.richtxtPrintAnalyze);
            this.panel1.Controls.Add(this.panelRequest);
            this.panel1.Controls.Add(this.panelResponse);
            this.panel1.Location = new System.Drawing.Point(122, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 288);
            this.panel1.TabIndex = 40;
            // 
            // richtxtPrintAnalyze
            // 
            this.richtxtPrintAnalyze.BackColor = System.Drawing.Color.White;
            this.richtxtPrintAnalyze.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtPrintAnalyze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.richtxtPrintAnalyze.Location = new System.Drawing.Point(22, 112);
            this.richtxtPrintAnalyze.MaxLength = 4;
            this.richtxtPrintAnalyze.Name = "richtxtPrintAnalyze";
            this.richtxtPrintAnalyze.Size = new System.Drawing.Size(572, 165);
            this.richtxtPrintAnalyze.TabIndex = 44;
            this.richtxtPrintAnalyze.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Location = new System.Drawing.Point(122, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 50);
            this.panel2.TabIndex = 41;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODBUS TCP Client";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelRegsNumber.ResumeLayout(false);
            this.panelRegsNumber.PerformLayout();
            this.panelValues.ResumeLayout(false);
            this.panelValues.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.panelRequest.ResumeLayout(false);
            this.panelResponse.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSend;
        private Label label2;
        private Label label7;
        private ComboBox comboFunctionCode;
        private Button btnClear;
        private Label label6;
        private Label label10;
        private Button btnPlus;
        private Button btnMinus;
        private Label label18;
        private ComboBox comboSlave;
        private Button btnHistory;
        private Label label12;
        private Panel panel4;
        private Label label15;
        private Label label16;
        private Panel panel5;
        private Panel panel6;
        private Label label17;
        private Label label19;
        private Panel panel7;
        private Panel panel8;
        private Label label20;
        private Label label3;
        private Label label1;
        private RichTextBox richtxtIP;
        private RichTextBox richtxtPort;
        private Label labelStatus2;
        private Panel panel9;
        private Panel panel11;
        private RichTextBox richtxtTransactionId;
        private RichTextBox richtxtDataAddress;
        private RichTextBox richtxtDataRegisters;
        private Panel panelRegsNumber;
        private Panel panelValues;
        private RichTextBox richtxtDataValues;
        private Panel panelMessage;
        private Panel panelRequest;
        private Label label4;
        private Panel panelResponse;
        private RichTextBox richtxtPrintRequest;
        private RichTextBox richtxtPrintResponse;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox richtxtSlaveId;
        private ToolTip toolTipForm;
        private RichTextBox richtxtPrintAnalyze;
        private CustomControls.CustomButton buttonConnect;
        private CustomControls.CustomButton buttonDisconnect;
    }
}
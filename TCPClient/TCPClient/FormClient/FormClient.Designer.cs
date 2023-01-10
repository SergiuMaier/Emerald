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
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.customTextBoxPort = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxIP = new TCPClient.CustomControls.CustomTextBox();
            this.buttonDisconnect = new TCPClient.CustomControls.CustomButton();
            this.buttonConnect = new TCPClient.CustomControls.CustomButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelRegsNumber = new System.Windows.Forms.Panel();
            this.customTextBoxDataRegisters = new TCPClient.CustomControls.CustomTextBox();
            this.panelValues = new System.Windows.Forms.Panel();
            this.customTextBoxDataValues = new TCPClient.CustomControls.CustomTextBox();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.buttonSend = new TCPClient.CustomControls.CustomButton();
            this.customTextBoxDataAddress = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxSlaveId = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxTransactionId = new TCPClient.CustomControls.CustomTextBox();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.customTextBoxPrintResponse = new TCPClient.CustomControls.CustomTextBox();
            this.panelResponse = new System.Windows.Forms.Panel();
            this.customTextBoxPrintRequest = new TCPClient.CustomControls.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new TCPClient.CustomControls.CustomButton();
            this.customTextBoxPrintAnalyze = new TCPClient.CustomControls.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHistory = new TCPClient.CustomControls.CustomButton();
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
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.labelStatus2.Location = new System.Drawing.Point(602, 18);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(90, 15);
            this.labelStatus2.TabIndex = 11;
            this.labelStatus2.Text = "Not connected";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.customTextBoxPort);
            this.panel9.Controls.Add(this.customTextBoxIP);
            this.panel9.Controls.Add(this.buttonDisconnect);
            this.panel9.Controls.Add(this.buttonConnect);
            this.panel9.Controls.Add(this.labelStatus2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(122, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(745, 50);
            this.panel9.TabIndex = 30;
            // 
            // customTextBoxPort
            // 
            this.customTextBoxPort.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPort.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxPort.BorderSize = 2;
            this.customTextBoxPort.Enable = true;
            this.customTextBoxPort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPort.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPort.Location = new System.Drawing.Point(316, 8);
            this.customTextBoxPort.MaxLength = 5;
            this.customTextBoxPort.Multiline = false;
            this.customTextBoxPort.Name = "customTextBoxPort";
            this.customTextBoxPort.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPort.Size = new System.Drawing.Size(68, 33);
            this.customTextBoxPort.TabIndex = 42;
            this.customTextBoxPort.Texts = "502";
            this.customTextBoxPort.UnderlinedStyle = true;
            // 
            // customTextBoxIP
            // 
            this.customTextBoxIP.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxIP.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxIP.BorderSize = 2;
            this.customTextBoxIP.Enable = true;
            this.customTextBoxIP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxIP.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxIP.Location = new System.Drawing.Point(112, 8);
            this.customTextBoxIP.MaxLength = 15;
            this.customTextBoxIP.Multiline = false;
            this.customTextBoxIP.Name = "customTextBoxIP";
            this.customTextBoxIP.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxIP.Size = new System.Drawing.Size(160, 33);
            this.customTextBoxIP.TabIndex = 45;
            this.customTextBoxIP.Texts = "192.168.88.100";
            this.customTextBoxIP.UnderlinedStyle = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonDisconnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonDisconnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonDisconnect.BorderRadius = 25;
            this.buttonDisconnect.BorderSize = 0;
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDisconnect.ForeColor = System.Drawing.Color.White;
            this.buttonDisconnect.Location = new System.Drawing.Point(495, 7);
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
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonConnect.BorderRadius = 25;
            this.buttonConnect.BorderSize = 0;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(395, 7);
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
            // panelRegsNumber
            // 
            this.panelRegsNumber.Controls.Add(this.customTextBoxDataRegisters);
            this.panelRegsNumber.Controls.Add(this.label12);
            this.panelRegsNumber.Controls.Add(this.btnMinus);
            this.panelRegsNumber.Controls.Add(this.btnPlus);
            this.panelRegsNumber.Location = new System.Drawing.Point(218, 54);
            this.panelRegsNumber.Name = "panelRegsNumber";
            this.panelRegsNumber.Size = new System.Drawing.Size(206, 42);
            this.panelRegsNumber.TabIndex = 37;
            // 
            // customTextBoxDataRegisters
            // 
            this.customTextBoxDataRegisters.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxDataRegisters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxDataRegisters.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxDataRegisters.BorderSize = 2;
            this.customTextBoxDataRegisters.Enable = true;
            this.customTextBoxDataRegisters.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxDataRegisters.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxDataRegisters.Location = new System.Drawing.Point(88, 3);
            this.customTextBoxDataRegisters.MaxLength = 4;
            this.customTextBoxDataRegisters.Multiline = false;
            this.customTextBoxDataRegisters.Name = "customTextBoxDataRegisters";
            this.customTextBoxDataRegisters.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxDataRegisters.Size = new System.Drawing.Size(56, 33);
            this.customTextBoxDataRegisters.TabIndex = 44;
            this.customTextBoxDataRegisters.Texts = "0001";
            this.customTextBoxDataRegisters.UnderlinedStyle = true;
            // 
            // panelValues
            // 
            this.panelValues.Controls.Add(this.label18);
            this.panelValues.Controls.Add(this.customTextBoxDataValues);
            this.panelValues.Location = new System.Drawing.Point(72, 97);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(528, 81);
            this.panelValues.TabIndex = 38;
            // 
            // customTextBoxDataValues
            // 
            this.customTextBoxDataValues.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxDataValues.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxDataValues.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxDataValues.BorderSize = 2;
            this.customTextBoxDataValues.Enable = true;
            this.customTextBoxDataValues.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxDataValues.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxDataValues.Location = new System.Drawing.Point(56, 8);
            this.customTextBoxDataValues.MaxLength = 4;
            this.customTextBoxDataValues.Multiline = true;
            this.customTextBoxDataValues.Name = "customTextBoxDataValues";
            this.customTextBoxDataValues.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxDataValues.Size = new System.Drawing.Size(466, 64);
            this.customTextBoxDataValues.TabIndex = 42;
            this.customTextBoxDataValues.Texts = "";
            this.customTextBoxDataValues.UnderlinedStyle = false;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.White;
            this.panelMessage.Controls.Add(this.buttonSend);
            this.panelMessage.Controls.Add(this.customTextBoxDataAddress);
            this.panelMessage.Controls.Add(this.customTextBoxSlaveId);
            this.panelMessage.Controls.Add(this.customTextBoxTransactionId);
            this.panelMessage.Controls.Add(this.label6);
            this.panelMessage.Controls.Add(this.panelValues);
            this.panelMessage.Controls.Add(this.panelRegsNumber);
            this.panelMessage.Controls.Add(this.label7);
            this.panelMessage.Controls.Add(this.comboFunctionCode);
            this.panelMessage.Controls.Add(this.label10);
            this.panelMessage.Controls.Add(this.label2);
            this.panelMessage.Controls.Add(this.comboSlave);
            this.panelMessage.Enabled = false;
            this.panelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panelMessage.Location = new System.Drawing.Point(122, 50);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(700, 228);
            this.panelMessage.TabIndex = 39;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonSend.BorderRadius = 25;
            this.buttonSend.BorderSize = 0;
            this.buttonSend.Enabled = false;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(606, 136);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(62, 33);
            this.buttonSend.TabIndex = 44;
            this.buttonSend.Text = "Send";
            this.buttonSend.TextColor = System.Drawing.Color.White;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // customTextBoxDataAddress
            // 
            this.customTextBoxDataAddress.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxDataAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxDataAddress.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxDataAddress.BorderSize = 2;
            this.customTextBoxDataAddress.Enable = true;
            this.customTextBoxDataAddress.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxDataAddress.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxDataAddress.Location = new System.Drawing.Point(128, 54);
            this.customTextBoxDataAddress.MaxLength = 4;
            this.customTextBoxDataAddress.Multiline = false;
            this.customTextBoxDataAddress.Name = "customTextBoxDataAddress";
            this.customTextBoxDataAddress.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxDataAddress.Size = new System.Drawing.Size(56, 33);
            this.customTextBoxDataAddress.TabIndex = 43;
            this.customTextBoxDataAddress.Texts = "0097";
            this.customTextBoxDataAddress.UnderlinedStyle = true;
            // 
            // customTextBoxSlaveId
            // 
            this.customTextBoxSlaveId.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxSlaveId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxSlaveId.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxSlaveId.BorderSize = 2;
            this.customTextBoxSlaveId.Enable = false;
            this.customTextBoxSlaveId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxSlaveId.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxSlaveId.Location = new System.Drawing.Point(370, 10);
            this.customTextBoxSlaveId.MaxLength = 2;
            this.customTextBoxSlaveId.Multiline = false;
            this.customTextBoxSlaveId.Name = "customTextBoxSlaveId";
            this.customTextBoxSlaveId.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxSlaveId.Size = new System.Drawing.Size(36, 33);
            this.customTextBoxSlaveId.TabIndex = 43;
            this.customTextBoxSlaveId.Texts = "00";
            this.customTextBoxSlaveId.UnderlinedStyle = true;
            // 
            // customTextBoxTransactionId
            // 
            this.customTextBoxTransactionId.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxTransactionId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxTransactionId.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxTransactionId.BorderSize = 2;
            this.customTextBoxTransactionId.Enable = true;
            this.customTextBoxTransactionId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxTransactionId.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxTransactionId.Location = new System.Drawing.Point(128, 10);
            this.customTextBoxTransactionId.MaxLength = 4;
            this.customTextBoxTransactionId.Multiline = false;
            this.customTextBoxTransactionId.Name = "customTextBoxTransactionId";
            this.customTextBoxTransactionId.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxTransactionId.Size = new System.Drawing.Size(56, 33);
            this.customTextBoxTransactionId.TabIndex = 42;
            this.customTextBoxTransactionId.Texts = "0001";
            this.customTextBoxTransactionId.UnderlinedStyle = true;
            // 
            // panelRequest
            // 
            this.panelRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelRequest.Controls.Add(this.customTextBoxPrintResponse);
            this.panelRequest.Location = new System.Drawing.Point(0, 54);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(745, 50);
            this.panelRequest.TabIndex = 40;
            // 
            // customTextBoxPrintResponse
            // 
            this.customTextBoxPrintResponse.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPrintResponse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintResponse.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxPrintResponse.BorderSize = 2;
            this.customTextBoxPrintResponse.Enable = true;
            this.customTextBoxPrintResponse.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPrintResponse.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPrintResponse.Location = new System.Drawing.Point(22, 9);
            this.customTextBoxPrintResponse.MaxLength = 1;
            this.customTextBoxPrintResponse.Multiline = false;
            this.customTextBoxPrintResponse.Name = "customTextBoxPrintResponse";
            this.customTextBoxPrintResponse.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPrintResponse.Size = new System.Drawing.Size(572, 33);
            this.customTextBoxPrintResponse.TabIndex = 47;
            this.customTextBoxPrintResponse.Texts = "";
            this.customTextBoxPrintResponse.UnderlinedStyle = true;
            // 
            // panelResponse
            // 
            this.panelResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panelResponse.Controls.Add(this.customTextBoxPrintRequest);
            this.panelResponse.Location = new System.Drawing.Point(0, 2);
            this.panelResponse.Name = "panelResponse";
            this.panelResponse.Size = new System.Drawing.Size(745, 50);
            this.panelResponse.TabIndex = 41;
            // 
            // customTextBoxPrintRequest
            // 
            this.customTextBoxPrintRequest.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPrintRequest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintRequest.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxPrintRequest.BorderSize = 2;
            this.customTextBoxPrintRequest.Enable = true;
            this.customTextBoxPrintRequest.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPrintRequest.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPrintRequest.Location = new System.Drawing.Point(22, 9);
            this.customTextBoxPrintRequest.MaxLength = 1;
            this.customTextBoxPrintRequest.Multiline = false;
            this.customTextBoxPrintRequest.Name = "customTextBoxPrintRequest";
            this.customTextBoxPrintRequest.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPrintRequest.Size = new System.Drawing.Size(572, 33);
            this.customTextBoxPrintRequest.TabIndex = 46;
            this.customTextBoxPrintRequest.Texts = "";
            this.customTextBoxPrintRequest.UnderlinedStyle = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.customTextBoxPrintAnalyze);
            this.panel1.Controls.Add(this.panelRequest);
            this.panel1.Controls.Add(this.panelResponse);
            this.panel1.Location = new System.Drawing.Point(122, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 288);
            this.panel1.TabIndex = 40;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonClear.BorderRadius = 25;
            this.buttonClear.BorderSize = 0;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(606, 244);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(62, 33);
            this.buttonClear.TabIndex = 45;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextColor = System.Drawing.Color.White;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // customTextBoxPrintAnalyze
            // 
            this.customTextBoxPrintAnalyze.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPrintAnalyze.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintAnalyze.BorderFocusColor = System.Drawing.Color.Red;
            this.customTextBoxPrintAnalyze.BorderSize = 2;
            this.customTextBoxPrintAnalyze.Enable = true;
            this.customTextBoxPrintAnalyze.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPrintAnalyze.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPrintAnalyze.Location = new System.Drawing.Point(22, 110);
            this.customTextBoxPrintAnalyze.MaxLength = 1;
            this.customTextBoxPrintAnalyze.Multiline = true;
            this.customTextBoxPrintAnalyze.Name = "customTextBoxPrintAnalyze";
            this.customTextBoxPrintAnalyze.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPrintAnalyze.Size = new System.Drawing.Size(572, 167);
            this.customTextBoxPrintAnalyze.TabIndex = 43;
            this.customTextBoxPrintAnalyze.Texts = "";
            this.customTextBoxPrintAnalyze.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonHistory);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(122, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 50);
            this.panel2.TabIndex = 41;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonHistory.BorderRadius = 25;
            this.buttonHistory.BorderSize = 0;
            this.buttonHistory.Enabled = false;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(22, 8);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(73, 33);
            this.buttonHistory.TabIndex = 46;
            this.buttonHistory.Text = "History";
            this.buttonHistory.TextColor = System.Drawing.Color.White;
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(822, 561);
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
        private Label label2;
        private Label label7;
        private ComboBox comboFunctionCode;
        private Label label6;
        private Label label10;
        private Button btnPlus;
        private Button btnMinus;
        private Label label18;
        private ComboBox comboSlave;
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
        private Label labelStatus2;
        private Panel panel9;
        private Panel panel11;
        private Panel panelRegsNumber;
        private Panel panelValues;
        private Panel panelMessage;
        private Panel panelRequest;
        private Label label4;
        private Panel panelResponse;
        private Panel panel1;
        private Panel panel2;
        private ToolTip toolTipForm;
        private CustomControls.CustomButton buttonConnect;
        private CustomControls.CustomButton buttonDisconnect;
        private CustomControls.CustomTextBox customTextBoxIP;
        private CustomControls.CustomTextBox customTextBoxPort;
        private CustomControls.CustomTextBox customTextBoxTransactionId;
        private CustomControls.CustomTextBox customTextBoxSlaveId;
        private CustomControls.CustomTextBox customTextBoxDataAddress;
        private CustomControls.CustomTextBox customTextBoxDataRegisters;
        private CustomControls.CustomTextBox customTextBoxDataValues;
        private CustomControls.CustomTextBox customTextBoxPrintRequest;
        private CustomControls.CustomTextBox customTextBoxPrintResponse;
        private CustomControls.CustomTextBox customTextBoxPrintAnalyze;
        private CustomControls.CustomButton buttonSend;
        private CustomControls.CustomButton buttonClear;
        private CustomControls.CustomButton buttonHistory;
    }
}
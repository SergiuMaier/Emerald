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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.customTextBoxPort = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxIP = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxSlaveId = new TCPClient.CustomControls.CustomTextBox();
            this.buttonConnect = new TCPClient.CustomControls.CustomButton();
            this.panelRegsNumber = new System.Windows.Forms.Panel();
            this.customTextBoxDataRegisters = new TCPClient.CustomControls.CustomTextBox();
            this.panelValues = new System.Windows.Forms.Panel();
            this.customTextBoxDataValues = new TCPClient.CustomControls.CustomTextBox();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.customTextBoxDataAddress = new TCPClient.CustomControls.CustomTextBox();
            this.customTextBoxTransactionId = new TCPClient.CustomControls.CustomTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSend = new TCPClient.CustomControls.CustomButton();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.customTextBoxPrintResponse = new TCPClient.CustomControls.CustomTextBox();
            this.panelResponse = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.customTextBoxPrintRequest = new TCPClient.CustomControls.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.customTextBoxPrintAnalyze = new TCPClient.CustomControls.CustomTextBox();
            this.buttonHistory = new TCPClient.CustomControls.CustomButton();
            this.buttonClear = new TCPClient.CustomControls.CustomButton();
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panelRegsNumber.SuspendLayout();
            this.panelValues.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.panelRequest.SuspendLayout();
            this.panelResponse.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboSlave
            // 
            this.comboSlave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSlave.ForeColor = System.Drawing.Color.Black;
            this.comboSlave.FormattingEnabled = true;
            this.comboSlave.Items.AddRange(new object[] {
            "COM100",
            "New Device"});
            this.comboSlave.Location = new System.Drawing.Point(92, 15);
            this.comboSlave.Name = "comboSlave";
            this.comboSlave.Size = new System.Drawing.Size(103, 28);
            this.comboSlave.TabIndex = 24;
            this.comboSlave.SelectedIndexChanged += new System.EventHandler(this.comboSlave_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(33, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Command:";
            // 
            // comboFunctionCode
            // 
            this.comboFunctionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFunctionCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFunctionCode.ForeColor = System.Drawing.Color.Black;
            this.comboFunctionCode.FormattingEnabled = true;
            this.comboFunctionCode.Items.AddRange(new object[] {
            "Read Holding Registers ",
            "Preset Single Register",
            "Preset Multiple Registers"});
            this.comboFunctionCode.Location = new System.Drawing.Point(92, 14);
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
            this.label12.Location = new System.Drawing.Point(7, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "No. of regs:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label18.Location = new System.Drawing.Point(3, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 18);
            this.label18.TabIndex = 33;
            this.label18.Text = "Values";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(162, 15);
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
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(147, 15);
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
            this.label10.Location = new System.Drawing.Point(58, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Transaction ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(506, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(253, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus2.ForeColor = System.Drawing.Color.Black;
            this.labelStatus2.Location = new System.Drawing.Point(535, 2);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(90, 15);
            this.labelStatus2.TabIndex = 11;
            this.labelStatus2.Text = "Not connected";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.customTextBoxPort);
            this.panel9.Controls.Add(this.customTextBoxIP);
            this.panel9.Controls.Add(this.customTextBoxSlaveId);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.buttonConnect);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.comboSlave);
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel9.Location = new System.Drawing.Point(-4, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(746, 60);
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
            this.customTextBoxPort.Location = new System.Drawing.Point(549, 13);
            this.customTextBoxPort.MaxLength = 5;
            this.customTextBoxPort.Multiline = false;
            this.customTextBoxPort.Name = "customTextBoxPort";
            this.customTextBoxPort.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPort.Size = new System.Drawing.Size(65, 33);
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
            this.customTextBoxIP.Location = new System.Drawing.Point(338, 13);
            this.customTextBoxIP.MaxLength = 15;
            this.customTextBoxIP.Multiline = false;
            this.customTextBoxIP.Name = "customTextBoxIP";
            this.customTextBoxIP.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxIP.Size = new System.Drawing.Size(160, 33);
            this.customTextBoxIP.TabIndex = 45;
            this.customTextBoxIP.Texts = "192.168.88.100";
            this.customTextBoxIP.UnderlinedStyle = true;
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
            this.customTextBoxSlaveId.Location = new System.Drawing.Point(202, 12);
            this.customTextBoxSlaveId.MaxLength = 2;
            this.customTextBoxSlaveId.Multiline = false;
            this.customTextBoxSlaveId.Name = "customTextBoxSlaveId";
            this.customTextBoxSlaveId.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxSlaveId.Size = new System.Drawing.Size(36, 33);
            this.customTextBoxSlaveId.TabIndex = 43;
            this.customTextBoxSlaveId.Texts = "00";
            this.customTextBoxSlaveId.UnderlinedStyle = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonConnect.BorderColor = System.Drawing.Color.Silver;
            this.buttonConnect.BorderRadius = 35;
            this.buttonConnect.BorderSize = 1;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(635, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 37);
            this.buttonConnect.TabIndex = 43;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.TextColor = System.Drawing.Color.White;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelRegsNumber
            // 
            this.panelRegsNumber.Controls.Add(this.customTextBoxDataRegisters);
            this.panelRegsNumber.Controls.Add(this.label12);
            this.panelRegsNumber.Controls.Add(this.btnMinus);
            this.panelRegsNumber.Controls.Add(this.btnPlus);
            this.panelRegsNumber.Location = new System.Drawing.Point(33, 134);
            this.panelRegsNumber.Name = "panelRegsNumber";
            this.panelRegsNumber.Size = new System.Drawing.Size(182, 42);
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
            this.customTextBoxDataRegisters.Location = new System.Drawing.Point(87, 6);
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
            this.panelValues.Location = new System.Drawing.Point(222, 48);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(399, 141);
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
            this.customTextBoxDataValues.Location = new System.Drawing.Point(4, 26);
            this.customTextBoxDataValues.MaxLength = 4;
            this.customTextBoxDataValues.Multiline = true;
            this.customTextBoxDataValues.Name = "customTextBoxDataValues";
            this.customTextBoxDataValues.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxDataValues.Size = new System.Drawing.Size(388, 100);
            this.customTextBoxDataValues.TabIndex = 42;
            this.customTextBoxDataValues.Texts = "";
            this.customTextBoxDataValues.UnderlinedStyle = false;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.White;
            this.panelMessage.Controls.Add(this.customTextBoxDataAddress);
            this.panelMessage.Controls.Add(this.customTextBoxTransactionId);
            this.panelMessage.Controls.Add(this.labelStatus2);
            this.panelMessage.Controls.Add(this.label6);
            this.panelMessage.Controls.Add(this.panelValues);
            this.panelMessage.Controls.Add(this.panelRegsNumber);
            this.panelMessage.Controls.Add(this.comboFunctionCode);
            this.panelMessage.Controls.Add(this.label10);
            this.panelMessage.Controls.Add(this.label2);
            this.panelMessage.Enabled = false;
            this.panelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panelMessage.Location = new System.Drawing.Point(-4, 61);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(628, 187);
            this.panelMessage.TabIndex = 39;
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
            this.customTextBoxDataAddress.Location = new System.Drawing.Point(120, 95);
            this.customTextBoxDataAddress.MaxLength = 4;
            this.customTextBoxDataAddress.Multiline = false;
            this.customTextBoxDataAddress.Name = "customTextBoxDataAddress";
            this.customTextBoxDataAddress.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxDataAddress.Size = new System.Drawing.Size(56, 33);
            this.customTextBoxDataAddress.TabIndex = 43;
            this.customTextBoxDataAddress.Texts = "0097";
            this.customTextBoxDataAddress.UnderlinedStyle = true;
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
            this.customTextBoxTransactionId.Location = new System.Drawing.Point(120, 50);
            this.customTextBoxTransactionId.MaxLength = 4;
            this.customTextBoxTransactionId.Multiline = false;
            this.customTextBoxTransactionId.Name = "customTextBoxTransactionId";
            this.customTextBoxTransactionId.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxTransactionId.Size = new System.Drawing.Size(56, 33);
            this.customTextBoxTransactionId.TabIndex = 42;
            this.customTextBoxTransactionId.Texts = "0001";
            this.customTextBoxTransactionId.UnderlinedStyle = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(-5, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 1);
            this.panel3.TabIndex = 45;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSend.BorderRadius = 35;
            this.buttonSend.BorderSize = 0;
            this.buttonSend.Enabled = false;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(631, 66);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(96, 36);
            this.buttonSend.TabIndex = 44;
            this.buttonSend.Text = "Send";
            this.buttonSend.TextColor = System.Drawing.Color.White;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panelRequest
            // 
            this.panelRequest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRequest.Controls.Add(this.label8);
            this.panelRequest.Controls.Add(this.customTextBoxPrintResponse);
            this.panelRequest.Location = new System.Drawing.Point(0, 66);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(629, 60);
            this.panelRequest.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label8.Location = new System.Drawing.Point(19, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Response";
            // 
            // customTextBoxPrintResponse
            // 
            this.customTextBoxPrintResponse.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPrintResponse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintResponse.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintResponse.BorderSize = 2;
            this.customTextBoxPrintResponse.Enable = true;
            this.customTextBoxPrintResponse.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPrintResponse.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPrintResponse.Location = new System.Drawing.Point(19, 20);
            this.customTextBoxPrintResponse.MaxLength = 1;
            this.customTextBoxPrintResponse.Multiline = false;
            this.customTextBoxPrintResponse.Name = "customTextBoxPrintResponse";
            this.customTextBoxPrintResponse.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPrintResponse.Size = new System.Drawing.Size(595, 33);
            this.customTextBoxPrintResponse.TabIndex = 47;
            this.customTextBoxPrintResponse.Texts = "";
            this.customTextBoxPrintResponse.UnderlinedStyle = true;
            // 
            // panelResponse
            // 
            this.panelResponse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelResponse.Controls.Add(this.label9);
            this.panelResponse.Controls.Add(this.customTextBoxPrintRequest);
            this.panelResponse.Location = new System.Drawing.Point(0, 2);
            this.panelResponse.Name = "panelResponse";
            this.panelResponse.Size = new System.Drawing.Size(629, 60);
            this.panelResponse.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label9.Location = new System.Drawing.Point(18, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "Request";
            // 
            // customTextBoxPrintRequest
            // 
            this.customTextBoxPrintRequest.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPrintRequest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintRequest.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintRequest.BorderSize = 2;
            this.customTextBoxPrintRequest.Enable = true;
            this.customTextBoxPrintRequest.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPrintRequest.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPrintRequest.Location = new System.Drawing.Point(19, 19);
            this.customTextBoxPrintRequest.MaxLength = 1;
            this.customTextBoxPrintRequest.Multiline = false;
            this.customTextBoxPrintRequest.Name = "customTextBoxPrintRequest";
            this.customTextBoxPrintRequest.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPrintRequest.Size = new System.Drawing.Size(595, 33);
            this.customTextBoxPrintRequest.TabIndex = 46;
            this.customTextBoxPrintRequest.Texts = "";
            this.customTextBoxPrintRequest.UnderlinedStyle = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customTextBoxPrintAnalyze);
            this.panel1.Controls.Add(this.panelRequest);
            this.panel1.Controls.Add(this.panelResponse);
            this.panel1.Location = new System.Drawing.Point(-4, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 362);
            this.panel1.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Response analysis";
            // 
            // customTextBoxPrintAnalyze
            // 
            this.customTextBoxPrintAnalyze.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxPrintAnalyze.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintAnalyze.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxPrintAnalyze.BorderSize = 2;
            this.customTextBoxPrintAnalyze.Enable = true;
            this.customTextBoxPrintAnalyze.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxPrintAnalyze.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxPrintAnalyze.Location = new System.Drawing.Point(19, 150);
            this.customTextBoxPrintAnalyze.MaxLength = 1;
            this.customTextBoxPrintAnalyze.Multiline = true;
            this.customTextBoxPrintAnalyze.Name = "customTextBoxPrintAnalyze";
            this.customTextBoxPrintAnalyze.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPrintAnalyze.Size = new System.Drawing.Size(595, 195);
            this.customTextBoxPrintAnalyze.TabIndex = 43;
            this.customTextBoxPrintAnalyze.Texts = "";
            this.customTextBoxPrintAnalyze.UnderlinedStyle = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonHistory.BorderRadius = 35;
            this.buttonHistory.BorderSize = 0;
            this.buttonHistory.Enabled = false;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(631, 151);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(96, 37);
            this.buttonHistory.TabIndex = 46;
            this.buttonHistory.Text = "History";
            this.buttonHistory.TextColor = System.Drawing.Color.White;
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonClear.BorderRadius = 35;
            this.buttonClear.BorderSize = 0;
            this.buttonClear.Enabled = false;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(631, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 37);
            this.buttonClear.TabIndex = 45;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextColor = System.Drawing.Color.White;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(623, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 606);
            this.panel4.TabIndex = 46;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 602);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panel9);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODBUS TCP Client";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelRegsNumber.ResumeLayout(false);
            this.panelRegsNumber.PerformLayout();
            this.panelValues.ResumeLayout(false);
            this.panelValues.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.panelRequest.ResumeLayout(false);
            this.panelRequest.PerformLayout();
            this.panelResponse.ResumeLayout(false);
            this.panelResponse.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Label label3;
        private Label label1;
        private Label labelStatus2;
        private Panel panel9;
        private Panel panelRegsNumber;
        private Panel panelValues;
        private Panel panelMessage;
        private Panel panelRequest;
        private Panel panelResponse;
        private Panel panel1;
        private ToolTip toolTipForm;
        private CustomControls.CustomButton buttonConnect;
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
        private Panel panel3;
        private Label label8;
        private Label label9;
        private Label label5;
        private Panel panel4;
    }
}
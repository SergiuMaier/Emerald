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
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProfinet = new TCPClient.CustomControls.CustomButton();
            this.buttonModbus = new TCPClient.CustomControls.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelProfinetSelected = new System.Windows.Forms.Panel();
            this.panelModbusSelected = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "*NAME*";
            // 
            // buttonProfinet
            // 
            this.buttonProfinet.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfinet.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonProfinet.BorderColor = System.Drawing.Color.White;
            this.buttonProfinet.BorderRadius = 10;
            this.buttonProfinet.BorderSize = 1;
            this.buttonProfinet.FlatAppearance.BorderSize = 0;
            this.buttonProfinet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.buttonProfinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfinet.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProfinet.ForeColor = System.Drawing.Color.White;
            this.buttonProfinet.Location = new System.Drawing.Point(350, 14);
            this.buttonProfinet.Name = "buttonProfinet";
            this.buttonProfinet.Size = new System.Drawing.Size(100, 45);
            this.buttonProfinet.TabIndex = 57;
            this.buttonProfinet.Text = "PROFINET";
            this.buttonProfinet.TextColor = System.Drawing.Color.White;
            this.buttonProfinet.UseVisualStyleBackColor = false;
            this.buttonProfinet.Click += new System.EventHandler(this.buttonProfinet_Click);
            // 
            // buttonModbus
            // 
            this.buttonModbus.BackColor = System.Drawing.Color.Transparent;
            this.buttonModbus.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonModbus.BorderColor = System.Drawing.Color.White;
            this.buttonModbus.BorderRadius = 10;
            this.buttonModbus.BorderSize = 1;
            this.buttonModbus.FlatAppearance.BorderSize = 0;
            this.buttonModbus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.buttonModbus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModbus.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModbus.ForeColor = System.Drawing.Color.White;
            this.buttonModbus.Location = new System.Drawing.Point(227, 14);
            this.buttonModbus.Name = "buttonModbus";
            this.buttonModbus.Size = new System.Drawing.Size(100, 45);
            this.buttonModbus.TabIndex = 56;
            this.buttonModbus.Text = "MODBUS";
            this.buttonModbus.TextColor = System.Drawing.Color.White;
            this.buttonModbus.UseVisualStyleBackColor = false;
            this.buttonModbus.Click += new System.EventHandler(this.buttonModbus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panelProfinetSelected);
            this.panel2.Controls.Add(this.panelModbusSelected);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonModbus);
            this.panel2.Controls.Add(this.buttonProfinet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 72);
            this.panel2.TabIndex = 55;
            // 
            // panelProfinetSelected
            // 
            this.panelProfinetSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProfinetSelected.Location = new System.Drawing.Point(350, 44);
            this.panelProfinetSelected.Name = "panelProfinetSelected";
            this.panelProfinetSelected.Size = new System.Drawing.Size(100, 31);
            this.panelProfinetSelected.TabIndex = 61;
            this.panelProfinetSelected.Visible = false;
            // 
            // panelModbusSelected
            // 
            this.panelModbusSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelModbusSelected.Location = new System.Drawing.Point(227, 44);
            this.panelModbusSelected.Name = "panelModbusSelected";
            this.panelModbusSelected.Size = new System.Drawing.Size(100, 32);
            this.panelModbusSelected.TabIndex = 59;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Location = new System.Drawing.Point(-2, 72);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(850, 730);
            this.panelMenu.TabIndex = 56;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(839, 791);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "*NAME*";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolTip toolTipForm;
        private Panel panel2;
        private CustomControls.CustomButton buttonProfinet;
        private CustomControls.CustomButton buttonModbus;
        private Label label4;
        private Panel panelProfinetSelected;
        private Panel panelModbusSelected;
        private Panel panelMenu;
    }
}
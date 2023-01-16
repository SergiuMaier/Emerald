namespace TCPClient
{
    partial class FormHistory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.toolTipHistory = new System.Windows.Forms.ToolTip(this.components);
            this.customTextBoxHistory = new TCPClient.CustomControls.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new TCPClient.CustomControls.CustomButton();
            this.buttonSave = new TCPClient.CustomControls.CustomButton();
            this.buttonClear = new TCPClient.CustomControls.CustomButton();
            this.customButton1 = new TCPClient.CustomControls.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customTextBoxHistory
            // 
            this.customTextBoxHistory.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxHistory.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.customTextBoxHistory.BorderSize = 2;
            this.customTextBoxHistory.Enable = true;
            this.customTextBoxHistory.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxHistory.ForeColor = System.Drawing.Color.Black;
            this.customTextBoxHistory.Location = new System.Drawing.Point(12, 12);
            this.customTextBoxHistory.MaxLength = 4;
            this.customTextBoxHistory.Multiline = true;
            this.customTextBoxHistory.Name = "customTextBoxHistory";
            this.customTextBoxHistory.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxHistory.SelectionStartIndex = 0;
            this.customTextBoxHistory.Size = new System.Drawing.Size(619, 317);
            this.customTextBoxHistory.TabIndex = 43;
            this.customTextBoxHistory.Texts = "";
            this.customTextBoxHistory.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(-5, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 60);
            this.panel1.TabIndex = 44;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenFile.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonOpenFile.BorderColor = System.Drawing.Color.White;
            this.buttonOpenFile.BorderRadius = 5;
            this.buttonOpenFile.BorderSize = 1;
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile.Location = new System.Drawing.Point(97, 9);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(74, 37);
            this.buttonOpenFile.TabIndex = 49;
            this.buttonOpenFile.Text = "File";
            this.buttonOpenFile.TextColor = System.Drawing.Color.White;
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderColor = System.Drawing.Color.White;
            this.buttonSave.BorderRadius = 5;
            this.buttonSave.BorderSize = 1;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(177, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(74, 37);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextColor = System.Drawing.Color.White;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonClear.BorderColor = System.Drawing.Color.White;
            this.buttonClear.BorderRadius = 5;
            this.buttonClear.BorderSize = 1;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(17, 9);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 37);
            this.buttonClear.TabIndex = 46;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextColor = System.Drawing.Color.White;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(562, 9);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(74, 37);
            this.customButton1.TabIndex = 47;
            this.customButton1.Text = "Close";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // FormHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(643, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customTextBoxHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ToolTip toolTipHistory;
        private CustomControls.CustomTextBox customTextBoxHistory;
        private Panel panel1;
        private CustomControls.CustomButton buttonClear;
        private CustomControls.CustomButton buttonSave;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton buttonOpenFile;
    }
}
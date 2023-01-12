namespace TCPClient
{
    partial class FormExceptionCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExceptionCode));
            this.labelExceptionText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExceptionTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExceptionText
            // 
            this.labelExceptionText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExceptionText.Location = new System.Drawing.Point(10, 45);
            this.labelExceptionText.Name = "labelExceptionText";
            this.labelExceptionText.Size = new System.Drawing.Size(476, 54);
            this.labelExceptionText.TabIndex = 0;
            this.labelExceptionText.Text = "info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelExceptionTitle);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 36);
            this.panel1.TabIndex = 1;
            // 
            // labelExceptionTitle
            // 
            this.labelExceptionTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelExceptionTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExceptionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelExceptionTitle.Location = new System.Drawing.Point(12, 9);
            this.labelExceptionTitle.Name = "labelExceptionTitle";
            this.labelExceptionTitle.Size = new System.Drawing.Size(476, 25);
            this.labelExceptionTitle.TabIndex = 2;
            this.labelExceptionTitle.Text = "title";
            // 
            // FormExceptionCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 108);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelExceptionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormExceptionCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception code in response";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelExceptionText;
        private Panel panel1;
        private Label labelExceptionTitle;
    }
}
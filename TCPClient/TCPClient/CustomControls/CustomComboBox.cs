using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Drawing.Design;

namespace TCPClient.CustomControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class CustomComboBox : UserControl
    {
        //Fields
        private Color backColor = Color.White;
        private Color iconColor = Color.WhiteSmoke;
        private Color listBackColor = Color.White;
        private Color listTextColor = Color.FromArgb(0, 153, 153);
        private Color borderColor = Color.FromArgb(0, 153, 153);
        private int borderSize = 1;

        //Items
        private ComboBox comboList;
        private Label labelText;
        private Button buttonIcon;

        //Properties
        [Category("Custom ComboBox")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                labelText.BackColor = backColor;
                buttonIcon.BackColor = backColor;
            }
        }

        [Category("Custom ComboBox")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                buttonIcon.Invalidate();//Redraw icon
            }
        }

        [Category("Custom ComboBox")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                comboList.BackColor = listBackColor;
            }
        }

        [Category("Custom ComboBox")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                comboList.ForeColor = listTextColor;
            }
        }

        [Category("Custom ComboBox")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }

        [Category("Custom ComboBox")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }

        [Category("Custom ComboBox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                labelText.ForeColor = value;
            }
        }

        [Category("Custom ComboBox")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                labelText.Font = value;
                comboList.Font = value;//Optional
            }
        }

        [Category("Custom ComboBox")]
        public string Texts
        {
            get { return labelText.Text; }
            set { labelText.Text = value; }
        }

        [Category("Custom ComboBox")]
        public ComboBoxStyle DropDownStyle
        {
            get { return comboList.DropDownStyle; }
            set
            {
                if (comboList.DropDownStyle != ComboBoxStyle.Simple)
                    comboList.DropDownStyle = value;
            }
        }

        //-> Data
        [Category("Custom ComboBox - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return comboList.Items; }
        }

        [Category("Custom ComboBox - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return comboList.DataSource; }
            set { comboList.DataSource = value; }
        }

        [Category("Custom ComboBox - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return comboList.AutoCompleteCustomSource; }
            set { comboList.AutoCompleteCustomSource = value; }
        }

        [Category("Custom ComboBox - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return comboList.AutoCompleteSource; }
            set { comboList.AutoCompleteSource = value; }
        }

        [Category("Custom ComboBox - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return comboList.AutoCompleteMode; }
            set { comboList.AutoCompleteMode = value; }
        }

        [Category("Custom ComboBox - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return comboList.SelectedItem; }
            set { comboList.SelectedItem = value; }
        }

        [Category("Custom ComboBox - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return comboList.SelectedIndex; }
            set { comboList.SelectedIndex = value; }
        }

        [Category("Custom ComboBox - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return comboList.DisplayMember; }
            set { comboList.DisplayMember = value; }
        }

        [Category("Custom ComboBox - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return comboList.ValueMember; }
            set { comboList.ValueMember = value; }
        }

        //Events
        public event EventHandler OnSelectedIndexChanged;

        //Constructor
        public CustomComboBox()
        {
            comboList = new ComboBox();
            labelText = new Label();
            buttonIcon = new Button();
            this.SuspendLayout();

            comboList.BackColor = backColor;
            comboList.Font = new Font(this.Font.Name, 10F);
            comboList.ForeColor = listTextColor;
            comboList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            comboList.TextChanged += new EventHandler(ComboBox_TextChanged);

            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = backColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Cursor = Cursors.Hand;
            buttonIcon.Click += new EventHandler(Icon_Click);     //Open dropdown list
            buttonIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon
                                                                  //Label: Text
            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.BackColor = backColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(8, 0, 0, 0);
            labelText.Font = new Font(this.Font.Name, 10F);

            //->Attach label events to user control event
            labelText.Click += new EventHandler(Surface_Click);//Select combo box
            labelText.MouseEnter += new EventHandler(Surface_MouseEnter);
            labelText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            this.Controls.Add(labelText);//2
            this.Controls.Add(buttonIcon);//1
            this.Controls.Add(comboList);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Border Color
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }
        //Methods
        private void AdjustComboBoxDimensions()
        {
            comboList.Width = labelText.Width;
            comboList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - comboList.Width,
                Y = labelText.Bottom - comboList.Height
            };
        }
      
        //Event methods
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            labelText.Text = comboList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((buttonIcon.Width - iconWidht) / 2, (buttonIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            comboList.Select();
            comboList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            //Attach label click to user control click
            this.OnClick(e);
            //Select combo box
            comboList.Select();
            if (comboList.DropDownStyle == ComboBoxStyle.DropDownList)
                comboList.DroppedDown = true; //Open dropdown list
        }
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            labelText.Text = comboList.Text;
        }

        
    }
}

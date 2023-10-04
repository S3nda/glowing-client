using CustomControls.RJControls;

namespace glowing_client
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            linkLabel1 = new LinkLabel();
            siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            CpsCount = new Label();
            trackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            LeftClicker = new System.Windows.Forms.Timer(components);
            jitter = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            Bind = new System.Windows.Forms.Timer(components);
            BindBtn = new Button();
            autoBtn = new RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.FromArgb(25, 25, 25);
            siticonePanel1.Controls.Add(linkLabel1);
            siticonePanel1.Controls.Add(siticoneControlBox3);
            siticonePanel1.Controls.Add(siticoneControlBox2);
            siticonePanel1.Controls.Add(siticoneControlBox1);
            siticonePanel1.Dock = DockStyle.Top;
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Margin = new Padding(4);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(933, 49);
            siticonePanel1.TabIndex = 0;
            siticonePanel1.MouseDown += siticonePanel1_MouseDown;
            siticonePanel1.MouseMove += siticonePanel1_MouseMove;
            siticonePanel1.MouseUp += siticonePanel1_MouseUp;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkGray;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Product Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.DarkGray;
            linkLabel1.Location = new Point(13, 14);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(226, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Glowing client (early access)";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // siticoneControlBox3
            // 
            siticoneControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            siticoneControlBox3.FillColor = Color.FromArgb(25, 25, 25);
            siticoneControlBox3.HoverState.BorderColor = Color.LightGray;
            siticoneControlBox3.HoverState.FillColor = Color.DimGray;
            siticoneControlBox3.IconColor = Color.DarkGray;
            siticoneControlBox3.Location = new Point(779, 0);
            siticoneControlBox3.Margin = new Padding(4);
            siticoneControlBox3.Name = "siticoneControlBox3";
            siticoneControlBox3.Size = new Size(47, 49);
            siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            siticoneControlBox2.FillColor = Color.FromArgb(25, 25, 25);
            siticoneControlBox2.HoverState.BorderColor = Color.LightGray;
            siticoneControlBox2.HoverState.FillColor = Color.DimGray;
            siticoneControlBox2.IconColor = Color.DarkGray;
            siticoneControlBox2.Location = new Point(833, 0);
            siticoneControlBox2.Margin = new Padding(4);
            siticoneControlBox2.Name = "siticoneControlBox2";
            siticoneControlBox2.Size = new Size(47, 49);
            siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.FillColor = Color.FromArgb(25, 25, 25);
            siticoneControlBox1.HoverState.BorderColor = Color.LightGray;
            siticoneControlBox1.HoverState.FillColor = Color.DimGray;
            siticoneControlBox1.IconColor = Color.DarkGray;
            siticoneControlBox1.Location = new Point(887, 0);
            siticoneControlBox1.Margin = new Padding(4);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(47, 49);
            siticoneControlBox1.TabIndex = 0;
            siticoneControlBox1.Click += siticoneControlBox1_Click;
            // 
            // CpsCount
            // 
            CpsCount.AutoSize = true;
            CpsCount.Font = new Font("Product Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CpsCount.ForeColor = Color.DarkGray;
            CpsCount.Location = new Point(651, 306);
            CpsCount.Margin = new Padding(4, 0, 4, 0);
            CpsCount.Name = "CpsCount";
            CpsCount.Size = new Size(51, 26);
            CpsCount.TabIndex = 1;
            CpsCount.Text = "CPS";
            CpsCount.Click += label1_Click;
            // 
            // trackbar
            // 
            trackbar.FillColor = Color.DimGray;
            trackbar.Location = new Point(291, 306);
            trackbar.Margin = new Padding(4);
            trackbar.Maximum = 25;
            trackbar.Minimum = 1;
            trackbar.Name = "trackbar";
            trackbar.Size = new Size(350, 28);
            trackbar.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            trackbar.TabIndex = 2;
            trackbar.ThumbColor = Color.DarkGray;
            trackbar.Value = 5;
            trackbar.Scroll += trackbar_Scroll;
            // 
            // LeftClicker
            // 
            LeftClicker.Enabled = true;
            LeftClicker.Tick += LeftClicker_Tick;
            // 
            // jitter
            // 
            jitter.Enabled = true;
            jitter.Tick += jitter_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(383, 111);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Bind
            // 
            Bind.Enabled = true;
            Bind.Tick += Bind_Tick;
            // 
            // BindBtn
            // 
            BindBtn.FlatStyle = FlatStyle.Flat;
            BindBtn.Font = new Font("Product Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BindBtn.ForeColor = Color.DarkGray;
            BindBtn.Location = new Point(422, 361);
            BindBtn.Margin = new Padding(4);
            BindBtn.Name = "BindBtn";
            BindBtn.Size = new Size(88, 36);
            BindBtn.TabIndex = 11;
            BindBtn.Text = "Bind";
            BindBtn.UseVisualStyleBackColor = true;
            BindBtn.Click += BindBtn_Click;
            BindBtn.KeyUp += BindBtn_KeyUp;
            // 
            // autoBtn
            // 
            autoBtn.BackColor = Color.DarkGray;
            autoBtn.Location = new Point(230, 306);
            autoBtn.MinimumSize = new Size(45, 22);
            autoBtn.Name = "autoBtn";
            autoBtn.OffBackColor = Color.DimGray;
            autoBtn.OffToggleColor = Color.Gainsboro;
            autoBtn.OnBackColor = Color.DarkViolet;
            autoBtn.OnToggleColor = Color.WhiteSmoke;
            autoBtn.Size = new Size(51, 26);
            autoBtn.SolidStyle = false;
            autoBtn.TabIndex = 12;
            autoBtn.UseVisualStyleBackColor = false;
            autoBtn.CheckedChanged += autoBtn_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(933, 554);
            Controls.Add(autoBtn);
            Controls.Add(BindBtn);
            Controls.Add(pictureBox1);
            Controls.Add(trackbar);
            Controls.Add(CpsCount);
            Controls.Add(siticonePanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private LinkLabel linkLabel1;
        private Label CpsCount;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar trackbar;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Timer jitter;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer Bind;
        private Button BindBtn;
        private RJToggleButton autoBtn;
    }
}


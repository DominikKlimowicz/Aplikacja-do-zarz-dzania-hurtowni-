namespace Zarządzanie_Hurtownią
{
    partial class Okno1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno1));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(3, 425);
            button1.Margin = new Padding(3, 3, 3, 300);
            button1.Name = "button1";
            button1.Size = new Size(312, 98);
            button1.TabIndex = 0;
            button1.Text = "Rozpocznij";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MinimumSize = new Size(300, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe Print", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 252);
            label1.TabIndex = 2;
            label1.Text = "KRAINA ŚWIEŻYCH SMAKÓW";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Padding = new Padding(3, 0, 6, 30);
            splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
            splitContainer1.RightToLeft = RightToLeft.Yes;
            splitContainer1.Size = new Size(972, 553);
            splitContainer1.SplitterDistance = 321;
            splitContainer1.TabIndex = 3;
            // 
            // Okno1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(972, 553);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(990, 600);
            Name = "Okno1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private SplitContainer splitContainer1;
    }
}
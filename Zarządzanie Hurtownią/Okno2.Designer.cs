namespace Zarządzanie_Hurtownią
{
    partial class Okno2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno2));
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            button1 = new Button();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Ods = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 30, 3, 3);
            groupBox1.Size = new Size(756, 702);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox3);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 649);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 590);
            button1.Name = "button1";
            button1.Size = new Size(744, 50);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(500, 0);
            listBox3.Name = "listBox3";
            listBox3.SelectionMode = SelectionMode.None;
            listBox3.Size = new Size(250, 584);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(250, 0);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.None;
            listBox2.Size = new Size(250, 584);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.MenuBar;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(250, 584);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 35);
            label1.TabIndex = 1;
            label1.Text = "Magazyny";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 35);
            label2.TabIndex = 2;
            label2.Text = "Klienci";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(553, 9);
            label3.Name = "label3";
            label3.Size = new Size(144, 35);
            label3.TabIndex = 3;
            label3.Text = "Pracownicy";
            // 
            // Ods
            // 
            Ods.Tick += Ods_Tick;
            // 
            // Okno2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(756, 702);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(774, 99999);
            Name = "Okno2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Okno2";
            FormClosing += Okno2_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private ListBox listBox2;
        private ListBox listBox1;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private System.Windows.Forms.Timer Ods;
    }
}
namespace Zarządzanie_Hurtownią
{
    partial class OknoLogowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoLogowania));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            TextLogin = new TextBox();
            label2 = new Label();
            TextHaslo = new TextBox();
            PrzyciskLogowanie = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(TextLogin);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(TextHaslo);
            flowLayoutPanel1.Controls.Add(PrzyciskLogowanie);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(283, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 70, 5, 30);
            flowLayoutPanel1.Size = new Size(260, 426);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 70);
            label1.Margin = new Padding(30, 0, 30, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // TextLogin
            // 
            TextLogin.Location = new Point(8, 121);
            TextLogin.Margin = new Padding(3, 3, 3, 20);
            TextLogin.Name = "TextLogin";
            TextLogin.Size = new Size(242, 27);
            TextLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 168);
            label2.Margin = new Padding(30, 0, 30, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 2;
            label2.Text = "Hasło";
            // 
            // TextHaslo
            // 
            TextHaslo.Location = new Point(8, 219);
            TextHaslo.Margin = new Padding(3, 3, 3, 20);
            TextHaslo.Name = "TextHaslo";
            TextHaslo.PasswordChar = '*';
            TextHaslo.Size = new Size(242, 27);
            TextHaslo.TabIndex = 3;
            TextHaslo.UseSystemPasswordChar = true;
            // 
            // PrzyciskLogowanie
            // 
            PrzyciskLogowanie.DialogResult = DialogResult.OK;
            PrzyciskLogowanie.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PrzyciskLogowanie.Location = new Point(8, 286);
            PrzyciskLogowanie.Margin = new Padding(3, 20, 3, 3);
            PrzyciskLogowanie.Name = "PrzyciskLogowanie";
            PrzyciskLogowanie.Size = new Size(242, 43);
            PrzyciskLogowanie.TabIndex = 4;
            PrzyciskLogowanie.Text = "Zaloguj się";
            PrzyciskLogowanie.UseVisualStyleBackColor = true;
            PrzyciskLogowanie.Click += PrzyciskLogowanie_Click;
            // 
            // OknoLogowania
            // 
            AcceptButton = PrzyciskLogowanie;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(814, 493);
            Name = "OknoLogowania";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OknoLogowania";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox TextLogin;
        private Label label2;
        private TextBox TextHaslo;
        private Button PrzyciskLogowanie;
    }
}
namespace Zarządzanie_Hurtownią
{
    partial class OknoMagazyn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoMagazyn));
            label1 = new Label();
            panel1 = new Panel();
            Zapisz = new Button();
            PanelEdycja = new FlowLayoutPanel();
            PanelProdukty = new FlowLayoutPanel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 58);
            label1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 63);
            panel1.TabIndex = 3;
            // 
            // Zapisz
            // 
            Zapisz.Anchor = AnchorStyles.Bottom;
            Zapisz.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Zapisz.Location = new Point(12, 440);
            Zapisz.Name = "Zapisz";
            Zapisz.Size = new Size(342, 44);
            Zapisz.TabIndex = 4;
            Zapisz.Text = "Zapisz zmiany";
            Zapisz.UseVisualStyleBackColor = true;
            Zapisz.Click += Klikniecie;
            // 
            // PanelEdycja
            // 
            PanelEdycja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelEdycja.FlowDirection = FlowDirection.TopDown;
            PanelEdycja.Location = new Point(542, 69);
            PanelEdycja.Name = "PanelEdycja";
            PanelEdycja.Size = new Size(432, 365);
            PanelEdycja.TabIndex = 6;
            // 
            // PanelProdukty
            // 
            PanelProdukty.FlowDirection = FlowDirection.TopDown;
            PanelProdukty.Location = new Point(0, 69);
            PanelProdukty.Name = "PanelProdukty";
            PanelProdukty.Size = new Size(536, 365);
            PanelProdukty.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(620, 440);
            button1.Name = "button1";
            button1.Size = new Size(342, 44);
            button1.TabIndex = 8;
            button1.Text = "Prześlij dane do bazy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PrzesylDoBazy;
            // 
            // OknoMagazyn
            // 
            AcceptButton = Zapisz;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 496);
            Controls.Add(button1);
            Controls.Add(PanelProdukty);
            Controls.Add(PanelEdycja);
            Controls.Add(Zapisz);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OknoMagazyn";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OknoMagazyn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button Zapisz;
        private FlowLayoutPanel PanelEdycja;
        private FlowLayoutPanel PanelProdukty;
        private Button button1;
    }
}
namespace Zarządzanie_Hurtownią
{
    partial class OknoDodajProdukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoDodajProdukt));
            label1 = new Label();
            NazwaTekst = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            CenaTekst = new TextBox();
            PrzyciskZapisz = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            KategoriaCombo = new ComboBox();
            label4 = new Label();
            IloscTekst = new NumericTextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 20);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 35);
            label1.TabIndex = 0;
            label1.Text = "Nazwa";
            // 
            // NazwaTekst
            // 
            NazwaTekst.Location = new Point(23, 78);
            NazwaTekst.Name = "NazwaTekst";
            NazwaTekst.Size = new Size(212, 27);
            NazwaTekst.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NazwaTekst);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(CenaTekst);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(261, 211);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 108);
            label3.Margin = new Padding(3, 0, 3, 30);
            label3.Name = "label3";
            label3.Size = new Size(223, 35);
            label3.TabIndex = 0;
            label3.Text = "Cena za jednostkę";
            // 
            // CenaTekst
            // 
            CenaTekst.Location = new Point(23, 176);
            CenaTekst.Name = "CenaTekst";
            CenaTekst.Size = new Size(223, 27);
            CenaTekst.TabIndex = 1;
            CenaTekst.KeyPress += CenaTekst_KeyPress;
            // 
            // PrzyciskZapisz
            // 
            PrzyciskZapisz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrzyciskZapisz.Location = new Point(165, 224);
            PrzyciskZapisz.Margin = new Padding(3, 20, 3, 3);
            PrzyciskZapisz.Name = "PrzyciskZapisz";
            PrzyciskZapisz.Size = new Size(223, 29);
            PrzyciskZapisz.TabIndex = 2;
            PrzyciskZapisz.Text = "Zapisz zmiany";
            PrzyciskZapisz.UseVisualStyleBackColor = true;
            PrzyciskZapisz.Click += PrzyciskZapisz_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(KategoriaCombo);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(IloscTekst);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(279, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(20, 20, 0, 0);
            flowLayoutPanel2.Size = new Size(261, 211);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 20);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(127, 35);
            label2.TabIndex = 0;
            label2.Text = "Kategoria";
            // 
            // KategoriaCombo
            // 
            KategoriaCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            KategoriaCombo.FlatStyle = FlatStyle.Popup;
            KategoriaCombo.FormattingEnabled = true;
            KategoriaCombo.Items.AddRange(new object[] { "Owoc", "Warzywo", "Produkt mleczny", "Słodycz", "Produkt zbożowy", "Przyprawa", "Ryba" });
            KategoriaCombo.Location = new Point(23, 78);
            KategoriaCombo.Name = "KategoriaCombo";
            KategoriaCombo.Size = new Size(218, 28);
            KategoriaCombo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 109);
            label4.Margin = new Padding(3, 0, 3, 30);
            label4.Name = "label4";
            label4.Size = new Size(67, 35);
            label4.TabIndex = 0;
            label4.Text = "Ilość";
            // 
            // IloscTekst
            // 
            IloscTekst.Location = new Point(23, 177);
            IloscTekst.Name = "IloscTekst";
            IloscTekst.Size = new Size(220, 27);
            IloscTekst.TabIndex = 1;
            // 
            // OknoDodajProdukt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 265);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(PrzyciskZapisz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OknoDodajProdukt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OknoDodajProdukt";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox NazwaTekst;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private ComboBox KategoriaCombo;
        private Label label3;
        private TextBox CenaTekst;
        private Label label4;
        private NumericTextBox IloscTekst;
        private Button PrzyciskZapisz;
    }
}
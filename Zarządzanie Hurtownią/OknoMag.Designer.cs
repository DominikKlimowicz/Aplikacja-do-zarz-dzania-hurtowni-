namespace Zarządzanie_Hurtownią
{
    partial class OknoMag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoMag));
            ListaProduktow = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            LabelIlosc = new Label();
            label3 = new Label();
            LabelCena = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            NazwaProduktu = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            NowaIlosc = new TextBox();
            label4 = new Label();
            NowaCena = new TextBox();
            CheckEdycja = new CheckBox();
            PrzyciskZapisz = new Button();
            PrzyciskDodaj = new Button();
            PrzyciskUsun = new Button();
            Odswiezenie = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // ListaProduktow
            // 
            ListaProduktow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListaProduktow.FormattingEnabled = true;
            ListaProduktow.ItemHeight = 20;
            ListaProduktow.Location = new Point(12, 54);
            ListaProduktow.Name = "ListaProduktow";
            ListaProduktow.Size = new Size(213, 284);
            ListaProduktow.TabIndex = 0;
            ListaProduktow.MouseClick += ListaProduktow_SelectedIndexChanged;
            ListaProduktow.SelectedIndexChanged += ListaProduktow_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(LabelIlosc);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(LabelCena);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(231, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(251, 264);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Ilość";
            // 
            // LabelIlosc
            // 
            LabelIlosc.AutoSize = true;
            LabelIlosc.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelIlosc.Location = new Point(13, 71);
            LabelIlosc.Margin = new Padding(3, 0, 3, 20);
            LabelIlosc.Name = "LabelIlosc";
            LabelIlosc.Size = new Size(0, 28);
            LabelIlosc.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 119);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(156, 82);
            label3.TabIndex = 2;
            label3.Text = "Cena za jednostkę";
            // 
            // LabelCena
            // 
            LabelCena.AutoSize = true;
            LabelCena.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCena.Location = new Point(13, 221);
            LabelCena.Name = "LabelCena";
            LabelCena.Size = new Size(0, 28);
            LabelCena.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(NazwaProduktu);
            flowLayoutPanel2.Location = new Point(231, 18);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(506, 50);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // NazwaProduktu
            // 
            NazwaProduktu.AutoSize = true;
            NazwaProduktu.Dock = DockStyle.Fill;
            NazwaProduktu.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            NazwaProduktu.Location = new Point(3, 0);
            NazwaProduktu.Name = "NazwaProduktu";
            NazwaProduktu.Size = new Size(275, 45);
            NazwaProduktu.TabIndex = 0;
            NazwaProduktu.Text = "Nazwa Produktu";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(NowaIlosc);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(NowaCena);
            flowLayoutPanel3.Enabled = false;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(487, 104);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(253, 234);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 17.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 36);
            label2.TabIndex = 0;
            label2.Text = "Nowa ilość";
            // 
            // NowaIlosc
            // 
            NowaIlosc.Location = new Point(3, 39);
            NowaIlosc.Name = "NowaIlosc";
            NowaIlosc.Size = new Size(245, 27);
            NowaIlosc.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 17.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 89);
            label4.Margin = new Padding(3, 20, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 36);
            label4.TabIndex = 2;
            label4.Text = "Nowa cena";
            // 
            // NowaCena
            // 
            NowaCena.Location = new Point(3, 128);
            NowaCena.Name = "NowaCena";
            NowaCena.Size = new Size(245, 27);
            NowaCena.TabIndex = 3;
            NowaCena.KeyPress += NowaCena_KeyPress;
            // 
            // CheckEdycja
            // 
            CheckEdycja.AutoSize = true;
            CheckEdycja.Location = new Point(487, 74);
            CheckEdycja.Name = "CheckEdycja";
            CheckEdycja.Size = new Size(72, 24);
            CheckEdycja.TabIndex = 4;
            CheckEdycja.Text = "Edytuj";
            CheckEdycja.UseVisualStyleBackColor = true;
            CheckEdycja.CheckedChanged += CheckEdycja_CheckedChanged;
            // 
            // PrzyciskZapisz
            // 
            PrzyciskZapisz.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PrzyciskZapisz.Enabled = false;
            PrzyciskZapisz.Location = new Point(487, 344);
            PrzyciskZapisz.Name = "PrzyciskZapisz";
            PrzyciskZapisz.Size = new Size(249, 40);
            PrzyciskZapisz.TabIndex = 5;
            PrzyciskZapisz.Text = "Zapisz zmiany";
            PrzyciskZapisz.UseVisualStyleBackColor = true;
            PrzyciskZapisz.Click += PrzyciskZapisz_Click;
            // 
            // PrzyciskDodaj
            // 
            PrzyciskDodaj.Location = new Point(121, 11);
            PrzyciskDodaj.Name = "PrzyciskDodaj";
            PrzyciskDodaj.Size = new Size(103, 30);
            PrzyciskDodaj.TabIndex = 6;
            PrzyciskDodaj.Text = "Dodaj";
            PrzyciskDodaj.UseVisualStyleBackColor = true;
            PrzyciskDodaj.Click += button1_Click;
            // 
            // PrzyciskUsun
            // 
            PrzyciskUsun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PrzyciskUsun.Location = new Point(12, 344);
            PrzyciskUsun.Name = "PrzyciskUsun";
            PrzyciskUsun.Size = new Size(213, 40);
            PrzyciskUsun.TabIndex = 8;
            PrzyciskUsun.Text = "Usuń produkt";
            PrzyciskUsun.UseVisualStyleBackColor = true;
            PrzyciskUsun.Click += PrzyciskUsun_Click;
            // 
            // Odswiezenie
            // 
            Odswiezenie.Location = new Point(12, 12);
            Odswiezenie.Name = "Odswiezenie";
            Odswiezenie.Size = new Size(103, 29);
            Odswiezenie.TabIndex = 9;
            Odswiezenie.Text = "Odśwież";
            Odswiezenie.UseVisualStyleBackColor = true;
            Odswiezenie.Click += Refresh_Click;
            // 
            // OknoMag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 395);
            Controls.Add(Odswiezenie);
            Controls.Add(PrzyciskUsun);
            Controls.Add(PrzyciskDodaj);
            Controls.Add(PrzyciskZapisz);
            Controls.Add(CheckEdycja);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ListaProduktow);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OknoMag";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OknoMag";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListaProduktow;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label NazwaProduktu;
        private Label label1;
        private Label LabelIlosc;
        private Label label3;
        private Label LabelCena;
        private CheckBox CheckEdycja;
        private Button PrzyciskZapisz;
        private Label label2;
        private TextBox NowaIlosc;
        private Button PrzyciskDodaj;
        private Button PrzyciskUsun;
        private Button Odswiezenie;
        private Label label4;
        private TextBox NowaCena;
    }
}
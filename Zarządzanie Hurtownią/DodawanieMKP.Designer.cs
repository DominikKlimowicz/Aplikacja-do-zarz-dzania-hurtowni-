namespace Zarządzanie_Hurtownią
{
    partial class DodawanieMKP
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
            MagSpr = new RadioButton();
            PracSpr = new RadioButton();
            KlientSpr = new RadioButton();
            PanelMag = new FlowLayoutPanel();
            NazwaMag = new TextBox();
            MiastoMag = new TextBox();
            UlicaMag = new TextBox();
            NrBudynkuMag = new TextBox();
            PanelPrac = new FlowLayoutPanel();
            ImiePrac = new TextBox();
            NazwiskoPrac = new TextBox();
            MiastoPrac = new TextBox();
            UlicaPrac = new TextBox();
            NrBudPrac = new TextBox();
            NrTelPrac = new TextBox();
            PanelKlient = new FlowLayoutPanel();
            NazwaKlient = new TextBox();
            ImieKlient = new TextBox();
            NazwiskoKlient = new TextBox();
            MiastoKlient = new TextBox();
            UlicaKlient = new TextBox();
            NrBudKlient = new TextBox();
            NrTelKlient = new TextBox();
            EmailKlient = new TextBox();
            FaxKlient = new TextBox();
            DodajMag = new Button();
            DodajKlient = new Button();
            DodajPrac = new Button();
            PanelMag.SuspendLayout();
            PanelPrac.SuspendLayout();
            PanelKlient.SuspendLayout();
            SuspendLayout();
            // 
            // MagSpr
            // 
            MagSpr.AutoSize = true;
            MagSpr.Location = new Point(111, 12);
            MagSpr.Name = "MagSpr";
            MagSpr.Size = new Size(90, 24);
            MagSpr.TabIndex = 0;
            MagSpr.TabStop = true;
            MagSpr.Text = "Magazyn";
            MagSpr.UseVisualStyleBackColor = true;
            MagSpr.CheckedChanged += MagSpr_CheckedChanged;
            // 
            // PracSpr
            // 
            PracSpr.AutoSize = true;
            PracSpr.Location = new Point(409, 12);
            PracSpr.Name = "PracSpr";
            PracSpr.Size = new Size(97, 24);
            PracSpr.TabIndex = 1;
            PracSpr.TabStop = true;
            PracSpr.Text = "Pracownik";
            PracSpr.UseVisualStyleBackColor = true;
            PracSpr.CheckedChanged += PracSpr_CheckedChanged;
            // 
            // KlientSpr
            // 
            KlientSpr.AutoSize = true;
            KlientSpr.Location = new Point(698, 12);
            KlientSpr.Name = "KlientSpr";
            KlientSpr.Size = new Size(68, 24);
            KlientSpr.TabIndex = 2;
            KlientSpr.TabStop = true;
            KlientSpr.Text = "Klient";
            KlientSpr.UseVisualStyleBackColor = true;
            KlientSpr.CheckedChanged += KlientSpr_CheckedChanged;
            // 
            // PanelMag
            // 
            PanelMag.Controls.Add(NazwaMag);
            PanelMag.Controls.Add(MiastoMag);
            PanelMag.Controls.Add(UlicaMag);
            PanelMag.Controls.Add(NrBudynkuMag);
            PanelMag.Enabled = false;
            PanelMag.FlowDirection = FlowDirection.TopDown;
            PanelMag.Location = new Point(12, 42);
            PanelMag.Name = "PanelMag";
            PanelMag.Padding = new Padding(10, 10, 0, 0);
            PanelMag.Size = new Size(293, 219);
            PanelMag.TabIndex = 3;
            // 
            // NazwaMag
            // 
            NazwaMag.Location = new Point(13, 13);
            NazwaMag.Margin = new Padding(3, 3, 3, 20);
            NazwaMag.Name = "NazwaMag";
            NazwaMag.PlaceholderText = "Nazwa";
            NazwaMag.Size = new Size(265, 27);
            NazwaMag.TabIndex = 0;
            // 
            // MiastoMag
            // 
            MiastoMag.Location = new Point(13, 63);
            MiastoMag.Margin = new Padding(3, 3, 3, 20);
            MiastoMag.Name = "MiastoMag";
            MiastoMag.PlaceholderText = "Miasto";
            MiastoMag.Size = new Size(265, 27);
            MiastoMag.TabIndex = 1;
            // 
            // UlicaMag
            // 
            UlicaMag.Location = new Point(13, 113);
            UlicaMag.Margin = new Padding(3, 3, 3, 20);
            UlicaMag.Name = "UlicaMag";
            UlicaMag.PlaceholderText = "Ulica";
            UlicaMag.Size = new Size(265, 27);
            UlicaMag.TabIndex = 2;
            // 
            // NrBudynkuMag
            // 
            NrBudynkuMag.Location = new Point(13, 163);
            NrBudynkuMag.Margin = new Padding(3, 3, 3, 20);
            NrBudynkuMag.Name = "NrBudynkuMag";
            NrBudynkuMag.PlaceholderText = "Numer Budynku";
            NrBudynkuMag.Size = new Size(265, 27);
            NrBudynkuMag.TabIndex = 3;
            // 
            // PanelPrac
            // 
            PanelPrac.Controls.Add(ImiePrac);
            PanelPrac.Controls.Add(NazwiskoPrac);
            PanelPrac.Controls.Add(MiastoPrac);
            PanelPrac.Controls.Add(UlicaPrac);
            PanelPrac.Controls.Add(NrBudPrac);
            PanelPrac.Controls.Add(NrTelPrac);
            PanelPrac.Enabled = false;
            PanelPrac.Location = new Point(311, 42);
            PanelPrac.Name = "PanelPrac";
            PanelPrac.Padding = new Padding(10, 10, 0, 0);
            PanelPrac.Size = new Size(292, 317);
            PanelPrac.TabIndex = 4;
            // 
            // ImiePrac
            // 
            ImiePrac.Location = new Point(13, 13);
            ImiePrac.Margin = new Padding(3, 3, 3, 20);
            ImiePrac.Name = "ImiePrac";
            ImiePrac.PlaceholderText = "Imię";
            ImiePrac.Size = new Size(265, 27);
            ImiePrac.TabIndex = 1;
            // 
            // NazwiskoPrac
            // 
            NazwiskoPrac.Location = new Point(13, 63);
            NazwiskoPrac.Margin = new Padding(3, 3, 3, 20);
            NazwiskoPrac.Name = "NazwiskoPrac";
            NazwiskoPrac.PlaceholderText = "Nazwisko";
            NazwiskoPrac.Size = new Size(265, 27);
            NazwiskoPrac.TabIndex = 2;
            // 
            // MiastoPrac
            // 
            MiastoPrac.Location = new Point(13, 113);
            MiastoPrac.Margin = new Padding(3, 3, 3, 20);
            MiastoPrac.Name = "MiastoPrac";
            MiastoPrac.PlaceholderText = "Miasto";
            MiastoPrac.Size = new Size(265, 27);
            MiastoPrac.TabIndex = 3;
            // 
            // UlicaPrac
            // 
            UlicaPrac.Location = new Point(13, 163);
            UlicaPrac.Margin = new Padding(3, 3, 3, 20);
            UlicaPrac.Name = "UlicaPrac";
            UlicaPrac.PlaceholderText = "Ulica";
            UlicaPrac.Size = new Size(265, 27);
            UlicaPrac.TabIndex = 4;
            // 
            // NrBudPrac
            // 
            NrBudPrac.Location = new Point(13, 213);
            NrBudPrac.Margin = new Padding(3, 3, 3, 20);
            NrBudPrac.Name = "NrBudPrac";
            NrBudPrac.PlaceholderText = "Numer Budyunku";
            NrBudPrac.Size = new Size(265, 27);
            NrBudPrac.TabIndex = 5;
            // 
            // NrTelPrac
            // 
            NrTelPrac.Location = new Point(13, 263);
            NrTelPrac.Margin = new Padding(3, 3, 3, 20);
            NrTelPrac.Name = "NrTelPrac";
            NrTelPrac.PlaceholderText = "Nr Telefonu";
            NrTelPrac.Size = new Size(265, 27);
            NrTelPrac.TabIndex = 6;
            // 
            // PanelKlient
            // 
            PanelKlient.Controls.Add(NazwaKlient);
            PanelKlient.Controls.Add(ImieKlient);
            PanelKlient.Controls.Add(NazwiskoKlient);
            PanelKlient.Controls.Add(MiastoKlient);
            PanelKlient.Controls.Add(UlicaKlient);
            PanelKlient.Controls.Add(NrBudKlient);
            PanelKlient.Controls.Add(NrTelKlient);
            PanelKlient.Controls.Add(EmailKlient);
            PanelKlient.Controls.Add(FaxKlient);
            PanelKlient.Enabled = false;
            PanelKlient.Location = new Point(609, 42);
            PanelKlient.Name = "PanelKlient";
            PanelKlient.Padding = new Padding(10, 10, 0, 0);
            PanelKlient.Size = new Size(293, 459);
            PanelKlient.TabIndex = 6;
            // 
            // NazwaKlient
            // 
            NazwaKlient.Location = new Point(13, 13);
            NazwaKlient.Margin = new Padding(3, 3, 3, 20);
            NazwaKlient.Name = "NazwaKlient";
            NazwaKlient.PlaceholderText = "Nazwa Firmy";
            NazwaKlient.Size = new Size(265, 27);
            NazwaKlient.TabIndex = 9;
            // 
            // ImieKlient
            // 
            ImieKlient.Location = new Point(13, 63);
            ImieKlient.Margin = new Padding(3, 3, 3, 20);
            ImieKlient.Name = "ImieKlient";
            ImieKlient.PlaceholderText = "Imię";
            ImieKlient.Size = new Size(265, 27);
            ImieKlient.TabIndex = 1;
            // 
            // NazwiskoKlient
            // 
            NazwiskoKlient.Location = new Point(13, 113);
            NazwiskoKlient.Margin = new Padding(3, 3, 3, 20);
            NazwiskoKlient.Name = "NazwiskoKlient";
            NazwiskoKlient.PlaceholderText = "Nazwisko";
            NazwiskoKlient.Size = new Size(265, 27);
            NazwiskoKlient.TabIndex = 2;
            // 
            // MiastoKlient
            // 
            MiastoKlient.Location = new Point(13, 163);
            MiastoKlient.Margin = new Padding(3, 3, 3, 20);
            MiastoKlient.Name = "MiastoKlient";
            MiastoKlient.PlaceholderText = "Miasto";
            MiastoKlient.Size = new Size(265, 27);
            MiastoKlient.TabIndex = 3;
            // 
            // UlicaKlient
            // 
            UlicaKlient.Location = new Point(13, 213);
            UlicaKlient.Margin = new Padding(3, 3, 3, 20);
            UlicaKlient.Name = "UlicaKlient";
            UlicaKlient.PlaceholderText = "Ulica";
            UlicaKlient.Size = new Size(265, 27);
            UlicaKlient.TabIndex = 4;
            // 
            // NrBudKlient
            // 
            NrBudKlient.Location = new Point(13, 263);
            NrBudKlient.Margin = new Padding(3, 3, 3, 20);
            NrBudKlient.Name = "NrBudKlient";
            NrBudKlient.PlaceholderText = "Numer Budyunku";
            NrBudKlient.Size = new Size(265, 27);
            NrBudKlient.TabIndex = 5;
            // 
            // NrTelKlient
            // 
            NrTelKlient.Location = new Point(13, 313);
            NrTelKlient.Margin = new Padding(3, 3, 3, 20);
            NrTelKlient.Name = "NrTelKlient";
            NrTelKlient.PlaceholderText = "Nr Telefonu";
            NrTelKlient.Size = new Size(265, 27);
            NrTelKlient.TabIndex = 6;
            // 
            // EmailKlient
            // 
            EmailKlient.Location = new Point(13, 363);
            EmailKlient.Margin = new Padding(3, 3, 3, 20);
            EmailKlient.Name = "EmailKlient";
            EmailKlient.PlaceholderText = "Email";
            EmailKlient.Size = new Size(265, 27);
            EmailKlient.TabIndex = 7;
            // 
            // FaxKlient
            // 
            FaxKlient.Location = new Point(13, 413);
            FaxKlient.Margin = new Padding(3, 3, 3, 20);
            FaxKlient.Name = "FaxKlient";
            FaxKlient.PlaceholderText = "FAX";
            FaxKlient.Size = new Size(265, 27);
            FaxKlient.TabIndex = 8;
            // 
            // DodajMag
            // 
            DodajMag.Enabled = false;
            DodajMag.Location = new Point(12, 507);
            DodajMag.Name = "DodajMag";
            DodajMag.Size = new Size(293, 59);
            DodajMag.TabIndex = 7;
            DodajMag.Text = "Dodaj Magazyn";
            DodajMag.UseVisualStyleBackColor = true;
            DodajMag.Click += DodajMag_Click;
            // 
            // DodajKlient
            // 
            DodajKlient.Enabled = false;
            DodajKlient.Location = new Point(609, 507);
            DodajKlient.Name = "DodajKlient";
            DodajKlient.Size = new Size(292, 59);
            DodajKlient.TabIndex = 8;
            DodajKlient.Text = "Dodaj Klienta";
            DodajKlient.UseVisualStyleBackColor = true;
            DodajKlient.Click += DodajKlient_Click;
            // 
            // DodajPrac
            // 
            DodajPrac.Enabled = false;
            DodajPrac.Location = new Point(311, 507);
            DodajPrac.Name = "DodajPrac";
            DodajPrac.Size = new Size(293, 59);
            DodajPrac.TabIndex = 9;
            DodajPrac.Text = "Dodaj Pracownika";
            DodajPrac.UseVisualStyleBackColor = true;
            DodajPrac.Click += DodajPrac_Click;
            // 
            // DodawanieMKP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 576);
            Controls.Add(DodajPrac);
            Controls.Add(DodajKlient);
            Controls.Add(DodajMag);
            Controls.Add(PanelKlient);
            Controls.Add(PanelPrac);
            Controls.Add(PanelMag);
            Controls.Add(KlientSpr);
            Controls.Add(PracSpr);
            Controls.Add(MagSpr);
            Name = "DodawanieMKP";
            Text = "DodawanieMKP";
            PanelMag.ResumeLayout(false);
            PanelMag.PerformLayout();
            PanelPrac.ResumeLayout(false);
            PanelPrac.PerformLayout();
            PanelKlient.ResumeLayout(false);
            PanelKlient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton MagSpr;
        private RadioButton PracSpr;
        private RadioButton KlientSpr;
        private FlowLayoutPanel PanelMag;
        private FlowLayoutPanel PanelPrac;
        private TextBox NazwaMag;
        private TextBox MiastoMag;
        private TextBox UlicaMag;
        private TextBox NrBudynkuMag;
        private TextBox ImiePrac;
        private TextBox NazwiskoPrac;
        private TextBox MiastoPrac;
        private TextBox UlicaPrac;
        private TextBox NrBudPrac;
        private TextBox NrTelPrac;
        private FlowLayoutPanel PanelKlient;
        private TextBox ImieKlient;
        private TextBox NazwiskoKlient;
        private TextBox MiastoKlient;
        private TextBox UlicaKlient;
        private TextBox NrBudKlient;
        private TextBox NrTelKlient;
        private TextBox EmailKlient;
        private TextBox FaxKlient;
        private TextBox NazwaKlient;
        private Button DodajMag;
        private Button DodajKlient;
        private Button DodajPrac;
    }
}
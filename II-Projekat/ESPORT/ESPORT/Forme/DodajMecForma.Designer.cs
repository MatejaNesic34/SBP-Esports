namespace ESPORT.Forme
{
    partial class DodajMecForma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTakmicenje = new Label();
            cmbTakmicenje = new ComboBox();
            lblRedniBroj = new Label();
            numRedniBroj = new NumericUpDown();
            lblDatumVremePocetka = new Label();
            dtpDatumVremePocetka = new DateTimePicker();
            lblFormatMeca = new Label();
            txtFormatMeca = new TextBox();
            lblBrojMapa = new Label();
            numBrojMapa = new NumericUpDown();
            lblRezultat = new Label();
            txtRezultat = new TextBox();
            lblTrajanje = new Label();
            txtTrajanje = new TextBox();
            lblLokacijaIgranja = new Label();
            txtLokacijaIgranja = new TextBox();
            lblSudije = new Label();
            txtSudije = new TextBox();
            lblStatusMeca = new Label();
            dodajMecBtn = new Button();
            odustaniBtn = new Button();
            cmbStatusMeca = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numRedniBroj).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBrojMapa).BeginInit();
            SuspendLayout();
            // 
            // lblTakmicenje
            // 
            lblTakmicenje.AutoSize = true;
            lblTakmicenje.Location = new Point(49, 68);
            lblTakmicenje.Margin = new Padding(7, 0, 7, 0);
            lblTakmicenje.Name = "lblTakmicenje";
            lblTakmicenje.Size = new Size(171, 41);
            lblTakmicenje.TabIndex = 0;
            lblTakmicenje.Text = "Takmičenje:";
            // 
            // cmbTakmicenje
            // 
            cmbTakmicenje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTakmicenje.FormattingEnabled = true;
            cmbTakmicenje.Location = new Point(437, 55);
            cmbTakmicenje.Margin = new Padding(7, 8, 7, 8);
            cmbTakmicenje.Name = "cmbTakmicenje";
            cmbTakmicenje.Size = new Size(674, 49);
            cmbTakmicenje.TabIndex = 1;
            // 
            // lblRedniBroj
            // 
            lblRedniBroj.AutoSize = true;
            lblRedniBroj.Location = new Point(49, 178);
            lblRedniBroj.Margin = new Padding(7, 0, 7, 0);
            lblRedniBroj.Name = "lblRedniBroj";
            lblRedniBroj.Size = new Size(161, 41);
            lblRedniBroj.TabIndex = 2;
            lblRedniBroj.Text = "Redni broj:";
            // 
            // numRedniBroj
            // 
            numRedniBroj.Location = new Point(437, 164);
            numRedniBroj.Margin = new Padding(7, 8, 7, 8);
            numRedniBroj.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRedniBroj.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRedniBroj.Name = "numRedniBroj";
            numRedniBroj.Size = new Size(680, 47);
            numRedniBroj.TabIndex = 3;
            numRedniBroj.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDatumVremePocetka
            // 
            lblDatumVremePocetka.AutoSize = true;
            lblDatumVremePocetka.Location = new Point(49, 287);
            lblDatumVremePocetka.Margin = new Padding(7, 0, 7, 0);
            lblDatumVremePocetka.Name = "lblDatumVremePocetka";
            lblDatumVremePocetka.Size = new Size(219, 41);
            lblDatumVremePocetka.TabIndex = 4;
            lblDatumVremePocetka.Text = "Datum i vreme:";
            // 
            // dtpDatumVremePocetka
            // 
            dtpDatumVremePocetka.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDatumVremePocetka.Format = DateTimePickerFormat.Custom;
            dtpDatumVremePocetka.Location = new Point(437, 273);
            dtpDatumVremePocetka.Margin = new Padding(7, 8, 7, 8);
            dtpDatumVremePocetka.Name = "dtpDatumVremePocetka";
            dtpDatumVremePocetka.Size = new Size(674, 47);
            dtpDatumVremePocetka.TabIndex = 5;
            // 
            // lblFormatMeca
            // 
            lblFormatMeca.AutoSize = true;
            lblFormatMeca.Location = new Point(49, 396);
            lblFormatMeca.Margin = new Padding(7, 0, 7, 0);
            lblFormatMeca.Name = "lblFormatMeca";
            lblFormatMeca.Size = new Size(198, 41);
            lblFormatMeca.TabIndex = 6;
            lblFormatMeca.Text = "Format meča:";
            // 
            // txtFormatMeca
            // 
            txtFormatMeca.Location = new Point(437, 383);
            txtFormatMeca.Margin = new Padding(7, 8, 7, 8);
            txtFormatMeca.Name = "txtFormatMeca";
            txtFormatMeca.Size = new Size(674, 47);
            txtFormatMeca.TabIndex = 7;
            // 
            // lblBrojMapa
            // 
            lblBrojMapa.AutoSize = true;
            lblBrojMapa.Location = new Point(49, 506);
            lblBrojMapa.Margin = new Padding(7, 0, 7, 0);
            lblBrojMapa.Name = "lblBrojMapa";
            lblBrojMapa.Size = new Size(159, 41);
            lblBrojMapa.TabIndex = 8;
            lblBrojMapa.Text = "Broj mapa:";
            // 
            // numBrojMapa
            // 
            numBrojMapa.Location = new Point(437, 492);
            numBrojMapa.Margin = new Padding(7, 8, 7, 8);
            numBrojMapa.Name = "numBrojMapa";
            numBrojMapa.Size = new Size(680, 47);
            numBrojMapa.TabIndex = 9;
            // 
            // lblRezultat
            // 
            lblRezultat.AutoSize = true;
            lblRezultat.Location = new Point(49, 615);
            lblRezultat.Margin = new Padding(7, 0, 7, 0);
            lblRezultat.Name = "lblRezultat";
            lblRezultat.Size = new Size(131, 41);
            lblRezultat.TabIndex = 10;
            lblRezultat.Text = "Rezultat:";
            // 
            // txtRezultat
            // 
            txtRezultat.Location = new Point(437, 601);
            txtRezultat.Margin = new Padding(7, 8, 7, 8);
            txtRezultat.Name = "txtRezultat";
            txtRezultat.Size = new Size(674, 47);
            txtRezultat.TabIndex = 11;
            // 
            // lblTrajanje
            // 
            lblTrajanje.AutoSize = true;
            lblTrajanje.Location = new Point(49, 724);
            lblTrajanje.Margin = new Padding(7, 0, 7, 0);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(125, 41);
            lblTrajanje.TabIndex = 12;
            lblTrajanje.Text = "Trajanje:";
            // 
            // txtTrajanje
            // 
            txtTrajanje.Location = new Point(437, 711);
            txtTrajanje.Margin = new Padding(7, 8, 7, 8);
            txtTrajanje.Name = "txtTrajanje";
            txtTrajanje.Size = new Size(674, 47);
            txtTrajanje.TabIndex = 13;
            // 
            // lblLokacijaIgranja
            // 
            lblLokacijaIgranja.AutoSize = true;
            lblLokacijaIgranja.Location = new Point(49, 834);
            lblLokacijaIgranja.Margin = new Padding(7, 0, 7, 0);
            lblLokacijaIgranja.Name = "lblLokacijaIgranja";
            lblLokacijaIgranja.Size = new Size(227, 41);
            lblLokacijaIgranja.TabIndex = 14;
            lblLokacijaIgranja.Text = "Lokacija igranja:";
            // 
            // txtLokacijaIgranja
            // 
            txtLokacijaIgranja.Location = new Point(437, 820);
            txtLokacijaIgranja.Margin = new Padding(7, 8, 7, 8);
            txtLokacijaIgranja.Name = "txtLokacijaIgranja";
            txtLokacijaIgranja.Size = new Size(674, 47);
            txtLokacijaIgranja.TabIndex = 15;
            // 
            // lblSudije
            // 
            lblSudije.AutoSize = true;
            lblSudije.Location = new Point(49, 943);
            lblSudije.Margin = new Padding(7, 0, 7, 0);
            lblSudije.Name = "lblSudije";
            lblSudije.Size = new Size(106, 41);
            lblSudije.TabIndex = 16;
            lblSudije.Text = "Sudije:";
            // 
            // txtSudije
            // 
            txtSudije.Location = new Point(437, 929);
            txtSudije.Margin = new Padding(7, 8, 7, 8);
            txtSudije.Name = "txtSudije";
            txtSudije.Size = new Size(674, 47);
            txtSudije.TabIndex = 17;
            // 
            // lblStatusMeca
            // 
            lblStatusMeca.AutoSize = true;
            lblStatusMeca.Location = new Point(49, 1052);
            lblStatusMeca.Margin = new Padding(7, 0, 7, 0);
            lblStatusMeca.Name = "lblStatusMeca";
            lblStatusMeca.Size = new Size(184, 41);
            lblStatusMeca.TabIndex = 18;
            lblStatusMeca.Text = "Status meča:";
            // 
            // dodajMecBtn
            // 
            dodajMecBtn.Location = new Point(437, 1175);
            dodajMecBtn.Margin = new Padding(7, 8, 7, 8);
            dodajMecBtn.Name = "dodajMecBtn";
            dodajMecBtn.Size = new Size(316, 96);
            dodajMecBtn.TabIndex = 10;
            dodajMecBtn.Text = "Dodaj";
            dodajMecBtn.UseVisualStyleBackColor = true;
            dodajMecBtn.Click += dodajMecBtn_Click;
            // 
            // odustaniBtn
            // 
            odustaniBtn.Location = new Point(801, 1175);
            odustaniBtn.Margin = new Padding(7, 8, 7, 8);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(316, 96);
            odustaniBtn.TabIndex = 11;
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;
            // 
            // cmbStatusMeca
            // 
            cmbStatusMeca.FormattingEnabled = true;
            cmbStatusMeca.Items.AddRange(new object[] { "Zakazan", "U toku", "Završen", "Odložen", "Prekinut" });
            cmbStatusMeca.Location = new Point(437, 1052);
            cmbStatusMeca.Name = "cmbStatusMeca";
            cmbStatusMeca.Size = new Size(669, 49);
            cmbStatusMeca.TabIndex = 20;
            // 
            // DodajMecForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 1367);
            Controls.Add(cmbStatusMeca);
            Controls.Add(lblTakmicenje);
            Controls.Add(cmbTakmicenje);
            Controls.Add(lblRedniBroj);
            Controls.Add(numRedniBroj);
            Controls.Add(lblDatumVremePocetka);
            Controls.Add(dtpDatumVremePocetka);
            Controls.Add(lblFormatMeca);
            Controls.Add(txtFormatMeca);
            Controls.Add(lblBrojMapa);
            Controls.Add(numBrojMapa);
            Controls.Add(lblRezultat);
            Controls.Add(txtRezultat);
            Controls.Add(lblTrajanje);
            Controls.Add(txtTrajanje);
            Controls.Add(lblLokacijaIgranja);
            Controls.Add(txtLokacijaIgranja);
            Controls.Add(lblSudije);
            Controls.Add(txtSudije);
            Controls.Add(lblStatusMeca);
            Controls.Add(dodajMecBtn);
            Controls.Add(odustaniBtn);
            Margin = new Padding(7, 8, 7, 8);
            Name = "DodajMecForma";
            Text = "Dodavanje meča";
            ((System.ComponentModel.ISupportInitialize)numRedniBroj).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBrojMapa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTakmicenje;
        private ComboBox cmbTakmicenje;

        private Label lblRedniBroj;
        private NumericUpDown numRedniBroj;

        private Label lblDatumVremePocetka;
        private DateTimePicker dtpDatumVremePocetka;

        private Label lblFormatMeca;
        private TextBox txtFormatMeca;

        private Label lblBrojMapa;
        private NumericUpDown numBrojMapa;

        private Label lblRezultat;
        private TextBox txtRezultat;

        private Label lblTrajanje;
        private TextBox txtTrajanje;

        private Label lblLokacijaIgranja;
        private TextBox txtLokacijaIgranja;

        private Label lblSudije;
        private TextBox txtSudije;

        private Label lblStatusMeca;

        private Button dodajMecBtn;
        private Button odustaniBtn;
        private ComboBox cmbStatusMeca;
    }
}
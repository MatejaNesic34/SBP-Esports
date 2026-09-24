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
            txtStatusMeca = new TextBox();

            dodajMecBtn = new Button();
            odustaniBtn = new Button();

            ((System.ComponentModel.ISupportInitialize)numRedniBroj).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBrojMapa).BeginInit();

            SuspendLayout();

            lblTakmicenje.AutoSize = true;
            lblTakmicenje.Location = new Point(20, 25);
            lblTakmicenje.Name = "lblTakmicenje";
            lblTakmicenje.Size = new Size(75, 15);
            lblTakmicenje.Text = "Takmičenje:";

            cmbTakmicenje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTakmicenje.FormattingEnabled = true;
            cmbTakmicenje.Location = new Point(180, 20);
            cmbTakmicenje.Name = "cmbTakmicenje";
            cmbTakmicenje.Size = new Size(280, 23);

            lblRedniBroj.AutoSize = true;
            lblRedniBroj.Location = new Point(20, 65);
            lblRedniBroj.Name = "lblRedniBroj";
            lblRedniBroj.Size = new Size(67, 15);
            lblRedniBroj.Text = "Redni broj:";

            numRedniBroj.Location = new Point(180, 60);
            numRedniBroj.Maximum = new decimal(new int[]
            {
                10000,
                0,
                0,
                0
            });
            numRedniBroj.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            numRedniBroj.Name = "numRedniBroj";
            numRedniBroj.Size = new Size(280, 23);
            numRedniBroj.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });

            lblDatumVremePocetka.AutoSize = true;
            lblDatumVremePocetka.Location = new Point(20, 105);
            lblDatumVremePocetka.Name = "lblDatumVremePocetka";
            lblDatumVremePocetka.Size = new Size(130, 15);
            lblDatumVremePocetka.Text = "Datum i vreme:";

            dtpDatumVremePocetka.Format = DateTimePickerFormat.Custom;
            dtpDatumVremePocetka.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDatumVremePocetka.Location = new Point(180, 100);
            dtpDatumVremePocetka.Name = "dtpDatumVremePocetka";
            dtpDatumVremePocetka.Size = new Size(280, 23);

            lblFormatMeca.AutoSize = true;
            lblFormatMeca.Location = new Point(20, 145);
            lblFormatMeca.Name = "lblFormatMeca";
            lblFormatMeca.Size = new Size(78, 15);
            lblFormatMeca.Text = "Format meča:";

            txtFormatMeca.Location = new Point(180, 140);
            txtFormatMeca.Name = "txtFormatMeca";
            txtFormatMeca.Size = new Size(280, 23);

            lblBrojMapa.AutoSize = true;
            lblBrojMapa.Location = new Point(20, 185);
            lblBrojMapa.Name = "lblBrojMapa";
            lblBrojMapa.Size = new Size(65, 15);
            lblBrojMapa.Text = "Broj mapa:";

            numBrojMapa.Location = new Point(180, 180);
            numBrojMapa.Maximum = new decimal(new int[]
            {
                100,
                0,
                0,
                0
            });
            numBrojMapa.Minimum = new decimal(new int[]
            {
                0,
                0,
                0,
                0
            });
            numBrojMapa.Name = "numBrojMapa";
            numBrojMapa.Size = new Size(280, 23);

            lblRezultat.AutoSize = true;
            lblRezultat.Location = new Point(20, 225);
            lblRezultat.Name = "lblRezultat";
            lblRezultat.Size = new Size(55, 15);
            lblRezultat.Text = "Rezultat:";

            txtRezultat.Location = new Point(180, 220);
            txtRezultat.Name = "txtRezultat";
            txtRezultat.Size = new Size(280, 23);

            lblTrajanje.AutoSize = true;
            lblTrajanje.Location = new Point(20, 265);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(53, 15);
            lblTrajanje.Text = "Trajanje:";

            txtTrajanje.Location = new Point(180, 260);
            txtTrajanje.Name = "txtTrajanje";
            txtTrajanje.Size = new Size(280, 23);

            lblLokacijaIgranja.AutoSize = true;
            lblLokacijaIgranja.Location = new Point(20, 305);
            lblLokacijaIgranja.Name = "lblLokacijaIgranja";
            lblLokacijaIgranja.Size = new Size(96, 15);
            lblLokacijaIgranja.Text = "Lokacija igranja:";

            txtLokacijaIgranja.Location = new Point(180, 300);
            txtLokacijaIgranja.Name = "txtLokacijaIgranja";
            txtLokacijaIgranja.Size = new Size(280, 23);

            lblSudije.AutoSize = true;
            lblSudije.Location = new Point(20, 345);
            lblSudije.Name = "lblSudije";
            lblSudije.Size = new Size(43, 15);
            lblSudije.Text = "Sudije:";

            txtSudije.Location = new Point(180, 340);
            txtSudije.Name = "txtSudije";
            txtSudije.Size = new Size(280, 23);

            lblStatusMeca.AutoSize = true;
            lblStatusMeca.Location = new Point(20, 385);
            lblStatusMeca.Name = "lblStatusMeca";
            lblStatusMeca.Size = new Size(75, 15);
            lblStatusMeca.Text = "Status meča:";

            txtStatusMeca.Location = new Point(180, 380);
            txtStatusMeca.Name = "txtStatusMeca";
            txtStatusMeca.Size = new Size(280, 23);

            dodajMecBtn.Location = new Point(180, 430);
            dodajMecBtn.Name = "dodajMecBtn";
            dodajMecBtn.Size = new Size(130, 35);
            dodajMecBtn.TabIndex = 10;
            dodajMecBtn.Text = "Dodaj";
            dodajMecBtn.UseVisualStyleBackColor = true;
            dodajMecBtn.Click += dodajMecBtn_Click;

            odustaniBtn.Location = new Point(330, 430);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(130, 35);
            odustaniBtn.TabIndex = 11;
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);

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
            Controls.Add(txtStatusMeca);

            Controls.Add(dodajMecBtn);
            Controls.Add(odustaniBtn);

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
        private TextBox txtStatusMeca;

        private Button dodajMecBtn;
        private Button odustaniBtn;
    }
}
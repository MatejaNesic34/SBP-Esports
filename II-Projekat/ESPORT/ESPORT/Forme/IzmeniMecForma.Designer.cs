namespace ESPORT.Forme
{
    partial class IzmeniMecForma
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
            lblMecId = new Label();
            txtMecId = new TextBox();
            lblTakmicenje = new Label();
            cmbTakmicenje = new ComboBox();
            lblRedniBroj = new Label();
            txtRedniBroj = new TextBox();
            lblDatumVremePocetka = new Label();
            dtpDatumVremePocetka = new DateTimePicker();
            lblFormatMeca = new Label();
            txtFormatMeca = new TextBox();
            lblBrojMapa = new Label();
            txtBrojMapa = new TextBox();
            lblRezultat = new Label();
            txtRezultat = new TextBox();
            lblTrajanje = new Label();
            txtTrajanje = new TextBox();
            lblLokacijaIgranja = new Label();
            txtLokacijaIgranja = new TextBox();
            lblSudije = new Label();
            txtSudije = new TextBox();
            lblStatusMeca = new Label();
            izmeniMecBtn = new Button();
            odustaniBtn = new Button();
            cmbStatusMeca = new ComboBox();
            SuspendLayout();
            // 
            // lblMecId
            // 
            lblMecId.AutoSize = true;
            lblMecId.Location = new Point(49, 68);
            lblMecId.Margin = new Padding(7, 0, 7, 0);
            lblMecId.Name = "lblMecId";
            lblMecId.Size = new Size(119, 41);
            lblMecId.TabIndex = 0;
            lblMecId.Text = "Meč ID:";
            // 
            // txtMecId
            // 
            txtMecId.Location = new Point(437, 55);
            txtMecId.Margin = new Padding(7, 8, 7, 8);
            txtMecId.Name = "txtMecId";
            txtMecId.ReadOnly = true;
            txtMecId.Size = new Size(674, 47);
            txtMecId.TabIndex = 1;
            // 
            // lblTakmicenje
            // 
            lblTakmicenje.AutoSize = true;
            lblTakmicenje.Location = new Point(49, 178);
            lblTakmicenje.Margin = new Padding(7, 0, 7, 0);
            lblTakmicenje.Name = "lblTakmicenje";
            lblTakmicenje.Size = new Size(171, 41);
            lblTakmicenje.TabIndex = 2;
            lblTakmicenje.Text = "Takmičenje:";
            // 
            // cmbTakmicenje
            // 
            cmbTakmicenje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTakmicenje.FormattingEnabled = true;
            cmbTakmicenje.Location = new Point(437, 164);
            cmbTakmicenje.Margin = new Padding(7, 8, 7, 8);
            cmbTakmicenje.Name = "cmbTakmicenje";
            cmbTakmicenje.Size = new Size(674, 49);
            cmbTakmicenje.TabIndex = 3;
            // 
            // lblRedniBroj
            // 
            lblRedniBroj.AutoSize = true;
            lblRedniBroj.Location = new Point(49, 287);
            lblRedniBroj.Margin = new Padding(7, 0, 7, 0);
            lblRedniBroj.Name = "lblRedniBroj";
            lblRedniBroj.Size = new Size(161, 41);
            lblRedniBroj.TabIndex = 4;
            lblRedniBroj.Text = "Redni broj:";
            // 
            // txtRedniBroj
            // 
            txtRedniBroj.Location = new Point(437, 273);
            txtRedniBroj.Margin = new Padding(7, 8, 7, 8);
            txtRedniBroj.Name = "txtRedniBroj";
            txtRedniBroj.Size = new Size(674, 47);
            txtRedniBroj.TabIndex = 5;
            // 
            // lblDatumVremePocetka
            // 
            lblDatumVremePocetka.AutoSize = true;
            lblDatumVremePocetka.Location = new Point(49, 396);
            lblDatumVremePocetka.Margin = new Padding(7, 0, 7, 0);
            lblDatumVremePocetka.Name = "lblDatumVremePocetka";
            lblDatumVremePocetka.Size = new Size(219, 41);
            lblDatumVremePocetka.TabIndex = 6;
            lblDatumVremePocetka.Text = "Datum i vreme:";
            // 
            // dtpDatumVremePocetka
            // 
            dtpDatumVremePocetka.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDatumVremePocetka.Format = DateTimePickerFormat.Custom;
            dtpDatumVremePocetka.Location = new Point(437, 383);
            dtpDatumVremePocetka.Margin = new Padding(7, 8, 7, 8);
            dtpDatumVremePocetka.Name = "dtpDatumVremePocetka";
            dtpDatumVremePocetka.Size = new Size(674, 47);
            dtpDatumVremePocetka.TabIndex = 7;
            // 
            // lblFormatMeca
            // 
            lblFormatMeca.AutoSize = true;
            lblFormatMeca.Location = new Point(49, 506);
            lblFormatMeca.Margin = new Padding(7, 0, 7, 0);
            lblFormatMeca.Name = "lblFormatMeca";
            lblFormatMeca.Size = new Size(198, 41);
            lblFormatMeca.TabIndex = 8;
            lblFormatMeca.Text = "Format meča:";
            // 
            // txtFormatMeca
            // 
            txtFormatMeca.Location = new Point(437, 492);
            txtFormatMeca.Margin = new Padding(7, 8, 7, 8);
            txtFormatMeca.Name = "txtFormatMeca";
            txtFormatMeca.Size = new Size(674, 47);
            txtFormatMeca.TabIndex = 9;
            // 
            // lblBrojMapa
            // 
            lblBrojMapa.AutoSize = true;
            lblBrojMapa.Location = new Point(49, 615);
            lblBrojMapa.Margin = new Padding(7, 0, 7, 0);
            lblBrojMapa.Name = "lblBrojMapa";
            lblBrojMapa.Size = new Size(159, 41);
            lblBrojMapa.TabIndex = 10;
            lblBrojMapa.Text = "Broj mapa:";
            // 
            // txtBrojMapa
            // 
            txtBrojMapa.Location = new Point(437, 601);
            txtBrojMapa.Margin = new Padding(7, 8, 7, 8);
            txtBrojMapa.Name = "txtBrojMapa";
            txtBrojMapa.Size = new Size(674, 47);
            txtBrojMapa.TabIndex = 11;
            // 
            // lblRezultat
            // 
            lblRezultat.AutoSize = true;
            lblRezultat.Location = new Point(49, 724);
            lblRezultat.Margin = new Padding(7, 0, 7, 0);
            lblRezultat.Name = "lblRezultat";
            lblRezultat.Size = new Size(131, 41);
            lblRezultat.TabIndex = 12;
            lblRezultat.Text = "Rezultat:";
            // 
            // txtRezultat
            // 
            txtRezultat.Location = new Point(437, 711);
            txtRezultat.Margin = new Padding(7, 8, 7, 8);
            txtRezultat.Name = "txtRezultat";
            txtRezultat.Size = new Size(674, 47);
            txtRezultat.TabIndex = 13;
            // 
            // lblTrajanje
            // 
            lblTrajanje.AutoSize = true;
            lblTrajanje.Location = new Point(49, 834);
            lblTrajanje.Margin = new Padding(7, 0, 7, 0);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(125, 41);
            lblTrajanje.TabIndex = 14;
            lblTrajanje.Text = "Trajanje:";
            // 
            // txtTrajanje
            // 
            txtTrajanje.Location = new Point(437, 820);
            txtTrajanje.Margin = new Padding(7, 8, 7, 8);
            txtTrajanje.Name = "txtTrajanje";
            txtTrajanje.Size = new Size(674, 47);
            txtTrajanje.TabIndex = 15;
            // 
            // lblLokacijaIgranja
            // 
            lblLokacijaIgranja.AutoSize = true;
            lblLokacijaIgranja.Location = new Point(49, 943);
            lblLokacijaIgranja.Margin = new Padding(7, 0, 7, 0);
            lblLokacijaIgranja.Name = "lblLokacijaIgranja";
            lblLokacijaIgranja.Size = new Size(227, 41);
            lblLokacijaIgranja.TabIndex = 16;
            lblLokacijaIgranja.Text = "Lokacija igranja:";
            // 
            // txtLokacijaIgranja
            // 
            txtLokacijaIgranja.Location = new Point(437, 929);
            txtLokacijaIgranja.Margin = new Padding(7, 8, 7, 8);
            txtLokacijaIgranja.Name = "txtLokacijaIgranja";
            txtLokacijaIgranja.Size = new Size(674, 47);
            txtLokacijaIgranja.TabIndex = 17;
            // 
            // lblSudije
            // 
            lblSudije.AutoSize = true;
            lblSudije.Location = new Point(49, 1052);
            lblSudije.Margin = new Padding(7, 0, 7, 0);
            lblSudije.Name = "lblSudije";
            lblSudije.Size = new Size(106, 41);
            lblSudije.TabIndex = 18;
            lblSudije.Text = "Sudije:";
            // 
            // txtSudije
            // 
            txtSudije.Location = new Point(437, 1039);
            txtSudije.Margin = new Padding(7, 8, 7, 8);
            txtSudije.Name = "txtSudije";
            txtSudije.Size = new Size(674, 47);
            txtSudije.TabIndex = 19;
            // 
            // lblStatusMeca
            // 
            lblStatusMeca.AutoSize = true;
            lblStatusMeca.Location = new Point(49, 1162);
            lblStatusMeca.Margin = new Padding(7, 0, 7, 0);
            lblStatusMeca.Name = "lblStatusMeca";
            lblStatusMeca.Size = new Size(184, 41);
            lblStatusMeca.TabIndex = 20;
            lblStatusMeca.Text = "Status meča:";
            // 
            // izmeniMecBtn
            // 
            izmeniMecBtn.Location = new Point(437, 1285);
            izmeniMecBtn.Margin = new Padding(7, 8, 7, 8);
            izmeniMecBtn.Name = "izmeniMecBtn";
            izmeniMecBtn.Size = new Size(316, 96);
            izmeniMecBtn.TabIndex = 10;
            izmeniMecBtn.Text = "Izmeni";
            izmeniMecBtn.UseVisualStyleBackColor = true;
            izmeniMecBtn.Click += izmeniMecBtn_Click;
            // 
            // odustaniBtn
            // 
            odustaniBtn.Location = new Point(801, 1285);
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
            cmbStatusMeca.Location = new Point(437, 1159);
            cmbStatusMeca.Name = "cmbStatusMeca";
            cmbStatusMeca.Size = new Size(669, 49);
            cmbStatusMeca.TabIndex = 22;
            // 
            // IzmeniMecForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 1476);
            Controls.Add(cmbStatusMeca);
            Controls.Add(lblMecId);
            Controls.Add(txtMecId);
            Controls.Add(lblTakmicenje);
            Controls.Add(cmbTakmicenje);
            Controls.Add(lblRedniBroj);
            Controls.Add(txtRedniBroj);
            Controls.Add(lblDatumVremePocetka);
            Controls.Add(dtpDatumVremePocetka);
            Controls.Add(lblFormatMeca);
            Controls.Add(txtFormatMeca);
            Controls.Add(lblBrojMapa);
            Controls.Add(txtBrojMapa);
            Controls.Add(lblRezultat);
            Controls.Add(txtRezultat);
            Controls.Add(lblTrajanje);
            Controls.Add(txtTrajanje);
            Controls.Add(lblLokacijaIgranja);
            Controls.Add(txtLokacijaIgranja);
            Controls.Add(lblSudije);
            Controls.Add(txtSudije);
            Controls.Add(lblStatusMeca);
            Controls.Add(izmeniMecBtn);
            Controls.Add(odustaniBtn);
            Margin = new Padding(7, 8, 7, 8);
            Name = "IzmeniMecForma";
            Text = "Izmena meča";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMecId;
        private TextBox txtMecId;

        private Label lblTakmicenje;
        private ComboBox cmbTakmicenje;

        private Label lblRedniBroj;
        private TextBox txtRedniBroj;

        private Label lblDatumVremePocetka;
        private DateTimePicker dtpDatumVremePocetka;

        private Label lblFormatMeca;
        private TextBox txtFormatMeca;

        private Label lblBrojMapa;
        private TextBox txtBrojMapa;

        private Label lblRezultat;
        private TextBox txtRezultat;

        private Label lblTrajanje;
        private TextBox txtTrajanje;

        private Label lblLokacijaIgranja;
        private TextBox txtLokacijaIgranja;

        private Label lblSudije;
        private TextBox txtSudije;

        private Label lblStatusMeca;

        private Button izmeniMecBtn;
        private Button odustaniBtn;
        private ComboBox cmbStatusMeca;
    }
}
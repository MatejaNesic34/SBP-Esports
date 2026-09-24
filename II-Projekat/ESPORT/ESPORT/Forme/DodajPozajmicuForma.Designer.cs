namespace ESPORT
{
    partial class DodajPozajmicuForma
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
            lblIgrac = new Label();
            cmbIgrac = new ComboBox();
            lblMaticniTim = new Label();
            cmbMaticniTim = new ComboBox();
            lblTimNaPozajmici = new Label();
            cmbTimNaPozajmici = new ComboBox();
            lblDatumOd = new Label();
            dtpDatumOd = new DateTimePicker();
            lblDatumDo = new Label();
            dtpDatumDo = new DateTimePicker();
            lblFinansijskiUslovi = new Label();
            txtFinansijskiUslovi = new TextBox();
            lblPravoOtkupa = new Label();
            cmbPravoOtkupa = new ComboBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            lblIgrac.AutoSize = true;
            lblIgrac.Location = new Point(1, 13);
            lblIgrac.Name = "lblIgrac";
            lblIgrac.Size = new Size(31, 15);
            lblIgrac.TabIndex = 0;
            lblIgrac.Text = "Igrač:";

            cmbIgrac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIgrac.FormattingEnabled = true;
            cmbIgrac.Location = new Point(130, 10);
            cmbIgrac.Name = "cmbIgrac";
            cmbIgrac.Size = new Size(167, 23);
            cmbIgrac.TabIndex = 1;

            lblMaticniTim.AutoSize = true;
            lblMaticniTim.Location = new Point(1, 38);
            lblMaticniTim.Name = "lblMaticniTim";
            lblMaticniTim.Size = new Size(70, 15);
            lblMaticniTim.TabIndex = 2;
            lblMaticniTim.Text = "Matični tim:";

            cmbMaticniTim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaticniTim.FormattingEnabled = true;
            cmbMaticniTim.Location = new Point(130, 35);
            cmbMaticniTim.Name = "cmbMaticniTim";
            cmbMaticniTim.Size = new Size(167, 23);
            cmbMaticniTim.TabIndex = 3;

            lblTimNaPozajmici.AutoSize = true;
            lblTimNaPozajmici.Location = new Point(1, 63);
            lblTimNaPozajmici.Name = "lblTimNaPozajmici";
            lblTimNaPozajmici.Size = new Size(104, 15);
            lblTimNaPozajmici.TabIndex = 4;
            lblTimNaPozajmici.Text = "Tim na pozajmici:";

            cmbTimNaPozajmici.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimNaPozajmici.FormattingEnabled = true;
            cmbTimNaPozajmici.Location = new Point(130, 60);
            cmbTimNaPozajmici.Name = "cmbTimNaPozajmici";
            cmbTimNaPozajmici.Size = new Size(167, 23);
            cmbTimNaPozajmici.TabIndex = 5;

            lblDatumOd.AutoSize = true;
            lblDatumOd.Location = new Point(1, 88);
            lblDatumOd.Name = "lblDatumOd";
            lblDatumOd.Size = new Size(61, 15);
            lblDatumOd.TabIndex = 6;
            lblDatumOd.Text = "Datum od:";

            dtpDatumOd.Format = DateTimePickerFormat.Short;
            dtpDatumOd.Location = new Point(130, 85);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(167, 23);
            dtpDatumOd.TabIndex = 7;

            lblDatumDo.AutoSize = true;
            lblDatumDo.Location = new Point(1, 113);
            lblDatumDo.Name = "lblDatumDo";
            lblDatumDo.Size = new Size(61, 15);
            lblDatumDo.TabIndex = 8;
            lblDatumDo.Text = "Datum do:";

            dtpDatumDo.Format = DateTimePickerFormat.Short;
            dtpDatumDo.Location = new Point(130, 110);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(167, 23);
            dtpDatumDo.TabIndex = 9;

            lblFinansijskiUslovi.AutoSize = true;
            lblFinansijskiUslovi.Location = new Point(1, 138);
            lblFinansijskiUslovi.Name = "lblFinansijskiUslovi";
            lblFinansijskiUslovi.Size = new Size(99, 15);
            lblFinansijskiUslovi.TabIndex = 10;
            lblFinansijskiUslovi.Text = "Finansijski uslovi:";

            txtFinansijskiUslovi.Location = new Point(130, 135);
            txtFinansijskiUslovi.Name = "txtFinansijskiUslovi";
            txtFinansijskiUslovi.Size = new Size(167, 23);
            txtFinansijskiUslovi.TabIndex = 11;

            lblPravoOtkupa.AutoSize = true;
            lblPravoOtkupa.Location = new Point(1, 163);
            lblPravoOtkupa.Name = "lblPravoOtkupa";
            lblPravoOtkupa.Size = new Size(83, 15);
            lblPravoOtkupa.TabIndex = 12;
            lblPravoOtkupa.Text = "Pravo otkupa:";

            cmbPravoOtkupa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPravoOtkupa.FormattingEnabled = true;
            cmbPravoOtkupa.Items.AddRange(new object[] {
                "Da",
                "Ne"});
            cmbPravoOtkupa.Location = new Point(130, 160);
            cmbPravoOtkupa.Name = "cmbPravoOtkupa";
            cmbPravoOtkupa.Size = new Size(167, 23);
            cmbPravoOtkupa.TabIndex = 13;

            btnSacuvaj.Location = new Point(130, 195);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(78, 22);
            btnSacuvaj.TabIndex = 14;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            btnOdustani.Location = new Point(219, 195);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(78, 22);
            btnOdustani.TabIndex = 15;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 240);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbPravoOtkupa);
            Controls.Add(lblPravoOtkupa);
            Controls.Add(txtFinansijskiUslovi);
            Controls.Add(lblFinansijskiUslovi);
            Controls.Add(dtpDatumDo);
            Controls.Add(lblDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(lblDatumOd);
            Controls.Add(cmbTimNaPozajmici);
            Controls.Add(lblTimNaPozajmici);
            Controls.Add(cmbMaticniTim);
            Controls.Add(lblMaticniTim);
            Controls.Add(cmbIgrac);
            Controls.Add(lblIgrac);
            Name = "DodajPozajmicuForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodavanje pozajmice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIgrac;
        private ComboBox cmbIgrac;
        private Label lblMaticniTim;
        private ComboBox cmbMaticniTim;
        private Label lblTimNaPozajmici;
        private ComboBox cmbTimNaPozajmici;
        private Label lblDatumOd;
        private DateTimePicker dtpDatumOd;
        private Label lblDatumDo;
        private DateTimePicker dtpDatumDo;
        private Label lblFinansijskiUslovi;
        private TextBox txtFinansijskiUslovi;
        private Label lblPravoOtkupa;
        private ComboBox cmbPravoOtkupa;
        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}
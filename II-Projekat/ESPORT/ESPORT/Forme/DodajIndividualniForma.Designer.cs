namespace ESPORT.Forme
{
    partial class DodajIndividualniForma
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

            lblNazivPriznanja = new Label();
            txtNazivPriznanja = new TextBox();

            lblDatum = new Label();
            chkDatum = new CheckBox();
            dtpDatum = new DateTimePicker();

            lblTakmicenje = new Label();
            cmbTakmicenje = new ComboBox();

            lblOpis = new Label();
            txtOpis = new TextBox();

            btnSacuvaj = new Button();
            btnOdustani = new Button();

            SuspendLayout();

            lblIgrac.AutoSize = true;
            lblIgrac.Location = new Point(15, 18);
            lblIgrac.Name = "lblIgrac";
            lblIgrac.Size = new Size(45, 20);
            lblIgrac.Text = "Igrač:";

            cmbIgrac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIgrac.FormattingEnabled = true;
            cmbIgrac.Location = new Point(145, 15);
            cmbIgrac.Name = "cmbIgrac";
            cmbIgrac.Size = new Size(220, 28);

            lblNazivPriznanja.AutoSize = true;
            lblNazivPriznanja.Location = new Point(15, 55);
            lblNazivPriznanja.Name = "lblNazivPriznanja";
            lblNazivPriznanja.Size = new Size(120, 20);
            lblNazivPriznanja.Text = "Naziv priznanja:";

            txtNazivPriznanja.Location = new Point(145, 52);
            txtNazivPriznanja.Name = "txtNazivPriznanja";
            txtNazivPriznanja.Size = new Size(220, 27);

            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(15, 92);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(125, 20);
            lblDatum.Text = "Datum ostvarivanja:";

            chkDatum.AutoSize = true;
            chkDatum.Location = new Point(145, 94);
            chkDatum.Name = "chkDatum";
            chkDatum.Size = new Size(18, 17);
            chkDatum.Text = "";

            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(175, 88);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(190, 27);
            dtpDatum.Enabled = false;

            lblTakmicenje.AutoSize = true;
            lblTakmicenje.Location = new Point(15, 130);
            lblTakmicenje.Name = "lblTakmicenje";
            lblTakmicenje.Size = new Size(95, 20);
            lblTakmicenje.Text = "Takmičenje:";

            cmbTakmicenje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTakmicenje.FormattingEnabled = true;
            cmbTakmicenje.Location = new Point(145, 127);
            cmbTakmicenje.Name = "cmbTakmicenje";
            cmbTakmicenje.Size = new Size(220, 28);

            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(15, 168);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(40, 20);
            lblOpis.Text = "Opis:";

            txtOpis.Location = new Point(145, 165);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.ScrollBars = ScrollBars.Vertical;
            txtOpis.Size = new Size(220, 65);

            btnSacuvaj.Location = new Point(70, 250);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(120, 35);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            btnOdustani.Location = new Point(205, 250);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(120, 35);
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 310);

            Controls.Add(lblIgrac);
            Controls.Add(cmbIgrac);

            Controls.Add(lblNazivPriznanja);
            Controls.Add(txtNazivPriznanja);

            Controls.Add(lblDatum);
            Controls.Add(chkDatum);
            Controls.Add(dtpDatum);

            Controls.Add(lblTakmicenje);
            Controls.Add(cmbTakmicenje);

            Controls.Add(lblOpis);
            Controls.Add(txtOpis);

            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);

            Name = "DodajIndividualniForma";
            Text = "Dodavanje individualnog rezultata";

            ResumeLayout(false);
            PerformLayout();

            chkDatum.CheckedChanged += chkDatum_CheckedChanged;
        }

        #endregion

        private Label lblIgrac;
        private ComboBox cmbIgrac;

        private Label lblNazivPriznanja;
        private TextBox txtNazivPriznanja;

        private Label lblDatum;
        private CheckBox chkDatum;
        private DateTimePicker dtpDatum;

        private Label lblTakmicenje;
        private ComboBox cmbTakmicenje;

        private Label lblOpis;
        private TextBox txtOpis;

        private Button btnSacuvaj;
        private Button btnOdustani;

        private void chkDatum_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatum.Enabled = chkDatum.Checked;
        }
    }
}
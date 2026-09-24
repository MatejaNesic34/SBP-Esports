namespace ESPORT.Forme
{
    partial class IzmeniTakmicenjeForma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNaziv = new TextBox();
            txtOrganizator = new TextBox();
            txtTipTakmicenja = new TextBox();
            cmbIgra = new ComboBox();
            txtRegion = new TextBox();
            txtLokacija = new TextBox();
            txtFormatTakmicenja = new TextBox();
            dtpDatumPocetka = new DateTimePicker();
            dtpDatumZavrsetka = new DateTimePicker();
            txtNagradniFond = new TextBox();
            txtValutaNagrade = new TextBox();
            txtStatus = new TextBox();

            lblNaziv = new Label();
            lblOrganizator = new Label();
            lblTipTakmicenja = new Label();
            lblIgra = new Label();
            lblRegion = new Label();
            lblLokacija = new Label();
            lblFormatTakmicenja = new Label();
            lblDatumPocetka = new Label();
            lblDatumZavrsetka = new Label();
            lblNagradniFond = new Label();
            lblValutaNagrade = new Label();
            lblStatus = new Label();

            izmeniTakmicenjeBtn = new Button();
            odustaniBtn = new Button();

            SuspendLayout();

            txtNaziv.Location = new Point(170, 20);
            txtNaziv.Size = new Size(250, 23);

            txtOrganizator.Location = new Point(170, 55);
            txtOrganizator.Size = new Size(250, 23);

            txtTipTakmicenja.Location = new Point(170, 90);
            txtTipTakmicenja.Size = new Size(250, 23);

            cmbIgra.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIgra.FormattingEnabled = true;
            cmbIgra.Location = new Point(170, 125);
            cmbIgra.Size = new Size(250, 23);

            txtRegion.Location = new Point(170, 160);
            txtRegion.Size = new Size(250, 23);

            txtLokacija.Location = new Point(170, 195);
            txtLokacija.Size = new Size(250, 23);

            txtFormatTakmicenja.Location = new Point(170, 230);
            txtFormatTakmicenja.Size = new Size(250, 23);

            dtpDatumPocetka.Format = DateTimePickerFormat.Short;
            dtpDatumPocetka.Location = new Point(170, 265);
            dtpDatumPocetka.Size = new Size(250, 23);

            dtpDatumZavrsetka.Format = DateTimePickerFormat.Short;
            dtpDatumZavrsetka.Location = new Point(170, 300);
            dtpDatumZavrsetka.Size = new Size(250, 23);

            txtNagradniFond.Location = new Point(170, 335);
            txtNagradniFond.Size = new Size(250, 23);

            txtValutaNagrade.Location = new Point(170, 370);
            txtValutaNagrade.Size = new Size(250, 23);

            txtStatus.Location = new Point(170, 405);
            txtStatus.Size = new Size(250, 23);

            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(20, 23);
            lblNaziv.Text = "Naziv:";

            lblOrganizator.AutoSize = true;
            lblOrganizator.Location = new Point(20, 58);
            lblOrganizator.Text = "Organizator:";

            lblTipTakmicenja.AutoSize = true;
            lblTipTakmicenja.Location = new Point(20, 93);
            lblTipTakmicenja.Text = "Tip takmičenja:";

            lblIgra.AutoSize = true;
            lblIgra.Location = new Point(20, 128);
            lblIgra.Text = "Igra:";

            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(20, 163);
            lblRegion.Text = "Region:";

            lblLokacija.AutoSize = true;
            lblLokacija.Location = new Point(20, 198);
            lblLokacija.Text = "Lokacija:";

            lblFormatTakmicenja.AutoSize = true;
            lblFormatTakmicenja.Location = new Point(20, 233);
            lblFormatTakmicenja.Text = "Format takmičenja:";

            lblDatumPocetka.AutoSize = true;
            lblDatumPocetka.Location = new Point(20, 268);
            lblDatumPocetka.Text = "Datum početka:";

            lblDatumZavrsetka.AutoSize = true;
            lblDatumZavrsetka.Location = new Point(20, 303);
            lblDatumZavrsetka.Text = "Datum završetka:";

            lblNagradniFond.AutoSize = true;
            lblNagradniFond.Location = new Point(20, 338);
            lblNagradniFond.Text = "Nagradni fond:";

            lblValutaNagrade.AutoSize = true;
            lblValutaNagrade.Location = new Point(20, 373);
            lblValutaNagrade.Text = "Valuta nagrade:";

            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 408);
            lblStatus.Text = "Status:";

            izmeniTakmicenjeBtn.Location = new Point(170, 450);
            izmeniTakmicenjeBtn.Size = new Size(115, 30);
            izmeniTakmicenjeBtn.Text = "Izmeni";
            izmeniTakmicenjeBtn.UseVisualStyleBackColor = true;
            izmeniTakmicenjeBtn.Click += izmeniTakmicenjeBtn_Click;

            odustaniBtn.Location = new Point(305, 450);
            odustaniBtn.Size = new Size(115, 30);
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 510);

            Controls.Add(txtNaziv);
            Controls.Add(txtOrganizator);
            Controls.Add(txtTipTakmicenja);
            Controls.Add(cmbIgra);
            Controls.Add(txtRegion);
            Controls.Add(txtLokacija);
            Controls.Add(txtFormatTakmicenja);
            Controls.Add(dtpDatumPocetka);
            Controls.Add(dtpDatumZavrsetka);
            Controls.Add(txtNagradniFond);
            Controls.Add(txtValutaNagrade);
            Controls.Add(txtStatus);

            Controls.Add(lblNaziv);
            Controls.Add(lblOrganizator);
            Controls.Add(lblTipTakmicenja);
            Controls.Add(lblIgra);
            Controls.Add(lblRegion);
            Controls.Add(lblLokacija);
            Controls.Add(lblFormatTakmicenja);
            Controls.Add(lblDatumPocetka);
            Controls.Add(lblDatumZavrsetka);
            Controls.Add(lblNagradniFond);
            Controls.Add(lblValutaNagrade);
            Controls.Add(lblStatus);

            Controls.Add(izmeniTakmicenjeBtn);
            Controls.Add(odustaniBtn);

            Name = "IzmeniTakmicenjeForma";
            Text = "Izmena takmičenja";

            Load += IzmeniTakmicenjeForma_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaziv;
        private TextBox txtOrganizator;
        private TextBox txtTipTakmicenja;
        private ComboBox cmbIgra;
        private TextBox txtRegion;
        private TextBox txtLokacija;
        private TextBox txtFormatTakmicenja;
        private DateTimePicker dtpDatumPocetka;
        private DateTimePicker dtpDatumZavrsetka;
        private TextBox txtNagradniFond;
        private TextBox txtValutaNagrade;
        private TextBox txtStatus;

        private Label lblNaziv;
        private Label lblOrganizator;
        private Label lblTipTakmicenja;
        private Label lblIgra;
        private Label lblRegion;
        private Label lblLokacija;
        private Label lblFormatTakmicenja;
        private Label lblDatumPocetka;
        private Label lblDatumZavrsetka;
        private Label lblNagradniFond;
        private Label lblValutaNagrade;
        private Label lblStatus;

        private Button izmeniTakmicenjeBtn;
        private Button odustaniBtn;
    }
}
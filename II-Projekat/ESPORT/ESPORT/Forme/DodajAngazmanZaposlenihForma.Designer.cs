namespace ESPORT.Forme
{
    partial class DodajAngazmanZaposlenihForma
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblOsoba;
        private System.Windows.Forms.ComboBox cmbOsoba;

        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.ComboBox cmbTim;

        private System.Windows.Forms.Label lblNazivUloge;
        private System.Windows.Forms.ComboBox cmbNazivUloge;

        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;

        private System.Windows.Forms.CheckBox chkDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;

        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.TextBox txtPlata;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblOsoba = new Label();
            cmbOsoba = new ComboBox();

            lblTim = new Label();
            cmbTim = new ComboBox();

            lblNazivUloge = new Label();
            cmbNazivUloge = new ComboBox();

            lblDatumOd = new Label();
            dtpDatumOd = new DateTimePicker();

            chkDatumDo = new CheckBox();
            dtpDatumDo = new DateTimePicker();

            lblPlata = new Label();
            txtPlata = new TextBox();

            btnSacuvaj = new Button();
            btnOdustani = new Button();

            SuspendLayout();

            // 
            // lblOsoba
            // 
            lblOsoba.AutoSize = true;
            lblOsoba.Location = new Point(15, 20);
            lblOsoba.Name = "lblOsoba";
            lblOsoba.Size = new Size(43, 15);
            lblOsoba.Text = "Osoba:";

            // 
            // cmbOsoba
            // 
            cmbOsoba.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOsoba.FormattingEnabled = true;
            cmbOsoba.Location = new Point(130, 17);
            cmbOsoba.Name = "cmbOsoba";
            cmbOsoba.Size = new Size(220, 23);

            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Location = new Point(15, 60);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(28, 15);
            lblTim.Text = "Tim:";

            // 
            // cmbTim
            // 
            cmbTim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTim.FormattingEnabled = true;
            cmbTim.Location = new Point(130, 57);
            cmbTim.Name = "cmbTim";
            cmbTim.Size = new Size(220, 23);

            // 
            // lblNazivUloge
            // 
            lblNazivUloge.AutoSize = true;
            lblNazivUloge.Location = new Point(15, 100);
            lblNazivUloge.Name = "lblNazivUloge";
            lblNazivUloge.Size = new Size(74, 15);
            lblNazivUloge.Text = "Naziv uloge:";

            // 
            // cmbNazivUloge
            // 
            cmbNazivUloge.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNazivUloge.FormattingEnabled = true;
            cmbNazivUloge.Location = new Point(130, 97);
            cmbNazivUloge.Name = "cmbNazivUloge";
            cmbNazivUloge.Size = new Size(220, 23);

            // 
            // lblDatumOd
            // 
            lblDatumOd.AutoSize = true;
            lblDatumOd.Location = new Point(15, 140);
            lblDatumOd.Name = "lblDatumOd";
            lblDatumOd.Size = new Size(65, 15);
            lblDatumOd.Text = "Datum od:";

            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Format = DateTimePickerFormat.Short;
            dtpDatumOd.Location = new Point(130, 137);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(220, 23);

            // 
            // chkDatumDo
            // 
            chkDatumDo.AutoSize = true;
            chkDatumDo.Location = new Point(15, 180);
            chkDatumDo.Name = "chkDatumDo";
            chkDatumDo.Size = new Size(82, 19);
            chkDatumDo.Text = "Datum do";
            chkDatumDo.UseVisualStyleBackColor = true;
            chkDatumDo.CheckedChanged += chkDatumDo_CheckedChanged;

            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Enabled = false;
            dtpDatumDo.Format = DateTimePickerFormat.Short;
            dtpDatumDo.Location = new Point(130, 177);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(220, 23);

            // 
            // lblPlata
            // 
            lblPlata.AutoSize = true;
            lblPlata.Location = new Point(15, 220);
            lblPlata.Name = "lblPlata";
            lblPlata.Size = new Size(37, 15);
            lblPlata.Text = "Plata:";

            // 
            // txtPlata
            // 
            txtPlata.Location = new Point(130, 217);
            txtPlata.Name = "txtPlata";
            txtPlata.Size = new Size(220, 23);

            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(130, 260);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(105, 35);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(245, 260);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(105, 35);
            btnOdustani.TabIndex = 8;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            // 
            // DodajAngazmanZaposlenihForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 320);

            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);

            Controls.Add(txtPlata);
            Controls.Add(lblPlata);

            Controls.Add(dtpDatumDo);
            Controls.Add(chkDatumDo);

            Controls.Add(dtpDatumOd);
            Controls.Add(lblDatumOd);

            Controls.Add(cmbNazivUloge);
            Controls.Add(lblNazivUloge);

            Controls.Add(cmbTim);
            Controls.Add(lblTim);

            Controls.Add(cmbOsoba);
            Controls.Add(lblOsoba);

            Name = "DodajAngazmanZaposlenihForma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj angažman zaposlenog";

            Load += DodajAngazmanZaposlenihForma_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
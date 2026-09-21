namespace ESPORT.Forme
{
    partial class DodajSponzorKontaktForma
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

        private void InitializeComponent()
        {
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnDodaj = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            lblIme.AutoSize = true;
            lblIme.Location = new Point(50, 50);
            lblIme.Size = new Size(76, 41);
            lblIme.Text = "Ime:";

            txtIme.Location = new Point(250, 47);
            txtIme.Size = new Size(400, 47);

            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(50, 130);
            lblPrezime.Size = new Size(130, 41);
            lblPrezime.Text = "Prezime:";

            txtPrezime.Location = new Point(250, 127);
            txtPrezime.Size = new Size(400, 47);

            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(50, 210);
            lblTelefon.Size = new Size(125, 41);
            lblTelefon.Text = "Telefon:";

            txtTelefon.Location = new Point(250, 207);
            txtTelefon.Size = new Size(400, 47);

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 290);
            lblEmail.Size = new Size(95, 41);
            lblEmail.Text = "Email:";

            txtEmail.Location = new Point(250, 287);
            txtEmail.Size = new Size(400, 47);

            btnDodaj.Location = new Point(250, 390);
            btnDodaj.Size = new Size(180, 60);
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            btnOdustani.Location = new Point(470, 390);
            btnOdustani.Size = new Size(180, 60);
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 500);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodaj);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Name = "DodajSponzorKontaktForma";
            Text = "Dodaj Kontakt";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblIme;
        private TextBox txtIme;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnDodaj;
        private Button btnOdustani;
    }
}
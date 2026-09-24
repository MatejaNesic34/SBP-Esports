namespace ESPORT.Forme
{
    partial class SponzorKontaktiForma
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
            listViewKontakti = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderIme = new ColumnHeader();
            columnHeaderPrezime = new ColumnHeader();
            columnHeaderTelefon = new ColumnHeader();
            columnHeaderEmail = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnObrisiKontakt = new Button();
            btnIzmeniKontakt = new Button();
            btnDodajKontakt = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewKontakti.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderIme, columnHeaderPrezime, columnHeaderTelefon, columnHeaderEmail });
            listViewKontakti.FullRowSelect = true;
            listViewKontakti.Location = new Point(11, 27);
            listViewKontakti.Margin = new Padding(1);
            listViewKontakti.MultiSelect = false;
            listViewKontakti.Name = "listViewKontakti";
            listViewKontakti.Size = new Size(658, 324);
            listViewKontakti.TabIndex = 0;
            listViewKontakti.UseCompatibleStateImageBehavior = false;
            listViewKontakti.View = View.Details;

            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 50;

            columnHeaderIme.Text = "Ime";
            columnHeaderIme.Width = 120;

            columnHeaderPrezime.Text = "Prezime";
            columnHeaderPrezime.Width = 120;

            columnHeaderTelefon.Text = "Telefon";
            columnHeaderTelefon.Width = 150;

            columnHeaderEmail.Text = "Email";
            columnHeaderEmail.Width = 200;

            groupBox1.Controls.Add(listViewKontakti);
            groupBox1.Location = new Point(19, 31);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(677, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista kontakata";

            groupBox2.Controls.Add(btnObrisiKontakt);
            groupBox2.Controls.Add(btnIzmeniKontakt);
            groupBox2.Controls.Add(btnDodajKontakt);
            groupBox2.Location = new Point(727, 91);
            groupBox2.Margin = new Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1);
            groupBox2.Size = new Size(165, 241);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije sa kontaktima";

            btnObrisiKontakt.Location = new Point(25, 156);
            btnObrisiKontakt.Margin = new Padding(1);
            btnObrisiKontakt.Name = "btnObrisiKontakt";
            btnObrisiKontakt.Size = new Size(114, 38);
            btnObrisiKontakt.TabIndex = 2;
            btnObrisiKontakt.Text = "Obriši kontakt";
            btnObrisiKontakt.UseVisualStyleBackColor = true;
            btnObrisiKontakt.Click += btnObrisiKontakt_Click;

            btnIzmeniKontakt.Location = new Point(25, 98);
            btnIzmeniKontakt.Margin = new Padding(1);
            btnIzmeniKontakt.Name = "btnIzmeniKontakt";
            btnIzmeniKontakt.Size = new Size(114, 37);
            btnIzmeniKontakt.TabIndex = 1;
            btnIzmeniKontakt.Text = "Izmeni kontakt";
            btnIzmeniKontakt.UseVisualStyleBackColor = true;
            btnIzmeniKontakt.Click += btnIzmeniKontakt_Click;

            btnDodajKontakt.Location = new Point(25, 37);
            btnDodajKontakt.Margin = new Padding(1);
            btnDodajKontakt.Name = "btnDodajKontakt";
            btnDodajKontakt.Size = new Size(114, 37);
            btnDodajKontakt.TabIndex = 0;
            btnDodajKontakt.Text = "Dodaj kontakt";
            btnDodajKontakt.UseVisualStyleBackColor = true;
            btnDodajKontakt.Click += btnDodajKontakt_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 439);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(1);
            Name = "SponzorKontaktiForma";
            Text = "Sponzor Kontakti";
            Load += SponzorKontaktiForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewKontakti;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderIme;
        private ColumnHeader columnHeaderPrezime;
        private ColumnHeader columnHeaderTelefon;
        private ColumnHeader columnHeaderEmail;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnObrisiKontakt;
        private Button btnIzmeniKontakt;
        private Button btnDodajKontakt;
    }
}
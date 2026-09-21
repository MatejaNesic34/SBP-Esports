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
            // 
            // listViewKontakti
            // 
            listViewKontakti.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderIme, columnHeaderPrezime, columnHeaderTelefon, columnHeaderEmail });
            listViewKontakti.FullRowSelect = true;
            listViewKontakti.Location = new Point(24, 56);
            listViewKontakti.MultiSelect = false;
            listViewKontakti.Name = "listViewKontakti";
            listViewKontakti.Size = new Size(1100, 659);
            listViewKontakti.TabIndex = 0;
            listViewKontakti.UseCompatibleStateImageBehavior = false;
            listViewKontakti.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 80;
            // 
            // columnHeaderIme
            // 
            columnHeaderIme.Text = "Ime";
            columnHeaderIme.Width = 220;
            // 
            // columnHeaderPrezime
            // 
            columnHeaderPrezime.Text = "Prezime";
            columnHeaderPrezime.Width = 240;
            // 
            // columnHeaderTelefon
            // 
            columnHeaderTelefon.Text = "Telefon";
            columnHeaderTelefon.Width = 240;
            // 
            // columnHeaderEmail
            // 
            columnHeaderEmail.Text = "Email";
            columnHeaderEmail.Width = 280;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewKontakti);
            groupBox1.Location = new Point(40, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista kontakata";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnObrisiKontakt);
            groupBox2.Controls.Add(btnIzmeniKontakt);
            groupBox2.Controls.Add(btnDodajKontakt);
            groupBox2.Location = new Point(1240, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije sa kontaktima";
            // 
            // btnObrisiKontakt
            // 
            btnObrisiKontakt.Location = new Point(54, 320);
            btnObrisiKontakt.Name = "btnObrisiKontakt";
            btnObrisiKontakt.Size = new Size(243, 77);
            btnObrisiKontakt.TabIndex = 2;
            btnObrisiKontakt.Text = "Obriši kontakt";
            btnObrisiKontakt.UseVisualStyleBackColor = true;
            btnObrisiKontakt.Click += btnObrisiKontakt_Click;
            // 
            // btnIzmeniKontakt
            // 
            btnIzmeniKontakt.Location = new Point(54, 200);
            btnIzmeniKontakt.Name = "btnIzmeniKontakt";
            btnIzmeniKontakt.Size = new Size(243, 76);
            btnIzmeniKontakt.TabIndex = 1;
            btnIzmeniKontakt.Text = "Izmeni kontakt";
            btnIzmeniKontakt.UseVisualStyleBackColor = true;
            btnIzmeniKontakt.Click += btnIzmeniKontakt_Click;
            // 
            // btnDodajKontakt
            // 
            btnDodajKontakt.Location = new Point(54, 76);
            btnDodajKontakt.Name = "btnDodajKontakt";
            btnDodajKontakt.Size = new Size(243, 76);
            btnDodajKontakt.TabIndex = 0;
            btnDodajKontakt.Text = "Dodaj kontakt";
            btnDodajKontakt.UseVisualStyleBackColor = true;
            btnDodajKontakt.Click += btnDodajKontakt_Click;
            // 
            // SponzorKontaktiForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 900);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
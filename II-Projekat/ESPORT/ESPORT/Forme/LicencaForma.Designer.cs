namespace ESPORT.Forme
{
    partial class LicencaForma
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
            listViewlicenca = new ListView();
            ID = new ColumnHeader();
            idosobe = new ColumnHeader();
            naziv = new ColumnHeader();
            institucija = new ColumnHeader();
            datum = new ColumnHeader();
            btndodaj = new Button();
            btnizmeni = new Button();
            btnobrisi = new Button();
            Imeiprezime = new ColumnHeader();
            SuspendLayout();

            listViewlicenca.Columns.AddRange(new ColumnHeader[] { ID, idosobe, naziv, institucija, datum, Imeiprezime });
            listViewlicenca.FullRowSelect = true;
            listViewlicenca.Location = new Point(101, 112);
            listViewlicenca.Name = "listViewlicenca";
            listViewlicenca.Size = new Size(1157, 668);
            listViewlicenca.TabIndex = 0;
            listViewlicenca.UseCompatibleStateImageBehavior = false;
            listViewlicenca.View = View.Details;

            ID.Text = "ID";

            idosobe.Text = "ID osobe";
            idosobe.Width = 150;

            naziv.Text = "Naziv";
            naziv.Width = 200;

            institucija.Text = "Institucija izdavanja";
            institucija.Width = 300;

            datum.Text = "Datum";
            datum.Width = 200;

            btndodaj.Location = new Point(1368, 147);
            btndodaj.Name = "btndodaj";
            btndodaj.Size = new Size(284, 102);
            btndodaj.TabIndex = 1;
            btndodaj.Text = "Dodaj licencu";
            btndodaj.UseVisualStyleBackColor = true;
            btndodaj.Click += btndodaj_Click;

            btnizmeni.Location = new Point(1368, 300);
            btnizmeni.Name = "btnizmeni";
            btnizmeni.Size = new Size(284, 102);
            btnizmeni.TabIndex = 2;
            btnizmeni.Text = "Izmeni licencu";
            btnizmeni.UseVisualStyleBackColor = true;
            btnizmeni.Click += btnizmeni_Click;

            btnobrisi.Location = new Point(1368, 446);
            btnobrisi.Name = "btnobrisi";
            btnobrisi.Size = new Size(284, 102);
            btnobrisi.TabIndex = 3;
            btnobrisi.Text = "Obrisi licencu";
            btnobrisi.UseVisualStyleBackColor = true;
            btnobrisi.Click += btnobrisi_Click;

            Imeiprezime.Text = "Ime i prezime";
            Imeiprezime.Width = 300;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 1007);
            Controls.Add(btnobrisi);
            Controls.Add(btnizmeni);
            Controls.Add(btndodaj);
            Controls.Add(listViewlicenca);
            Name = "LicencaForma";
            Text = "LicencaForma";
            Load += LicencaForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewlicenca;
        private ColumnHeader ID;
        private ColumnHeader idosobe;
        private ColumnHeader naziv;
        private ColumnHeader institucija;
        private ColumnHeader datum;
        private Button btndodaj;
        private Button btnizmeni;
        private Button btnobrisi;
        private ColumnHeader Imeiprezime;
    }
}
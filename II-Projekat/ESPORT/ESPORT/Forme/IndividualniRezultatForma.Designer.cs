namespace ESPORT.Forme
{
    partial class IndividualniRezultatForma
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
            listViewRezultati = new ListView();

            RezultatId = new ColumnHeader();
            Igrac = new ColumnHeader();
            NazivPriznanja = new ColumnHeader();
            DatumOstvarivanja = new ColumnHeader();
            Takmicenje = new ColumnHeader();
            Opis = new ColumnHeader();

            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();

            SuspendLayout();

            listViewRezultati.Columns.AddRange(new ColumnHeader[]
            {
                RezultatId,
                Igrac,
                NazivPriznanja,
                DatumOstvarivanja,
                Takmicenje,
                Opis
            });

            listViewRezultati.FullRowSelect = true;
            listViewRezultati.GridLines = true;
            listViewRezultati.Location = new Point(20, 20);
            listViewRezultati.MultiSelect = false;
            listViewRezultati.Name = "listViewRezultati";
            listViewRezultati.Size = new Size(900, 420);
            listViewRezultati.TabIndex = 0;
            listViewRezultati.UseCompatibleStateImageBehavior = false;
            listViewRezultati.View = View.Details;

            RezultatId.Text = "ID";
            RezultatId.Width = 60;

            Igrac.Text = "Igrač";
            Igrac.Width = 150;

            NazivPriznanja.Text = "Priznanje";
            NazivPriznanja.Width = 180;

            DatumOstvarivanja.Text = "Datum";
            DatumOstvarivanja.Width = 100;

            Takmicenje.Text = "Takmičenje";
            Takmicenje.Width = 180;

            Opis.Text = "Opis";
            Opis.Width = 230;

            btnDodaj.Location = new Point(20, 460);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 40);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            btnIzmeni.Location = new Point(160, 460);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(120, 40);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnObrisi.Location = new Point(300, 460);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 40);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 530);

            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(listViewRezultati);

            Name = "IndividualniRezultatForma";
            Text = "Individualni rezultati";

            ResumeLayout(false);
        }

        #endregion

        private ListView listViewRezultati;

        private ColumnHeader RezultatId;
        private ColumnHeader Igrac;
        private ColumnHeader NazivPriznanja;
        private ColumnHeader DatumOstvarivanja;
        private ColumnHeader Takmicenje;
        private ColumnHeader Opis;

        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}
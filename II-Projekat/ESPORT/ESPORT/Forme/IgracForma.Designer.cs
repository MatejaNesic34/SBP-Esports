namespace ESPORT.Forme
{
    partial class IgracForma
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
            listViewIgraci = new ListView();
            ID = new ColumnHeader();
            ime = new ColumnHeader();
            prezime = new ColumnHeader();
            nadimak = new ColumnHeader();
            primarnauloga = new ColumnHeader();
            sekundarna_uloga = new ColumnHeader();
            dominantanstiligre = new ColumnHeader();
            rang = new ColumnHeader();
            telefon = new ColumnHeader();
            drzava = new ColumnHeader();
            email = new ColumnHeader();
            status_aranzmana = new ColumnHeader();
            dodajigracabtn = new Button();
            izmeniigracabtn = new Button();
            obrisiigracabtn = new Button();
            btnUgovoriIgraca = new Button();
            btnTransferi = new Button();
            btnPozajmice = new Button();
            btnIndividualniRezultati = new Button();
            SuspendLayout();

            listViewIgraci.Columns.AddRange(new ColumnHeader[] { ID, ime, prezime, nadimak, primarnauloga, sekundarna_uloga, dominantanstiligre, rang, telefon, drzava, email, status_aranzmana });
            listViewIgraci.FullRowSelect = true;
            listViewIgraci.Location = new Point(10, 51);
            listViewIgraci.Margin = new Padding(1, 1, 1, 1);
            listViewIgraci.Name = "listViewIgraci";
            listViewIgraci.Size = new Size(1102, 458);
            listViewIgraci.TabIndex = 0;
            listViewIgraci.UseCompatibleStateImageBehavior = false;
            listViewIgraci.View = View.Details;

            ID.Text = "ID";
            ID.Width = 80;

            ime.Text = "Ime";
            ime.Width = 150;

            prezime.Text = "Prezime";
            prezime.Width = 150;

            nadimak.Text = "Nadimak";
            nadimak.Width = 200;

            primarnauloga.Text = "Primarna Uloga";
            primarnauloga.Width = 200;

            sekundarna_uloga.Text = "Sekundarna Uloga";
            sekundarna_uloga.Width = 200;

            dominantanstiligre.Text = "Dominantan stil igre";
            dominantanstiligre.Width = 300;

            rang.Text = "Rang";
            rang.Width = 200;

            telefon.Text = "Telefon";
            telefon.Width = 200;

            drzava.Text = "Drzava";
            drzava.Width = 220;

            email.Text = "Email";
            email.Width = 220;

            status_aranzmana.Text = "Status aranzmana";
            status_aranzmana.Width = 200;

            dodajigracabtn.Location = new Point(1149, 51);
            dodajigracabtn.Margin = new Padding(1, 1, 1, 1);
            dodajigracabtn.Name = "dodajigracabtn";
            dodajigracabtn.Size = new Size(104, 48);
            dodajigracabtn.TabIndex = 1;
            dodajigracabtn.Text = "Dodaj igraca";
            dodajigracabtn.UseVisualStyleBackColor = true;
            dodajigracabtn.Click += dodajigracabtn_Click;

            izmeniigracabtn.Location = new Point(1148, 101);
            izmeniigracabtn.Margin = new Padding(1, 1, 1, 1);
            izmeniigracabtn.Name = "izmeniigracabtn";
            izmeniigracabtn.Size = new Size(104, 48);
            izmeniigracabtn.TabIndex = 2;
            izmeniigracabtn.Text = "Izmeni igraca";
            izmeniigracabtn.UseVisualStyleBackColor = true;
            izmeniigracabtn.Click += izmeniigracabtn_Click;

            obrisiigracabtn.Location = new Point(1149, 151);
            obrisiigracabtn.Margin = new Padding(1, 1, 1, 1);
            obrisiigracabtn.Name = "obrisiigracabtn";
            obrisiigracabtn.Size = new Size(104, 48);
            obrisiigracabtn.TabIndex = 3;
            obrisiigracabtn.Text = "Obrisi igraca";
            obrisiigracabtn.UseVisualStyleBackColor = true;
            obrisiigracabtn.Click += obrisiigracabtn_Click;

            btnUgovoriIgraca.Location = new Point(1148, 201);
            btnUgovoriIgraca.Margin = new Padding(1, 1, 1, 1);
            btnUgovoriIgraca.Name = "btnUgovoriIgraca";
            btnUgovoriIgraca.Size = new Size(104, 48);
            btnUgovoriIgraca.TabIndex = 4;
            btnUgovoriIgraca.Text = "Ugovori Igraca";
            btnUgovoriIgraca.UseVisualStyleBackColor = true;
            btnUgovoriIgraca.Click += btnUgovoriIgraca_Click;

            btnTransferi.Location = new Point(1150, 250);
            btnTransferi.Margin = new Padding(0, 0, 0, 0);
            btnTransferi.Name = "btnTransferi";
            btnTransferi.Size = new Size(103, 57);
            btnTransferi.TabIndex = 5;
            btnTransferi.Text = "Transferi";
            btnTransferi.UseVisualStyleBackColor = true;
            btnTransferi.Click += btnTransferi_Click;

            btnPozajmice.Location = new Point(1151, 307);
            btnPozajmice.Margin = new Padding(0, 0, 0, 0);
            btnPozajmice.Name = "btnPozajmice";
            btnPozajmice.Size = new Size(102, 57);
            btnPozajmice.TabIndex = 6;
            btnPozajmice.Text = "Pozajmice";
            btnPozajmice.UseVisualStyleBackColor = true;
            btnPozajmice.Click += btnPozajmice_Click;

            btnIndividualniRezultati.Location = new Point(1151, 364);
            btnIndividualniRezultati.Margin = new Padding(0, 0, 0, 0);
            btnIndividualniRezultati.Name = "btnIndividualniRezultati";
            btnIndividualniRezultati.Size = new Size(101, 69);
            btnIndividualniRezultati.TabIndex = 7;
            btnIndividualniRezultati.Text = "Individualni rezultati";
            btnIndividualniRezultati.UseVisualStyleBackColor = true;
            btnIndividualniRezultati.Click += btnIndividualniRezultati_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 519);
            Controls.Add(btnIndividualniRezultati);
            Controls.Add(btnPozajmice);
            Controls.Add(btnUgovoriIgraca);
            Controls.Add(btnTransferi);
            Controls.Add(obrisiigracabtn);
            Controls.Add(izmeniigracabtn);
            Controls.Add(dodajigracabtn);
            Controls.Add(listViewIgraci);
            Margin = new Padding(1, 1, 1, 1);
            Name = "IgracForma";
            Text = "IgracForma";
            Load += IgracForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewIgraci;
        private ColumnHeader ID;
        private ColumnHeader ime;
        private ColumnHeader prezime;
        private ColumnHeader nadimak;
        private ColumnHeader primarnauloga;
        private ColumnHeader sekundarna_uloga;
        private ColumnHeader dominantanstiligre;
        private ColumnHeader rang;
        private ColumnHeader telefon;
        private ColumnHeader drzava;
        private ColumnHeader email;
        private ColumnHeader status_aranzmana;

        private Button dodajigracabtn;
        private Button izmeniigracabtn;
        private Button obrisiigracabtn;
        private Button btnUgovoriIgraca;
        private Button btnTransferi;
        private Button btnPozajmice;
        private Button btnIndividualniRezultati;
    }
}
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewIgraci
            // 
            listViewIgraci.Columns.AddRange(new ColumnHeader[] { ID, ime, prezime, nadimak, primarnauloga, sekundarna_uloga, dominantanstiligre, rang, telefon, drzava, email, status_aranzmana });
            listViewIgraci.FullRowSelect = true;
            listViewIgraci.Location = new Point(76, 60);
            listViewIgraci.Margin = new Padding(2, 2, 2, 2);
            listViewIgraci.Name = "listViewIgraci";
            listViewIgraci.Size = new Size(2337, 935);
            listViewIgraci.TabIndex = 0;
            listViewIgraci.UseCompatibleStateImageBehavior = false;
            listViewIgraci.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // ime
            // 
            ime.Text = "Ime";
            ime.Width = 150;
            // 
            // prezime
            // 
            prezime.Text = "Prezime";
            prezime.Width = 150;
            // 
            // nadimak
            // 
            nadimak.Text = "Nadimak";
            nadimak.Width = 200;
            // 
            // primarnauloga
            // 
            primarnauloga.Text = "Primarna Uloga";
            primarnauloga.Width = 200;
            // 
            // sekundarna_uloga
            // 
            sekundarna_uloga.Text = "Sekundarna Uloga";
            sekundarna_uloga.Width = 200;
            // 
            // dominantanstiligre
            // 
            dominantanstiligre.Text = "Dominantan stil igre";
            dominantanstiligre.Width = 300;
            // 
            // rang
            // 
            rang.Text = "Rang";
            rang.Width = 200;
            // 
            // telefon
            // 
            telefon.Text = "Telefon";
            telefon.Width = 200;
            // 
            // drzava
            // 
            drzava.Text = "Drzava";
            drzava.Width = 220;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 220;
            // 
            // status_aranzmana
            // 
            status_aranzmana.Text = "Status aranzmana";
            status_aranzmana.Width = 200;
            // 
            // dodajigracabtn
            // 
            dodajigracabtn.Location = new Point(25, 66);
            dodajigracabtn.Margin = new Padding(2, 2, 2, 2);
            dodajigracabtn.Name = "dodajigracabtn";
            dodajigracabtn.Size = new Size(254, 98);
            dodajigracabtn.TabIndex = 1;
            dodajigracabtn.Text = "Dodaj igraca";
            dodajigracabtn.UseVisualStyleBackColor = true;
            dodajigracabtn.Click += dodajigracabtn_Click;
            // 
            // izmeniigracabtn
            // 
            izmeniigracabtn.Location = new Point(25, 184);
            izmeniigracabtn.Margin = new Padding(2, 2, 2, 2);
            izmeniigracabtn.Name = "izmeniigracabtn";
            izmeniigracabtn.Size = new Size(254, 98);
            izmeniigracabtn.TabIndex = 2;
            izmeniigracabtn.Text = "Izmeni igraca";
            izmeniigracabtn.UseVisualStyleBackColor = true;
            izmeniigracabtn.Click += izmeniigracabtn_Click;
            // 
            // obrisiigracabtn
            // 
            obrisiigracabtn.Location = new Point(25, 302);
            obrisiigracabtn.Margin = new Padding(2, 2, 2, 2);
            obrisiigracabtn.Name = "obrisiigracabtn";
            obrisiigracabtn.Size = new Size(254, 98);
            obrisiigracabtn.TabIndex = 3;
            obrisiigracabtn.Text = "Obrisi igraca";
            obrisiigracabtn.UseVisualStyleBackColor = true;
            obrisiigracabtn.Click += obrisiigracabtn_Click;
            // 
            // btnUgovoriIgraca
            // 
            btnUgovoriIgraca.Location = new Point(25, 425);
            btnUgovoriIgraca.Margin = new Padding(2, 2, 2, 2);
            btnUgovoriIgraca.Name = "btnUgovoriIgraca";
            btnUgovoriIgraca.Size = new Size(254, 98);
            btnUgovoriIgraca.TabIndex = 4;
            btnUgovoriIgraca.Text = "Ugovori Igraca";
            btnUgovoriIgraca.UseVisualStyleBackColor = true;
            btnUgovoriIgraca.Click += btnUgovoriIgraca_Click;
            // 
            // btnTransferi
            // 
            btnTransferi.Location = new Point(25, 182);
            btnTransferi.Margin = new Padding(0);
            btnTransferi.Name = "btnTransferi";
            btnTransferi.Size = new Size(254, 98);
            btnTransferi.TabIndex = 5;
            btnTransferi.Text = "Transferi";
            btnTransferi.UseVisualStyleBackColor = true;
            btnTransferi.Click += btnTransferi_Click;
            // 
            // btnPozajmice
            // 
            btnPozajmice.Location = new Point(25, 62);
            btnPozajmice.Margin = new Padding(0);
            btnPozajmice.Name = "btnPozajmice";
            btnPozajmice.Size = new Size(254, 98);
            btnPozajmice.TabIndex = 6;
            btnPozajmice.Text = "Pozajmice";
            btnPozajmice.UseVisualStyleBackColor = true;
            btnPozajmice.Click += btnPozajmice_Click;
            // 
            // btnIndividualniRezultati
            // 
            btnIndividualniRezultati.Location = new Point(25, 305);
            btnIndividualniRezultati.Margin = new Padding(0);
            btnIndividualniRezultati.Name = "btnIndividualniRezultati";
            btnIndividualniRezultati.Size = new Size(254, 98);
            btnIndividualniRezultati.TabIndex = 7;
            btnIndividualniRezultati.Text = "Individualni rezultati";
            btnIndividualniRezultati.UseVisualStyleBackColor = true;
            btnIndividualniRezultati.Click += btnIndividualniRezultati_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dodajigracabtn);
            groupBox1.Controls.Add(izmeniigracabtn);
            groupBox1.Controls.Add(obrisiigracabtn);
            groupBox1.Location = new Point(2440, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 428);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Igrac";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUgovoriIgraca);
            groupBox2.Controls.Add(btnTransferi);
            groupBox2.Controls.Add(btnIndividualniRezultati);
            groupBox2.Controls.Add(btnPozajmice);
            groupBox2.Location = new Point(2440, 486);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 556);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operacije";
            // 
            // IgracForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2805, 1064);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listViewIgraci);
            Margin = new Padding(2, 2, 2, 2);
            Name = "IgracForma";
            Text = "IgracForma";
            Load += IgracForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
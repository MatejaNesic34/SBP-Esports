namespace ESPORT.Forme
{
    partial class SponzoriForma
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
            listViewSponzori = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Drzava = new ColumnHeader();
            TipSponzora = new ColumnHeader();
            OblastPoslovanja = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnUgovori = new Button();
            btnKontakti = new Button();
            obrisiSponzorbtn = new Button();
            izmeniSponzorbtn = new Button();
            dodajSponzorbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewSponzori.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Drzava, TipSponzora, OblastPoslovanja });
            listViewSponzori.FullRowSelect = true;
            listViewSponzori.Location = new Point(11, 27);
            listViewSponzori.Margin = new Padding(1);
            listViewSponzori.MultiSelect = false;
            listViewSponzori.Name = "listViewSponzori";
            listViewSponzori.Size = new Size(654, 324);
            listViewSponzori.TabIndex = 0;
            listViewSponzori.UseCompatibleStateImageBehavior = false;
            listViewSponzori.View = View.Details;

            ID.Text = "ID";
            ID.Width = 50;

            Naziv.Text = "Naziv";
            Naziv.Width = 150;

            Drzava.Text = "Država";
            Drzava.Width = 80;

            TipSponzora.Text = "Tip sponzora";
            TipSponzora.Width = 150;

            OblastPoslovanja.Text = "Oblast poslovanja";
            OblastPoslovanja.Width = 200;

            groupBox1.Controls.Add(listViewSponzori);
            groupBox1.Location = new Point(19, 31);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(675, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz sponzora";

            groupBox2.Controls.Add(btnUgovori);
            groupBox2.Controls.Add(btnKontakti);
            groupBox2.Controls.Add(obrisiSponzorbtn);
            groupBox2.Controls.Add(izmeniSponzorbtn);
            groupBox2.Controls.Add(dodajSponzorbtn);
            groupBox2.Location = new Point(722, 39);
            groupBox2.Margin = new Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1);
            groupBox2.Size = new Size(165, 355);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sponzori akcije";

            btnUgovori.Location = new Point(29, 289);
            btnUgovori.Margin = new Padding(1);
            btnUgovori.Name = "btnUgovori";
            btnUgovori.Size = new Size(114, 38);
            btnUgovori.TabIndex = 4;
            btnUgovori.Text = "Ugovori";
            btnUgovori.UseVisualStyleBackColor = true;
            btnUgovori.Click += btnUgovori_Click;

            btnKontakti.Location = new Point(29, 224);
            btnKontakti.Margin = new Padding(1);
            btnKontakti.Name = "btnKontakti";
            btnKontakti.Size = new Size(114, 38);
            btnKontakti.TabIndex = 3;
            btnKontakti.Text = "Kontakti";
            btnKontakti.UseVisualStyleBackColor = true;
            btnKontakti.Click += btnKontakti_Click;

            obrisiSponzorbtn.Location = new Point(29, 156);
            obrisiSponzorbtn.Margin = new Padding(1);
            obrisiSponzorbtn.Name = "obrisiSponzorbtn";
            obrisiSponzorbtn.Size = new Size(114, 38);
            obrisiSponzorbtn.TabIndex = 2;
            obrisiSponzorbtn.Text = "Obrisi sponzora";
            obrisiSponzorbtn.UseVisualStyleBackColor = true;
            obrisiSponzorbtn.Click += obrisiSponzorbtn_Click;

            izmeniSponzorbtn.Location = new Point(29, 98);
            izmeniSponzorbtn.Margin = new Padding(1);
            izmeniSponzorbtn.Name = "izmeniSponzorbtn";
            izmeniSponzorbtn.Size = new Size(114, 37);
            izmeniSponzorbtn.TabIndex = 1;
            izmeniSponzorbtn.Text = "Izmeni sponzora";
            izmeniSponzorbtn.UseVisualStyleBackColor = true;
            izmeniSponzorbtn.Click += izmeniSponzorbtn_Click;

            dodajSponzorbtn.Location = new Point(29, 37);
            dodajSponzorbtn.Margin = new Padding(1);
            dodajSponzorbtn.Name = "dodajSponzorbtn";
            dodajSponzorbtn.Size = new Size(114, 37);
            dodajSponzorbtn.TabIndex = 0;
            dodajSponzorbtn.Text = "Dodaj sponzora";
            dodajSponzorbtn.UseVisualStyleBackColor = true;
            dodajSponzorbtn.Click += dodajSponzorbtn_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 439);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(1);
            Name = "SponzoriForma";
            Text = "SponzoriForma";
            Load += SponzoriForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewSponzori;
        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Drzava;
        private ColumnHeader TipSponzora;
        private ColumnHeader OblastPoslovanja;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button obrisiSponzorbtn;
        private Button izmeniSponzorbtn;
        private Button dodajSponzorbtn;
        private Button btnUgovori;
        private Button btnKontakti;
    }
}
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
            // 
            // listViewSponzori
            // 
            listViewSponzori.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Drzava, TipSponzora, OblastPoslovanja });
            listViewSponzori.FullRowSelect = true;
            listViewSponzori.Location = new Point(23, 55);
            listViewSponzori.Margin = new Padding(2, 2, 2, 2);
            listViewSponzori.MultiSelect = false;
            listViewSponzori.Name = "listViewSponzori";
            listViewSponzori.Size = new Size(1385, 660);
            listViewSponzori.TabIndex = 0;
            listViewSponzori.UseCompatibleStateImageBehavior = false;
            listViewSponzori.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 250;
            // 
            // Drzava
            // 
            Drzava.Text = "Država";
            Drzava.Width = 250;
            // 
            // TipSponzora
            // 
            TipSponzora.Text = "Tip sponzora";
            TipSponzora.Width = 250;
            // 
            // OblastPoslovanja
            // 
            OblastPoslovanja.Text = "Oblast poslovanja";
            OblastPoslovanja.Width = 250;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewSponzori);
            groupBox1.Location = new Point(40, 64);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(1434, 744);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz sponzora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUgovori);
            groupBox2.Controls.Add(btnKontakti);
            groupBox2.Controls.Add(obrisiSponzorbtn);
            groupBox2.Controls.Add(izmeniSponzorbtn);
            groupBox2.Controls.Add(dodajSponzorbtn);
            groupBox2.Location = new Point(1534, 80);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(351, 728);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sponzori akcije";
            // 
            // btnUgovori
            // 
            btnUgovori.Location = new Point(62, 592);
            btnUgovori.Margin = new Padding(2, 2, 2, 2);
            btnUgovori.Name = "btnUgovori";
            btnUgovori.Size = new Size(242, 78);
            btnUgovori.TabIndex = 4;
            btnUgovori.Text = "Ugovori";
            btnUgovori.UseVisualStyleBackColor = true;
            btnUgovori.Click += btnUgovori_Click;
            // 
            // btnKontakti
            // 
            btnKontakti.Location = new Point(62, 459);
            btnKontakti.Margin = new Padding(2, 2, 2, 2);
            btnKontakti.Name = "btnKontakti";
            btnKontakti.Size = new Size(242, 78);
            btnKontakti.TabIndex = 3;
            btnKontakti.Text = "Kontakti";
            btnKontakti.UseVisualStyleBackColor = true;
            btnKontakti.Click += btnKontakti_Click;
            // 
            // obrisiSponzorbtn
            // 
            obrisiSponzorbtn.Location = new Point(62, 320);
            obrisiSponzorbtn.Margin = new Padding(2, 2, 2, 2);
            obrisiSponzorbtn.Name = "obrisiSponzorbtn";
            obrisiSponzorbtn.Size = new Size(242, 78);
            obrisiSponzorbtn.TabIndex = 2;
            obrisiSponzorbtn.Text = "Obrisi sponzora";
            obrisiSponzorbtn.UseVisualStyleBackColor = true;
            obrisiSponzorbtn.Click += obrisiSponzorbtn_Click;
            // 
            // izmeniSponzorbtn
            // 
            izmeniSponzorbtn.Location = new Point(62, 201);
            izmeniSponzorbtn.Margin = new Padding(2, 2, 2, 2);
            izmeniSponzorbtn.Name = "izmeniSponzorbtn";
            izmeniSponzorbtn.Size = new Size(242, 76);
            izmeniSponzorbtn.TabIndex = 1;
            izmeniSponzorbtn.Text = "Izmeni sponzora";
            izmeniSponzorbtn.UseVisualStyleBackColor = true;
            izmeniSponzorbtn.Click += izmeniSponzorbtn_Click;
            // 
            // dodajSponzorbtn
            // 
            dodajSponzorbtn.Location = new Point(62, 76);
            dodajSponzorbtn.Margin = new Padding(2, 2, 2, 2);
            dodajSponzorbtn.Name = "dodajSponzorbtn";
            dodajSponzorbtn.Size = new Size(242, 76);
            dodajSponzorbtn.TabIndex = 0;
            dodajSponzorbtn.Text = "Dodaj sponzora";
            dodajSponzorbtn.UseVisualStyleBackColor = true;
            dodajSponzorbtn.Click += dodajSponzorbtn_Click;
            // 
            // SponzoriForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1938, 900);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
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
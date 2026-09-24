namespace ESPORT.Forme
{
    partial class TimoviForma
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
            listViewTimovi = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Igra = new ColumnHeader();
            DatumOsnivanja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Status = new ColumnHeader();
            Nivo = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnAngazmaniZaposlenih = new Button();
            btnAngazmaniTrenera = new Button();
            obrisitimbtn = new Button();
            izmenitimbtn = new Button();
            dodajtimbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewTimovi
            // 
            listViewTimovi.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Igra, DatumOsnivanja, Drzava, Status, Nivo });
            listViewTimovi.FullRowSelect = true;
            listViewTimovi.Location = new Point(23, 55);
            listViewTimovi.Margin = new Padding(2, 2, 2, 2);
            listViewTimovi.MultiSelect = false;
            listViewTimovi.Name = "listViewTimovi";
            listViewTimovi.Size = new Size(1347, 660);
            listViewTimovi.TabIndex = 0;
            listViewTimovi.UseCompatibleStateImageBehavior = false;
            listViewTimovi.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 220;
            // 
            // Igra
            // 
            Igra.Text = "Igra";
            Igra.Width = 180;
            // 
            // DatumOsnivanja
            // 
            DatumOsnivanja.Text = "Datum osnivanja";
            DatumOsnivanja.Width = 250;
            // 
            // Drzava
            // 
            Drzava.Text = "Država registracije";
            Drzava.Width = 250;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 150;
            // 
            // Nivo
            // 
            Nivo.Text = "Nivo takmičenja";
            Nivo.Width = 240;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewTimovi);
            groupBox1.Location = new Point(40, 64);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(1413, 744);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz timova";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAngazmaniZaposlenih);
            groupBox2.Controls.Add(btnAngazmaniTrenera);
            groupBox2.Controls.Add(obrisitimbtn);
            groupBox2.Controls.Add(izmenitimbtn);
            groupBox2.Controls.Add(dodajtimbtn);
            groupBox2.Location = new Point(1481, 119);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(497, 660);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Timovi akcije";
            // 
            // btnAngazmaniZaposlenih
            // 
            btnAngazmaniZaposlenih.Location = new Point(62, 521);
            btnAngazmaniZaposlenih.Margin = new Padding(2, 2, 2, 2);
            btnAngazmaniZaposlenih.Name = "btnAngazmaniZaposlenih";
            btnAngazmaniZaposlenih.Size = new Size(382, 92);
            btnAngazmaniZaposlenih.TabIndex = 4;
            btnAngazmaniZaposlenih.Text = "Angažmani zaposlenih";
            btnAngazmaniZaposlenih.UseVisualStyleBackColor = true;
            btnAngazmaniZaposlenih.Click += btnAngazmaniZaposlenih_Click;
            // 
            // btnAngazmaniTrenera
            // 
            btnAngazmaniTrenera.Location = new Point(62, 424);
            btnAngazmaniTrenera.Margin = new Padding(2, 2, 2, 2);
            btnAngazmaniTrenera.Name = "btnAngazmaniTrenera";
            btnAngazmaniTrenera.Size = new Size(382, 78);
            btnAngazmaniTrenera.TabIndex = 3;
            btnAngazmaniTrenera.Text = "Angažmani trenera";
            btnAngazmaniTrenera.UseVisualStyleBackColor = true;
            btnAngazmaniTrenera.Click += btnAngazmaniTrenera_Click;
            // 
            // obrisitimbtn
            // 
            obrisitimbtn.Location = new Point(62, 320);
            obrisitimbtn.Margin = new Padding(2, 2, 2, 2);
            obrisitimbtn.Name = "obrisitimbtn";
            obrisitimbtn.Size = new Size(242, 78);
            obrisitimbtn.TabIndex = 2;
            obrisitimbtn.Text = "Obrisi tim";
            obrisitimbtn.UseVisualStyleBackColor = true;
            obrisitimbtn.Click += obrisitimbtn_Click;
            // 
            // izmenitimbtn
            // 
            izmenitimbtn.Location = new Point(62, 201);
            izmenitimbtn.Margin = new Padding(2, 2, 2, 2);
            izmenitimbtn.Name = "izmenitimbtn";
            izmenitimbtn.Size = new Size(242, 76);
            izmenitimbtn.TabIndex = 1;
            izmenitimbtn.Text = "Izmeni tim";
            izmenitimbtn.UseVisualStyleBackColor = true;
            izmenitimbtn.Click += izmenitimbtn_Click;
            // 
            // dodajtimbtn
            // 
            dodajtimbtn.Location = new Point(62, 76);
            dodajtimbtn.Margin = new Padding(2, 2, 2, 2);
            dodajtimbtn.Name = "dodajtimbtn";
            dodajtimbtn.Size = new Size(242, 76);
            dodajtimbtn.TabIndex = 0;
            dodajtimbtn.Text = "Dodaj tim";
            dodajtimbtn.UseVisualStyleBackColor = true;
            dodajtimbtn.Click += dodajtimbtn_Click;
            // 
            // TimoviForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 898);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TimoviForma";
            Text = "TimoviForma";
            Load += TimoviForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTimovi;

        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Igra;
        private ColumnHeader DatumOsnivanja;
        private ColumnHeader Drzava;
        private ColumnHeader Status;
        private ColumnHeader Nivo;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button obrisitimbtn;
        private Button izmenitimbtn;
        private Button dodajtimbtn;
        private Button btnAngazmaniTrenera;
        private Button btnAngazmaniZaposlenih;
    }
}
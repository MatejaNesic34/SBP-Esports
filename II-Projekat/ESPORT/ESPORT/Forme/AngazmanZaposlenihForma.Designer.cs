namespace ESPORT.Forme
{
    partial class AngazmanZaposlenihForma
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListView listViewAngazmaniZaposlenih;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;

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
            listViewAngazmaniZaposlenih = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();

            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();

            SuspendLayout();

            listViewAngazmaniZaposlenih.Columns.AddRange(
                new ColumnHeader[]
                {
                    columnHeader1,
                    columnHeader2,
                    columnHeader3,
                    columnHeader4,
                    columnHeader5,
                    columnHeader6,
                    columnHeader7
                });

            listViewAngazmaniZaposlenih.FullRowSelect = true;
            listViewAngazmaniZaposlenih.GridLines = true;
            listViewAngazmaniZaposlenih.Location = new Point(12, 12);
            listViewAngazmaniZaposlenih.Name =
                "listViewAngazmaniZaposlenih";
            listViewAngazmaniZaposlenih.Size =
                new Size(900, 400);
            listViewAngazmaniZaposlenih.TabIndex = 0;
            listViewAngazmaniZaposlenih.UseCompatibleStateImageBehavior = false;
            listViewAngazmaniZaposlenih.View = View.Details;

            columnHeader1.Text = "ID";
            columnHeader1.Width = 60;

            columnHeader2.Text = "Osoba";
            columnHeader2.Width = 180;

            columnHeader3.Text = "Tim";
            columnHeader3.Width = 150;

            columnHeader4.Text = "Uloga";
            columnHeader4.Width = 150;

            columnHeader5.Text = "Datum od";
            columnHeader5.Width = 110;

            columnHeader6.Text = "Datum do";
            columnHeader6.Width = 110;

            columnHeader7.Text = "Plata";
            columnHeader7.Width = 100;

            btnDodaj.Location = new Point(12, 430);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 45);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            btnIzmeni.Location = new Point(158, 430);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(130, 45);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnObrisi.Location = new Point(304, 430);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 45);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 500);

            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(listViewAngazmaniZaposlenih);

            Name = "AngazmanZaposlenihForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Angažmani zaposlenih";
            Load += AngazmanZaposlenihForma_Load;

            ResumeLayout(false);
        }
    }
}
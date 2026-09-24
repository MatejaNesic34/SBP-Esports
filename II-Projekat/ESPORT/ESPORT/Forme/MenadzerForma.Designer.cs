namespace ESPORT.Forme
{
    partial class MenadzerForma
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
            listViewMenazer = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Datum_Rodjenja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Email = new ColumnHeader();
            Status_aranzmana = new ColumnHeader();
            oblastodgovornosti = new ColumnHeader();
            btndodajmenadzera = new Button();
            btnizmenimenadzera = new Button();
            btnizbrisimenadzera = new Button();
            SuspendLayout();

            listViewMenazer.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, Datum_Rodjenja, Drzava, Email, Status_aranzmana, oblastodgovornosti });
            listViewMenazer.FullRowSelect = true;
            listViewMenazer.Location = new Point(71, 113);
            listViewMenazer.Name = "listViewMenazer";
            listViewMenazer.Size = new Size(1704, 820);
            listViewMenazer.TabIndex = 1;
            listViewMenazer.UseCompatibleStateImageBehavior = false;
            listViewMenazer.View = View.Details;

            ID.Text = "ID";
            ID.Width = 80;

            Ime.Text = "Ime";
            Ime.Width = 220;

            Prezime.Text = "Prezime";
            Prezime.Width = 220;

            Datum_Rodjenja.Text = "Datum rodjenja";
            Datum_Rodjenja.Width = 230;

            Drzava.Text = "Drzava";
            Drzava.Width = 200;

            Email.Text = "Email";
            Email.Width = 250;

            Status_aranzmana.Text = "Status aranzmana";
            Status_aranzmana.Width = 250;

            oblastodgovornosti.Text = "Oblast odgovornosti";
            oblastodgovornosti.Width = 200;

            btndodajmenadzera.Location = new Point(1910, 171);
            btndodajmenadzera.Name = "btndodajmenadzera";
            btndodajmenadzera.Size = new Size(297, 111);
            btndodajmenadzera.TabIndex = 2;
            btndodajmenadzera.Text = "Dodaj menadzera";
            btndodajmenadzera.UseVisualStyleBackColor = true;
            btndodajmenadzera.Click += btndodajmenadzera_Click;

            btnizmenimenadzera.Location = new Point(1910, 330);
            btnizmenimenadzera.Name = "btnizmenimenadzera";
            btnizmenimenadzera.Size = new Size(297, 111);
            btnizmenimenadzera.TabIndex = 3;
            btnizmenimenadzera.Text = "Izmeni menadzera";
            btnizmenimenadzera.UseVisualStyleBackColor = true;
            btnizmenimenadzera.Click += btnizmenimenadzera_Click;

            btnizbrisimenadzera.Location = new Point(1910, 490);
            btnizbrisimenadzera.Name = "btnizbrisimenadzera";
            btnizbrisimenadzera.Size = new Size(297, 111);
            btnizbrisimenadzera.TabIndex = 4;
            btnizbrisimenadzera.Text = "Izbrisi menadzera";
            btnizbrisimenadzera.UseVisualStyleBackColor = true;
            btnizbrisimenadzera.Click += btnizbrisimenadzera_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2419, 1322);
            Controls.Add(btnizbrisimenadzera);
            Controls.Add(btnizmenimenadzera);
            Controls.Add(btndodajmenadzera);
            Controls.Add(listViewMenazer);
            Name = "MenadzerForma";
            Text = "MenadzerForma";
            Load += MenadzerForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewMenazer;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Datum_Rodjenja;
        private ColumnHeader Drzava;
        private ColumnHeader Email;
        private ColumnHeader Status_aranzmana;
        private ColumnHeader oblastodgovornosti;
        private Button btndodajmenadzera;
        private Button btnizmenimenadzera;
        private Button btnizbrisimenadzera;
    }
}
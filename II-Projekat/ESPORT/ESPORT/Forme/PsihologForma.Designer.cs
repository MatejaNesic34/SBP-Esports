namespace ESPORT.Forme
{
    partial class PsihologForma
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
            listViewpsiholog = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Datum_Rodjenja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Email = new ColumnHeader();
            Status_aranzmana = new ColumnHeader();
            oblastrada = new ColumnHeader();
            perioddostupnosti = new ColumnHeader();
            btndodajpshiloga = new Button();
            btnizmenipsihologa = new Button();
            btnobrisipsihologa = new Button();
            btnlicenca = new Button();
            btnangazmanzaposlenih = new Button();
            SuspendLayout();
            // 
            // listViewpsiholog
            // 
            listViewpsiholog.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, Datum_Rodjenja, Drzava, Email, Status_aranzmana, oblastrada, perioddostupnosti });
            listViewpsiholog.FullRowSelect = true;
            listViewpsiholog.Location = new Point(69, 68);
            listViewpsiholog.Name = "listViewpsiholog";
            listViewpsiholog.Size = new Size(1869, 820);
            listViewpsiholog.TabIndex = 1;
            listViewpsiholog.UseCompatibleStateImageBehavior = false;
            listViewpsiholog.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // Ime
            // 
            Ime.Text = "Ime";
            Ime.Width = 220;
            // 
            // Prezime
            // 
            Prezime.Text = "Prezime";
            Prezime.Width = 220;
            // 
            // Datum_Rodjenja
            // 
            Datum_Rodjenja.Text = "Datum rodjenja";
            Datum_Rodjenja.Width = 230;
            // 
            // Drzava
            // 
            Drzava.Text = "Drzava";
            Drzava.Width = 200;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 250;
            // 
            // Status_aranzmana
            // 
            Status_aranzmana.Text = "Status aranzmana";
            Status_aranzmana.Width = 250;
            // 
            // oblastrada
            // 
            oblastrada.Text = "Oblast rada";
            oblastrada.Width = 200;
            // 
            // perioddostupnosti
            // 
            perioddostupnosti.Text = "Period dostupnosti";
            perioddostupnosti.Width = 200;
            // 
            // btndodajpshiloga
            // 
            btndodajpshiloga.Location = new Point(2028, 116);
            btndodajpshiloga.Name = "btndodajpshiloga";
            btndodajpshiloga.Size = new Size(268, 117);
            btndodajpshiloga.TabIndex = 2;
            btndodajpshiloga.Text = "Dodaj psihologa";
            btndodajpshiloga.UseVisualStyleBackColor = true;
            btndodajpshiloga.Click += btndodajpshiloga_Click;
            // 
            // btnizmenipsihologa
            // 
            btnizmenipsihologa.Location = new Point(2028, 275);
            btnizmenipsihologa.Name = "btnizmenipsihologa";
            btnizmenipsihologa.Size = new Size(268, 117);
            btnizmenipsihologa.TabIndex = 3;
            btnizmenipsihologa.Text = "Izmeni psihologa";
            btnizmenipsihologa.UseVisualStyleBackColor = true;
            btnizmenipsihologa.Click += btnizmenipsihologa_Click;
            // 
            // btnobrisipsihologa
            // 
            btnobrisipsihologa.Location = new Point(2028, 429);
            btnobrisipsihologa.Name = "btnobrisipsihologa";
            btnobrisipsihologa.Size = new Size(268, 117);
            btnobrisipsihologa.TabIndex = 4;
            btnobrisipsihologa.Text = "Obrisi psihologa";
            btnobrisipsihologa.UseVisualStyleBackColor = true;
            btnobrisipsihologa.Click += btnobrisipsihologa_Click;
            // 
            // btnlicenca
            // 
            btnlicenca.Location = new Point(2028, 643);
            btnlicenca.Name = "btnlicenca";
            btnlicenca.Size = new Size(268, 117);
            btnlicenca.TabIndex = 5;
            btnlicenca.Text = "Licenca";
            btnlicenca.UseVisualStyleBackColor = true;
            btnlicenca.Click += btnlicenca_Click;
            // 
            // btnangazmanzaposlenih
            // 
            btnangazmanzaposlenih.Location = new Point(2028, 783);
            btnangazmanzaposlenih.Name = "btnangazmanzaposlenih";
            btnangazmanzaposlenih.Size = new Size(268, 117);
            btnangazmanzaposlenih.TabIndex = 7;
            btnangazmanzaposlenih.Text = "Angazman zaposlenih";
            btnangazmanzaposlenih.UseVisualStyleBackColor = true;
            btnangazmanzaposlenih.Click += btnangazmanzaposlenih_Click;
            // 
            // PsihologForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2396, 1000);
            Controls.Add(btnangazmanzaposlenih);
            Controls.Add(btnlicenca);
            Controls.Add(btnobrisipsihologa);
            Controls.Add(btnizmenipsihologa);
            Controls.Add(btndodajpshiloga);
            Controls.Add(listViewpsiholog);
            Name = "PsihologForma";
            Text = "PsihologForma";
            Load += PsihologForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewpsiholog;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Datum_Rodjenja;
        private ColumnHeader Drzava;
        private ColumnHeader Email;
        private ColumnHeader Status_aranzmana;
        private ColumnHeader oblastrada;
        private ColumnHeader perioddostupnosti;
        private Button btndodajpshiloga;
        private Button btnizmenipsihologa;
        private Button btnobrisipsihologa;
        private Button btnlicenca;
        private Button btnangazmanzaposlenih;
    }
}
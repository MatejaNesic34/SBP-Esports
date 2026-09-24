namespace ESPORT.Forme
{
    partial class AnaliticarForm
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
            listViewAnaliticari = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            datumrodjenja = new ColumnHeader();
            drzava = new ColumnHeader();
            email = new ColumnHeader();
            datumprvogangazovanja = new ColumnHeader();
            statusangazmana = new ColumnHeader();
            oblastanalize = new ColumnHeader();
            alati = new ColumnHeader();
            nivoiskustva = new ColumnHeader();
            dodajanaliticarabtn = new Button();
            izmenianaliticarabtn = new Button();
            obrisianaliticarabtn = new Button();
            SuspendLayout();

            listViewAnaliticari.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, datumrodjenja, drzava, email, datumprvogangazovanja, statusangazmana, oblastanalize, alati, nivoiskustva });
            listViewAnaliticari.FullRowSelect = true;
            listViewAnaliticari.Location = new Point(32, 96);
            listViewAnaliticari.Name = "listViewAnaliticari";
            listViewAnaliticari.Size = new Size(2002, 1080);
            listViewAnaliticari.TabIndex = 0;
            listViewAnaliticari.UseCompatibleStateImageBehavior = false;
            listViewAnaliticari.View = View.Details;

            ID.Text = "ID";
            ID.Width = 80;

            Ime.Text = "Ime";
            Ime.Width = 150;

            Prezime.Text = "Prezime";
            Prezime.Width = 150;

            datumrodjenja.Text = "Datum rodjenja";
            datumrodjenja.Width = 200;

            drzava.Text = "Drzava";
            drzava.Width = 200;

            email.Text = "Email";
            email.Width = 200;

            datumprvogangazovanja.Text = "Datum prvog angazovanja";
            datumprvogangazovanja.Width = 200;

            statusangazmana.Text = "Status angazmana";
            statusangazmana.Width = 200;

            oblastanalize.Text = "Oblast analize";
            oblastanalize.Width = 200;

            alati.Text = "Alati";
            alati.Width = 200;

            nivoiskustva.Text = "Nivo iskustva";
            nivoiskustva.Width = 200;

            dodajanaliticarabtn.Location = new Point(2135, 120);
            dodajanaliticarabtn.Name = "dodajanaliticarabtn";
            dodajanaliticarabtn.Size = new Size(330, 111);
            dodajanaliticarabtn.TabIndex = 1;
            dodajanaliticarabtn.Text = "Dodaj analiticara";
            dodajanaliticarabtn.UseVisualStyleBackColor = true;
            dodajanaliticarabtn.Click += dodajanaliticarabtn_Click;

            izmenianaliticarabtn.Location = new Point(2135, 268);
            izmenianaliticarabtn.Name = "izmenianaliticarabtn";
            izmenianaliticarabtn.Size = new Size(330, 111);
            izmenianaliticarabtn.TabIndex = 2;
            izmenianaliticarabtn.Text = "Izmeni analiticara";
            izmenianaliticarabtn.UseVisualStyleBackColor = true;
            izmenianaliticarabtn.Click += izmenianaliticarabtn_Click;

            obrisianaliticarabtn.Location = new Point(2135, 413);
            obrisianaliticarabtn.Name = "obrisianaliticarabtn";
            obrisianaliticarabtn.Size = new Size(330, 111);
            obrisianaliticarabtn.TabIndex = 3;
            obrisianaliticarabtn.Text = "Obrisi analiticara";
            obrisianaliticarabtn.UseVisualStyleBackColor = true;
            obrisianaliticarabtn.Click += obrisianaliticarabtn_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2582, 1258);
            Controls.Add(obrisianaliticarabtn);
            Controls.Add(izmenianaliticarabtn);
            Controls.Add(dodajanaliticarabtn);
            Controls.Add(listViewAnaliticari);
            Name = "AnaliticarForm";
            Text = "AnaliticarForm";
            Load += AnaliticarForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAnaliticari;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader datumrodjenja;
        private ColumnHeader drzava;
        private ColumnHeader email;
        private ColumnHeader datumprvogangazovanja;
        private ColumnHeader statusangazmana;
        private ColumnHeader oblastanalize;
        private ColumnHeader alati;
        private ColumnHeader nivoiskustva;
        private Button dodajanaliticarabtn;
        private Button izmenianaliticarabtn;
        private Button obrisianaliticarabtn;
    }
}
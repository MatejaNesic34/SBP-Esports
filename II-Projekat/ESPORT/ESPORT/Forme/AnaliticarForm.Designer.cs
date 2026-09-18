namespace ESPORT.Forme
{
    partial class AnaliticarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            // 
            // listViewAnaliticari
            // 
            listViewAnaliticari.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, datumrodjenja, drzava, email, datumprvogangazovanja, statusangazmana, oblastanalize, alati, nivoiskustva });
            listViewAnaliticari.FullRowSelect = true;
            listViewAnaliticari.Location = new Point(32, 96);
            listViewAnaliticari.Name = "listViewAnaliticari";
            listViewAnaliticari.Size = new Size(2002, 1080);
            listViewAnaliticari.TabIndex = 0;
            listViewAnaliticari.UseCompatibleStateImageBehavior = false;
            listViewAnaliticari.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // Ime
            // 
            Ime.Text = "Ime";
            Ime.Width = 150;
            // 
            // Prezime
            // 
            Prezime.Text = "Prezime";
            Prezime.Width = 150;
            // 
            // datumrodjenja
            // 
            datumrodjenja.Text = "Datum rodjenja";
            datumrodjenja.Width = 200;
            // 
            // drzava
            // 
            drzava.Text = "Drzava";
            drzava.Width = 200;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 200;
            // 
            // datumprvogangazovanja
            // 
            datumprvogangazovanja.Text = "Datum prvog angazovanja";
            datumprvogangazovanja.Width = 200;
            // 
            // statusangazmana
            // 
            statusangazmana.Text = "Status angazmana";
            statusangazmana.Width = 200;
            // 
            // oblastanalize
            // 
            oblastanalize.Text = "Oblast analize";
            oblastanalize.Width = 200;
            // 
            // alati
            // 
            alati.Text = "Alati";
            alati.Width = 200;
            // 
            // nivoiskustva
            // 
            nivoiskustva.Text = "Nivo iskustva";
            nivoiskustva.Width = 200;
            // 
            // dodajanaliticarabtn
            // 
            dodajanaliticarabtn.Location = new Point(2135, 120);
            dodajanaliticarabtn.Name = "dodajanaliticarabtn";
            dodajanaliticarabtn.Size = new Size(330, 111);
            dodajanaliticarabtn.TabIndex = 1;
            dodajanaliticarabtn.Text = "Dodaj analiticara";
            dodajanaliticarabtn.UseVisualStyleBackColor = true;
            dodajanaliticarabtn.Click += dodajanaliticarabtn_Click;
            // 
            // izmenianaliticarabtn
            // 
            izmenianaliticarabtn.Location = new Point(2135, 268);
            izmenianaliticarabtn.Name = "izmenianaliticarabtn";
            izmenianaliticarabtn.Size = new Size(330, 111);
            izmenianaliticarabtn.TabIndex = 2;
            izmenianaliticarabtn.Text = "Izmeni analiticara";
            izmenianaliticarabtn.UseVisualStyleBackColor = true;
            izmenianaliticarabtn.Click += izmenianaliticarabtn_Click;
            // 
            // obrisianaliticarabtn
            // 
            obrisianaliticarabtn.Location = new Point(2135, 413);
            obrisianaliticarabtn.Name = "obrisianaliticarabtn";
            obrisianaliticarabtn.Size = new Size(330, 111);
            obrisianaliticarabtn.TabIndex = 3;
            obrisianaliticarabtn.Text = "Obrisi analiticara";
            obrisianaliticarabtn.UseVisualStyleBackColor = true;
            obrisianaliticarabtn.Click += obrisianaliticarabtn_Click;
            // 
            // AnaliticarForm
            // 
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
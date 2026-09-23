namespace ESPORT.Forme
{
    partial class TrenerForma
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
            listViewTreneri = new ListView();
            ID = new ColumnHeader();
            ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            datumrodjenja = new ColumnHeader();
            datumprvoganagazovanja = new ColumnHeader();
            drzava = new ColumnHeader();
            email = new ColumnHeader();
            statusangazmana = new ColumnHeader();
            tipuloge = new ColumnHeader();
            stilrada = new ColumnHeader();
            dodajtrenerabtn = new Button();
            izmenitrenerabtn = new Button();
            obrisitrenerabtn = new Button();
            SuspendLayout();
            // 
            // listViewTreneri
            // 
            listViewTreneri.Columns.AddRange(new ColumnHeader[] { ID, ime, Prezime, datumrodjenja, datumprvoganagazovanja, drzava, email, statusangazmana, tipuloge, stilrada });
            listViewTreneri.FullRowSelect = true;
            listViewTreneri.Location = new Point(37, 100);
            listViewTreneri.Name = "listViewTreneri";
            listViewTreneri.Size = new Size(2011, 1012);
            listViewTreneri.TabIndex = 0;
            listViewTreneri.UseCompatibleStateImageBehavior = false;
            listViewTreneri.View = View.Details;
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
            // Prezime
            // 
            Prezime.Text = "Prezime";
            Prezime.Width = 150;
            // 
            // datumrodjenja
            // 
            datumrodjenja.Text = "Datum rodjenja";
            datumrodjenja.Width = 250;
            // 
            // datumprvoganagazovanja
            // 
            datumprvoganagazovanja.Text = "Datum prvog angazovanja";
            datumprvoganagazovanja.Width = 300;
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
            // statusangazmana
            // 
            statusangazmana.Text = "Status angazmana";
            statusangazmana.Width = 200;
            // 
            // tipuloge
            // 
            tipuloge.Text = "Tip uloge";
            tipuloge.Width = 200;
            // 
            // stilrada
            // 
            stilrada.Text = "Stil rada";
            stilrada.Width = 200;
            // 
            // dodajtrenerabtn
            // 
            dodajtrenerabtn.Location = new Point(2253, 153);
            dodajtrenerabtn.Name = "dodajtrenerabtn";
            dodajtrenerabtn.Size = new Size(265, 115);
            dodajtrenerabtn.TabIndex = 1;
            dodajtrenerabtn.Text = "Dodaj trenera";
            dodajtrenerabtn.UseVisualStyleBackColor = true;
            dodajtrenerabtn.Click += dodajtrenerabtn_Click;
            // 
            // izmenitrenerabtn
            // 
            izmenitrenerabtn.Location = new Point(2253, 316);
            izmenitrenerabtn.Name = "izmenitrenerabtn";
            izmenitrenerabtn.Size = new Size(265, 115);
            izmenitrenerabtn.TabIndex = 2;
            izmenitrenerabtn.Text = "Izmeni trenera";
            izmenitrenerabtn.UseVisualStyleBackColor = true;
            izmenitrenerabtn.Click += izmenitrenerabtn_Click;
            // 
            // obrisitrenerabtn
            // 
            obrisitrenerabtn.Location = new Point(2253, 473);
            obrisitrenerabtn.Name = "obrisitrenerabtn";
            obrisitrenerabtn.Size = new Size(265, 115);
            obrisitrenerabtn.TabIndex = 3;
            obrisitrenerabtn.Text = "Obrisi trenera";
            obrisitrenerabtn.UseVisualStyleBackColor = true;
            obrisitrenerabtn.Click += obrisitrenerabtn_Click;
            // 
            // TrenerForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2619, 1221);
            Controls.Add(obrisitrenerabtn);
            Controls.Add(izmenitrenerabtn);
            Controls.Add(dodajtrenerabtn);
            Controls.Add(listViewTreneri);
            Name = "TrenerForma";
            Text = "TrenerForma";
            Load += TrenerForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTreneri;
        private ColumnHeader ID;
        private ColumnHeader ime;
        private ColumnHeader Prezime;
        private ColumnHeader datumrodjenja;
        private ColumnHeader datumprvoganagazovanja;
        private ColumnHeader drzava;
        private ColumnHeader email;
        private ColumnHeader statusangazmana;
        private ColumnHeader tipuloge;
        private ColumnHeader stilrada;
        private Button dodajtrenerabtn;
        private Button izmenitrenerabtn;
        private Button obrisitrenerabtn;
    }
}
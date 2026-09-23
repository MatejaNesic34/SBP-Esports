namespace ESPORT.Forme
{
    partial class SkautForma
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
            listViewskaut = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Datum_Rodjenja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Email = new ColumnHeader();
            Status_aranzmana = new ColumnHeader();
            datumprvogangazovanja = new ColumnHeader();
            Igra = new ColumnHeader();
            btndodajskauta = new Button();
            btnizmeniskauta = new Button();
            btnobrisiskauta = new Button();
            SuspendLayout();
            // 
            // listViewskaut
            // 
            listViewskaut.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, Datum_Rodjenja, Drzava, Email, Status_aranzmana, datumprvogangazovanja, Igra });
            listViewskaut.FullRowSelect = true;
            listViewskaut.Location = new Point(23, 80);
            listViewskaut.Name = "listViewskaut";
            listViewskaut.Size = new Size(2085, 831);
            listViewskaut.TabIndex = 6;
            listViewskaut.UseCompatibleStateImageBehavior = false;
            listViewskaut.View = View.Details;
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
            Email.Width = 320;
            // 
            // Status_aranzmana
            // 
            Status_aranzmana.Text = "Status aranzmana";
            Status_aranzmana.Width = 250;
            // 
            // datumprvogangazovanja
            // 
            datumprvogangazovanja.DisplayIndex = 8;
            datumprvogangazovanja.Text = "Datum prvog angazovanja";
            datumprvogangazovanja.Width = 300;
            // 
            // Igra
            // 
            Igra.DisplayIndex = 7;
            Igra.Text = "Igra";
            Igra.Width = 250;
            // 
            // btndodajskauta
            // 
            btndodajskauta.Location = new Point(2155, 123);
            btndodajskauta.Name = "btndodajskauta";
            btndodajskauta.Size = new Size(279, 102);
            btndodajskauta.TabIndex = 7;
            btndodajskauta.Text = "Dodaj skauta";
            btndodajskauta.UseVisualStyleBackColor = true;
            btndodajskauta.Click += btndodajskauta_Click;
            // 
            // btnizmeniskauta
            // 
            btnizmeniskauta.Location = new Point(2155, 266);
            btnizmeniskauta.Name = "btnizmeniskauta";
            btnizmeniskauta.Size = new Size(279, 102);
            btnizmeniskauta.TabIndex = 8;
            btnizmeniskauta.Text = "Izmeni skauta";
            btnizmeniskauta.UseVisualStyleBackColor = true;
            btnizmeniskauta.Click += btnizmeniskauta_Click;
            // 
            // btnobrisiskauta
            // 
            btnobrisiskauta.Location = new Point(2155, 404);
            btnobrisiskauta.Name = "btnobrisiskauta";
            btnobrisiskauta.Size = new Size(279, 102);
            btnobrisiskauta.TabIndex = 9;
            btnobrisiskauta.Text = "Obrisi skauta";
            btnobrisiskauta.UseVisualStyleBackColor = true;
            btnobrisiskauta.Click += btnobrisiskauta_Click;
            // 
            // SkautForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2512, 954);
            Controls.Add(btnobrisiskauta);
            Controls.Add(btnizmeniskauta);
            Controls.Add(btndodajskauta);
            Controls.Add(listViewskaut);
            Name = "SkautForma";
            Text = "SkautForma";
            Load += SkautForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewskaut;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Datum_Rodjenja;
        private ColumnHeader Drzava;
        private ColumnHeader Email;
        private ColumnHeader Status_aranzmana;
        private ColumnHeader Igra;
        private ColumnHeader datumprvogangazovanja;
        private Button btndodajskauta;
        private Button btnizmeniskauta;
        private Button btnobrisiskauta;
    }
}
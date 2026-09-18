namespace ESPORT.Forme
{
    partial class Fizioterapeutforma
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
            btnobrisifizio = new Button();
            btnizmenifizio = new Button();
            btndodajfizio = new Button();
            listViewfizio = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Datum_Rodjenja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Email = new ColumnHeader();
            Status_aranzmana = new ColumnHeader();
            oblastrada = new ColumnHeader();
            perioddostupnosti = new ColumnHeader();
            SuspendLayout();
            // 
            // btnobrisifizio
            // 
            btnobrisifizio.Location = new Point(2041, 476);
            btnobrisifizio.Name = "btnobrisifizio";
            btnobrisifizio.Size = new Size(268, 117);
            btnobrisifizio.TabIndex = 8;
            btnobrisifizio.Text = "Obrisi fizioterapeuta";
            btnobrisifizio.UseVisualStyleBackColor = true;
            btnobrisifizio.Click += btnobrisifizio_Click;
            // 
            // btnizmenifizio
            // 
            btnizmenifizio.Location = new Point(2041, 322);
            btnizmenifizio.Name = "btnizmenifizio";
            btnizmenifizio.Size = new Size(268, 117);
            btnizmenifizio.TabIndex = 7;
            btnizmenifizio.Text = "Izmeni fizioterapeuta";
            btnizmenifizio.UseVisualStyleBackColor = true;
            btnizmenifizio.Click += btnizmenifizio_Click;
            // 
            // btndodajfizio
            // 
            btndodajfizio.Location = new Point(2041, 163);
            btndodajfizio.Name = "btndodajfizio";
            btndodajfizio.Size = new Size(268, 117);
            btndodajfizio.TabIndex = 6;
            btndodajfizio.Text = "Dodaj fizioterapeuta";
            btndodajfizio.UseVisualStyleBackColor = true;
            btndodajfizio.Click += btndodajfizio_Click;
            // 
            // listViewfizio
            // 
            listViewfizio.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, Datum_Rodjenja, Drzava, Email, Status_aranzmana, oblastrada, perioddostupnosti });
            listViewfizio.FullRowSelect = true;
            listViewfizio.Location = new Point(82, 115);
            listViewfizio.Name = "listViewfizio";
            listViewfizio.Size = new Size(1869, 820);
            listViewfizio.TabIndex = 5;
            listViewfizio.UseCompatibleStateImageBehavior = false;
            listViewfizio.View = View.Details;
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
            // Fizioterapeutforma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2437, 1164);
            Controls.Add(btnobrisifizio);
            Controls.Add(btnizmenifizio);
            Controls.Add(btndodajfizio);
            Controls.Add(listViewfizio);
            Name = "Fizioterapeutforma";
            Text = "Fizioterapeutforma";
            Load += Fizioterapeutforma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnobrisifizio;
        private Button btnizmenifizio;
        private Button btndodajfizio;
        private ListView listViewfizio;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Datum_Rodjenja;
        private ColumnHeader Drzava;
        private ColumnHeader Email;
        private ColumnHeader Status_aranzmana;
        private ColumnHeader oblastrada;
        private ColumnHeader perioddostupnosti;
    }
}
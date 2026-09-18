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
            listViewfizio = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Datum_Rodjenja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Email = new ColumnHeader();
            Status_aranzmana = new ColumnHeader();
            Igra = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewfizio
            // 
            listViewfizio.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, Datum_Rodjenja, Drzava, Email, Status_aranzmana, Igra });
            listViewfizio.FullRowSelect = true;
            listViewfizio.Location = new Point(23, 152);
            listViewfizio.Name = "listViewfizio";
            listViewfizio.Size = new Size(1903, 820);
            listViewfizio.TabIndex = 6;
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
            // Igra
            // 
            Igra.Text = "Igra";
            Igra.Width = 200;
            // 
            // SkautForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2372, 1124);
            Controls.Add(listViewfizio);
            Name = "SkautForma";
            Text = "SkautForma";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewfizio;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Datum_Rodjenja;
        private ColumnHeader Drzava;
        private ColumnHeader Email;
        private ColumnHeader Status_aranzmana;
        private ColumnHeader Igra;
    }
}
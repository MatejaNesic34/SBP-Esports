namespace ESPORT
{
    partial class PozajmicaForma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listViewPozajmice = new ListView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            SuspendLayout();

            // 
            // listViewPozajmice
            // 
            listViewPozajmice.FullRowSelect = true;
            listViewPozajmice.GridLines = true;
            listViewPozajmice.Location = new Point(12, 12);
            listViewPozajmice.Name = "listViewPozajmice";
            listViewPozajmice.Size = new Size(1050, 380);
            listViewPozajmice.TabIndex = 0;
            listViewPozajmice.UseCompatibleStateImageBehavior = false;
            listViewPozajmice.View = View.Details;

            // 
            // Kolone
            // 
            listViewPozajmice.Columns.Add("ID", 50);
            listViewPozajmice.Columns.Add("Igrač", 130);
            listViewPozajmice.Columns.Add("Matični tim", 130);
            listViewPozajmice.Columns.Add("Tim na pozajmici", 150);
            listViewPozajmice.Columns.Add("Datum od", 100);
            listViewPozajmice.Columns.Add("Datum do", 100);
            listViewPozajmice.Columns.Add("Finansijski uslovi", 200);
            listViewPozajmice.Columns.Add("Pravo otkupa", 100);

            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(12, 405);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(100, 30);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(118, 405);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(100, 30);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(224, 405);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(100, 30);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;

            // 
            // PozajmicaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 450);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(listViewPozajmice);
            Name = "PozajmicaForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pozajmice";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewPozajmice;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}
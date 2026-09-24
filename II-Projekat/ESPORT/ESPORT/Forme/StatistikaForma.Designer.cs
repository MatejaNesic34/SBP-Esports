namespace ESPORT
{
    partial class StatistikaForma
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
            listViewStatistike = new ListView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            SuspendLayout();

            listViewStatistike.FullRowSelect = true;
            listViewStatistike.GridLines = true;
            listViewStatistike.Location = new Point(12, 12);
            listViewStatistike.Name = "listViewStatistike";
            listViewStatistike.Size = new Size(900, 380);
            listViewStatistike.TabIndex = 0;
            listViewStatistike.UseCompatibleStateImageBehavior = false;
            listViewStatistike.View = View.Details;

            listViewStatistike.Columns.Add("Meč", 100);
            listViewStatistike.Columns.Add("Tim", 150);
            listViewStatistike.Columns.Add("Kills", 80);
            listViewStatistike.Columns.Add("Deaths", 80);
            listViewStatistike.Columns.Add("Assists", 80);
            listViewStatistike.Columns.Add("Damage", 100);
            listViewStatistike.Columns.Add("Objective Score", 130);
            listViewStatistike.Columns.Add("Gold", 100);

            btnDodaj.Location = new Point(12, 405);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(100, 30);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            btnIzmeni.Location = new Point(118, 405);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(100, 30);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnObrisi.Location = new Point(224, 405);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(100, 30);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(listViewStatistike);
            Name = "StatistikaForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistika tima na meču";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewStatistike;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}
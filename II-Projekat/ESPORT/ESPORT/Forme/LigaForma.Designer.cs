namespace ESPORT.Forme
{
    partial class LigaForma
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
            listViewLige = new ListView();

            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Organizator = new ColumnHeader();
            Igra = new ColumnHeader();
            Region = new ColumnHeader();
            Lokacija = new ColumnHeader();
            FormatTakmicenja = new ColumnHeader();
            DatumPocetka = new ColumnHeader();
            DatumZavrsetka = new ColumnHeader();
            NagradniFond = new ColumnHeader();
            ValutaNagrade = new ColumnHeader();
            Status = new ColumnHeader();
            SistemBodovanja = new ColumnHeader();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            obrisiLiguBtn = new Button();
            izmeniLiguBtn = new Button();
            dodajLiguBtn = new Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewLige.Columns.AddRange(new ColumnHeader[]
            {
                ID,
                Naziv,
                Organizator,
                Igra,
                Region,
                Lokacija,
                FormatTakmicenja,
                DatumPocetka,
                DatumZavrsetka,
                NagradniFond,
                ValutaNagrade,
                Status,
                SistemBodovanja
            });

            listViewLige.FullRowSelect = true;
            listViewLige.GridLines = true;
            listViewLige.Location = new Point(24, 56);
            listViewLige.MultiSelect = false;
            listViewLige.Name = "listViewLige";
            listViewLige.Size = new Size(1100, 659);
            listViewLige.TabIndex = 0;
            listViewLige.UseCompatibleStateImageBehavior = false;
            listViewLige.View = View.Details;

            ID.Text = "ID";
            ID.Width = 70;

            Naziv.Text = "Naziv";
            Naziv.Width = 180;

            Organizator.Text = "Organizator";
            Organizator.Width = 150;

            Igra.Text = "Igra";
            Igra.Width = 150;

            Region.Text = "Region";
            Region.Width = 100;

            Lokacija.Text = "Lokacija";
            Lokacija.Width = 130;

            FormatTakmicenja.Text = "Format";
            FormatTakmicenja.Width = 120;

            DatumPocetka.Text = "Datum početka";
            DatumPocetka.Width = 120;

            DatumZavrsetka.Text = "Datum završetka";
            DatumZavrsetka.Width = 120;

            NagradniFond.Text = "Nagradni fond";
            NagradniFond.Width = 120;

            ValutaNagrade.Text = "Valuta";
            ValutaNagrade.Width = 80;

            Status.Text = "Status";
            Status.Width = 100;

            SistemBodovanja.Text = "Sistem bodovanja";
            SistemBodovanja.Width = 150;

            groupBox1.Controls.Add(listViewLige);
            groupBox1.Location = new Point(40, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz liga";

            groupBox2.Controls.Add(obrisiLiguBtn);
            groupBox2.Controls.Add(izmeniLiguBtn);
            groupBox2.Controls.Add(dodajLiguBtn);
            groupBox2.Location = new Point(1220, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije liga";

            obrisiLiguBtn.Location = new Point(62, 320);
            obrisiLiguBtn.Name = "obrisiLiguBtn";
            obrisiLiguBtn.Size = new Size(243, 77);
            obrisiLiguBtn.TabIndex = 2;
            obrisiLiguBtn.Text = "Obriši ligu";
            obrisiLiguBtn.UseVisualStyleBackColor = true;
            obrisiLiguBtn.Click += obrisiLiguBtn_Click;

            izmeniLiguBtn.Location = new Point(62, 200);
            izmeniLiguBtn.Name = "izmeniLiguBtn";
            izmeniLiguBtn.Size = new Size(243, 76);
            izmeniLiguBtn.TabIndex = 1;
            izmeniLiguBtn.Text = "Izmeni ligu";
            izmeniLiguBtn.UseVisualStyleBackColor = true;
            izmeniLiguBtn.Click += izmeniLiguBtn_Click;

            dodajLiguBtn.Location = new Point(62, 76);
            dodajLiguBtn.Name = "dodajLiguBtn";
            dodajLiguBtn.Size = new Size(243, 76);
            dodajLiguBtn.TabIndex = 0;
            dodajLiguBtn.Text = "Dodaj ligu";
            dodajLiguBtn.UseVisualStyleBackColor = true;
            dodajLiguBtn.Click += dodajLiguBtn_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);

            Controls.Add(groupBox2);
            Controls.Add(groupBox1);

            Name = "LigaForma";
            Text = "Lige";

            Load += LigaForma_Load;

            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewLige;

        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Organizator;
        private ColumnHeader Igra;
        private ColumnHeader Region;
        private ColumnHeader Lokacija;
        private ColumnHeader FormatTakmicenja;
        private ColumnHeader DatumPocetka;
        private ColumnHeader DatumZavrsetka;
        private ColumnHeader NagradniFond;
        private ColumnHeader ValutaNagrade;
        private ColumnHeader Status;
        private ColumnHeader SistemBodovanja;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button obrisiLiguBtn;
        private Button izmeniLiguBtn;
        private Button dodajLiguBtn;
    }
}
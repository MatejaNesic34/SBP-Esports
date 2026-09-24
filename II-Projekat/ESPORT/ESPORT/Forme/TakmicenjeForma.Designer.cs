namespace ESPORT.Forme
{
    partial class TakmicenjeForma
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
            listViewTakmicenja = new ListView();

            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Organizator = new ColumnHeader();
            TipTakmicenja = new ColumnHeader();
            Igra = new ColumnHeader();
            Region = new ColumnHeader();
            Lokacija = new ColumnHeader();
            FormatTakmicenja = new ColumnHeader();
            DatumPocetka = new ColumnHeader();
            DatumZavrsetka = new ColumnHeader();
            NagradniFond = new ColumnHeader();
            ValutaNagrade = new ColumnHeader();
            Status = new ColumnHeader();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            obrisiTakmicenjeBtn = new Button();
            izmeniTakmicenjeBtn = new Button();
            dodajTakmicenjeBtn = new Button();
            ligeBtn = new Button();
            turniriBtn = new Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewTakmicenja.Columns.AddRange(new ColumnHeader[]
            {
                ID,
                Naziv,
                Organizator,
                TipTakmicenja,
                Igra,
                Region,
                Lokacija,
                FormatTakmicenja,
                DatumPocetka,
                DatumZavrsetka,
                NagradniFond,
                ValutaNagrade,
                Status
            });

            listViewTakmicenja.FullRowSelect = true;
            listViewTakmicenja.Location = new Point(24, 56);
            listViewTakmicenja.MultiSelect = false;
            listViewTakmicenja.Name = "listViewTakmicenja";
            listViewTakmicenja.Size = new Size(1100, 659);
            listViewTakmicenja.TabIndex = 0;
            listViewTakmicenja.UseCompatibleStateImageBehavior = false;
            listViewTakmicenja.View = View.Details;

            ID.Text = "ID";
            ID.Width = 70;

            Naziv.Text = "Naziv";
            Naziv.Width = 180;

            Organizator.Text = "Organizator";
            Organizator.Width = 150;

            TipTakmicenja.Text = "Tip";
            TipTakmicenja.Width = 100;

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

            groupBox1.Controls.Add(listViewTakmicenja);
            groupBox1.Location = new Point(40, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz takmičenja";

            groupBox2.Controls.Add(obrisiTakmicenjeBtn);
            groupBox2.Controls.Add(izmeniTakmicenjeBtn);
            groupBox2.Controls.Add(dodajTakmicenjeBtn);
            groupBox2.Location = new Point(1220, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije takmičenja";

            obrisiTakmicenjeBtn.Location = new Point(62, 320);
            obrisiTakmicenjeBtn.Name = "obrisiTakmicenjeBtn";
            obrisiTakmicenjeBtn.Size = new Size(243, 77);
            obrisiTakmicenjeBtn.TabIndex = 2;
            obrisiTakmicenjeBtn.Text = "Obriši takmičenje";
            obrisiTakmicenjeBtn.UseVisualStyleBackColor = true;
            obrisiTakmicenjeBtn.Click += obrisiTakmicenjeBtn_Click;

            izmeniTakmicenjeBtn.Location = new Point(62, 200);
            izmeniTakmicenjeBtn.Name = "izmeniTakmicenjeBtn";
            izmeniTakmicenjeBtn.Size = new Size(243, 76);
            izmeniTakmicenjeBtn.TabIndex = 1;
            izmeniTakmicenjeBtn.Text = "Izmeni takmičenje";
            izmeniTakmicenjeBtn.UseVisualStyleBackColor = true;
            izmeniTakmicenjeBtn.Click += izmeniTakmicenjeBtn_Click;

            dodajTakmicenjeBtn.Location = new Point(62, 76);
            dodajTakmicenjeBtn.Name = "dodajTakmicenjeBtn";
            dodajTakmicenjeBtn.Size = new Size(243, 76);
            dodajTakmicenjeBtn.TabIndex = 0;
            dodajTakmicenjeBtn.Text = "Dodaj takmičenje";
            dodajTakmicenjeBtn.UseVisualStyleBackColor = true;
            dodajTakmicenjeBtn.Click += dodajTakmicenjeBtn_Click;

            ligeBtn.Location = new Point(1220, 580);
            ligeBtn.Name = "ligeBtn";
            ligeBtn.Size = new Size(350, 80);
            ligeBtn.TabIndex = 3;
            ligeBtn.Text = "Lige";
            ligeBtn.UseVisualStyleBackColor = true;
            ligeBtn.Click += ligeBtn_Click;

            turniriBtn.Location = new Point(1220, 680);
            turniriBtn.Name = "turniriBtn";
            turniriBtn.Size = new Size(350, 80);
            turniriBtn.TabIndex = 4;
            turniriBtn.Text = "Turniri";
            turniriBtn.UseVisualStyleBackColor = true;
            turniriBtn.Click += turniriBtn_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);

            Controls.Add(turniriBtn);
            Controls.Add(ligeBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);

            Name = "TakmicenjeForma";
            Text = "Takmičenja";

            Load += TakmicenjeForma_Load;

            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTakmicenja;

        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Organizator;
        private ColumnHeader TipTakmicenja;
        private ColumnHeader Igra;
        private ColumnHeader Region;
        private ColumnHeader Lokacija;
        private ColumnHeader FormatTakmicenja;
        private ColumnHeader DatumPocetka;
        private ColumnHeader DatumZavrsetka;
        private ColumnHeader NagradniFond;
        private ColumnHeader ValutaNagrade;
        private ColumnHeader Status;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button obrisiTakmicenjeBtn;
        private Button izmeniTakmicenjeBtn;
        private Button dodajTakmicenjeBtn;
        private Button ligeBtn;
        private Button turniriBtn;
    }
}
namespace ESPORT.Forme
{
    partial class TurnirForma
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
            listViewTurniri = new ListView();
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
            TipKostura = new ColumnHeader();
            PravilaNapredovanja = new ColumnHeader();
            BrojMecevaPoRundi = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            obrisiTurnirBtn = new Button();
            izmeniTurnirBtn = new Button();
            dodajTurnirBtn = new Button();
            fazeBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewTurniri
            // 
            listViewTurniri.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Organizator, Igra, Region, Lokacija, FormatTakmicenja, DatumPocetka, DatumZavrsetka, NagradniFond, ValutaNagrade, Status, TipKostura, PravilaNapredovanja, BrojMecevaPoRundi });
            listViewTurniri.FullRowSelect = true;
            listViewTurniri.GridLines = true;
            listViewTurniri.Location = new Point(24, 56);
            listViewTurniri.MultiSelect = false;
            listViewTurniri.Name = "listViewTurniri";
            listViewTurniri.Size = new Size(1967, 828);
            listViewTurniri.TabIndex = 0;
            listViewTurniri.UseCompatibleStateImageBehavior = false;
            listViewTurniri.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 70;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 180;
            // 
            // Organizator
            // 
            Organizator.Text = "Organizator";
            Organizator.Width = 200;
            // 
            // Igra
            // 
            Igra.Text = "Igra";
            Igra.Width = 150;
            // 
            // Region
            // 
            Region.Text = "Region";
            Region.Width = 180;
            // 
            // Lokacija
            // 
            Lokacija.Text = "Lokacija";
            Lokacija.Width = 180;
            // 
            // FormatTakmicenja
            // 
            FormatTakmicenja.Text = "Format";
            FormatTakmicenja.Width = 220;
            // 
            // DatumPocetka
            // 
            DatumPocetka.Text = "Datum početka";
            DatumPocetka.Width = 220;
            // 
            // DatumZavrsetka
            // 
            DatumZavrsetka.Text = "Datum završetka";
            DatumZavrsetka.Width = 240;
            // 
            // NagradniFond
            // 
            NagradniFond.Text = "Nagradni fond";
            NagradniFond.Width = 200;
            // 
            // ValutaNagrade
            // 
            ValutaNagrade.Text = "Valuta";
            ValutaNagrade.Width = 140;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 220;
            // 
            // TipKostura
            // 
            TipKostura.Text = "Tip kostura";
            TipKostura.Width = 220;
            // 
            // PravilaNapredovanja
            // 
            PravilaNapredovanja.Text = "Pravila napredovanja";
            PravilaNapredovanja.Width = 250;
            // 
            // BrojMecevaPoRundi
            // 
            BrojMecevaPoRundi.Text = "Mečevi po rundi";
            BrojMecevaPoRundi.Width = 240;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewTurniri);
            groupBox1.Location = new Point(40, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2020, 903);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz turnira";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(obrisiTurnirBtn);
            groupBox2.Controls.Add(izmeniTurnirBtn);
            groupBox2.Controls.Add(dodajTurnirBtn);
            groupBox2.Location = new Point(2079, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije turnira";
            // 
            // obrisiTurnirBtn
            // 
            obrisiTurnirBtn.Location = new Point(62, 320);
            obrisiTurnirBtn.Name = "obrisiTurnirBtn";
            obrisiTurnirBtn.Size = new Size(243, 77);
            obrisiTurnirBtn.TabIndex = 2;
            obrisiTurnirBtn.Text = "Obriši turnir";
            obrisiTurnirBtn.UseVisualStyleBackColor = true;
            obrisiTurnirBtn.Click += obrisiTurnirBtn_Click;
            // 
            // izmeniTurnirBtn
            // 
            izmeniTurnirBtn.Location = new Point(62, 200);
            izmeniTurnirBtn.Name = "izmeniTurnirBtn";
            izmeniTurnirBtn.Size = new Size(243, 76);
            izmeniTurnirBtn.TabIndex = 1;
            izmeniTurnirBtn.Text = "Izmeni turnir";
            izmeniTurnirBtn.UseVisualStyleBackColor = true;
            izmeniTurnirBtn.Click += izmeniTurnirBtn_Click;
            // 
            // dodajTurnirBtn
            // 
            dodajTurnirBtn.Location = new Point(62, 76);
            dodajTurnirBtn.Name = "dodajTurnirBtn";
            dodajTurnirBtn.Size = new Size(243, 76);
            dodajTurnirBtn.TabIndex = 0;
            dodajTurnirBtn.Text = "Dodaj turnir";
            dodajTurnirBtn.UseVisualStyleBackColor = true;
            dodajTurnirBtn.Click += dodajTurnirBtn_Click;
            // 
            // fazeBtn
            // 
            fazeBtn.Location = new Point(2079, 621);
            fazeBtn.Name = "fazeBtn";
            fazeBtn.Size = new Size(350, 60);
            fazeBtn.TabIndex = 5;
            fazeBtn.Text = "Faze takmičenja";
            fazeBtn.UseVisualStyleBackColor = true;
            fazeBtn.Click += fazeBtn_Click;
            // 
            // TurnirForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2478, 995);
            Controls.Add(fazeBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TurnirForma";
            Text = "Turniri";
            Load += TurnirForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTurniri;

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
        private ColumnHeader TipKostura;
        private ColumnHeader PravilaNapredovanja;
        private ColumnHeader BrojMecevaPoRundi;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button obrisiTurnirBtn;
        private Button izmeniTurnirBtn;
        private Button dodajTurnirBtn;

        private Button fazeBtn;
    }
}
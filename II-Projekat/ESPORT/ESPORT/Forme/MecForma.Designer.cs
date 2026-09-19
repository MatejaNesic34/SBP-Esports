namespace ESPORT.Forme
{
    partial class MecForma
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
            listViewMecevi = new ListView();

            MecId = new ColumnHeader();
            TakmicenjeId = new ColumnHeader();
            Takmicenje = new ColumnHeader();
            RedniBroj = new ColumnHeader();
            DatumVremePocetka = new ColumnHeader();
            FormatMeca = new ColumnHeader();
            BrojOdigranihMapa = new ColumnHeader();
            Rezultat = new ColumnHeader();
            Trajanje = new ColumnHeader();
            LokacijaIgranja = new ColumnHeader();
            Sudije = new ColumnHeader();
            StatusMeca = new ColumnHeader();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            dodajMecBtn = new Button();
            izmeniMecBtn = new Button();
            obrisiMecBtn = new Button();
            dogadjajiBtn = new Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            // 
            // listViewMecevi
            // 
            listViewMecevi.Columns.AddRange(new ColumnHeader[]
            {
                MecId,
                TakmicenjeId,
                Takmicenje,
                RedniBroj,
                DatumVremePocetka,
                FormatMeca,
                BrojOdigranihMapa,
                Rezultat,
                Trajanje,
                LokacijaIgranja,
                Sudije,
                StatusMeca
            });

            listViewMecevi.FullRowSelect = true;
            listViewMecevi.GridLines = true;
            listViewMecevi.Location = new Point(24, 56);
            listViewMecevi.MultiSelect = false;
            listViewMecevi.Name = "listViewMecevi";
            listViewMecevi.Size = new Size(1100, 659);
            listViewMecevi.TabIndex = 0;
            listViewMecevi.UseCompatibleStateImageBehavior = false;
            listViewMecevi.View = View.Details;

            // 
            // Kolone
            // 

            MecId.Text = "Meč ID";
            MecId.Width = 70;

            TakmicenjeId.Text = "Takmičenje ID";
            TakmicenjeId.Width = 110;

            Takmicenje.Text = "Takmičenje";
            Takmicenje.Width = 220;

            RedniBroj.Text = "Redni broj";
            RedniBroj.Width = 90;

            DatumVremePocetka.Text = "Datum i vreme";
            DatumVremePocetka.Width = 140;

            FormatMeca.Text = "Format meča";
            FormatMeca.Width = 120;

            BrojOdigranihMapa.Text = "Broj mapa";
            BrojOdigranihMapa.Width = 100;

            Rezultat.Text = "Rezultat";
            Rezultat.Width = 100;

            Trajanje.Text = "Trajanje";
            Trajanje.Width = 90;

            LokacijaIgranja.Text = "Lokacija";
            LokacijaIgranja.Width = 150;

            Sudije.Text = "Sudije";
            Sudije.Width = 150;

            StatusMeca.Text = "Status";
            StatusMeca.Width = 100;

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewMecevi);
            groupBox1.Location = new Point(40, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz mečeva";

            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(obrisiMecBtn);
            groupBox2.Controls.Add(izmeniMecBtn);
            groupBox2.Controls.Add(dodajMecBtn);
            groupBox2.Location = new Point(1220, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije meča";

            Controls.Add(dogadjajiBtn);

            // 
            // dodajMecBtn
            // 
            dodajMecBtn.Location = new Point(62, 76);
            dodajMecBtn.Name = "dodajMecBtn";
            dodajMecBtn.Size = new Size(243, 76);
            dodajMecBtn.TabIndex = 0;
            dodajMecBtn.Text = "Dodaj meč";
            dodajMecBtn.UseVisualStyleBackColor = true;
            dodajMecBtn.Click += dodajMecBtn_Click;

            // 
            // izmeniMecBtn
            // 
            izmeniMecBtn.Location = new Point(62, 200);
            izmeniMecBtn.Name = "izmeniMecBtn";
            izmeniMecBtn.Size = new Size(243, 76);
            izmeniMecBtn.TabIndex = 1;
            izmeniMecBtn.Text = "Izmeni meč";
            izmeniMecBtn.UseVisualStyleBackColor = true;
            izmeniMecBtn.Click += izmeniMecBtn_Click;

            // 
            // obrisiMecBtn
            // 
            obrisiMecBtn.Location = new Point(62, 320);
            obrisiMecBtn.Name = "obrisiMecBtn";
            obrisiMecBtn.Size = new Size(243, 77);
            obrisiMecBtn.TabIndex = 2;
            obrisiMecBtn.Text = "Obriši meč";
            obrisiMecBtn.UseVisualStyleBackColor = true;
            obrisiMecBtn.Click += obrisiMecBtn_Click;

            // 
            // dogadjajiBtn
            // 
            dogadjajiBtn.Location = new Point(1220, 590);
            dogadjajiBtn.Name = "dogadjajiBtn";
            dogadjajiBtn.Size = new Size(350, 80);
            dogadjajiBtn.TabIndex = 3;
            dogadjajiBtn.Text = "Događaji na meču";
            dogadjajiBtn.UseVisualStyleBackColor = true;
            dogadjajiBtn.Click += dogadjajiBtn_Click;

            // 
            // MecForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);

            Controls.Add(groupBox2);
            Controls.Add(groupBox1);

            Name = "MecForma";
            Text = "Mečevi";

            Load += MecForma_Load;

            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewMecevi;

        private ColumnHeader MecId;
        private ColumnHeader TakmicenjeId;
        private ColumnHeader Takmicenje;
        private ColumnHeader RedniBroj;
        private ColumnHeader DatumVremePocetka;
        private ColumnHeader FormatMeca;
        private ColumnHeader BrojOdigranihMapa;
        private ColumnHeader Rezultat;
        private ColumnHeader Trajanje;
        private ColumnHeader LokacijaIgranja;
        private ColumnHeader Sudije;
        private ColumnHeader StatusMeca;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button dodajMecBtn;
        private Button izmeniMecBtn;
        private Button obrisiMecBtn;

        private Button dogadjajiBtn;
    }
}
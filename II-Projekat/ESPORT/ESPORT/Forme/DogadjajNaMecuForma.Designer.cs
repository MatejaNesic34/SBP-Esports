namespace ESPORT.Forme
{
    partial class DogadjajNaMecuForma
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
            listViewDogadjaji = new ListView();

            DogadjajId = new ColumnHeader();
            MecId = new ColumnHeader();
            RedniBrojMeca = new ColumnHeader();
            TipDogadjaja = new ColumnHeader();
            VremeDogadjaja = new ColumnHeader();
            Opis = new ColumnHeader();
            OdlukaSudije = new ColumnHeader();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            dodajDogadjajBtn = new Button();
            izmeniDogadjajBtn = new Button();
            obrisiDogadjajBtn = new Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewDogadjaji.Columns.AddRange(new ColumnHeader[]
            {
                DogadjajId,
                MecId,
                RedniBrojMeca,
                TipDogadjaja,
                VremeDogadjaja,
                Opis,
                OdlukaSudije
            });

            listViewDogadjaji.FullRowSelect = true;
            listViewDogadjaji.GridLines = true;
            listViewDogadjaji.Location = new Point(24, 56);
            listViewDogadjaji.MultiSelect = false;
            listViewDogadjaji.Name = "listViewDogadjaji";
            listViewDogadjaji.Size = new Size(1100, 659);
            listViewDogadjaji.TabIndex = 0;
            listViewDogadjaji.UseCompatibleStateImageBehavior = false;
            listViewDogadjaji.View = View.Details;

            DogadjajId.Text = "Događaj ID";
            DogadjajId.Width = 90;

            MecId.Text = "Meč ID";
            MecId.Width = 80;

            RedniBrojMeca.Text = "Redni broj meča";
            RedniBrojMeca.Width = 130;

            TipDogadjaja.Text = "Tip događaja";
            TipDogadjaja.Width = 150;

            VremeDogadjaja.Text = "Vreme događaja";
            VremeDogadjaja.Width = 150;

            Opis.Text = "Opis";
            Opis.Width = 250;

            OdlukaSudije.Text = "Odluka sudije";
            OdlukaSudije.Width = 200;

            groupBox1.Controls.Add(listViewDogadjaji);
            groupBox1.Location = new Point(40, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz događaja na meču";

            groupBox2.Controls.Add(obrisiDogadjajBtn);
            groupBox2.Controls.Add(izmeniDogadjajBtn);
            groupBox2.Controls.Add(dodajDogadjajBtn);
            groupBox2.Location = new Point(1220, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije događaja";

            dodajDogadjajBtn.Location = new Point(62, 76);
            dodajDogadjajBtn.Name = "dodajDogadjajBtn";
            dodajDogadjajBtn.Size = new Size(243, 76);
            dodajDogadjajBtn.TabIndex = 0;
            dodajDogadjajBtn.Text = "Dodaj događaj";
            dodajDogadjajBtn.UseVisualStyleBackColor = true;
            dodajDogadjajBtn.Click += dodajDogadjajBtn_Click;

            izmeniDogadjajBtn.Location = new Point(62, 200);
            izmeniDogadjajBtn.Name = "izmeniDogadjajBtn";
            izmeniDogadjajBtn.Size = new Size(243, 76);
            izmeniDogadjajBtn.TabIndex = 1;
            izmeniDogadjajBtn.Text = "Izmeni događaj";
            izmeniDogadjajBtn.UseVisualStyleBackColor = true;
            izmeniDogadjajBtn.Click += izmeniDogadjajBtn_Click;

            obrisiDogadjajBtn.Location = new Point(62, 320);
            obrisiDogadjajBtn.Name = "obrisiDogadjajBtn";
            obrisiDogadjajBtn.Size = new Size(243, 77);
            obrisiDogadjajBtn.TabIndex = 2;
            obrisiDogadjajBtn.Text = "Obriši događaj";
            obrisiDogadjajBtn.UseVisualStyleBackColor = true;
            obrisiDogadjajBtn.Click += obrisiDogadjajBtn_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);

            Controls.Add(groupBox2);
            Controls.Add(groupBox1);

            Name = "DogadjajNaMecuForma";
            Text = "Događaji na meču";

            Load += DogadjajNaMecuForma_Load;

            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDogadjaji;

        private ColumnHeader DogadjajId;
        private ColumnHeader MecId;
        private ColumnHeader RedniBrojMeca;
        private ColumnHeader TipDogadjaja;
        private ColumnHeader VremeDogadjaja;
        private ColumnHeader Opis;
        private ColumnHeader OdlukaSudije;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button dodajDogadjajBtn;
        private Button izmeniDogadjajBtn;
        private Button obrisiDogadjajBtn;
    }
}
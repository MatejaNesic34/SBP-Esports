namespace ESPORT.Forme
{
    partial class OsobaForma
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
            listViewOsobe = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Datum_Rodjenja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Email = new ColumnHeader();
            Status_aranzmana = new ColumnHeader();
            igracibtn = new Button();
            trenerbtn = new Button();
            analiticarbtn = new Button();
            menadzerbtn = new Button();
            psihologbtn = new Button();
            fizioterapeutbtn = new Button();
            skautbtn = new Button();
            SuspendLayout();

            listViewOsobe.Columns.AddRange(new ColumnHeader[] { ID, Ime, Prezime, Datum_Rodjenja, Drzava, Email, Status_aranzmana });
            listViewOsobe.Location = new Point(49, 87);
            listViewOsobe.Name = "listViewOsobe";
            listViewOsobe.Size = new Size(1535, 820);
            listViewOsobe.TabIndex = 0;
            listViewOsobe.UseCompatibleStateImageBehavior = false;
            listViewOsobe.View = View.Details;

            ID.Text = "ID";
            ID.Width = 80;

            Ime.Text = "Ime";
            Ime.Width = 220;

            Prezime.Text = "Prezime";
            Prezime.Width = 220;

            Datum_Rodjenja.Text = "Datum rodjenja";
            Datum_Rodjenja.Width = 230;

            Drzava.Text = "Drzava";
            Drzava.Width = 200;

            Email.Text = "Email";
            Email.Width = 250;

            Status_aranzmana.Text = "Status aranzmana";
            Status_aranzmana.Width = 250;

            igracibtn.Location = new Point(1712, 137);
            igracibtn.Name = "igracibtn";
            igracibtn.Size = new Size(292, 126);
            igracibtn.TabIndex = 1;
            igracibtn.Text = "Igraci";
            igracibtn.UseVisualStyleBackColor = true;
            igracibtn.Click += igracibtn_Click;

            trenerbtn.Location = new Point(2058, 137);
            trenerbtn.Name = "trenerbtn";
            trenerbtn.Size = new Size(292, 126);
            trenerbtn.TabIndex = 2;
            trenerbtn.Text = "Trener";
            trenerbtn.UseVisualStyleBackColor = true;
            trenerbtn.Click += trenerbtn_Click;

            analiticarbtn.Location = new Point(1712, 324);
            analiticarbtn.Name = "analiticarbtn";
            analiticarbtn.Size = new Size(292, 126);
            analiticarbtn.TabIndex = 3;
            analiticarbtn.Text = "Analiticar";
            analiticarbtn.UseVisualStyleBackColor = true;
            analiticarbtn.Click += analiticarbtn_Click;

            menadzerbtn.Location = new Point(2058, 324);
            menadzerbtn.Name = "menadzerbtn";
            menadzerbtn.Size = new Size(292, 126);
            menadzerbtn.TabIndex = 4;
            menadzerbtn.Text = "Menadzer";
            menadzerbtn.UseVisualStyleBackColor = true;
            menadzerbtn.Click += menadzerbtn_Click;

            psihologbtn.Location = new Point(1712, 510);
            psihologbtn.Name = "psihologbtn";
            psihologbtn.Size = new Size(292, 126);
            psihologbtn.TabIndex = 5;
            psihologbtn.Text = "Psiholog";
            psihologbtn.UseVisualStyleBackColor = true;
            psihologbtn.Click += psihologbtn_Click;

            fizioterapeutbtn.Location = new Point(2058, 510);
            fizioterapeutbtn.Name = "fizioterapeutbtn";
            fizioterapeutbtn.Size = new Size(292, 126);
            fizioterapeutbtn.TabIndex = 6;
            fizioterapeutbtn.Text = "Fizioterapeut";
            fizioterapeutbtn.UseVisualStyleBackColor = true;
            fizioterapeutbtn.Click += fizioterapeutbtn_Click;

            skautbtn.Location = new Point(1712, 691);
            skautbtn.Name = "skautbtn";
            skautbtn.Size = new Size(292, 126);
            skautbtn.TabIndex = 7;
            skautbtn.Text = "Skaut";
            skautbtn.UseVisualStyleBackColor = true;
            skautbtn.Click += skautbtn_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2443, 1018);
            Controls.Add(skautbtn);
            Controls.Add(fizioterapeutbtn);
            Controls.Add(psihologbtn);
            Controls.Add(menadzerbtn);
            Controls.Add(analiticarbtn);
            Controls.Add(trenerbtn);
            Controls.Add(igracibtn);
            Controls.Add(listViewOsobe);
            Name = "OsobaForma";
            Text = "OsobaForma";
            Load += OsobaForma_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewOsobe;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Datum_Rodjenja;
        private ColumnHeader Drzava;
        private ColumnHeader Email;
        private ColumnHeader Status_aranzmana;
        private Button igracibtn;
        private Button trenerbtn;
        private Button analiticarbtn;
        private Button menadzerbtn;
        private Button psihologbtn;
        private Button fizioterapeutbtn;
        private Button skautbtn;
    }
}
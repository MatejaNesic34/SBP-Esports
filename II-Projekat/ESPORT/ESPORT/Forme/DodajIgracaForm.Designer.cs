namespace ESPORT.Forme
{
    partial class DodajIgracaForm
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
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxdrzava = new TextBox();
            textBoxemail = new TextBox();
            textBoxnadimak = new TextBox();
            textBoxprimarnauloga = new TextBox();
            textBoxsekundarnauloga = new TextBox();
            textBoxdominantanstiligre = new TextBox();
            textBoxrang = new TextBox();
            imelbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            dtpdatum = new DateTimePicker();
            textBoxtelefon = new TextBox();
            otkazibtn = new Button();
            savebtn = new Button();
            comboBoxstatusaranzmana = new ComboBox();
            SuspendLayout();
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(382, 75);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 0;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(382, 149);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 1;
            // 
            // textBoxdrzava
            // 
            textBoxdrzava.Location = new Point(382, 321);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 2;
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(382, 405);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 3;
            // 
            // textBoxnadimak
            // 
            textBoxnadimak.Location = new Point(1281, 78);
            textBoxnadimak.Name = "textBoxnadimak";
            textBoxnadimak.Size = new Size(497, 47);
            textBoxnadimak.TabIndex = 5;
            // 
            // textBoxprimarnauloga
            // 
            textBoxprimarnauloga.Location = new Point(1281, 152);
            textBoxprimarnauloga.Name = "textBoxprimarnauloga";
            textBoxprimarnauloga.Size = new Size(497, 47);
            textBoxprimarnauloga.TabIndex = 6;
            // 
            // textBoxsekundarnauloga
            // 
            textBoxsekundarnauloga.Location = new Point(1287, 224);
            textBoxsekundarnauloga.Name = "textBoxsekundarnauloga";
            textBoxsekundarnauloga.Size = new Size(491, 47);
            textBoxsekundarnauloga.TabIndex = 7;
            // 
            // textBoxdominantanstiligre
            // 
            textBoxdominantanstiligre.Location = new Point(1287, 304);
            textBoxdominantanstiligre.Name = "textBoxdominantanstiligre";
            textBoxdominantanstiligre.Size = new Size(493, 47);
            textBoxdominantanstiligre.TabIndex = 8;
            // 
            // textBoxrang
            // 
            textBoxrang.Location = new Point(1281, 405);
            textBoxrang.Name = "textBoxrang";
            textBoxrang.Size = new Size(499, 47);
            textBoxrang.TabIndex = 9;
            // 
            // imelbl
            // 
            imelbl.AutoSize = true;
            imelbl.Location = new Point(100, 81);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 10;
            imelbl.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 153);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 11;
            label2.Text = "Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 239);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 12;
            label3.Text = "Datum rodjenja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 327);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 13;
            label4.Text = "Drzava";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 392);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 481);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 15;
            label6.Text = "Status aranzmana";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(999, 78);
            label7.Name = "label7";
            label7.Size = new Size(136, 41);
            label7.TabIndex = 16;
            label7.Text = "Nadimak";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(999, 152);
            label8.Name = "label8";
            label8.Size = new Size(218, 41);
            label8.TabIndex = 17;
            label8.Text = "Primarna uloga";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(999, 230);
            label9.Name = "label9";
            label9.Size = new Size(257, 41);
            label9.TabIndex = 18;
            label9.Text = "Sekundarna uloga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(999, 310);
            label1.Name = "label1";
            label1.Size = new Size(285, 41);
            label1.TabIndex = 19;
            label1.Text = "Dominantan stil igre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(999, 405);
            label10.Name = "label10";
            label10.Size = new Size(86, 41);
            label10.TabIndex = 20;
            label10.Text = "Rang";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(999, 487);
            label11.Name = "label11";
            label11.Size = new Size(114, 41);
            label11.TabIndex = 21;
            label11.Text = "Telefon";
            // 
            // dtpdatum
            // 
            dtpdatum.Location = new Point(382, 230);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 22;
            // 
            // textBoxtelefon
            // 
            textBoxtelefon.Location = new Point(1281, 487);
            textBoxtelefon.Name = "textBoxtelefon";
            textBoxtelefon.Size = new Size(499, 47);
            textBoxtelefon.TabIndex = 23;
            // 
            // otkazibtn
            // 
            otkazibtn.Location = new Point(1379, 779);
            otkazibtn.Name = "otkazibtn";
            otkazibtn.Size = new Size(188, 58);
            otkazibtn.TabIndex = 24;
            otkazibtn.Text = "Otkazi";
            otkazibtn.UseVisualStyleBackColor = true;
            otkazibtn.Click += otkazibtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(1616, 779);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(188, 58);
            savebtn.TabIndex = 25;
            savebtn.Text = "Sacuvaj";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // comboBoxstatusaranzmana
            // 
            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(382, 487);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(520, 49);
            comboBoxstatusaranzmana.TabIndex = 26;
            // 
            // DodajIgracaForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1930, 913);
            Controls.Add(comboBoxstatusaranzmana);
            Controls.Add(savebtn);
            Controls.Add(otkazibtn);
            Controls.Add(textBoxtelefon);
            Controls.Add(dtpdatum);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(imelbl);
            Controls.Add(textBoxrang);
            Controls.Add(textBoxdominantanstiligre);
            Controls.Add(textBoxsekundarnauloga);
            Controls.Add(textBoxprimarnauloga);
            Controls.Add(textBoxnadimak);
            Controls.Add(textBoxemail);
            Controls.Add(textBoxdrzava);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxIme);
            Name = "DodajIgracaForm";
            Text = "DodajIgracaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private TextBox textBoxdrzava;
        private TextBox textBoxemail;
        private TextBox textBoxnadimak;
        private TextBox textBoxprimarnauloga;
        private TextBox textBoxsekundarnauloga;
        private TextBox textBoxdominantanstiligre;
        private TextBox textBoxrang;
        private Label imelbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label1;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpdatum;
        private TextBox textBoxtelefon;
        private Button otkazibtn;
        private Button savebtn;
        private ComboBox comboBoxstatusaranzmana;
    }
}
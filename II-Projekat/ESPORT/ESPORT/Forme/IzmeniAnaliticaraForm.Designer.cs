namespace ESPORT.Forme
{
    partial class IzmeniAnaliticaraForm
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
            textBoxnivoiskustva = new TextBox();
            textBoxalati = new TextBox();
            textBoxoblastanalize = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            comboBoxstatusaranzmana = new ComboBox();
            dtpdatum = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            imelbl = new Label();
            textBoxemail = new TextBox();
            textBoxdrzava = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxIme = new TextBox();
            savebtn = new Button();
            dtpdatumprvogangazovanja = new DateTimePicker();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxnivoiskustva
            // 
            textBoxnivoiskustva.Location = new Point(360, 830);
            textBoxnivoiskustva.Name = "textBoxnivoiskustva";
            textBoxnivoiskustva.Size = new Size(524, 47);
            textBoxnivoiskustva.TabIndex = 63;
            // 
            // textBoxalati
            // 
            textBoxalati.Location = new Point(364, 753);
            textBoxalati.Name = "textBoxalati";
            textBoxalati.Size = new Size(520, 47);
            textBoxalati.TabIndex = 62;
            // 
            // textBoxoblastanalize
            // 
            textBoxoblastanalize.Location = new Point(364, 673);
            textBoxoblastanalize.Name = "textBoxoblastanalize";
            textBoxoblastanalize.Size = new Size(520, 47);
            textBoxoblastanalize.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 834);
            label8.Name = "label8";
            label8.Size = new Size(191, 41);
            label8.TabIndex = 60;
            label8.Text = "Nivo iskustva";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 753);
            label7.Name = "label7";
            label7.Size = new Size(76, 41);
            label7.TabIndex = 59;
            label7.Text = "Alati";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 672);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 58;
            label1.Text = "Oblast analize";
            // 
            // comboBoxstatusaranzmana
            // 
            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(381, 576);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 57;
            // 
            // dtpdatum
            // 
            dtpdatum.Location = new Point(364, 245);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 576);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 55;
            label6.Text = "Status aranzmana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 487);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 54;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 422);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 53;
            label4.Text = "Drzava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 254);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 52;
            label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 168);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 51;
            label2.Text = "Prezime";
            // 
            // imelbl
            // 
            imelbl.AutoSize = true;
            imelbl.Location = new Point(82, 96);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 50;
            imelbl.Text = "Ime";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(364, 500);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 49;
            // 
            // textBoxdrzava
            // 
            textBoxdrzava.Location = new Point(364, 416);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 48;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(364, 164);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 47;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(364, 90);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 46;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(714, 982);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(188, 58);
            savebtn.TabIndex = 64;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dtpdatumprvogangazovanja
            // 
            dtpdatumprvogangazovanja.Location = new Point(364, 339);
            dtpdatumprvogangazovanja.Name = "dtpdatumprvogangazovanja";
            dtpdatumprvogangazovanja.Size = new Size(520, 47);
            dtpdatumprvogangazovanja.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 345);
            label9.Name = "label9";
            label9.Size = new Size(304, 41);
            label9.TabIndex = 65;
            label9.Text = "Datum 1 angazovanja";
            // 
            // button2
            // 
            button2.Location = new Point(473, 982);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 67;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // IzmeniAnaliticaraForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 1082);
            Controls.Add(button2);
            Controls.Add(dtpdatumprvogangazovanja);
            Controls.Add(label9);
            Controls.Add(savebtn);
            Controls.Add(textBoxnivoiskustva);
            Controls.Add(textBoxalati);
            Controls.Add(textBoxoblastanalize);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(comboBoxstatusaranzmana);
            Controls.Add(dtpdatum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(imelbl);
            Controls.Add(textBoxemail);
            Controls.Add(textBoxdrzava);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxIme);
            Name = "IzmeniAnaliticaraForm";
            Text = "IzmeniAnaliticaraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxnivoiskustva;
        private TextBox textBoxalati;
        private TextBox textBoxoblastanalize;
        private Label label8;
        private Label label7;
        private Label label1;
        private ComboBox comboBoxstatusaranzmana;
        private DateTimePicker dtpdatum;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label imelbl;
        private TextBox textBoxemail;
        private TextBox textBoxdrzava;
        private TextBox textBoxPrezime;
        private TextBox textBoxIme;
        private Button savebtn;
        private DateTimePicker dtpdatumprvogangazovanja;
        private Label label9;
        private Button button2;
    }
}
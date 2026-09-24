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
            SuspendLayout();

            textBoxnivoiskustva.Location = new Point(434, 880);
            textBoxnivoiskustva.Name = "textBoxnivoiskustva";
            textBoxnivoiskustva.Size = new Size(524, 47);
            textBoxnivoiskustva.TabIndex = 63;

            textBoxalati.Location = new Point(438, 803);
            textBoxalati.Name = "textBoxalati";
            textBoxalati.Size = new Size(520, 47);
            textBoxalati.TabIndex = 62;

            textBoxoblastanalize.Location = new Point(438, 723);
            textBoxoblastanalize.Name = "textBoxoblastanalize";
            textBoxoblastanalize.Size = new Size(520, 47);
            textBoxoblastanalize.TabIndex = 61;

            label8.AutoSize = true;
            label8.Location = new Point(151, 884);
            label8.Name = "label8";
            label8.Size = new Size(191, 41);
            label8.TabIndex = 60;
            label8.Text = "Nivo iskustva";

            label7.AutoSize = true;
            label7.Location = new Point(156, 803);
            label7.Name = "label7";
            label7.Size = new Size(76, 41);
            label7.TabIndex = 59;
            label7.Text = "Alati";

            label1.AutoSize = true;
            label1.Location = new Point(151, 722);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 58;
            label1.Text = "Oblast analize";

            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(455, 626);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 57;

            dtpdatum.Location = new Point(438, 295);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 56;

            label6.AutoSize = true;
            label6.Location = new Point(156, 626);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 55;
            label6.Text = "Status aranzmana";

            label5.AutoSize = true;
            label5.Location = new Point(156, 537);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 54;
            label5.Text = "Email";

            label4.AutoSize = true;
            label4.Location = new Point(156, 472);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 53;
            label4.Text = "Drzava";

            label3.AutoSize = true;
            label3.Location = new Point(156, 304);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 52;
            label3.Text = "Datum rodjenja";

            label2.AutoSize = true;
            label2.Location = new Point(156, 218);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 51;
            label2.Text = "Prezime";

            imelbl.AutoSize = true;
            imelbl.Location = new Point(156, 146);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 50;
            imelbl.Text = "Ime";

            textBoxemail.Location = new Point(438, 550);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 49;

            textBoxdrzava.Location = new Point(438, 466);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 48;

            textBoxPrezime.Location = new Point(438, 214);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 47;

            textBoxIme.Location = new Point(438, 140);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 46;

            savebtn.Location = new Point(881, 1017);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(188, 58);
            savebtn.TabIndex = 64;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;

            dtpdatumprvogangazovanja.Location = new Point(438, 389);
            dtpdatumprvogangazovanja.Name = "dtpdatumprvogangazovanja";
            dtpdatumprvogangazovanja.Size = new Size(520, 47);
            dtpdatumprvogangazovanja.TabIndex = 66;

            label9.AutoSize = true;
            label9.Location = new Point(131, 395);
            label9.Name = "label9";
            label9.Size = new Size(304, 41);
            label9.TabIndex = 65;
            label9.Text = "Datum 1 angazovanja";

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 1158);
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
    }
}
namespace ESPORT.Forme
{
    partial class DodajAnaliticaraForm
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
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxoblastanalize = new TextBox();
            textBoxalati = new TextBox();
            textBoxnivoiskustva = new TextBox();
            btnsave = new Button();
            dtpdatumprvogangazovanja = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();

            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(407, 619);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 39;

            dtpdatum.Location = new Point(390, 282);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 38;

            label6.AutoSize = true;
            label6.Location = new Point(108, 619);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 37;
            label6.Text = "Status aranzmana";

            label5.AutoSize = true;
            label5.Location = new Point(108, 530);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 36;
            label5.Text = "Email";

            label4.AutoSize = true;
            label4.Location = new Point(108, 465);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 35;
            label4.Text = "Drzava";

            label3.AutoSize = true;
            label3.Location = new Point(108, 291);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 34;
            label3.Text = "Datum rodjenja";

            label2.AutoSize = true;
            label2.Location = new Point(108, 205);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 33;
            label2.Text = "Prezime";

            imelbl.AutoSize = true;
            imelbl.Location = new Point(108, 133);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 32;
            imelbl.Text = "Ime";

            textBoxemail.Location = new Point(390, 543);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 30;

            textBoxdrzava.Location = new Point(390, 459);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 29;

            textBoxPrezime.Location = new Point(390, 201);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 28;

            textBoxIme.Location = new Point(390, 127);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 27;

            label1.AutoSize = true;
            label1.Location = new Point(103, 715);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 40;
            label1.Text = "Oblast analize";

            label7.AutoSize = true;
            label7.Location = new Point(108, 796);
            label7.Name = "label7";
            label7.Size = new Size(76, 41);
            label7.TabIndex = 41;
            label7.Text = "Alati";

            label8.AutoSize = true;
            label8.Location = new Point(103, 877);
            label8.Name = "label8";
            label8.Size = new Size(191, 41);
            label8.TabIndex = 42;
            label8.Text = "Nivo iskustva";

            textBoxoblastanalize.Location = new Point(390, 716);
            textBoxoblastanalize.Name = "textBoxoblastanalize";
            textBoxoblastanalize.Size = new Size(520, 47);
            textBoxoblastanalize.TabIndex = 43;

            textBoxalati.Location = new Point(390, 796);
            textBoxalati.Name = "textBoxalati";
            textBoxalati.Size = new Size(520, 47);
            textBoxalati.TabIndex = 44;

            textBoxnivoiskustva.Location = new Point(386, 873);
            textBoxnivoiskustva.Name = "textBoxnivoiskustva";
            textBoxnivoiskustva.Size = new Size(524, 47);
            textBoxnivoiskustva.TabIndex = 45;

            btnsave.Location = new Point(912, 1122);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(188, 58);
            btnsave.TabIndex = 46;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;

            dtpdatumprvogangazovanja.Location = new Point(390, 367);
            dtpdatumprvogangazovanja.Name = "dtpdatumprvogangazovanja";
            dtpdatumprvogangazovanja.Size = new Size(520, 47);
            dtpdatumprvogangazovanja.TabIndex = 49;

            label9.AutoSize = true;
            label9.Location = new Point(83, 373);
            label9.Name = "label9";
            label9.Size = new Size(304, 41);
            label9.TabIndex = 48;
            label9.Text = "Datum 1 angazovanja";

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 1274);
            Controls.Add(dtpdatumprvogangazovanja);
            Controls.Add(label9);
            Controls.Add(btnsave);
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
            Name = "DodajAnaliticaraForm";
            Text = "DodajAnaliticaraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox textBoxoblastanalize;
        private TextBox textBoxalati;
        private TextBox textBoxnivoiskustva;
        private Button btnsave;
        private DateTimePicker dtpdatumprvogangazovanja;
        private Label label9;
    }
}
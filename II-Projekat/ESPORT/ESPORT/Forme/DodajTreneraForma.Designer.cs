namespace ESPORT.Forme
{
    partial class DodajTreneraForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            textboxstilrada = new TextBox();
            comboBoxtipuloge = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dtpdatumprvogangazovanja = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // comboBoxstatusaranzmana
            // 
            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(402, 543);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 39;
            // 
            // dtpdatum
            // 
            dtpdatum.Location = new Point(427, 240);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(507, 47);
            dtpdatum.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 543);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 37;
            label6.Text = "Status aranzmana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 454);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 36;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 389);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 35;
            label4.Text = "Drzava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 245);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 34;
            label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 159);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 33;
            label2.Text = "Prezime";
            // 
            // imelbl
            // 
            imelbl.AutoSize = true;
            imelbl.Location = new Point(120, 87);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 32;
            imelbl.Text = "Ime";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(402, 467);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 30;
            // 
            // textBoxdrzava
            // 
            textBoxdrzava.Location = new Point(402, 383);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 29;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(380, 153);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 28;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(380, 81);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 625);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 40;
            label1.Text = "Tip uloge";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 699);
            label7.Name = "label7";
            label7.Size = new Size(123, 41);
            label7.TabIndex = 41;
            label7.Text = "Stil rada";
            // 
            // textboxstilrada
            // 
            textboxstilrada.Location = new Point(402, 699);
            textboxstilrada.Name = "textboxstilrada";
            textboxstilrada.Size = new Size(520, 47);
            textboxstilrada.TabIndex = 42;
            // 
            // comboBoxtipuloge
            // 
            comboBoxtipuloge.FormattingEnabled = true;
            comboBoxtipuloge.Items.AddRange(new object[] { "Glavni", "Pomoćni", "Strateški" });
            comboBoxtipuloge.Location = new Point(404, 619);
            comboBoxtipuloge.Name = "comboBoxtipuloge";
            comboBoxtipuloge.Size = new Size(302, 49);
            comboBoxtipuloge.TabIndex = 43;
            // 
            // button1
            // 
            button1.Location = new Point(811, 837);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 44;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(591, 837);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 45;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // dtpdatumprvogangazovanja
            // 
            dtpdatumprvogangazovanja.Location = new Point(427, 315);
            dtpdatumprvogangazovanja.Name = "dtpdatumprvogangazovanja";
            dtpdatumprvogangazovanja.Size = new Size(507, 47);
            dtpdatumprvogangazovanja.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(120, 321);
            label8.Name = "label8";
            label8.Size = new Size(304, 41);
            label8.TabIndex = 46;
            label8.Text = "Datum 1 angazovanja";
            // 
            // DodajTreneraForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 984);
            Controls.Add(dtpdatumprvogangazovanja);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxtipuloge);
            Controls.Add(textboxstilrada);
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
            Name = "DodajTreneraForma";
            Text = "DodajTreneraForma";
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
        private TextBox textboxstilrada;
        private ComboBox comboBoxtipuloge;
        private Button button1;
        private Button button2;
        private DateTimePicker dtpdatumprvogangazovanja;
        private Label label8;
    }
}
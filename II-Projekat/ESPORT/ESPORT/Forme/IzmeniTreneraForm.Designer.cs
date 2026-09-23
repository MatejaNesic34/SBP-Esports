namespace ESPORT.Forme
{
    partial class IzmeniTreneraForm
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
            button2 = new Button();
            savebtn = new Button();
            comboBoxtipuloge = new ComboBox();
            textboxstilrada = new TextBox();
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
            dtpdatumprvogangazovanja = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(634, 890);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 63;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(854, 890);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(188, 58);
            savebtn.TabIndex = 62;
            savebtn.Text = "Sacuvaj";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // comboBoxtipuloge
            // 
            comboBoxtipuloge.FormattingEnabled = true;
            comboBoxtipuloge.Items.AddRange(new object[] { "Glavni", "Pomoćni", "Strateški" });
            comboBoxtipuloge.Location = new Point(447, 684);
            comboBoxtipuloge.Name = "comboBoxtipuloge";
            comboBoxtipuloge.Size = new Size(302, 49);
            comboBoxtipuloge.TabIndex = 61;
            // 
            // textboxstilrada
            // 
            textboxstilrada.Location = new Point(445, 764);
            textboxstilrada.Name = "textboxstilrada";
            textboxstilrada.Size = new Size(520, 47);
            textboxstilrada.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 764);
            label7.Name = "label7";
            label7.Size = new Size(123, 41);
            label7.TabIndex = 59;
            label7.Text = "Stil rada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 690);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 58;
            label1.Text = "Tip uloge";
            // 
            // comboBoxstatusaranzmana
            // 
            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(445, 608);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 57;
            // 
            // dtpdatum
            // 
            dtpdatum.Location = new Point(458, 289);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(507, 47);
            dtpdatum.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 608);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 55;
            label6.Text = "Status aranzmana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 519);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 54;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 454);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 53;
            label4.Text = "Drzava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 298);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 52;
            label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 212);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 51;
            label2.Text = "Prezime";
            // 
            // imelbl
            // 
            imelbl.AutoSize = true;
            imelbl.Location = new Point(163, 140);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 50;
            imelbl.Text = "Ime";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(445, 532);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 49;
            // 
            // textBoxdrzava
            // 
            textBoxdrzava.Location = new Point(445, 448);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 48;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(445, 208);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 47;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(445, 134);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 46;
            // 
            // dtpdatumprvogangazovanja
            // 
            dtpdatumprvogangazovanja.Location = new Point(458, 366);
            dtpdatumprvogangazovanja.Name = "dtpdatumprvogangazovanja";
            dtpdatumprvogangazovanja.Size = new Size(507, 47);
            dtpdatumprvogangazovanja.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 371);
            label8.Name = "label8";
            label8.Size = new Size(304, 41);
            label8.TabIndex = 64;
            label8.Text = "Datum 1 angazovanja";
            // 
            // IzmeniTreneraForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 1034);
            Controls.Add(dtpdatumprvogangazovanja);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(savebtn);
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
            Name = "IzmeniTreneraForm";
            Text = "IzmeniTreneraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button savebtn;
        private ComboBox comboBoxtipuloge;
        private TextBox textboxstilrada;
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
        private DateTimePicker dtpdatumprvogangazovanja;
        private Label label8;
    }
}
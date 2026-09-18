namespace ESPORT.Forme
{
    partial class DodajMenadzeraForma
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
            btnsave = new Button();
            textBoxoblastodgovornosti = new TextBox();
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
            SuspendLayout();
            // 
            // btnsave
            // 
            btnsave.Location = new Point(765, 986);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(188, 58);
            btnsave.TabIndex = 65;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // textBoxoblastodgovornosti
            // 
            textBoxoblastodgovornosti.Location = new Point(396, 602);
            textBoxoblastodgovornosti.Name = "textBoxoblastodgovornosti";
            textBoxoblastodgovornosti.Size = new Size(520, 47);
            textBoxoblastodgovornosti.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 602);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 59;
            label1.Text = "Oblast odgovornosti";
            // 
            // comboBoxstatusaranzmana
            // 
            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(413, 505);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 58;
            // 
            // dtpdatum
            // 
            dtpdatum.Location = new Point(396, 254);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 505);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 56;
            label6.Text = "Status aranzmana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 416);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 55;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 351);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 54;
            label4.Text = "Drzava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 263);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 53;
            label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 177);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 52;
            label2.Text = "Prezime";
            // 
            // imelbl
            // 
            imelbl.AutoSize = true;
            imelbl.Location = new Point(114, 105);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 51;
            imelbl.Text = "Ime";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(396, 429);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 50;
            // 
            // textBoxdrzava
            // 
            textBoxdrzava.Location = new Point(396, 345);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 49;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(396, 173);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 48;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(396, 99);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 47;
            // 
            // DodajMenadzeraForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 1130);
            Controls.Add(btnsave);
            Controls.Add(textBoxoblastodgovornosti);
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
            Name = "DodajMenadzeraForma";
            Text = "DodajMenadzeraForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsave;
        private TextBox textBoxoblastodgovornosti;
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
    }
}
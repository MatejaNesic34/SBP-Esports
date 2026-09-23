namespace ESPORT.Forme
{
    partial class DodajSkautaForma
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
            dtpdatumprvogangazovanja = new DateTimePicker();
            label9 = new Label();
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
            cmbigre = new ComboBox();
            savebtn = new Button();
            SuspendLayout();
            // 
            // dtpdatumprvogangazovanja
            // 
            dtpdatumprvogangazovanja.Location = new Point(380, 571);
            dtpdatumprvogangazovanja.Name = "dtpdatumprvogangazovanja";
            dtpdatumprvogangazovanja.Size = new Size(520, 47);
            dtpdatumprvogangazovanja.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(73, 577);
            label9.Name = "label9";
            label9.Size = new Size(304, 41);
            label9.TabIndex = 62;
            label9.Text = "Datum 1 angazovanja";
            // 
            // comboBoxstatusaranzmana
            // 
            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(380, 489);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 61;
            // 
            // dtpdatum
            // 
            dtpdatum.Location = new Point(363, 247);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 489);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 59;
            label6.Text = "Status aranzmana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 400);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 58;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 335);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 57;
            label4.Text = "Drzava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 256);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 56;
            label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 170);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 55;
            label2.Text = "Prezime";
            // 
            // imelbl
            // 
            imelbl.AutoSize = true;
            imelbl.Location = new Point(81, 98);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 54;
            imelbl.Text = "Ime";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(363, 413);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 53;
            // 
            // textBoxdrzava
            // 
            textBoxdrzava.Location = new Point(363, 329);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 52;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(363, 166);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 51;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(363, 92);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 661);
            label1.Name = "label1";
            label1.Size = new Size(69, 41);
            label1.TabIndex = 64;
            label1.Text = "Igra";
            // 
            // cmbigre
            // 
            cmbigre.FormattingEnabled = true;
            cmbigre.Location = new Point(353, 670);
            cmbigre.Name = "cmbigre";
            cmbigre.Size = new Size(408, 49);
            cmbigre.TabIndex = 65;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(737, 875);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(188, 58);
            savebtn.TabIndex = 66;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // DodajSkautaForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 1008);
            Controls.Add(savebtn);
            Controls.Add(cmbigre);
            Controls.Add(label1);
            Controls.Add(dtpdatumprvogangazovanja);
            Controls.Add(label9);
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
            Name = "DodajSkautaForma";
            Text = "DodajSkautaForma";
            Load += DodajSkautaForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpdatumprvogangazovanja;
        private Label label9;
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
        private ComboBox cmbigre;
        private Button savebtn;
    }
}
namespace ESPORT.Forme
{
    partial class DodajPsihologaForma
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
            btnsave = new Button();
            textBoxoblastrada = new TextBox();
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
            textBoxperioddostupnosti = new TextBox();
            label7 = new Label();
            SuspendLayout();

            btnsave.Location = new Point(756, 1003);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(188, 58);
            btnsave.TabIndex = 80;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;

            textBoxoblastrada.Location = new Point(387, 619);
            textBoxoblastrada.Name = "textBoxoblastrada";
            textBoxoblastrada.Size = new Size(520, 47);
            textBoxoblastrada.TabIndex = 79;

            label1.AutoSize = true;
            label1.Location = new Point(90, 619);
            label1.Name = "label1";
            label1.Size = new Size(170, 41);
            label1.TabIndex = 78;
            label1.Text = "Oblast rada";

            comboBoxstatusaranzmana.FormattingEnabled = true;
            comboBoxstatusaranzmana.Items.AddRange(new object[] { "Aktivno", "Neaktivno" });
            comboBoxstatusaranzmana.Location = new Point(404, 522);
            comboBoxstatusaranzmana.Name = "comboBoxstatusaranzmana";
            comboBoxstatusaranzmana.Size = new Size(302, 49);
            comboBoxstatusaranzmana.TabIndex = 77;

            dtpdatum.Location = new Point(387, 271);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(520, 47);
            dtpdatum.TabIndex = 76;

            label6.AutoSize = true;
            label6.Location = new Point(105, 522);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 75;
            label6.Text = "Status aranzmana";

            label5.AutoSize = true;
            label5.Location = new Point(105, 433);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 74;
            label5.Text = "Email";

            label4.AutoSize = true;
            label4.Location = new Point(105, 368);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 73;
            label4.Text = "Drzava";

            label3.AutoSize = true;
            label3.Location = new Point(105, 280);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 72;
            label3.Text = "Datum rodjenja";

            label2.AutoSize = true;
            label2.Location = new Point(105, 194);
            label2.Name = "label2";
            label2.Size = new Size(124, 41);
            label2.TabIndex = 71;
            label2.Text = "Prezime";

            imelbl.AutoSize = true;
            imelbl.Location = new Point(105, 122);
            imelbl.Name = "imelbl";
            imelbl.Size = new Size(68, 41);
            imelbl.TabIndex = 70;
            imelbl.Text = "Ime";

            textBoxemail.Location = new Point(387, 446);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(520, 47);
            textBoxemail.TabIndex = 69;

            textBoxdrzava.Location = new Point(387, 362);
            textBoxdrzava.Name = "textBoxdrzava";
            textBoxdrzava.Size = new Size(520, 47);
            textBoxdrzava.TabIndex = 68;

            textBoxPrezime.Location = new Point(387, 190);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(520, 47);
            textBoxPrezime.TabIndex = 67;

            textBoxIme.Location = new Point(387, 116);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(520, 47);
            textBoxIme.TabIndex = 66;

            textBoxperioddostupnosti.Location = new Point(387, 704);
            textBoxperioddostupnosti.Name = "textBoxperioddostupnosti";
            textBoxperioddostupnosti.Size = new Size(520, 47);
            textBoxperioddostupnosti.TabIndex = 82;

            label7.AutoSize = true;
            label7.Location = new Point(90, 704);
            label7.Name = "label7";
            label7.Size = new Size(270, 41);
            label7.TabIndex = 81;
            label7.Text = "Period dostupnosti";

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 1141);
            Controls.Add(textBoxperioddostupnosti);
            Controls.Add(label7);
            Controls.Add(btnsave);
            Controls.Add(textBoxoblastrada);
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
            Name = "DodajPsihologaForma";
            Text = "DodajPsihologaForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsave;
        private TextBox textBoxoblastrada;
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
        private TextBox textBoxperioddostupnosti;
        private Label label7;
    }
}
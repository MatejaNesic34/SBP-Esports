namespace ESPORT.Forme
{
    partial class DodajLicencuForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numid = new NumericUpDown();
            textBoxnaziv = new TextBox();
            textBoxinstitucija = new TextBox();
            dtpdatum = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numid).BeginInit();
            SuspendLayout();

            btnsave.Location = new Point(701, 635);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(188, 58);
            btnsave.TabIndex = 0;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;

            label1.AutoSize = true;
            label1.Location = new Point(99, 134);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 1;
            label1.Text = "ID osobe";

            label2.AutoSize = true;
            label2.Location = new Point(99, 216);
            label2.Name = "label2";
            label2.Size = new Size(90, 41);
            label2.TabIndex = 2;
            label2.Text = "Naziv";

            label3.AutoSize = true;
            label3.Location = new Point(99, 292);
            label3.Name = "label3";
            label3.Size = new Size(143, 41);
            label3.TabIndex = 3;
            label3.Text = "Institucija";

            label4.AutoSize = true;
            label4.Location = new Point(109, 380);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 4;
            label4.Text = "Datum";

            numid.Location = new Point(389, 134);
            numid.Name = "numid";
            numid.Size = new Size(500, 47);
            numid.TabIndex = 7;

            textBoxnaziv.Location = new Point(389, 210);
            textBoxnaziv.Name = "textBoxnaziv";
            textBoxnaziv.Size = new Size(500, 47);
            textBoxnaziv.TabIndex = 8;

            textBoxinstitucija.Location = new Point(389, 286);
            textBoxinstitucija.Name = "textBoxinstitucija";
            textBoxinstitucija.Size = new Size(500, 47);
            textBoxinstitucija.TabIndex = 9;

            dtpdatum.Location = new Point(389, 380);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(500, 47);
            dtpdatum.TabIndex = 12;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 744);
            Controls.Add(dtpdatum);
            Controls.Add(textBoxinstitucija);
            Controls.Add(textBoxnaziv);
            Controls.Add(numid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsave);
            Name = "DodajLicencuForm";
            Text = "DodajLicencuForm";
            ((System.ComponentModel.ISupportInitialize)numid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numid;
        private TextBox textBoxnaziv;
        private TextBox textBoxinstitucija;
        private DateTimePicker dtpdatum;
    }
}
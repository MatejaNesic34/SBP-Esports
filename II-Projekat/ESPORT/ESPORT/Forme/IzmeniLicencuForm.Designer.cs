namespace ESPORT.Forme
{
    partial class IzmeniLicencuForm
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
            dtpdatum = new DateTimePicker();
            textBoxinstitucija = new TextBox();
            textBoxnaziv = new TextBox();
            numid = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnsave = new Button();
            ((System.ComponentModel.ISupportInitialize)numid).BeginInit();
            SuspendLayout();

            dtpdatum.Location = new Point(336, 359);
            dtpdatum.Name = "dtpdatum";
            dtpdatum.Size = new Size(500, 47);
            dtpdatum.TabIndex = 21;

            textBoxinstitucija.Location = new Point(336, 265);
            textBoxinstitucija.Name = "textBoxinstitucija";
            textBoxinstitucija.Size = new Size(500, 47);
            textBoxinstitucija.TabIndex = 20;

            textBoxnaziv.Location = new Point(336, 189);
            textBoxnaziv.Name = "textBoxnaziv";
            textBoxnaziv.Size = new Size(500, 47);
            textBoxnaziv.TabIndex = 19;

            numid.Location = new Point(336, 113);
            numid.Name = "numid";
            numid.Size = new Size(500, 47);
            numid.TabIndex = 18;

            label4.AutoSize = true;
            label4.Location = new Point(56, 359);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 17;
            label4.Text = "Datum";

            label3.AutoSize = true;
            label3.Location = new Point(46, 271);
            label3.Name = "label3";
            label3.Size = new Size(143, 41);
            label3.TabIndex = 16;
            label3.Text = "Institucija";

            label2.AutoSize = true;
            label2.Location = new Point(46, 195);
            label2.Name = "label2";
            label2.Size = new Size(90, 41);
            label2.TabIndex = 15;
            label2.Text = "Naziv";

            label1.AutoSize = true;
            label1.Location = new Point(46, 113);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 14;
            label1.Text = "ID osobe";

            btnsave.Location = new Point(648, 614);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(188, 58);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 737);
            Controls.Add(dtpdatum);
            Controls.Add(textBoxinstitucija);
            Controls.Add(textBoxnaziv);
            Controls.Add(numid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsave);
            Name = "IzmeniLicencuForm";
            Text = "IzmeniLicencuForm";
            ((System.ComponentModel.ISupportInitialize)numid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpdatum;
        private TextBox textBoxinstitucija;
        private TextBox textBoxnaziv;
        private NumericUpDown numid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnsave;
    }
}
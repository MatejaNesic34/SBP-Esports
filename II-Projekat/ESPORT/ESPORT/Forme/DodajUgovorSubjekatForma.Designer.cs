namespace ESPORT.Forme
{
    partial class DodajUgovorSubjekatForma
    {
        System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        void InitializeComponent()
        {
            this.cmbUgovor = new System.Windows.Forms.ComboBox();
            this.cmbTipSubjekta = new System.Windows.Forms.ComboBox();
            this.cmbKonkretanSubjekat = new System.Windows.Forms.ComboBox();
            this.lblUgovor = new System.Windows.Forms.Label();
            this.lblTipSubjekta = new System.Windows.Forms.Label();
            this.lblSubjekat = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.cmbUgovor.FormattingEnabled = true;
            this.cmbUgovor.Location = new System.Drawing.Point(150, 30);
            this.cmbUgovor.Name = "cmbUgovor";
            this.cmbUgovor.Size = new System.Drawing.Size(250, 24);
            this.cmbUgovor.TabIndex = 0;

            this.cmbTipSubjekta.FormattingEnabled = true;
            this.cmbTipSubjekta.Location = new System.Drawing.Point(150, 80);
            this.cmbTipSubjekta.Name = "cmbTipSubjekta";
            this.cmbTipSubjekta.Size = new System.Drawing.Size(250, 24);
            this.cmbTipSubjekta.TabIndex = 1;
            this.cmbTipSubjekta.SelectedIndexChanged += new System.EventHandler(this.cmbTipSubjekta_SelectedIndexChanged);

            this.cmbKonkretanSubjekat.FormattingEnabled = true;
            this.cmbKonkretanSubjekat.Location = new System.Drawing.Point(150, 130);
            this.cmbKonkretanSubjekat.Name = "cmbKonkretanSubjekat";
            this.cmbKonkretanSubjekat.Size = new System.Drawing.Size(250, 24);
            this.cmbKonkretanSubjekat.TabIndex = 2;

            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Location = new System.Drawing.Point(30, 33);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(54, 16);
            this.lblUgovor.TabIndex = 3;
            this.lblUgovor.Text = "Ugovor:";

            this.lblTipSubjekta.AutoSize = true;
            this.lblTipSubjekta.Location = new System.Drawing.Point(30, 83);
            this.lblTipSubjekta.Name = "lblTipSubjekta";
            this.lblTipSubjekta.Size = new System.Drawing.Size(84, 16);
            this.lblTipSubjekta.TabIndex = 4;
            this.lblTipSubjekta.Text = "Tip subjekta:";

            this.lblSubjekat.AutoSize = true;
            this.lblSubjekat.Location = new System.Drawing.Point(30, 133);
            this.lblSubjekat.Name = "lblSubjekat";
            this.lblSubjekat.Size = new System.Drawing.Size(63, 16);
            this.lblSubjekat.TabIndex = 5;
            this.lblSubjekat.Text = "Subjekat:";

            this.btnSacuvaj.Location = new System.Drawing.Point(150, 190);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(110, 30);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);

            this.btnOtkazi.Location = new System.Drawing.Point(290, 190);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(110, 30);
            this.btnOtkazi.TabIndex = 7;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 250);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblSubjekat);
            this.Controls.Add(this.lblTipSubjekta);
            this.Controls.Add(this.lblUgovor);
            this.Controls.Add(this.cmbKonkretanSubjekat);
            this.Controls.Add(this.cmbTipSubjekta);
            this.Controls.Add(this.cmbUgovor);
            this.Name = "DodajUgovorSubjekatForma";
            this.Text = "Dodaj ugovor subjekat";
            this.Load += new System.EventHandler(this.DodajUgovorSubjekatForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        System.Windows.Forms.ComboBox cmbUgovor;
        System.Windows.Forms.ComboBox cmbTipSubjekta;
        System.Windows.Forms.ComboBox cmbKonkretanSubjekat;
        System.Windows.Forms.Label lblUgovor;
        System.Windows.Forms.Label lblTipSubjekta;
        System.Windows.Forms.Label lblSubjekat;
        System.Windows.Forms.Button btnSacuvaj;
        System.Windows.Forms.Button btnOtkazi;
    }
}
namespace ESPORT.Forme
{
    partial class IzmeniSponzoraForma
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
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblDrzava = new Label();
            txtDrzava = new TextBox();
            lblTipSponzora = new Label();
            txtTipSponzora = new TextBox();
            lblOblastPoslovanja = new Label();
            txtOblastPoslovanja = new TextBox();
            btnIzmeni = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(24, 24);
            lblNaziv.Margin = new Padding(1, 0, 1, 0);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(49, 20);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";

            txtNaziv.Location = new Point(172, 24);
            txtNaziv.Margin = new Padding(1, 1, 1, 1);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(190, 27);
            txtNaziv.TabIndex = 1;

            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(24, 63);
            lblDrzava.Margin = new Padding(1, 0, 1, 0);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(58, 20);
            lblDrzava.TabIndex = 2;
            lblDrzava.Text = "Država:";

            txtDrzava.Location = new Point(172, 63);
            txtDrzava.Margin = new Padding(1, 1, 1, 1);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(190, 27);
            txtDrzava.TabIndex = 3;

            lblTipSponzora.AutoSize = true;
            lblTipSponzora.Location = new Point(24, 102);
            lblTipSponzora.Margin = new Padding(1, 0, 1, 0);
            lblTipSponzora.Name = "lblTipSponzora";
            lblTipSponzora.Size = new Size(98, 20);
            lblTipSponzora.TabIndex = 4;
            lblTipSponzora.Text = "Tip sponzora:";

            txtTipSponzora.Location = new Point(172, 102);
            txtTipSponzora.Margin = new Padding(1, 1, 1, 1);
            txtTipSponzora.Name = "txtTipSponzora";
            txtTipSponzora.Size = new Size(190, 27);
            txtTipSponzora.TabIndex = 5;

            lblOblastPoslovanja.AutoSize = true;
            lblOblastPoslovanja.Location = new Point(24, 141);
            lblOblastPoslovanja.Margin = new Padding(1, 0, 1, 0);
            lblOblastPoslovanja.Name = "lblOblastPoslovanja";
            lblOblastPoslovanja.Size = new Size(131, 20);
            lblOblastPoslovanja.TabIndex = 6;
            lblOblastPoslovanja.Text = "Oblast poslovanja:";

            txtOblastPoslovanja.Location = new Point(172, 141);
            txtOblastPoslovanja.Margin = new Padding(1, 1, 1, 1);
            txtOblastPoslovanja.Name = "txtOblastPoslovanja";
            txtOblastPoslovanja.Size = new Size(190, 27);
            txtOblastPoslovanja.TabIndex = 7;

            btnIzmeni.Location = new Point(141, 195);
            btnIzmeni.Margin = new Padding(1, 1, 1, 1);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(85, 29);
            btnIzmeni.TabIndex = 8;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnOdustani.Location = new Point(245, 195);
            btnOdustani.Margin = new Padding(1, 1, 1, 1);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(85, 29);
            btnOdustani.TabIndex = 9;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 254);
            Controls.Add(btnOdustani);
            Controls.Add(btnIzmeni);
            Controls.Add(txtOblastPoslovanja);
            Controls.Add(lblOblastPoslovanja);
            Controls.Add(txtTipSponzora);
            Controls.Add(lblTipSponzora);
            Controls.Add(txtDrzava);
            Controls.Add(lblDrzava);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Margin = new Padding(1, 1, 1, 1);
            Name = "IzmeniSponzoraForma";
            Text = "Izmeni Sponzora";
            Load += IzmeniSponzoraForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private TextBox txtNaziv;
        private Label lblDrzava;
        private TextBox txtDrzava;
        private Label lblTipSponzora;
        private TextBox txtTipSponzora;
        private Label lblOblastPoslovanja;
        private TextBox txtOblastPoslovanja;
        private Button btnIzmeni;
        private Button btnOdustani;
    }
}
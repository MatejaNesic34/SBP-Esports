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
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(50, 50);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(85, 41);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(300, 47);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(400, 47);
            txtNaziv.TabIndex = 1;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(50, 130);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(111, 41);
            lblDrzava.TabIndex = 2;
            lblDrzava.Text = "Država:";
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(300, 127);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(400, 47);
            txtDrzava.TabIndex = 3;
            // 
            // lblTipSponzora
            // 
            lblTipSponzora.AutoSize = true;
            lblTipSponzora.Location = new Point(50, 210);
            lblTipSponzora.Name = "lblTipSponzora";
            lblTipSponzora.Size = new Size(196, 41);
            lblTipSponzora.TabIndex = 4;
            lblTipSponzora.Text = "Tip sponzora:";
            // 
            // txtTipSponzora
            // 
            txtTipSponzora.Location = new Point(300, 207);
            txtTipSponzora.Name = "txtTipSponzora";
            txtTipSponzora.Size = new Size(400, 47);
            txtTipSponzora.TabIndex = 5;
            // 
            // lblOblastPoslovanja
            // 
            lblOblastPoslovanja.AutoSize = true;
            lblOblastPoslovanja.Location = new Point(50, 290);
            lblOblastPoslovanja.Name = "lblOblastPoslovanja";
            lblOblastPoslovanja.Size = new Size(244, 41);
            lblOblastPoslovanja.TabIndex = 6;
            lblOblastPoslovanja.Text = "Oblast poslovanja:";
            // 
            // txtOblastPoslovanja
            // 
            txtOblastPoslovanja.Location = new Point(300, 287);
            txtOblastPoslovanja.Name = "txtOblastPoslovanja";
            txtOblastPoslovanja.Size = new Size(400, 47);
            txtOblastPoslovanja.TabIndex = 7;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(300, 400);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(180, 60);
            btnIzmeni.TabIndex = 8;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(520, 400);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(180, 60);
            btnOdustani.TabIndex = 9;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // IzmeniSponzoraForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 520);
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
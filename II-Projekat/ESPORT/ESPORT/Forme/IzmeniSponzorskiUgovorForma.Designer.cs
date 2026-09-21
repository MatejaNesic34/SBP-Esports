namespace ESPORT.Forme
{
    partial class IzmeniSponzorskiUgovorForma
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

        private void InitializeComponent()
        {
            lblDatumOd = new Label();
            dtpDatumOd = new DateTimePicker();
            lblDatumDo = new Label();
            dtpDatumDo = new DateTimePicker();
            lblIznos = new Label();
            txtIznos = new TextBox();
            lblValuta = new Label();
            txtValuta = new TextBox();
            lblTipPodrske = new Label();
            txtTipPodrske = new TextBox();
            lblMarketinskeObaveze = new Label();
            txtMarketinskeObaveze = new TextBox();
            btnIzmeni = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            lblDatumOd.AutoSize = true;
            lblDatumOd.Location = new Point(40, 40);
            lblDatumOd.Text = "Datum od:";

            dtpDatumOd.Location = new Point(320, 37);
            dtpDatumOd.Format = DateTimePickerFormat.Short;
            dtpDatumOd.Size = new Size(350, 47);

            lblDatumDo.AutoSize = true;
            lblDatumDo.Location = new Point(40, 110);
            lblDatumDo.Text = "Datum do:";

            dtpDatumDo.Location = new Point(320, 107);
            dtpDatumDo.Format = DateTimePickerFormat.Short;
            dtpDatumDo.Size = new Size(350, 47);

            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(40, 180);
            lblIznos.Text = "Iznos:";

            txtIznos.Location = new Point(320, 177);
            txtIznos.Size = new Size(350, 47);

            lblValuta.AutoSize = true;
            lblValuta.Location = new Point(40, 250);
            lblValuta.Text = "Valuta:";

            txtValuta.Location = new Point(320, 247);
            txtValuta.Size = new Size(350, 47);

            lblTipPodrske.AutoSize = true;
            lblTipPodrske.Location = new Point(40, 320);
            lblTipPodrske.Text = "Tip podrške:";

            txtTipPodrske.Location = new Point(320, 317);
            txtTipPodrske.Size = new Size(350, 47);

            lblMarketinskeObaveze.AutoSize = true;
            lblMarketinskeObaveze.Location = new Point(40, 390);
            lblMarketinskeObaveze.Text = "Marketinške obaveze:";

            txtMarketinskeObaveze.Location = new Point(320, 387);
            txtMarketinskeObaveze.Size = new Size(350, 47);

            btnIzmeni.Location = new Point(320, 480);
            btnIzmeni.Size = new Size(160, 60);
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnOdustani.Location = new Point(510, 480);
            btnOdustani.Size = new Size(160, 60);
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 580);
            Controls.Add(btnOdustani);
            Controls.Add(btnIzmeni);
            Controls.Add(txtMarketinskeObaveze);
            Controls.Add(lblMarketinskeObaveze);
            Controls.Add(txtTipPodrske);
            Controls.Add(lblTipPodrske);
            Controls.Add(txtValuta);
            Controls.Add(lblValuta);
            Controls.Add(txtIznos);
            Controls.Add(lblIznos);
            Controls.Add(dtpDatumDo);
            Controls.Add(lblDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(lblDatumOd);
            Name = "IzmeniSponzorskiUgovorForma";
            Text = "Izmeni Sponzorski Ugovor";
            Load += IzmeniSponzorskiUgovorForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDatumOd;
        private DateTimePicker dtpDatumOd;
        private Label lblDatumDo;
        private DateTimePicker dtpDatumDo;
        private Label lblIznos;
        private TextBox txtIznos;
        private Label lblValuta;
        private TextBox txtValuta;
        private Label lblTipPodrske;
        private TextBox txtTipPodrske;
        private Label lblMarketinskeObaveze;
        private TextBox txtMarketinskeObaveze;
        private Button btnIzmeni;
        private Button btnOdustani;
    }
}
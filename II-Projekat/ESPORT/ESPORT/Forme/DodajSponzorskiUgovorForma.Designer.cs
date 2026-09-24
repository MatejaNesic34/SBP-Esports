namespace ESPORT.Forme
{
    partial class DodajSponzorskiUgovorForma
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
            lblTipPodrske = new Label();
            lblMarketinskeObaveze = new Label();
            txtMarketinskeObaveze = new TextBox();
            btnDodaj = new Button();
            btnOdustani = new Button();
            cmbTipPodrske = new ComboBox();
            cmbValuta = new ComboBox();
            SuspendLayout();
            // 
            // lblDatumOd
            // 
            lblDatumOd.AutoSize = true;
            lblDatumOd.Location = new Point(40, 40);
            lblDatumOd.Name = "lblDatumOd";
            lblDatumOd.Size = new Size(158, 41);
            lblDatumOd.TabIndex = 13;
            lblDatumOd.Text = "Datum od:";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Format = DateTimePickerFormat.Short;
            dtpDatumOd.Location = new Point(320, 37);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(350, 47);
            dtpDatumOd.TabIndex = 12;
            // 
            // lblDatumDo
            // 
            lblDatumDo.AutoSize = true;
            lblDatumDo.Location = new Point(40, 110);
            lblDatumDo.Name = "lblDatumDo";
            lblDatumDo.Size = new Size(158, 41);
            lblDatumDo.TabIndex = 11;
            lblDatumDo.Text = "Datum do:";
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Format = DateTimePickerFormat.Short;
            dtpDatumDo.Location = new Point(320, 107);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(350, 47);
            dtpDatumDo.TabIndex = 10;
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(40, 180);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(95, 41);
            lblIznos.TabIndex = 9;
            lblIznos.Text = "Iznos:";
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(320, 177);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(350, 47);
            txtIznos.TabIndex = 8;
            // 
            // lblValuta
            // 
            lblValuta.AutoSize = true;
            lblValuta.Location = new Point(40, 250);
            lblValuta.Name = "lblValuta";
            lblValuta.Size = new Size(106, 41);
            lblValuta.TabIndex = 7;
            lblValuta.Text = "Valuta:";
            // 
            // lblTipPodrske
            // 
            lblTipPodrske.AutoSize = true;
            lblTipPodrske.Location = new Point(40, 320);
            lblTipPodrske.Name = "lblTipPodrske";
            lblTipPodrske.Size = new Size(182, 41);
            lblTipPodrske.TabIndex = 5;
            lblTipPodrske.Text = "Tip podrške:";
            // 
            // lblMarketinskeObaveze
            // 
            lblMarketinskeObaveze.AutoSize = true;
            lblMarketinskeObaveze.Location = new Point(40, 390);
            lblMarketinskeObaveze.Name = "lblMarketinskeObaveze";
            lblMarketinskeObaveze.Size = new Size(305, 41);
            lblMarketinskeObaveze.TabIndex = 3;
            lblMarketinskeObaveze.Text = "Marketinške obaveze:";
            // 
            // txtMarketinskeObaveze
            // 
            txtMarketinskeObaveze.Location = new Point(320, 387);
            txtMarketinskeObaveze.Name = "txtMarketinskeObaveze";
            txtMarketinskeObaveze.Size = new Size(350, 47);
            txtMarketinskeObaveze.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(320, 480);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(160, 60);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(510, 480);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(160, 60);
            btnOdustani.TabIndex = 0;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // cmbTipPodrske
            // 
            cmbTipPodrske.FormattingEnabled = true;
            cmbTipPodrske.Items.AddRange(new object[] { "Novčani", "Oprema", "Putni troškovi", "Medijska promocija", "Kombinovano" });
            cmbTipPodrske.Location = new Point(320, 317);
            cmbTipPodrske.Name = "cmbTipPodrske";
            cmbTipPodrske.Size = new Size(350, 49);
            cmbTipPodrske.TabIndex = 14;
            // 
            // cmbValuta
            // 
            cmbValuta.FormattingEnabled = true;
            cmbValuta.Items.AddRange(new object[] { "RSD", "EUR", "USD" });
            cmbValuta.Location = new Point(320, 250);
            cmbValuta.Name = "cmbValuta";
            cmbValuta.Size = new Size(350, 49);
            cmbValuta.TabIndex = 15;
            // 
            // DodajSponzorskiUgovorForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 605);
            Controls.Add(cmbValuta);
            Controls.Add(cmbTipPodrske);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodaj);
            Controls.Add(txtMarketinskeObaveze);
            Controls.Add(lblMarketinskeObaveze);
            Controls.Add(lblTipPodrske);
            Controls.Add(lblValuta);
            Controls.Add(txtIznos);
            Controls.Add(lblIznos);
            Controls.Add(dtpDatumDo);
            Controls.Add(lblDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(lblDatumOd);
            Name = "DodajSponzorskiUgovorForma";
            Text = "Dodaj Sponzorski Ugovor";
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
        private Label lblTipPodrske;
        private Label lblMarketinskeObaveze;
        private TextBox txtMarketinskeObaveze;
        private Button btnDodaj;
        private Button btnOdustani;
        private ComboBox cmbTipPodrske;
        private ComboBox cmbValuta;
    }
}
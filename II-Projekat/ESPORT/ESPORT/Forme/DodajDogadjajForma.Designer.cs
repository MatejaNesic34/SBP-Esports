namespace ESPORT.Forme
{
    partial class DodajDogadjajForma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblMec = new Label();
            cmbMec = new ComboBox();

            lblTipDogadjaja = new Label();
            cmbTipDogadjaja = new ComboBox();

            lblVremeDogadjaja = new Label();
            dtpVremeDogadjaja = new DateTimePicker();

            lblOpis = new Label();
            txtOpis = new TextBox();

            lblOdlukaSudije = new Label();
            txtOdlukaSudije = new TextBox();

            dodajBtn = new Button();
            odustaniBtn = new Button();

            SuspendLayout();

            // 
            // lblMec
            // 
            lblMec.AutoSize = true;
            lblMec.Location = new Point(10, 50);
            lblMec.Name = "lblMec";
            lblMec.Size = new Size(55, 41);
            lblMec.Text = "Meč:";

            // 
            // cmbMec
            // 
            cmbMec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMec.FormattingEnabled = true;
            cmbMec.Location = new Point(250, 45);
            cmbMec.Name = "cmbMec";
            cmbMec.Size = new Size(450, 49);

            // 
            // lblTipDogadjaja
            // 
            lblTipDogadjaja.AutoSize = true;
            lblTipDogadjaja.Location = new Point(10, 125);
            lblTipDogadjaja.Name = "lblTipDogadjaja";
            lblTipDogadjaja.Size = new Size(160, 41);
            lblTipDogadjaja.Text = "Tip događaja:";

            // 
            // txtTipDogadjaja
            // 
            cmbTipDogadjaja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipDogadjaja.FormattingEnabled = true;
            cmbTipDogadjaja.Location = new Point(250, 120);
            cmbTipDogadjaja.Name = "cmbTipDogadjaja";
            cmbTipDogadjaja.Size = new Size(400, 40);
            cmbTipDogadjaja.TabIndex = 2;

            // 
            // lblVremeDogadjaja
            // 
            lblVremeDogadjaja.AutoSize = true;
            lblVremeDogadjaja.Location = new Point(10, 200);
            lblVremeDogadjaja.Name = "lblVremeDogadjaja";
            lblVremeDogadjaja.Size = new Size(185, 41);
            lblVremeDogadjaja.Text = "Vreme događaja:";

            // 
            // dtpVremeDogadjaja
            // 
            dtpVremeDogadjaja.Format = DateTimePickerFormat.Custom;
            dtpVremeDogadjaja.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpVremeDogadjaja.Location = new Point(250, 195);
            dtpVremeDogadjaja.Name = "dtpVremeDogadjaja";
            dtpVremeDogadjaja.Size = new Size(300, 47);

            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(10, 275);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(70, 41);
            lblOpis.Text = "Opis:";

            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(250, 270);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(450, 90);

            // 
            // lblOdlukaSudije
            // 
            lblOdlukaSudije.AutoSize = true;
            lblOdlukaSudije.Location = new Point(10, 395);
            lblOdlukaSudije.Name = "lblOdlukaSudije";
            lblOdlukaSudije.Size = new Size(180, 41);
            lblOdlukaSudije.Text = "Odluka sudije:";

            // 
            // txtOdlukaSudije
            // 
            txtOdlukaSudije.Location = new Point(250, 390);
            txtOdlukaSudije.Multiline = true;
            txtOdlukaSudije.Name = "txtOdlukaSudije";
            txtOdlukaSudije.Size = new Size(450, 90);

            // 
            // dodajBtn
            // 
            dodajBtn.Location = new Point(250, 530);
            dodajBtn.Name = "dodajBtn";
            dodajBtn.Size = new Size(200, 70);
            dodajBtn.Text = "Dodaj";
            dodajBtn.UseVisualStyleBackColor = true;
            dodajBtn.Click += dodajBtn_Click;

            // 
            // odustaniBtn
            // 
            odustaniBtn.Location = new Point(500, 530);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(200, 70);
            odustaniBtn.Text = "Otkaži";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            // 
            // DodajDogadjajForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 650);

            Controls.Add(lblMec);
            Controls.Add(cmbMec);

            Controls.Add(lblTipDogadjaja);
            Controls.Add(cmbTipDogadjaja);

            Controls.Add(lblVremeDogadjaja);
            Controls.Add(dtpVremeDogadjaja);

            Controls.Add(lblOpis);
            Controls.Add(txtOpis);

            Controls.Add(lblOdlukaSudije);
            Controls.Add(txtOdlukaSudije);

            Controls.Add(dodajBtn);
            Controls.Add(odustaniBtn);

            Name = "DodajDogadjajForma";
            Text = "Dodavanje događaja";

            Load += DodajDogadjajForma_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMec;
        private ComboBox cmbMec;

        private Label lblTipDogadjaja;
        private ComboBox cmbTipDogadjaja;

        private Label lblVremeDogadjaja;
        private DateTimePicker dtpVremeDogadjaja;

        private Label lblOpis;
        private TextBox txtOpis;

        private Label lblOdlukaSudije;
        private TextBox txtOdlukaSudije;

        private Button dodajBtn;
        private Button odustaniBtn;
    }
}
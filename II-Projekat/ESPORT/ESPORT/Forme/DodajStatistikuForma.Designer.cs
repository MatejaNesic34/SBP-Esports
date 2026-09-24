namespace ESPORT
{
    partial class DodajStatistikuForma
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
            lblTim = new Label();
            cmbTim = new ComboBox();

            lblKills = new Label();
            txtKills = new TextBox();

            lblDeaths = new Label();
            txtDeaths = new TextBox();

            lblAssists = new Label();
            txtAssists = new TextBox();

            lblDamage = new Label();
            txtDamage = new TextBox();

            lblObjectiveScore = new Label();
            txtObjectiveScore = new TextBox();

            lblGold = new Label();
            txtGold = new TextBox();

            btnSacuvaj = new Button();
            btnOdustani = new Button();

            SuspendLayout();

            lblMec.AutoSize = true;
            lblMec.Location = new Point(1, 13);
            lblMec.Name = "lblMec";
            lblMec.Size = new Size(31, 15);
            lblMec.TabIndex = 0;
            lblMec.Text = "Meč:";

            cmbMec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMec.FormattingEnabled = true;
            cmbMec.Location = new Point(130, 10);
            cmbMec.Name = "cmbMec";
            cmbMec.Size = new Size(167, 23);
            cmbMec.TabIndex = 1;

            lblTim.AutoSize = true;
            lblTim.Location = new Point(1, 38);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(28, 15);
            lblTim.TabIndex = 2;
            lblTim.Text = "Tim:";

            cmbTim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTim.FormattingEnabled = true;
            cmbTim.Location = new Point(130, 35);
            cmbTim.Name = "cmbTim";
            cmbTim.Size = new Size(167, 23);
            cmbTim.TabIndex = 3;

            lblKills.AutoSize = true;
            lblKills.Location = new Point(1, 63);
            lblKills.Name = "lblKills";
            lblKills.Size = new Size(29, 15);
            lblKills.TabIndex = 4;
            lblKills.Text = "Kills:";

            txtKills.Location = new Point(130, 60);
            txtKills.Name = "txtKills";
            txtKills.Size = new Size(167, 23);
            txtKills.TabIndex = 5;

            lblDeaths.AutoSize = true;
            lblDeaths.Location = new Point(1, 88);
            lblDeaths.Name = "lblDeaths";
            lblDeaths.Size = new Size(45, 15);
            lblDeaths.TabIndex = 6;
            lblDeaths.Text = "Deaths:";

            txtDeaths.Location = new Point(130, 85);
            txtDeaths.Name = "txtDeaths";
            txtDeaths.Size = new Size(167, 23);
            txtDeaths.TabIndex = 7;

            lblAssists.AutoSize = true;
            lblAssists.Location = new Point(1, 113);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(43, 15);
            lblAssists.TabIndex = 8;
            lblAssists.Text = "Assists:";

            txtAssists.Location = new Point(130, 110);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(167, 23);
            txtAssists.TabIndex = 9;

            lblDamage.AutoSize = true;
            lblDamage.Location = new Point(1, 138);
            lblDamage.Name = "lblDamage";
            lblDamage.Size = new Size(51, 15);
            lblDamage.TabIndex = 10;
            lblDamage.Text = "Damage:";

            txtDamage.Location = new Point(130, 135);
            txtDamage.Name = "txtDamage";
            txtDamage.Size = new Size(167, 23);
            txtDamage.TabIndex = 11;

            lblObjectiveScore.AutoSize = true;
            lblObjectiveScore.Location = new Point(1, 163);
            lblObjectiveScore.Name = "lblObjectiveScore";
            lblObjectiveScore.Size = new Size(88, 15);
            lblObjectiveScore.TabIndex = 12;
            lblObjectiveScore.Text = "Objective Score:";

            txtObjectiveScore.Location = new Point(130, 160);
            txtObjectiveScore.Name = "txtObjectiveScore";
            txtObjectiveScore.Size = new Size(167, 23);
            txtObjectiveScore.TabIndex = 13;

            lblGold.AutoSize = true;
            lblGold.Location = new Point(1, 188);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(32, 15);
            lblGold.TabIndex = 14;
            lblGold.Text = "Gold:";

            txtGold.Location = new Point(130, 185);
            txtGold.Name = "txtGold";
            txtGold.Size = new Size(167, 23);
            txtGold.TabIndex = 15;

            btnSacuvaj.Location = new Point(130, 220);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(78, 22);
            btnSacuvaj.TabIndex = 16;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            btnOdustani.Location = new Point(219, 220);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(78, 22);
            btnOdustani.TabIndex = 17;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 265);

            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtGold);
            Controls.Add(lblGold);
            Controls.Add(txtObjectiveScore);
            Controls.Add(lblObjectiveScore);
            Controls.Add(txtDamage);
            Controls.Add(lblDamage);
            Controls.Add(txtAssists);
            Controls.Add(lblAssists);
            Controls.Add(txtDeaths);
            Controls.Add(lblDeaths);
            Controls.Add(txtKills);
            Controls.Add(lblKills);
            Controls.Add(cmbTim);
            Controls.Add(lblTim);
            Controls.Add(cmbMec);
            Controls.Add(lblMec);

            Name = "DodajStatistikuForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodavanje statistike";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMec;
        private ComboBox cmbMec;
        private Label lblTim;
        private ComboBox cmbTim;

        private Label lblKills;
        private TextBox txtKills;

        private Label lblDeaths;
        private TextBox txtDeaths;

        private Label lblAssists;
        private TextBox txtAssists;

        private Label lblDamage;
        private TextBox txtDamage;

        private Label lblObjectiveScore;
        private TextBox txtObjectiveScore;

        private Label lblGold;
        private TextBox txtGold;

        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}
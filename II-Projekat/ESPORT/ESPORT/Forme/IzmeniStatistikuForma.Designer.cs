namespace ESPORT
{
    partial class IzmeniStatistikuForma
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
            lblMecVrednost = new Label();

            lblTim = new Label();
            lblTimVrednost = new Label();

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

            // 
            // lblMec
            // 
            lblMec.AutoSize = true;
            lblMec.Location = new Point(1, 13);
            lblMec.Name = "lblMec";
            lblMec.Size = new Size(31, 15);
            lblMec.TabIndex = 0;
            lblMec.Text = "Meč:";

            // 
            // lblMecVrednost
            // 
            lblMecVrednost.AutoSize = true;
            lblMecVrednost.Location = new Point(130, 13);
            lblMecVrednost.Name = "lblMecVrednost";
            lblMecVrednost.Size = new Size(13, 15);
            lblMecVrednost.TabIndex = 1;
            lblMecVrednost.Text = "-";

            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Location = new Point(1, 38);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(28, 15);
            lblTim.TabIndex = 2;
            lblTim.Text = "Tim:";

            // 
            // lblTimVrednost
            // 
            lblTimVrednost.AutoSize = true;
            lblTimVrednost.Location = new Point(130, 38);
            lblTimVrednost.Name = "lblTimVrednost";
            lblTimVrednost.Size = new Size(13, 15);
            lblTimVrednost.TabIndex = 3;
            lblTimVrednost.Text = "-";

            // 
            // lblKills
            // 
            lblKills.AutoSize = true;
            lblKills.Location = new Point(1, 63);
            lblKills.Name = "lblKills";
            lblKills.Size = new Size(29, 15);
            lblKills.TabIndex = 4;
            lblKills.Text = "Kills:";

            // 
            // txtKills
            // 
            txtKills.Location = new Point(130, 60);
            txtKills.Name = "txtKills";
            txtKills.Size = new Size(167, 23);
            txtKills.TabIndex = 5;

            // 
            // lblDeaths
            // 
            lblDeaths.AutoSize = true;
            lblDeaths.Location = new Point(1, 88);
            lblDeaths.Name = "lblDeaths";
            lblDeaths.Size = new Size(45, 15);
            lblDeaths.TabIndex = 6;
            lblDeaths.Text = "Deaths:";

            // 
            // txtDeaths
            // 
            txtDeaths.Location = new Point(130, 85);
            txtDeaths.Name = "txtDeaths";
            txtDeaths.Size = new Size(167, 23);
            txtDeaths.TabIndex = 7;

            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Location = new Point(1, 113);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(43, 15);
            lblAssists.TabIndex = 8;
            lblAssists.Text = "Assists:";

            // 
            // txtAssists
            // 
            txtAssists.Location = new Point(130, 110);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(167, 23);
            txtAssists.TabIndex = 9;

            // 
            // lblDamage
            // 
            lblDamage.AutoSize = true;
            lblDamage.Location = new Point(1, 138);
            lblDamage.Name = "lblDamage";
            lblDamage.Size = new Size(51, 15);
            lblDamage.TabIndex = 10;
            lblDamage.Text = "Damage:";

            // 
            // txtDamage
            // 
            txtDamage.Location = new Point(130, 135);
            txtDamage.Name = "txtDamage";
            txtDamage.Size = new Size(167, 23);
            txtDamage.TabIndex = 11;

            // 
            // lblObjectiveScore
            // 
            lblObjectiveScore.AutoSize = true;
            lblObjectiveScore.Location = new Point(1, 163);
            lblObjectiveScore.Name = "lblObjectiveScore";
            lblObjectiveScore.Size = new Size(88, 15);
            lblObjectiveScore.TabIndex = 12;
            lblObjectiveScore.Text = "Objective Score:";

            // 
            // txtObjectiveScore
            // 
            txtObjectiveScore.Location = new Point(130, 160);
            txtObjectiveScore.Name = "txtObjectiveScore";
            txtObjectiveScore.Size = new Size(167, 23);
            txtObjectiveScore.TabIndex = 13;

            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(1, 188);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(32, 15);
            lblGold.TabIndex = 14;
            lblGold.Text = "Gold:";

            // 
            // txtGold
            // 
            txtGold.Location = new Point(130, 185);
            txtGold.Name = "txtGold";
            txtGold.Size = new Size(167, 23);
            txtGold.TabIndex = 15;

            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(130, 220);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(78, 22);
            btnSacuvaj.TabIndex = 16;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(219, 220);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(78, 22);
            btnOdustani.TabIndex = 17;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            // 
            // IzmeniStatistikuForma
            // 
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

            Controls.Add(lblTimVrednost);
            Controls.Add(lblTim);

            Controls.Add(lblMecVrednost);
            Controls.Add(lblMec);

            Name = "IzmeniStatistikuForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmena statistike";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMec;
        private Label lblMecVrednost;

        private Label lblTim;
        private Label lblTimVrednost;

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
namespace ESPORT.Forme
{
    partial class DodajUcesceForma
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFaza;
        private System.Windows.Forms.ComboBox cmbFaza;

        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.ComboBox cmbTim;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;

        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtRezultat;

        private System.Windows.Forms.Label lblPobede;
        private System.Windows.Forms.TextBox txtPobede;

        private System.Windows.Forms.Label lblPorazi;
        private System.Windows.Forms.TextBox txtPorazi;

        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.TextBox txtBodovi;

        private System.Windows.Forms.Label lblPlasman;
        private System.Windows.Forms.TextBox txtPlasman;

        private System.Windows.Forms.Button dodajUcesceBtn;
        private System.Windows.Forms.Button odustaniBtn;

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
            this.lblFaza = new System.Windows.Forms.Label();
            this.cmbFaza = new System.Windows.Forms.ComboBox();

            this.lblTim = new System.Windows.Forms.Label();
            this.cmbTim = new System.Windows.Forms.ComboBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();

            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtRezultat = new System.Windows.Forms.TextBox();

            this.lblPobede = new System.Windows.Forms.Label();
            this.txtPobede = new System.Windows.Forms.TextBox();

            this.lblPorazi = new System.Windows.Forms.Label();
            this.txtPorazi = new System.Windows.Forms.TextBox();

            this.lblBodovi = new System.Windows.Forms.Label();
            this.txtBodovi = new System.Windows.Forms.TextBox();

            this.lblPlasman = new System.Windows.Forms.Label();
            this.txtPlasman = new System.Windows.Forms.TextBox();

            this.dodajUcesceBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.lblFaza.AutoSize = true;
            this.lblFaza.Location = new System.Drawing.Point(30, 30);
            this.lblFaza.Name = "lblFaza";
            this.lblFaza.Size = new System.Drawing.Size(38, 16);
            this.lblFaza.Text = "Faza:";

            this.cmbFaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaza.FormattingEnabled = true;
            this.cmbFaza.Location = new System.Drawing.Point(180, 27);
            this.cmbFaza.Name = "cmbFaza";
            this.cmbFaza.Size = new System.Drawing.Size(280, 24);

            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(30, 75);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(30, 16);
            this.lblTim.Text = "Tim:";

            this.cmbTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTim.FormattingEnabled = true;
            this.cmbTim.Location = new System.Drawing.Point(180, 72);
            this.cmbTim.Name = "cmbTim";
            this.cmbTim.Size = new System.Drawing.Size(280, 24);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.Text = "Status:";

            this.txtStatus.Location = new System.Drawing.Point(180, 117);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(280, 22);

            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(30, 165);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(116, 16);
            this.lblRezultat.Text = "Ostvareni rezultat:";

            this.txtRezultat.Location = new System.Drawing.Point(180, 162);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(280, 22);

            this.lblPobede.AutoSize = true;
            this.lblPobede.Location = new System.Drawing.Point(30, 210);
            this.lblPobede.Name = "lblPobede";
            this.lblPobede.Size = new System.Drawing.Size(58, 16);
            this.lblPobede.Text = "Pobede:";

            this.txtPobede.Location = new System.Drawing.Point(180, 207);
            this.txtPobede.Name = "txtPobede";
            this.txtPobede.Size = new System.Drawing.Size(280, 22);

            this.lblPorazi.AutoSize = true;
            this.lblPorazi.Location = new System.Drawing.Point(30, 255);
            this.lblPorazi.Name = "lblPorazi";
            this.lblPorazi.Size = new System.Drawing.Size(51, 16);
            this.lblPorazi.Text = "Porazi:";

            this.txtPorazi.Location = new System.Drawing.Point(180, 252);
            this.txtPorazi.Name = "txtPorazi";
            this.txtPorazi.Size = new System.Drawing.Size(280, 22);

            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(30, 300);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(52, 16);
            this.lblBodovi.Text = "Bodovi:";

            this.txtBodovi.Location = new System.Drawing.Point(180, 297);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.Size = new System.Drawing.Size(280, 22);

            this.lblPlasman.AutoSize = true;
            this.lblPlasman.Location = new System.Drawing.Point(30, 345);
            this.lblPlasman.Name = "lblPlasman";
            this.lblPlasman.Size = new System.Drawing.Size(114, 16);
            this.lblPlasman.Text = "Konačan plasman:";

            this.txtPlasman.Location = new System.Drawing.Point(180, 342);
            this.txtPlasman.Name = "txtPlasman";
            this.txtPlasman.Size = new System.Drawing.Size(280, 22);

            this.dodajUcesceBtn.Location = new System.Drawing.Point(30, 395);
            this.dodajUcesceBtn.Name = "dodajUcesceBtn";
            this.dodajUcesceBtn.Size = new System.Drawing.Size(200, 50);
            this.dodajUcesceBtn.Text = "Dodaj učešće";
            this.dodajUcesceBtn.UseVisualStyleBackColor = true;
            this.dodajUcesceBtn.Click += new System.EventHandler(this.dodajUcesceBtn_Click);

            this.odustaniBtn.Location = new System.Drawing.Point(260, 395);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(200, 50);
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.lblFaza);
            this.Controls.Add(this.cmbFaza);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.cmbTim);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.lblPobede);
            this.Controls.Add(this.txtPobede);
            this.Controls.Add(this.lblPorazi);
            this.Controls.Add(this.txtPorazi);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.txtBodovi);
            this.Controls.Add(this.lblPlasman);
            this.Controls.Add(this.txtPlasman);
            this.Controls.Add(this.dodajUcesceBtn);
            this.Controls.Add(this.odustaniBtn);
            this.Name = "DodajUcesceForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje učešća tima u fazi";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
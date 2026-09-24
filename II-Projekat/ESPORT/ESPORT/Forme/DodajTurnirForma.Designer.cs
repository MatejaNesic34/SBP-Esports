namespace ESPORT.Forme
{
    partial class DodajTurnirForma
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
            lblTakmicenjeId = new Label();
            txtTakmicenjeId = new TextBox();

            lblTipKostura = new Label();
            txtTipKostura = new TextBox();

            lblPravilaNapredovanja = new Label();
            txtPravilaNapredovanja = new TextBox();

            lblBrojMecevaPoRundi = new Label();
            txtBrojMecevaPoRundi = new TextBox();

            dodajTurnirBtn = new Button();
            odustaniBtn = new Button();

            SuspendLayout();

            lblTakmicenjeId.AutoSize = true;
            lblTakmicenjeId.Location = new Point(12, 20);
            lblTakmicenjeId.Name = "lblTakmicenjeId";
            lblTakmicenjeId.Size = new Size(92, 15);
            lblTakmicenjeId.TabIndex = 0;
            lblTakmicenjeId.Text = "Takmičenje ID:";

            txtTakmicenjeId.Location = new Point(160, 17);
            txtTakmicenjeId.Name = "txtTakmicenjeId";
            txtTakmicenjeId.Size = new Size(160, 23);
            txtTakmicenjeId.TabIndex = 1;

            lblTipKostura.AutoSize = true;
            lblTipKostura.Location = new Point(12, 55);
            lblTipKostura.Name = "lblTipKostura";
            lblTipKostura.Size = new Size(75, 15);
            lblTipKostura.TabIndex = 2;
            lblTipKostura.Text = "Tip kostura:";

            txtTipKostura.Location = new Point(160, 52);
            txtTipKostura.Name = "txtTipKostura";
            txtTipKostura.Size = new Size(160, 23);
            txtTipKostura.TabIndex = 3;

            lblPravilaNapredovanja.AutoSize = true;
            lblPravilaNapredovanja.Location = new Point(12, 90);
            lblPravilaNapredovanja.Name = "lblPravilaNapredovanja";
            lblPravilaNapredovanja.Size = new Size(129, 15);
            lblPravilaNapredovanja.TabIndex = 4;
            lblPravilaNapredovanja.Text = "Pravila napredovanja:";

            txtPravilaNapredovanja.Location = new Point(160, 87);
            txtPravilaNapredovanja.Name = "txtPravilaNapredovanja";
            txtPravilaNapredovanja.Size = new Size(160, 23);
            txtPravilaNapredovanja.TabIndex = 5;

            lblBrojMecevaPoRundi.AutoSize = true;
            lblBrojMecevaPoRundi.Location = new Point(12, 125);
            lblBrojMecevaPoRundi.Name = "lblBrojMecevaPoRundi";
            lblBrojMecevaPoRundi.Size = new Size(130, 15);
            lblBrojMecevaPoRundi.TabIndex = 6;
            lblBrojMecevaPoRundi.Text = "Mečevi po rundi:";

            txtBrojMecevaPoRundi.Location = new Point(160, 122);
            txtBrojMecevaPoRundi.Name = "txtBrojMecevaPoRundi";
            txtBrojMecevaPoRundi.Size = new Size(160, 23);
            txtBrojMecevaPoRundi.TabIndex = 7;

            dodajTurnirBtn.Location = new Point(160, 165);
            dodajTurnirBtn.Name = "dodajTurnirBtn";
            dodajTurnirBtn.Size = new Size(75, 25);
            dodajTurnirBtn.TabIndex = 8;
            dodajTurnirBtn.Text = "Dodaj";
            dodajTurnirBtn.UseVisualStyleBackColor = true;
            dodajTurnirBtn.Click += dodajTurnirBtn_Click;

            odustaniBtn.Location = new Point(245, 165);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(75, 25);
            odustaniBtn.TabIndex = 9;
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 220);

            Controls.Add(lblTakmicenjeId);
            Controls.Add(txtTakmicenjeId);
            Controls.Add(lblTipKostura);
            Controls.Add(txtTipKostura);
            Controls.Add(lblPravilaNapredovanja);
            Controls.Add(txtPravilaNapredovanja);
            Controls.Add(lblBrojMecevaPoRundi);
            Controls.Add(txtBrojMecevaPoRundi);
            Controls.Add(dodajTurnirBtn);
            Controls.Add(odustaniBtn);

            Name = "DodajTurnirForma";
            Text = "Dodavanje turnira";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTakmicenjeId;
        private TextBox txtTakmicenjeId;
        private Label lblTipKostura;
        private TextBox txtTipKostura;
        private Label lblPravilaNapredovanja;
        private TextBox txtPravilaNapredovanja;
        private Label lblBrojMecevaPoRundi;
        private TextBox txtBrojMecevaPoRundi;
        private Button dodajTurnirBtn;
        private Button odustaniBtn;
    }
}
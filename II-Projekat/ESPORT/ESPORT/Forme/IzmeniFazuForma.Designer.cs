namespace ESPORT.Forme
{
    partial class IzmeniFazuForma
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
            lblFazaId = new Label();
            txtFazaId = new TextBox();

            lblTurnirId = new Label();
            txtTurnirId = new TextBox();

            lblNazivFaze = new Label();
            txtNazivFaze = new TextBox();

            lblRedniBroj = new Label();
            numRedniBroj = new NumericUpDown();

            lblNadfaza = new Label();
            cmbNadfaza = new ComboBox();

            izmeniFazuBtn = new Button();
            odustaniBtn = new Button();

            ((System.ComponentModel.ISupportInitialize)numRedniBroj).BeginInit();
            SuspendLayout();

            // 
            // lblFazaId
            // 
            lblFazaId.AutoSize = true;
            lblFazaId.Location = new Point(20, 25);
            lblFazaId.Name = "lblFazaId";
            lblFazaId.Size = new Size(48, 15);
            lblFazaId.Text = "Faza ID:";

            // 
            // txtFazaId
            // 
            txtFazaId.Location = new Point(160, 20);
            txtFazaId.Name = "txtFazaId";
            txtFazaId.ReadOnly = true;
            txtFazaId.Size = new Size(280, 23);

            // 
            // lblTurnirId
            // 
            lblTurnirId.AutoSize = true;
            lblTurnirId.Location = new Point(20, 65);
            lblTurnirId.Name = "lblTurnirId";
            lblTurnirId.Size = new Size(66, 15);
            lblTurnirId.Text = "Turnir ID:";

            // 
            // txtTurnirId
            // 
            txtTurnirId.Location = new Point(160, 60);
            txtTurnirId.Name = "txtTurnirId";
            txtTurnirId.ReadOnly = true;
            txtTurnirId.Size = new Size(280, 23);

            // 
            // lblNazivFaze
            // 
            lblNazivFaze.AutoSize = true;
            lblNazivFaze.Location = new Point(20, 105);
            lblNazivFaze.Name = "lblNazivFaze";
            lblNazivFaze.Size = new Size(67, 15);
            lblNazivFaze.Text = "Naziv faze:";

            // 
            // txtNazivFaze
            // 
            txtNazivFaze.Location = new Point(160, 100);
            txtNazivFaze.Name = "txtNazivFaze";
            txtNazivFaze.Size = new Size(280, 23);

            // 
            // lblRedniBroj
            // 
            lblRedniBroj.AutoSize = true;
            lblRedniBroj.Location = new Point(20, 145);
            lblRedniBroj.Name = "lblRedniBroj";
            lblRedniBroj.Size = new Size(67, 15);
            lblRedniBroj.Text = "Redni broj:";

            // 
            // numRedniBroj
            // 
            numRedniBroj.Location = new Point(160, 140);
            numRedniBroj.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            numRedniBroj.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            numRedniBroj.Name = "numRedniBroj";
            numRedniBroj.Size = new Size(280, 23);
            numRedniBroj.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });

            // 
            // lblNadfaza
            // 
            lblNadfaza.AutoSize = true;
            lblNadfaza.Location = new Point(20, 185);
            lblNadfaza.Name = "lblNadfaza";
            lblNadfaza.Size = new Size(55, 15);
            lblNadfaza.Text = "Nadfaza:";

            // 
            // cmbNadfaza
            // 
            cmbNadfaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNadfaza.FormattingEnabled = true;
            cmbNadfaza.Location = new Point(160, 180);
            cmbNadfaza.Name = "cmbNadfaza";
            cmbNadfaza.Size = new Size(280, 23);

            // 
            // izmeniFazuBtn
            // 
            izmeniFazuBtn.Location = new Point(160, 230);
            izmeniFazuBtn.Name = "izmeniFazuBtn";
            izmeniFazuBtn.Size = new Size(130, 35);
            izmeniFazuBtn.Text = "Izmeni";
            izmeniFazuBtn.UseVisualStyleBackColor = true;
            izmeniFazuBtn.Click +=
                izmeniFazuBtn_Click;

            // 
            // odustaniBtn
            // 
            odustaniBtn.Location = new Point(310, 230);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(130, 35);
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click +=
                odustaniBtn_Click;

            // 
            // IzmeniFazuForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 300);

            Controls.Add(lblFazaId);
            Controls.Add(txtFazaId);

            Controls.Add(lblTurnirId);
            Controls.Add(txtTurnirId);

            Controls.Add(lblNazivFaze);
            Controls.Add(txtNazivFaze);

            Controls.Add(lblRedniBroj);
            Controls.Add(numRedniBroj);

            Controls.Add(lblNadfaza);
            Controls.Add(cmbNadfaza);

            Controls.Add(izmeniFazuBtn);
            Controls.Add(odustaniBtn);

            Name = "IzmeniFazuForma";
            Text = "Izmena faze";

            ((System.ComponentModel.ISupportInitialize)numRedniBroj).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblFazaId;
        private TextBox txtFazaId;

        private Label lblTurnirId;
        private TextBox txtTurnirId;

        private Label lblNazivFaze;
        private TextBox txtNazivFaze;

        private Label lblRedniBroj;
        private NumericUpDown numRedniBroj;

        private Label lblNadfaza;
        private ComboBox cmbNadfaza;

        private Button izmeniFazuBtn;
        private Button odustaniBtn;
    }
}
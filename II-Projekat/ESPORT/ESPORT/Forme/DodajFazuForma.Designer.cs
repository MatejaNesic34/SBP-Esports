namespace ESPORT.Forme
{
    partial class DodajFazuForma
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
            lblTurnir = new Label();
            cmbTurnir = new ComboBox();

            lblNazivFaze = new Label();
            txtNazivFaze = new TextBox();

            lblRedniBroj = new Label();
            numRedniBroj = new NumericUpDown();

            lblNadfaza = new Label();
            cmbNadfaza = new ComboBox();

            dodajFazuBtn = new Button();
            odustaniBtn = new Button();

            ((System.ComponentModel.ISupportInitialize)numRedniBroj).BeginInit();
            SuspendLayout();

            // 
            // lblTurnir
            // 
            lblTurnir.AutoSize = true;
            lblTurnir.Location = new Point(20, 25);
            lblTurnir.Name = "lblTurnir";
            lblTurnir.Size = new Size(42, 15);
            lblTurnir.Text = "Turnir:";

            // 
            // cmbTurnir
            // 
            cmbTurnir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurnir.FormattingEnabled = true;
            cmbTurnir.Location = new Point(160, 20);
            cmbTurnir.Name = "cmbTurnir";
            cmbTurnir.Size = new Size(280, 23);
            cmbTurnir.SelectedIndexChanged +=
                cmbTurnir_SelectedIndexChanged;

            // 
            // lblNazivFaze
            // 
            lblNazivFaze.AutoSize = true;
            lblNazivFaze.Location = new Point(20, 65);
            lblNazivFaze.Name = "lblNazivFaze";
            lblNazivFaze.Size = new Size(67, 15);
            lblNazivFaze.Text = "Naziv faze:";

            // 
            // txtNazivFaze
            // 
            txtNazivFaze.Location = new Point(160, 60);
            txtNazivFaze.Name = "txtNazivFaze";
            txtNazivFaze.Size = new Size(280, 23);

            // 
            // lblRedniBroj
            // 
            lblRedniBroj.AutoSize = true;
            lblRedniBroj.Location = new Point(20, 105);
            lblRedniBroj.Name = "lblRedniBroj";
            lblRedniBroj.Size = new Size(67, 15);
            lblRedniBroj.Text = "Redni broj:";

            // 
            // numRedniBroj
            // 
            numRedniBroj.Location = new Point(160, 100);
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
            lblNadfaza.Location = new Point(20, 145);
            lblNadfaza.Name = "lblNadfaza";
            lblNadfaza.Size = new Size(55, 15);
            lblNadfaza.Text = "Nadfaza:";

            // 
            // cmbNadfaza
            // 
            cmbNadfaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNadfaza.FormattingEnabled = true;
            cmbNadfaza.Location = new Point(160, 140);
            cmbNadfaza.Name = "cmbNadfaza";
            cmbNadfaza.Size = new Size(280, 23);

            // 
            // dodajFazuBtn
            // 
            dodajFazuBtn.Location = new Point(160, 190);
            dodajFazuBtn.Name = "dodajFazuBtn";
            dodajFazuBtn.Size = new Size(130, 35);
            dodajFazuBtn.Text = "Dodaj";
            dodajFazuBtn.UseVisualStyleBackColor = true;
            dodajFazuBtn.Click += dodajFazuBtn_Click;

            // 
            // odustaniBtn
            // 
            odustaniBtn.Location = new Point(310, 190);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(130, 35);
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            // 
            // DodajFazuForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 260);

            Controls.Add(lblTurnir);
            Controls.Add(cmbTurnir);

            Controls.Add(lblNazivFaze);
            Controls.Add(txtNazivFaze);

            Controls.Add(lblRedniBroj);
            Controls.Add(numRedniBroj);

            Controls.Add(lblNadfaza);
            Controls.Add(cmbNadfaza);

            Controls.Add(dodajFazuBtn);
            Controls.Add(odustaniBtn);

            Name = "DodajFazuForma";
            Text = "Dodavanje faze";

            ((System.ComponentModel.ISupportInitialize)numRedniBroj).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTurnir;
        private ComboBox cmbTurnir;

        private Label lblNazivFaze;
        private TextBox txtNazivFaze;

        private Label lblRedniBroj;
        private NumericUpDown numRedniBroj;

        private Label lblNadfaza;
        private ComboBox cmbNadfaza;

        private Button dodajFazuBtn;
        private Button odustaniBtn;
    }
}
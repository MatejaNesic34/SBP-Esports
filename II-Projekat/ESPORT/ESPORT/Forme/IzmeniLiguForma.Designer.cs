namespace ESPORT.Forme
{
    partial class IzmeniLiguForma
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
            lblTakmicenjeId = new Label();
            txtTakmicenjeId = new TextBox();
            lblSistemBodovanja = new Label();
            txtSistemBodovanja = new TextBox();
            izmeniLiguBtn = new Button();
            odustaniBtn = new Button();
            SuspendLayout();

            lblTakmicenjeId.AutoSize = true;
            lblTakmicenjeId.Location = new Point(12, 20);
            lblTakmicenjeId.Name = "lblTakmicenjeId";
            lblTakmicenjeId.Size = new Size(92, 15);
            lblTakmicenjeId.TabIndex = 0;
            lblTakmicenjeId.Text = "Takmičenje ID:";

            txtTakmicenjeId.Location = new Point(120, 17);
            txtTakmicenjeId.Name = "txtTakmicenjeId";
            txtTakmicenjeId.ReadOnly = true;
            txtTakmicenjeId.Size = new Size(160, 23);
            txtTakmicenjeId.TabIndex = 1;

            lblSistemBodovanja.AutoSize = true;
            lblSistemBodovanja.Location = new Point(12, 55);
            lblSistemBodovanja.Name = "lblSistemBodovanja";
            lblSistemBodovanja.Size = new Size(101, 15);
            lblSistemBodovanja.TabIndex = 2;
            lblSistemBodovanja.Text = "Sistem bodovanja:";

            txtSistemBodovanja.Location = new Point(120, 52);
            txtSistemBodovanja.Name = "txtSistemBodovanja";
            txtSistemBodovanja.Size = new Size(160, 23);
            txtSistemBodovanja.TabIndex = 3;

            izmeniLiguBtn.Location = new Point(120, 95);
            izmeniLiguBtn.Name = "izmeniLiguBtn";
            izmeniLiguBtn.Size = new Size(75, 25);
            izmeniLiguBtn.TabIndex = 4;
            izmeniLiguBtn.Text = "Izmeni";
            izmeniLiguBtn.UseVisualStyleBackColor = true;
            izmeniLiguBtn.Click += izmeniLiguBtn_Click;

            odustaniBtn.Location = new Point(205, 95);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(75, 25);
            odustaniBtn.TabIndex = 5;
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 145);

            Controls.Add(lblTakmicenjeId);
            Controls.Add(txtTakmicenjeId);
            Controls.Add(lblSistemBodovanja);
            Controls.Add(txtSistemBodovanja);
            Controls.Add(izmeniLiguBtn);
            Controls.Add(odustaniBtn);

            Name = "IzmeniLiguForma";
            Text = "Izmena lige";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTakmicenjeId;
        private TextBox txtTakmicenjeId;

        private Label lblSistemBodovanja;
        private TextBox txtSistemBodovanja;

        private Button izmeniLiguBtn;
        private Button odustaniBtn;
    }
}
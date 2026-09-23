namespace ESPORT.Forme
{
    partial class IzmeniAngazmanTreneraForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lblTrener = new Label();
            cmbTrener = new ComboBox();

            lblTim = new Label();
            cmbTim = new ComboBox();

            lblTipUloge = new Label();
            txtTipUloge = new TextBox();

            lblDatumOd = new Label();
            dtpDatumOd = new DateTimePicker();

            chkDatumDo = new CheckBox();
            dtpDatumDo = new DateTimePicker();

            btnSacuvaj = new Button();
            btnOdustani = new Button();

            SuspendLayout();

            // 
            // lblTrener
            // 
            lblTrener.AutoSize = true;
            lblTrener.Location = new Point(20, 20);
            lblTrener.Name = "lblTrener";
            lblTrener.Size = new Size(55, 20);
            lblTrener.TabIndex = 0;
            lblTrener.Text = "Trener:";

            // 
            // cmbTrener
            // 
            cmbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrener.FormattingEnabled = true;
            cmbTrener.Location = new Point(130, 17);
            cmbTrener.Name = "cmbTrener";
            cmbTrener.Size = new Size(240, 28);
            cmbTrener.TabIndex = 1;

            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Location = new Point(20, 60);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(36, 20);
            lblTim.TabIndex = 2;
            lblTim.Text = "Tim:";

            // 
            // cmbTim
            // 
            cmbTim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTim.FormattingEnabled = true;
            cmbTim.Location = new Point(130, 57);
            cmbTim.Name = "cmbTim";
            cmbTim.Size = new Size(240, 28);
            cmbTim.TabIndex = 3;

            // 
            // lblTipUloge
            // 
            lblTipUloge.AutoSize = true;
            lblTipUloge.Location = new Point(20, 100);
            lblTipUloge.Name = "lblTipUloge";
            lblTipUloge.Size = new Size(75, 20);
            lblTipUloge.TabIndex = 4;
            lblTipUloge.Text = "Tip uloge:";

            // 
            // txtTipUloge
            // 
            txtTipUloge.Location = new Point(130, 97);
            txtTipUloge.Name = "txtTipUloge";
            txtTipUloge.Size = new Size(240, 27);
            txtTipUloge.TabIndex = 5;

            // 
            // lblDatumOd
            // 
            lblDatumOd.AutoSize = true;
            lblDatumOd.Location = new Point(20, 140);
            lblDatumOd.Name = "lblDatumOd";
            lblDatumOd.Size = new Size(79, 20);
            lblDatumOd.TabIndex = 6;
            lblDatumOd.Text = "Datum od:";

            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Format = DateTimePickerFormat.Short;
            dtpDatumOd.Location = new Point(130, 137);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(240, 27);
            dtpDatumOd.TabIndex = 7;

            // 
            // chkDatumDo
            // 
            chkDatumDo.AutoSize = true;
            chkDatumDo.Location = new Point(20, 180);
            chkDatumDo.Name = "chkDatumDo";
            chkDatumDo.Size = new Size(101, 24);
            chkDatumDo.TabIndex = 8;
            chkDatumDo.Text = "Datum do:";
            chkDatumDo.UseVisualStyleBackColor = true;
            chkDatumDo.CheckedChanged += chkDatumDo_CheckedChanged;

            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Enabled = false;
            dtpDatumDo.Format = DateTimePickerFormat.Short;
            dtpDatumDo.Location = new Point(130, 177);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(240, 27);
            dtpDatumDo.TabIndex = 9;

            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(130, 225);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(110, 40);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;

            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(260, 225);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 40);
            btnOdustani.TabIndex = 11;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            // 
            // IzmeniAngazmanTreneraForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 290);
            Controls.Add(lblTrener);
            Controls.Add(cmbTrener);
            Controls.Add(lblTim);
            Controls.Add(cmbTim);
            Controls.Add(lblTipUloge);
            Controls.Add(txtTipUloge);
            Controls.Add(lblDatumOd);
            Controls.Add(dtpDatumOd);
            Controls.Add(chkDatumDo);
            Controls.Add(dtpDatumDo);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Name = "IzmeniAngazmanTreneraForma";
            Text = "Izmeni angažman trenera";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrener;
        private ComboBox cmbTrener;

        private Label lblTim;
        private ComboBox cmbTim;

        private Label lblTipUloge;
        private TextBox txtTipUloge;

        private Label lblDatumOd;
        private DateTimePicker dtpDatumOd;

        private CheckBox chkDatumDo;
        private DateTimePicker dtpDatumDo;

        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}
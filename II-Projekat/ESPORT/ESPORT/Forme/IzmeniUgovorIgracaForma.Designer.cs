namespace ESPORT.Forme
{
    partial class IzmeniUgovorIgracaForma
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            txtIgracId = new TextBox(); label1 = new Label();
            txtTimId = new TextBox(); label2 = new Label();
            dtpDatumOd = new DateTimePicker(); label3 = new Label();
            dtpDatumDo = new DateTimePicker(); label4 = new Label();
            txtTipUgovora = new TextBox(); label5 = new Label();
            txtPlata = new TextBox(); label6 = new Label();
            txtBonusi = new TextBox(); label7 = new Label();
            txtKlauzula = new TextBox(); label8 = new Label();
            txtZabrana = new TextBox(); label9 = new Label();
            txtStatus = new TextBox(); label10 = new Label();
            chkAktivan = new CheckBox();
            btnIzmeni = new Button(); btnOdustani = new Button();
            SuspendLayout();

            label1.Text = "ID Igrača:"; label1.Location = new Point(40, 30);
            txtIgracId.Location = new Point(250, 27); txtIgracId.Size = new Size(300, 27);

            label2.Text = "ID Tima:"; label2.Location = new Point(40, 80);
            txtTimId.Location = new Point(250, 77); txtTimId.Size = new Size(300, 27);

            label3.Text = "Datum od:"; label3.Location = new Point(40, 130);
            dtpDatumOd.Location = new Point(250, 127); dtpDatumOd.Size = new Size(300, 27); dtpDatumOd.Format = DateTimePickerFormat.Short;

            label4.Text = "Datum do:"; label4.Location = new Point(40, 180);
            dtpDatumDo.Location = new Point(250, 177); dtpDatumDo.Size = new Size(300, 27); dtpDatumDo.Format = DateTimePickerFormat.Short;

            chkAktivan.Text = "Neograničeno / Aktivan"; chkAktivan.Location = new Point(570, 180);
            chkAktivan.CheckedChanged += chkAktivan_CheckedChanged;

            label5.Text = "Tip ugovora:"; label5.Location = new Point(40, 230);
            txtTipUgovora.Location = new Point(250, 227); txtTipUgovora.Size = new Size(300, 27);

            label6.Text = "Plata:"; label6.Location = new Point(40, 280);
            txtPlata.Location = new Point(250, 277); txtPlata.Size = new Size(300, 27);

            label7.Text = "Bonusi:"; label7.Location = new Point(40, 330);
            txtBonusi.Location = new Point(250, 327); txtBonusi.Size = new Size(300, 27);

            label8.Text = "Klauzula otkupa:"; label8.Location = new Point(40, 380);
            txtKlauzula.Location = new Point(250, 377); txtKlauzula.Size = new Size(300, 27);

            label9.Text = "Zabrana nastupa:"; label9.Location = new Point(40, 430);
            txtZabrana.Location = new Point(250, 427); txtZabrana.Size = new Size(300, 27);

            label10.Text = "Status igrača:"; label10.Location = new Point(40, 480);
            txtStatus.Location = new Point(250, 477); txtStatus.Size = new Size(300, 27);

            btnIzmeni.Text = "Izmeni"; btnIzmeni.Location = new Point(250, 540); btnIzmeni.Size = new Size(140, 40); btnIzmeni.Click += btnIzmeni_Click;
            btnOdustani.Text = "Odustani"; btnOdustani.Location = new Point(410, 540); btnOdustani.Size = new Size(140, 40); btnOdustani.Click += btnOdustani_Click;

            ClientSize = new Size(820, 610);
            Controls.AddRange(new Control[] { label1, txtIgracId, label2, txtTimId, label3, dtpDatumOd, label4, dtpDatumDo, chkAktivan, label5, txtTipUgovora, label6, txtPlata, label7, txtBonusi, label8, txtKlauzula, label9, txtZabrana, label10, txtStatus, btnIzmeni, btnOdustani });
            Name = "IzmeniUgovorIgracaForma"; Text = "Izmeni Ugovor Igrača";
            Load += IzmeniUgovorIgracaForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtIgracId, txtTimId, txtTipUgovora, txtPlata, txtBonusi, txtKlauzula, txtZabrana, txtStatus;
        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
        private DateTimePicker dtpDatumOd, dtpDatumDo;
        private CheckBox chkAktivan;
        private Button btnIzmeni, btnOdustani;
    }
}
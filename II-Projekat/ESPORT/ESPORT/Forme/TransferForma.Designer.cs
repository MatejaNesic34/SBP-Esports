namespace ESPORT.Forme
{
    partial class TransferForma
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
            listViewTransferi = new ListView();

            TransferId = new ColumnHeader();
            IgracId = new ColumnHeader();
            Igrac = new ColumnHeader();
            PrethodniTimId = new ColumnHeader();
            PrethodniTim = new ColumnHeader();
            NoviTimId = new ColumnHeader();
            NoviTim = new ColumnHeader();
            DatumPrelaska = new ColumnHeader();
            IznosTransfera = new ColumnHeader();
            Valuta = new ColumnHeader();
            TrajanjeUgovoraMeseci = new ColumnHeader();
            PosebneKlauzule = new ColumnHeader();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            dodajTransferBtn = new Button();
            izmeniTransferBtn = new Button();
            obrisiTransferBtn = new Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewTransferi.Columns.AddRange(new ColumnHeader[]
            {
                TransferId,
                IgracId,
                Igrac,
                PrethodniTimId,
                PrethodniTim,
                NoviTimId,
                NoviTim,
                DatumPrelaska,
                IznosTransfera,
                Valuta,
                TrajanjeUgovoraMeseci,
                PosebneKlauzule
            });

            listViewTransferi.FullRowSelect = true;
            listViewTransferi.GridLines = true;
            listViewTransferi.Location = new Point(24, 56);
            listViewTransferi.MultiSelect = false;
            listViewTransferi.Name = "listViewTransferi";
            listViewTransferi.Size = new Size(1100, 659);
            listViewTransferi.TabIndex = 0;
            listViewTransferi.UseCompatibleStateImageBehavior = false;
            listViewTransferi.View = View.Details;

            TransferId.Text = "Transfer ID";
            TransferId.Width = 90;

            IgracId.Text = "Igrač ID";
            IgracId.Width = 80;

            Igrac.Text = "Igrač";
            Igrac.Width = 180;

            PrethodniTimId.Text = "Prethodni tim ID";
            PrethodniTimId.Width = 110;

            PrethodniTim.Text = "Prethodni tim";
            PrethodniTim.Width = 170;

            NoviTimId.Text = "Novi tim ID";
            NoviTimId.Width = 90;

            NoviTim.Text = "Novi tim";
            NoviTim.Width = 170;

            DatumPrelaska.Text = "Datum prelaska";
            DatumPrelaska.Width = 120;

            IznosTransfera.Text = "Iznos";
            IznosTransfera.Width = 100;

            Valuta.Text = "Valuta";
            Valuta.Width = 80;

            TrajanjeUgovoraMeseci.Text = "Trajanje ugovora";
            TrajanjeUgovoraMeseci.Width = 120;

            PosebneKlauzule.Text = "Posebne klauzule";
            PosebneKlauzule.Width = 180;

            groupBox1.Controls.Add(listViewTransferi);
            groupBox1.Location = new Point(40, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1150, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz transfera";

            groupBox2.Controls.Add(obrisiTransferBtn);
            groupBox2.Controls.Add(izmeniTransferBtn);
            groupBox2.Controls.Add(dodajTransferBtn);
            groupBox2.Location = new Point(1220, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije transfera";

            dodajTransferBtn.Location = new Point(62, 76);
            dodajTransferBtn.Name = "dodajTransferBtn";
            dodajTransferBtn.Size = new Size(243, 76);
            dodajTransferBtn.TabIndex = 0;
            dodajTransferBtn.Text = "Dodaj transfer";
            dodajTransferBtn.UseVisualStyleBackColor = true;
            dodajTransferBtn.Click += dodajTransferBtn_Click;

            izmeniTransferBtn.Location = new Point(62, 200);
            izmeniTransferBtn.Name = "izmeniTransferBtn";
            izmeniTransferBtn.Size = new Size(243, 76);
            izmeniTransferBtn.TabIndex = 1;
            izmeniTransferBtn.Text = "Izmeni transfer";
            izmeniTransferBtn.UseVisualStyleBackColor = true;
            izmeniTransferBtn.Click += izmeniTransferBtn_Click;

            obrisiTransferBtn.Location = new Point(62, 320);
            obrisiTransferBtn.Name = "obrisiTransferBtn";
            obrisiTransferBtn.Size = new Size(243, 77);
            obrisiTransferBtn.TabIndex = 2;
            obrisiTransferBtn.Text = "Obriši transfer";
            obrisiTransferBtn.UseVisualStyleBackColor = true;
            obrisiTransferBtn.Click += obrisiTransferBtn_Click;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);

            Controls.Add(groupBox2);
            Controls.Add(groupBox1);

            Name = "TransferForma";
            Text = "Transferi";

            Load += TransferForma_Load;

            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTransferi;

        private ColumnHeader TransferId;
        private ColumnHeader IgracId;
        private ColumnHeader Igrac;
        private ColumnHeader PrethodniTimId;
        private ColumnHeader PrethodniTim;
        private ColumnHeader NoviTimId;
        private ColumnHeader NoviTim;
        private ColumnHeader DatumPrelaska;
        private ColumnHeader IznosTransfera;
        private ColumnHeader Valuta;
        private ColumnHeader TrajanjeUgovoraMeseci;
        private ColumnHeader PosebneKlauzule;

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button dodajTransferBtn;
        private Button izmeniTransferBtn;
        private Button obrisiTransferBtn;
    }
}
namespace ESPORT.Forme
{
    partial class DodajTransferForma
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
            igracLbl = new Label();
            igracCB = new ComboBox();

            prethodniTimLbl = new Label();
            prethodniTimCB = new ComboBox();

            noviTimLbl = new Label();
            noviTimCB = new ComboBox();

            datumPrelaskaLbl = new Label();
            datumPrelaskaDTP = new DateTimePicker();

            iznosTransferaLbl = new Label();
            iznosTransferaTB = new TextBox();

            valutaLbl = new Label();
            valutaTB = new TextBox();

            trajanjeUgovoraLbl = new Label();
            trajanjeUgovoraTB = new TextBox();

            posebneKlauzuleLbl = new Label();
            posebneKlauzuleTB = new TextBox();

            sacuvajBtn = new Button();
            odustaniBtn = new Button();

            SuspendLayout();

            // 
            // igracLbl
            // 
            igracLbl.AutoSize = true;
            igracLbl.Location = new Point(1, 13);
            igracLbl.Margin = new Padding(1, 0, 1, 0);
            igracLbl.Name = "igracLbl";
            igracLbl.Size = new Size(39, 15);
            igracLbl.TabIndex = 0;
            igracLbl.Text = "Igrač:";

            // 
            // igracCB
            // 
            igracCB.DropDownStyle = ComboBoxStyle.DropDownList;
            igracCB.FormattingEnabled = true;
            igracCB.Location = new Point(130, 10);
            igracCB.Margin = new Padding(1);
            igracCB.Name = "igracCB";
            igracCB.Size = new Size(167, 23);
            igracCB.TabIndex = 1;

            // 
            // prethodniTimLbl
            // 
            prethodniTimLbl.AutoSize = true;
            prethodniTimLbl.Location = new Point(1, 38);
            prethodniTimLbl.Margin = new Padding(1, 0, 1, 0);
            prethodniTimLbl.Name = "prethodniTimLbl";
            prethodniTimLbl.Size = new Size(84, 15);
            prethodniTimLbl.TabIndex = 2;
            prethodniTimLbl.Text = "Prethodni tim:";

            // 
            // prethodniTimCB
            // 
            prethodniTimCB.DropDownStyle = ComboBoxStyle.DropDownList;
            prethodniTimCB.FormattingEnabled = true;
            prethodniTimCB.Location = new Point(130, 35);
            prethodniTimCB.Margin = new Padding(1);
            prethodniTimCB.Name = "prethodniTimCB";
            prethodniTimCB.Size = new Size(167, 23);
            prethodniTimCB.TabIndex = 3;

            // 
            // noviTimLbl
            // 
            noviTimLbl.AutoSize = true;
            noviTimLbl.Location = new Point(1, 63);
            noviTimLbl.Margin = new Padding(1, 0, 1, 0);
            noviTimLbl.Name = "noviTimLbl";
            noviTimLbl.Size = new Size(53, 15);
            noviTimLbl.TabIndex = 4;
            noviTimLbl.Text = "Novi tim:";

            // 
            // noviTimCB
            // 
            noviTimCB.DropDownStyle = ComboBoxStyle.DropDownList;
            noviTimCB.FormattingEnabled = true;
            noviTimCB.Location = new Point(130, 60);
            noviTimCB.Margin = new Padding(1);
            noviTimCB.Name = "noviTimCB";
            noviTimCB.Size = new Size(167, 23);
            noviTimCB.TabIndex = 5;

            // 
            // datumPrelaskaLbl
            // 
            datumPrelaskaLbl.AutoSize = true;
            datumPrelaskaLbl.Location = new Point(1, 88);
            datumPrelaskaLbl.Margin = new Padding(1, 0, 1, 0);
            datumPrelaskaLbl.Name = "datumPrelaskaLbl";
            datumPrelaskaLbl.Size = new Size(95, 15);
            datumPrelaskaLbl.TabIndex = 6;
            datumPrelaskaLbl.Text = "Datum prelaska:";

            // 
            // datumPrelaskaDTP
            // 
            datumPrelaskaDTP.Format = DateTimePickerFormat.Short;
            datumPrelaskaDTP.Location = new Point(130, 85);
            datumPrelaskaDTP.Margin = new Padding(1);
            datumPrelaskaDTP.Name = "datumPrelaskaDTP";
            datumPrelaskaDTP.Size = new Size(167, 23);
            datumPrelaskaDTP.TabIndex = 7;

            // 
            // iznosTransferaLbl
            // 
            iznosTransferaLbl.AutoSize = true;
            iznosTransferaLbl.Location = new Point(1, 113);
            iznosTransferaLbl.Margin = new Padding(1, 0, 1, 0);
            iznosTransferaLbl.Name = "iznosTransferaLbl";
            iznosTransferaLbl.Size = new Size(96, 15);
            iznosTransferaLbl.TabIndex = 8;
            iznosTransferaLbl.Text = "Iznos transfera:";

            // 
            // iznosTransferaTB
            // 
            iznosTransferaTB.Location = new Point(130, 110);
            iznosTransferaTB.Margin = new Padding(1);
            iznosTransferaTB.Name = "iznosTransferaTB";
            iznosTransferaTB.Size = new Size(167, 23);
            iznosTransferaTB.TabIndex = 9;

            // 
            // valutaLbl
            // 
            valutaLbl.AutoSize = true;
            valutaLbl.Location = new Point(1, 138);
            valutaLbl.Margin = new Padding(1, 0, 1, 0);
            valutaLbl.Name = "valutaLbl";
            valutaLbl.Size = new Size(45, 15);
            valutaLbl.TabIndex = 10;
            valutaLbl.Text = "Valuta:";

            // 
            // valutaTB
            // 
            valutaTB.Location = new Point(130, 135);
            valutaTB.Margin = new Padding(1);
            valutaTB.Name = "valutaTB";
            valutaTB.Size = new Size(167, 23);
            valutaTB.TabIndex = 11;

            // 
            // trajanjeUgovoraLbl
            // 
            trajanjeUgovoraLbl.AutoSize = true;
            trajanjeUgovoraLbl.Location = new Point(1, 163);
            trajanjeUgovoraLbl.Margin = new Padding(1, 0, 1, 0);
            trajanjeUgovoraLbl.Name = "trajanjeUgovoraLbl";
            trajanjeUgovoraLbl.Size = new Size(124, 15);
            trajanjeUgovoraLbl.TabIndex = 12;
            trajanjeUgovoraLbl.Text = "Trajanje ugovora (mes.):";

            // 
            // trajanjeUgovoraTB
            // 
            trajanjeUgovoraTB.Location = new Point(130, 160);
            trajanjeUgovoraTB.Margin = new Padding(1);
            trajanjeUgovoraTB.Name = "trajanjeUgovoraTB";
            trajanjeUgovoraTB.Size = new Size(167, 23);
            trajanjeUgovoraTB.TabIndex = 13;

            // 
            // posebneKlauzuleLbl
            // 
            posebneKlauzuleLbl.AutoSize = true;
            posebneKlauzuleLbl.Location = new Point(1, 188);
            posebneKlauzuleLbl.Margin = new Padding(1, 0, 1, 0);
            posebneKlauzuleLbl.Name = "posebneKlauzuleLbl";
            posebneKlauzuleLbl.Size = new Size(111, 15);
            posebneKlauzuleLbl.TabIndex = 14;
            posebneKlauzuleLbl.Text = "Posebne klauzule:";

            // 
            // posebneKlauzuleTB
            // 
            posebneKlauzuleTB.Location = new Point(130, 185);
            posebneKlauzuleTB.Margin = new Padding(1);
            posebneKlauzuleTB.Multiline = true;
            posebneKlauzuleTB.Name = "posebneKlauzuleTB";
            posebneKlauzuleTB.Size = new Size(167, 45);
            posebneKlauzuleTB.TabIndex = 15;

            // 
            // sacuvajBtn
            // 
            sacuvajBtn.Location = new Point(130, 240);
            sacuvajBtn.Margin = new Padding(1);
            sacuvajBtn.Name = "sacuvajBtn";
            sacuvajBtn.Size = new Size(78, 22);
            sacuvajBtn.TabIndex = 16;
            sacuvajBtn.Text = "Sačuvaj";
            sacuvajBtn.UseVisualStyleBackColor = true;
            sacuvajBtn.Click += sacuvajBtn_Click;

            // 
            // odustaniBtn
            // 
            odustaniBtn.Location = new Point(219, 240);
            odustaniBtn.Margin = new Padding(1);
            odustaniBtn.Name = "odustaniBtn";
            odustaniBtn.Size = new Size(78, 22);
            odustaniBtn.TabIndex = 17;
            odustaniBtn.Text = "Odustani";
            odustaniBtn.UseVisualStyleBackColor = true;
            odustaniBtn.Click += odustaniBtn_Click;

            // 
            // DodajTransferForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(320, 280);

            Controls.Add(igracLbl);
            Controls.Add(igracCB);
            Controls.Add(prethodniTimLbl);
            Controls.Add(prethodniTimCB);
            Controls.Add(noviTimLbl);
            Controls.Add(noviTimCB);
            Controls.Add(datumPrelaskaLbl);
            Controls.Add(datumPrelaskaDTP);
            Controls.Add(iznosTransferaLbl);
            Controls.Add(iznosTransferaTB);
            Controls.Add(valutaLbl);
            Controls.Add(valutaTB);
            Controls.Add(trajanjeUgovoraLbl);
            Controls.Add(trajanjeUgovoraTB);
            Controls.Add(posebneKlauzuleLbl);
            Controls.Add(posebneKlauzuleTB);
            Controls.Add(sacuvajBtn);
            Controls.Add(odustaniBtn);

            Margin = new Padding(1);
            Name = "DodajTransferForma";
            Text = "Dodavanje transfera";

            Load += DodajTransferForma_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label igracLbl;
        private ComboBox igracCB;

        private Label prethodniTimLbl;
        private ComboBox prethodniTimCB;

        private Label noviTimLbl;
        private ComboBox noviTimCB;

        private Label datumPrelaskaLbl;
        private DateTimePicker datumPrelaskaDTP;

        private Label iznosTransferaLbl;
        private TextBox iznosTransferaTB;

        private Label valutaLbl;
        private TextBox valutaTB;

        private Label trajanjeUgovoraLbl;
        private TextBox trajanjeUgovoraTB;

        private Label posebneKlauzuleLbl;
        private TextBox posebneKlauzuleTB;

        private Button sacuvajBtn;
        private Button odustaniBtn;
    }
}
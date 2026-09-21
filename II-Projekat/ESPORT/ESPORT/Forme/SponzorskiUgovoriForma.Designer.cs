namespace ESPORT.Forme
{
    partial class SponzorskiUgovoriForma
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
            listViewUgovori = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderDatumOd = new ColumnHeader();
            columnHeaderDatumDo = new ColumnHeader();
            columnHeaderIznos = new ColumnHeader();
            columnHeaderValuta = new ColumnHeader();
            columnHeaderTipPodrske = new ColumnHeader();
            columnHeaderMarketinskeObaveze = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnObrisiUgovor = new Button();
            btnIzmeniUgovor = new Button();
            btnDodajUgovor = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewUgovori
            // 
            listViewUgovori.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderDatumOd, columnHeaderDatumDo, columnHeaderIznos, columnHeaderValuta, columnHeaderTipPodrske, columnHeaderMarketinskeObaveze });
            listViewUgovori.FullRowSelect = true;
            listViewUgovori.Location = new Point(24, 56);
            listViewUgovori.MultiSelect = false;
            listViewUgovori.Name = "listViewUgovori";
            listViewUgovori.Size = new Size(1250, 659);
            listViewUgovori.TabIndex = 0;
            listViewUgovori.UseCompatibleStateImageBehavior = false;
            listViewUgovori.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 80;
            // 
            // columnHeaderDatumOd
            // 
            columnHeaderDatumOd.Text = "Datum od";
            columnHeaderDatumOd.Width = 170;
            // 
            // columnHeaderDatumDo
            // 
            columnHeaderDatumDo.Text = "Datum do";
            columnHeaderDatumDo.Width = 170;
            // 
            // columnHeaderIznos
            // 
            columnHeaderIznos.Text = "Iznos";
            columnHeaderIznos.Width = 150;
            // 
            // columnHeaderValuta
            // 
            columnHeaderValuta.Text = "Valuta";
            columnHeaderValuta.Width = 120;
            // 
            // columnHeaderTipPodrske
            // 
            columnHeaderTipPodrske.Text = "Tip podrške";
            columnHeaderTipPodrske.Width = 220;
            // 
            // columnHeaderMarketinskeObaveze
            // 
            columnHeaderMarketinskeObaveze.Text = "Marketinške obaveze";
            columnHeaderMarketinskeObaveze.Width = 300;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewUgovori);
            groupBox1.Location = new Point(40, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1300, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista sponzorskih ugovora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnObrisiUgovor);
            groupBox2.Controls.Add(btnIzmeniUgovor);
            groupBox2.Controls.Add(btnDodajUgovor);
            groupBox2.Location = new Point(1380, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije sa ugovorima";
            // 
            // btnObrisiUgovor
            // 
            btnObrisiUgovor.Location = new Point(54, 320);
            btnObrisiUgovor.Name = "btnObrisiUgovor";
            btnObrisiUgovor.Size = new Size(243, 77);
            btnObrisiUgovor.TabIndex = 2;
            btnObrisiUgovor.Text = "Obriši ugovor";
            btnObrisiUgovor.UseVisualStyleBackColor = true;
            btnObrisiUgovor.Click += btnObrisiUgovor_Click;
            // 
            // btnIzmeniUgovor
            // 
            btnIzmeniUgovor.Location = new Point(54, 200);
            btnIzmeniUgovor.Name = "btnIzmeniUgovor";
            btnIzmeniUgovor.Size = new Size(243, 76);
            btnIzmeniUgovor.TabIndex = 1;
            btnIzmeniUgovor.Text = "Izmeni ugovor";
            btnIzmeniUgovor.UseVisualStyleBackColor = true;
            btnIzmeniUgovor.Click += btnIzmeniUgovor_Click;
            // 
            // btnDodajUgovor
            // 
            btnDodajUgovor.Location = new Point(54, 76);
            btnDodajUgovor.Name = "btnDodajUgovor";
            btnDodajUgovor.Size = new Size(243, 76);
            btnDodajUgovor.TabIndex = 0;
            btnDodajUgovor.Text = "Dodaj ugovor";
            btnDodajUgovor.UseVisualStyleBackColor = true;
            btnDodajUgovor.Click += btnDodajUgovor_Click;
            // 
            // SponzorskiUgovoriForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1780, 900);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SponzorskiUgovoriForma";
            Text = "Sponzorski Ugovori";
            Load += SponzorskiUgovoriForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewUgovori;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderDatumOd;
        private ColumnHeader columnHeaderDatumDo;
        private ColumnHeader columnHeaderIznos;
        private ColumnHeader columnHeaderValuta;
        private ColumnHeader columnHeaderTipPodrske;
        private ColumnHeader columnHeaderMarketinskeObaveze;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnObrisiUgovor;
        private Button btnIzmeniUgovor;
        private Button btnDodajUgovor;
    }
}
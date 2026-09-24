namespace ESPORT.Forme
{
    partial class UcesceTimaUFaziForma
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListView listViewUcesca;
        private System.Windows.Forms.ColumnHeader colFazaId;
        private System.Windows.Forms.ColumnHeader colTimId;
        private System.Windows.Forms.ColumnHeader colNazivFaze;
        private System.Windows.Forms.ColumnHeader colNazivTima;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colRezultat;
        private System.Windows.Forms.ColumnHeader colPobede;
        private System.Windows.Forms.ColumnHeader colPorazi;
        private System.Windows.Forms.ColumnHeader colBodovi;
        private System.Windows.Forms.ColumnHeader colPlasman;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajUcesceBtn;
        private System.Windows.Forms.Button izmeniUcesceBtn;
        private System.Windows.Forms.Button obrisiUcesceBtn;

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
            this.listViewUcesca = new System.Windows.Forms.ListView();
            this.colFazaId = new System.Windows.Forms.ColumnHeader();
            this.colTimId = new System.Windows.Forms.ColumnHeader();
            this.colNazivFaze = new System.Windows.Forms.ColumnHeader();
            this.colNazivTima = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colRezultat = new System.Windows.Forms.ColumnHeader();
            this.colPobede = new System.Windows.Forms.ColumnHeader();
            this.colPorazi = new System.Windows.Forms.ColumnHeader();
            this.colBodovi = new System.Windows.Forms.ColumnHeader();
            this.colPlasman = new System.Windows.Forms.ColumnHeader();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajUcesceBtn = new System.Windows.Forms.Button();
            this.izmeniUcesceBtn = new System.Windows.Forms.Button();
            this.obrisiUcesceBtn = new System.Windows.Forms.Button();

            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            this.listViewUcesca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colFazaId,
                this.colTimId,
                this.colNazivFaze,
                this.colNazivTima,
                this.colStatus,
                this.colRezultat,
                this.colPobede,
                this.colPorazi,
                this.colBodovi,
                this.colPlasman
            });

            this.listViewUcesca.FullRowSelect = true;
            this.listViewUcesca.GridLines = true;
            this.listViewUcesca.HideSelection = false;
            this.listViewUcesca.Location = new System.Drawing.Point(20, 20);
            this.listViewUcesca.Name = "listViewUcesca";
            this.listViewUcesca.Size = new System.Drawing.Size(1540, 650);
            this.listViewUcesca.TabIndex = 0;
            this.listViewUcesca.UseCompatibleStateImageBehavior = false;
            this.listViewUcesca.View = System.Windows.Forms.View.Details;

            this.colFazaId.Text = "Faza ID";
            this.colFazaId.Width = 80;

            this.colTimId.Text = "Tim ID";
            this.colTimId.Width = 80;

            this.colNazivFaze.Text = "Naziv faze";
            this.colNazivFaze.Width = 180;

            this.colNazivTima.Text = "Naziv tima";
            this.colNazivTima.Width = 180;

            this.colStatus.Text = "Status";
            this.colStatus.Width = 150;

            this.colRezultat.Text = "Ostvareni rezultat";
            this.colRezultat.Width = 180;

            this.colPobede.Text = "Pobede";
            this.colPobede.Width = 80;

            this.colPorazi.Text = "Porazi";
            this.colPorazi.Width = 80;

            this.colBodovi.Text = "Bodovi";
            this.colBodovi.Width = 90;

            this.colPlasman.Text = "Konačan plasman";
            this.colPlasman.Width = 140;

            this.groupBox1.Controls.Add(this.dodajUcesceBtn);
            this.groupBox1.Controls.Add(this.izmeniUcesceBtn);
            this.groupBox1.Controls.Add(this.obrisiUcesceBtn);
            this.groupBox1.Location = new System.Drawing.Point(20, 700);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1540, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akcije";

            this.dodajUcesceBtn.Location = new System.Drawing.Point(30, 25);
            this.dodajUcesceBtn.Name = "dodajUcesceBtn";
            this.dodajUcesceBtn.Size = new System.Drawing.Size(300, 60);
            this.dodajUcesceBtn.TabIndex = 0;
            this.dodajUcesceBtn.Text = "Dodaj učešće";
            this.dodajUcesceBtn.UseVisualStyleBackColor = true;
            this.dodajUcesceBtn.Click += new System.EventHandler(this.dodajUcesceBtn_Click);

            this.izmeniUcesceBtn.Location = new System.Drawing.Point(360, 25);
            this.izmeniUcesceBtn.Name = "izmeniUcesceBtn";
            this.izmeniUcesceBtn.Size = new System.Drawing.Size(300, 60);
            this.izmeniUcesceBtn.TabIndex = 1;
            this.izmeniUcesceBtn.Text = "Izmeni učešće";
            this.izmeniUcesceBtn.UseVisualStyleBackColor = true;
            this.izmeniUcesceBtn.Click += new System.EventHandler(this.izmeniUcesceBtn_Click);

            this.obrisiUcesceBtn.Location = new System.Drawing.Point(690, 25);
            this.obrisiUcesceBtn.Name = "obrisiUcesceBtn";
            this.obrisiUcesceBtn.Size = new System.Drawing.Size(300, 60);
            this.obrisiUcesceBtn.TabIndex = 2;
            this.obrisiUcesceBtn.Text = "Obriši učešće";
            this.obrisiUcesceBtn.UseVisualStyleBackColor = true;
            this.obrisiUcesceBtn.Click += new System.EventHandler(this.obrisiUcesceBtn_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewUcesca);
            this.Name = "UcesceTimaUFaziForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Učešće tima u fazi";
            this.Load += new System.EventHandler(this.UcesceTimaUFaziForma_Load);

            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
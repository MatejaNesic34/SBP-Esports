namespace ESPORT.Forme
{
    partial class FazaTakmicenjaForma
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
            listViewFaze = new ListView();

            columnFazaId = new ColumnHeader();
            columnTakmicenjeId = new ColumnHeader();
            columnTakmicenje = new ColumnHeader();
            columnNazivFaze = new ColumnHeader();
            columnRedniBroj = new ColumnHeader();
            columnNadfazaId = new ColumnHeader();

            dodajFazuBtn = new Button();
            izmeniFazuBtn = new Button();
            obrisiFazuBtn = new Button();

            ucescaBtn = new Button();

            groupBoxFaze = new GroupBox();

            groupBoxFaze.SuspendLayout();
            SuspendLayout();

            // 
            // listViewFaze
            // 
            listViewFaze.Columns.AddRange(new ColumnHeader[]
            {
                columnFazaId,
                columnTakmicenjeId,
                columnTakmicenje,
                columnNazivFaze,
                columnRedniBroj,
                columnNadfazaId
            });

            listViewFaze.FullRowSelect = true;
            listViewFaze.GridLines = true;
            listViewFaze.Location = new Point(20, 30);
            listViewFaze.Name = "listViewFaze";
            listViewFaze.Size = new Size(1100, 500);
            listViewFaze.TabIndex = 0;
            listViewFaze.UseCompatibleStateImageBehavior = false;
            listViewFaze.View = View.Details;

            // 
            // columnFazaId
            // 
            columnFazaId.Text = "Faza ID";
            columnFazaId.Width = 80;

            // 
            // columnTakmicenjeId
            // 
            columnTakmicenjeId.Text = "Takmičenje ID";
            columnTakmicenjeId.Width = 110;

            // 
            // columnTakmicenje
            // 
            columnTakmicenje.Text = "Takmičenje";
            columnTakmicenje.Width = 250;

            // 
            // columnNazivFaze
            // 
            columnNazivFaze.Text = "Naziv faze";
            columnNazivFaze.Width = 200;

            // 
            // columnRedniBroj
            // 
            columnRedniBroj.Text = "Redni broj";
            columnRedniBroj.Width = 100;

            // 
            // columnNadfazaId
            // 
            columnNadfazaId.Text = "Nadfaza ID";
            columnNadfazaId.Width = 100;

            // 
            // groupBoxFaze
            // 
            groupBoxFaze.Controls.Add(listViewFaze);
            groupBoxFaze.Location = new Point(20, 20);
            groupBoxFaze.Name = "groupBoxFaze";
            groupBoxFaze.Size = new Size(1140, 550);
            groupBoxFaze.TabIndex = 1;
            groupBoxFaze.TabStop = false;
            groupBoxFaze.Text = "Faze takmičenja";

            // 
            // dodajFazuBtn
            // 
            dodajFazuBtn.Location = new Point(20, 600);
            dodajFazuBtn.Name = "dodajFazuBtn";
            dodajFazuBtn.Size = new Size(200, 60);
            dodajFazuBtn.TabIndex = 2;
            dodajFazuBtn.Text = "Dodaj fazu";
            dodajFazuBtn.UseVisualStyleBackColor = true;
            dodajFazuBtn.Click += dodajFazuBtn_Click;

            // 
            // izmeniFazuBtn
            // 
            izmeniFazuBtn.Location = new Point(240, 600);
            izmeniFazuBtn.Name = "izmeniFazuBtn";
            izmeniFazuBtn.Size = new Size(200, 60);
            izmeniFazuBtn.TabIndex = 3;
            izmeniFazuBtn.Text = "Izmeni fazu";
            izmeniFazuBtn.UseVisualStyleBackColor = true;
            izmeniFazuBtn.Click += izmeniFazuBtn_Click;

            // 
            // obrisiFazuBtn
            // 
            obrisiFazuBtn.Location = new Point(460, 600);
            obrisiFazuBtn.Name = "obrisiFazuBtn";
            obrisiFazuBtn.Size = new Size(200, 60);
            obrisiFazuBtn.TabIndex = 4;
            obrisiFazuBtn.Text = "Obriši fazu";
            obrisiFazuBtn.UseVisualStyleBackColor = true;
            obrisiFazuBtn.Click += obrisiFazuBtn_Click;

            // 
            // ucescaBtn
            // 
            ucescaBtn.Location = new Point(680, 600);
            ucescaBtn.Name = "ucescaBtn";
            ucescaBtn.Size = new Size(200, 60);
            ucescaBtn.TabIndex = 5;
            ucescaBtn.Text = "Učešća timova";
            ucescaBtn.UseVisualStyleBackColor = true;
            ucescaBtn.Click += ucescaBtn_Click;

            // 
            // FazaTakmicenjaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);

            Controls.Add(groupBoxFaze);
            Controls.Add(dodajFazuBtn);
            Controls.Add(izmeniFazuBtn);
            Controls.Add(obrisiFazuBtn);
            Controls.Add(ucescaBtn);

            Name = "FazaTakmicenjaForma";
            Text = "Faze takmičenja";

            Load += FazaTakmicenjaForma_Load;

            groupBoxFaze.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ListView listViewFaze;

        private ColumnHeader columnFazaId;
        private ColumnHeader columnTakmicenjeId;
        private ColumnHeader columnTakmicenje;
        private ColumnHeader columnNazivFaze;
        private ColumnHeader columnRedniBroj;
        private ColumnHeader columnNadfazaId;

        private Button dodajFazuBtn;
        private Button izmeniFazuBtn;
        private Button obrisiFazuBtn;

        private Button ucescaBtn;

        private GroupBox groupBoxFaze;
    }
}
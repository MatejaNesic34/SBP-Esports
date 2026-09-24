using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ESPORT.Forme
{
    partial class AngazmanTreneraForma
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
            listViewAngazmani = new ListView();
            ID = new ColumnHeader();
            trener = new ColumnHeader();
            tim = new ColumnHeader();
            tipUloge = new ColumnHeader();
            datumOd = new ColumnHeader();
            datumDo = new ColumnHeader();

            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();

            SuspendLayout();

            listViewAngazmani.Columns.AddRange(new ColumnHeader[]
            {
                ID,
                trener,
                tim,
                tipUloge,
                datumOd,
                datumDo
            });

            listViewAngazmani.FullRowSelect = true;
            listViewAngazmani.Location = new Point(20, 20);
            listViewAngazmani.Margin = new Padding(1);
            listViewAngazmani.Name = "listViewAngazmani";
            listViewAngazmani.Size = new Size(850, 400);
            listViewAngazmani.TabIndex = 0;
            listViewAngazmani.UseCompatibleStateImageBehavior = false;
            listViewAngazmani.View = View.Details;

            ID.Text = "ID";
            ID.Width = 70;

            trener.Text = "Trener";
            trener.Width = 200;

            tim.Text = "Tim";
            tim.Width = 180;

            tipUloge.Text = "Tip uloge";
            tipUloge.Width = 160;

            datumOd.Text = "Datum od";
            datumOd.Width = 120;

            datumDo.Text = "Datum do";
            datumDo.Width = 120;

            btnDodaj.Location = new Point(20, 440);
            btnDodaj.Margin = new Padding(1);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 45);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            btnIzmeni.Location = new Point(160, 440);
            btnIzmeni.Margin = new Padding(1);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(120, 45);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnObrisi.Location = new Point(300, 440);
            btnObrisi.Margin = new Padding(1);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 45);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 510);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(listViewAngazmani);
            Margin = new Padding(1);
            Name = "AngazmanTreneraForma";
            Text = "Angažman trenera";

            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAngazmani;

        private ColumnHeader ID;
        private ColumnHeader trener;
        private ColumnHeader tim;
        private ColumnHeader tipUloge;
        private ColumnHeader datumOd;
        private ColumnHeader datumDo;

        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}
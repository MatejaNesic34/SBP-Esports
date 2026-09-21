using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ESPORT.Forme
{
    partial class TimoviForma
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewTimovi = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Igra = new ColumnHeader();
            DatumOsnivanja = new ColumnHeader();
            Drzava = new ColumnHeader();
            Status = new ColumnHeader();
            Nivo = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            obrisitimbtn = new Button();
            izmenitimbtn = new Button();
            dodajtimbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewTimovi
            // 
            listViewTimovi.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Igra, DatumOsnivanja, Drzava, Status, Nivo });
            listViewTimovi.FullRowSelect = true;
            listViewTimovi.Location = new Point(24, 56);
            listViewTimovi.MultiSelect = false;
            listViewTimovi.Name = "listViewTimovi";
            listViewTimovi.Size = new Size(1200, 659);
            listViewTimovi.TabIndex = 0;
            listViewTimovi.UseCompatibleStateImageBehavior = false;
            listViewTimovi.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 230;
            // 
            // Igra
            // 
            Igra.Text = "Igra";
            Igra.Width = 200;
            // 
            // DatumOsnivanja
            // 
            DatumOsnivanja.Text = "Datum osnivanja";
            DatumOsnivanja.Width = 170;
            // 
            // Drzava
            // 
            Drzava.Text = "Država registracije";
            Drzava.Width = 200;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 150;
            // 
            // Nivo
            // 
            Nivo.Text = "Nivo takmičenja";
            Nivo.Width = 160;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewTimovi);
            groupBox1.Location = new Point(40, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1250, 745);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz timova";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(obrisitimbtn);
            groupBox2.Controls.Add(izmenitimbtn);
            groupBox2.Controls.Add(dodajtimbtn);
            groupBox2.Location = new Point(1340, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Timovi akcije";
            // 
            // obrisitimbtn
            // 
            obrisitimbtn.Location = new Point(62, 320);
            obrisitimbtn.Name = "obrisitimbtn";
            obrisitimbtn.Size = new Size(243, 77);
            obrisitimbtn.TabIndex = 2;
            obrisitimbtn.Text = "Obrisi tim";
            obrisitimbtn.UseVisualStyleBackColor = true;
            obrisitimbtn.Click += obrisitimbtn_Click;
            // 
            // izmenitimbtn
            // 
            izmenitimbtn.Location = new Point(62, 200);
            izmenitimbtn.Name = "izmenitimbtn";
            izmenitimbtn.Size = new Size(243, 76);
            izmenitimbtn.TabIndex = 1;
            izmenitimbtn.Text = "Izmeni tim";
            izmenitimbtn.UseVisualStyleBackColor = true;
            izmenitimbtn.Click += izmenitimbtn_Click;
            // 
            // dodajtimbtn
            // 
            dodajtimbtn.Location = new Point(62, 76);
            dodajtimbtn.Name = "dodajtimbtn";
            dodajtimbtn.Size = new Size(243, 76);
            dodajtimbtn.TabIndex = 0;
            dodajtimbtn.Text = "Dodaj tim";
            dodajtimbtn.UseVisualStyleBackColor = true;
            dodajtimbtn.Click += dodajtimbtn_Click;
            // 
            // TimoviForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 900);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TimoviForma";
            Text = "TimoviForma";
            Load += TimoviForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTimovi;
        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Igra;
        private ColumnHeader DatumOsnivanja;
        private ColumnHeader Drzava;
        private ColumnHeader Status;
        private ColumnHeader Nivo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button obrisitimbtn;
        private Button izmenitimbtn;
        private Button dodajtimbtn;
    }
}
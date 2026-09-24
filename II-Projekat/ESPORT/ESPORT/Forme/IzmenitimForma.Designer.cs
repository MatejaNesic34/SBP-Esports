using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ESPORT.Forme
{
    partial class IzmeniTimForma
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
            nazivlbl = new Label();
            nazivtxt = new TextBox();
            igralbl = new Label();
            igracmb = new ComboBox();
            datumlbl = new Label();
            datumosnivanjadtp = new DateTimePicker();
            drzavalbl = new Label();
            drzavatxt = new TextBox();
            statuslbl = new Label();
            statuscmb = new ComboBox();
            nivolbl = new Label();
            nivocmb = new ComboBox();
            sacuvajbtn = new Button();
            otkazibtn = new Button();
            SuspendLayout();

            nazivlbl.AutoSize = true;
            nazivlbl.Location = new Point(40, 46);
            nazivlbl.Name = "nazivlbl";
            nazivlbl.Size = new Size(120, 41);
            nazivlbl.TabIndex = 0;
            nazivlbl.Text = "Naziv tima:";

            nazivtxt.Location = new Point(340, 40);
            nazivtxt.MaxLength = 100;
            nazivtxt.Name = "nazivtxt";
            nazivtxt.Size = new Size(460, 47);
            nazivtxt.TabIndex = 1;

            igralbl.AutoSize = true;
            igralbl.Location = new Point(40, 136);
            igralbl.Name = "igralbl";
            igralbl.Size = new Size(60, 41);
            igralbl.TabIndex = 2;
            igralbl.Text = "Igra:";

            igracmb.DropDownStyle = ComboBoxStyle.DropDownList;
            igracmb.FormattingEnabled = true;
            igracmb.Location = new Point(340, 130);
            igracmb.Name = "igracmb";
            igracmb.Size = new Size(460, 49);
            igracmb.TabIndex = 3;

            datumlbl.AutoSize = true;
            datumlbl.Location = new Point(40, 226);
            datumlbl.Name = "datumlbl";
            datumlbl.Size = new Size(200, 41);
            datumlbl.TabIndex = 4;
            datumlbl.Text = "Datum osnivanja:";

            datumosnivanjadtp.Format = DateTimePickerFormat.Short;
            datumosnivanjadtp.Location = new Point(340, 220);
            datumosnivanjadtp.Name = "datumosnivanjadtp";
            datumosnivanjadtp.ShowCheckBox = true;
            datumosnivanjadtp.Size = new Size(460, 47);
            datumosnivanjadtp.TabIndex = 5;

            drzavalbl.AutoSize = true;
            drzavalbl.Location = new Point(40, 316);
            drzavalbl.Name = "drzavalbl";
            drzavalbl.Size = new Size(240, 41);
            drzavalbl.TabIndex = 6;
            drzavalbl.Text = "Država registracije:";

            drzavatxt.Location = new Point(340, 310);
            drzavatxt.MaxLength = 50;
            drzavatxt.Name = "drzavatxt";
            drzavatxt.Size = new Size(460, 47);
            drzavatxt.TabIndex = 7;

            statuslbl.AutoSize = true;
            statuslbl.Location = new Point(40, 406);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(130, 41);
            statuslbl.TabIndex = 8;
            statuslbl.Text = "Status tima:";

            statuscmb.DropDownStyle = ComboBoxStyle.DropDownList;
            statuscmb.FormattingEnabled = true;
            statuscmb.Items.AddRange(new object[] { "Aktivno", "Neaktivno", "U izradi", "Rasformiran" });
            statuscmb.Location = new Point(340, 400);
            statuscmb.Name = "statuscmb";
            statuscmb.Size = new Size(460, 49);
            statuscmb.TabIndex = 9;

            nivolbl.AutoSize = true;
            nivolbl.Location = new Point(40, 496);
            nivolbl.Name = "nivolbl";
            nivolbl.Size = new Size(220, 41);
            nivolbl.TabIndex = 10;
            nivolbl.Text = "Nivo takmičenja:";

            nivocmb.DropDownStyle = ComboBoxStyle.DropDownList;
            nivocmb.FormattingEnabled = true;
            nivocmb.Items.AddRange(new object[] { "Amaterski", "Drzavno", "Regionalni", "Pro" });
            nivocmb.Location = new Point(340, 490);
            nivocmb.Name = "nivocmb";
            nivocmb.Size = new Size(460, 49);
            nivocmb.TabIndex = 11;

            sacuvajbtn.Location = new Point(120, 620);
            sacuvajbtn.Name = "sacuvajbtn";
            sacuvajbtn.Size = new Size(260, 76);
            sacuvajbtn.TabIndex = 12;
            sacuvajbtn.Text = "Sačuvaj";
            sacuvajbtn.UseVisualStyleBackColor = true;
            sacuvajbtn.Click += sacuvajbtn_Click;

            otkazibtn.DialogResult = DialogResult.Cancel;
            otkazibtn.Location = new Point(460, 620);
            otkazibtn.Name = "otkazibtn";
            otkazibtn.Size = new Size(260, 76);
            otkazibtn.TabIndex = 13;
            otkazibtn.Text = "Otkaži";
            otkazibtn.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = otkazibtn;
            ClientSize = new Size(860, 740);
            Controls.Add(otkazibtn);
            Controls.Add(sacuvajbtn);
            Controls.Add(nivocmb);
            Controls.Add(nivolbl);
            Controls.Add(statuscmb);
            Controls.Add(statuslbl);
            Controls.Add(drzavatxt);
            Controls.Add(drzavalbl);
            Controls.Add(datumosnivanjadtp);
            Controls.Add(datumlbl);
            Controls.Add(igracmb);
            Controls.Add(igralbl);
            Controls.Add(nazivtxt);
            Controls.Add(nazivlbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzmeniTimForma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni tim";
            Load += IzmeniTimForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nazivlbl;
        private TextBox nazivtxt;
        private Label igralbl;
        private ComboBox igracmb;
        private Label datumlbl;
        private DateTimePicker datumosnivanjadtp;
        private Label drzavalbl;
        private TextBox drzavatxt;
        private Label statuslbl;
        private ComboBox statuscmb;
        private Label nivolbl;
        private ComboBox nivocmb;
        private Button sacuvajbtn;
        private Button otkazibtn;
    }
}
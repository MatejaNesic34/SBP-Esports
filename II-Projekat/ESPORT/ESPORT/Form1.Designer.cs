namespace ESPORT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            osobebtn = new Button();
            timbtn = new Button();
            takmicenjebtn = new Button();
            Mecbtn = new Button();
            sponzorbtn = new Button();
            igrebtn = new Button();
            SuspendLayout();
            // 
            // osobebtn
            // 
            osobebtn.Location = new Point(157, 105);
            osobebtn.Margin = new Padding(2, 2, 2, 2);
            osobebtn.Name = "osobebtn";
            osobebtn.Size = new Size(244, 57);
            osobebtn.TabIndex = 0;
            osobebtn.Text = "Osobe";
            osobebtn.UseVisualStyleBackColor = true;
            osobebtn.Click += osobebtn_Click;
            // 
            // timbtn
            // 
            timbtn.Location = new Point(157, 211);
            timbtn.Margin = new Padding(2, 2, 2, 2);
            timbtn.Name = "timbtn";
            timbtn.Size = new Size(244, 57);
            timbtn.TabIndex = 1;
            timbtn.Text = "Tim";
            timbtn.UseVisualStyleBackColor = true;
            // 
            // takmicenjebtn
            // 
            takmicenjebtn.Location = new Point(157, 320);
            takmicenjebtn.Margin = new Padding(2, 2, 2, 2);
            takmicenjebtn.Name = "takmicenjebtn";
            takmicenjebtn.Size = new Size(244, 57);
            takmicenjebtn.TabIndex = 2;
            takmicenjebtn.Text = "Takmicenje";
            takmicenjebtn.UseVisualStyleBackColor = true;
            // 
            // Mecbtn
            // 
            Mecbtn.Location = new Point(157, 422);
            Mecbtn.Margin = new Padding(2, 2, 2, 2);
            Mecbtn.Name = "Mecbtn";
            Mecbtn.Size = new Size(244, 57);
            Mecbtn.TabIndex = 3;
            Mecbtn.Text = "Mec";
            Mecbtn.UseVisualStyleBackColor = true;
            // 
            // sponzorbtn
            // 
            sponzorbtn.Location = new Point(159, 525);
            sponzorbtn.Margin = new Padding(2, 2, 2, 2);
            sponzorbtn.Name = "sponzorbtn";
            sponzorbtn.Size = new Size(242, 57);
            sponzorbtn.TabIndex = 4;
            sponzorbtn.Text = "Sponzor";
            sponzorbtn.UseVisualStyleBackColor = true;
            // 
            // igrebtn
            // 
            igrebtn.Location = new Point(162, 621);
            igrebtn.Margin = new Padding(2, 2, 2, 2);
            igrebtn.Name = "igrebtn";
            igrebtn.Size = new Size(240, 57);
            igrebtn.TabIndex = 5;
            igrebtn.Text = "Igre";
            igrebtn.UseVisualStyleBackColor = true;
            igrebtn.Click += igrebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 771);
            Controls.Add(igrebtn);
            Controls.Add(sponzorbtn);
            Controls.Add(Mecbtn);
            Controls.Add(takmicenjebtn);
            Controls.Add(timbtn);
            Controls.Add(osobebtn);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button osobebtn;
        private Button timbtn;
        private Button takmicenjebtn;
        private Button Mecbtn;
        private Button sponzorbtn;
        private Button igrebtn;
    }
}

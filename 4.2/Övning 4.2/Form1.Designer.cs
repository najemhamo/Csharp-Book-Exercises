namespace Övning_4._2
{
    partial class Form1
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
            this.lbl_förnamn = new System.Windows.Forms.Label();
            this.lbl_efternamn = new System.Windows.Forms.Label();
            this.lbl_epost = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.tbx_förnamn = new System.Windows.Forms.TextBox();
            this.tbx_efternamn = new System.Windows.Forms.TextBox();
            this.tbx_epost = new System.Windows.Forms.TextBox();
            this.tbx_telefon = new System.Windows.Forms.TextBox();
            this.btn_öppna = new System.Windows.Forms.Button();
            this.btn_spara = new System.Windows.Forms.Button();
            this.dlg_öppna = new System.Windows.Forms.OpenFileDialog();
            this.dlg_spara = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbl_förnamn
            // 
            this.lbl_förnamn.AutoSize = true;
            this.lbl_förnamn.Location = new System.Drawing.Point(53, 16);
            this.lbl_förnamn.Name = "lbl_förnamn";
            this.lbl_förnamn.Size = new System.Drawing.Size(48, 13);
            this.lbl_förnamn.TabIndex = 0;
            this.lbl_förnamn.Text = "Förnamn";
            // 
            // lbl_efternamn
            // 
            this.lbl_efternamn.AutoSize = true;
            this.lbl_efternamn.Location = new System.Drawing.Point(192, 16);
            this.lbl_efternamn.Name = "lbl_efternamn";
            this.lbl_efternamn.Size = new System.Drawing.Size(55, 13);
            this.lbl_efternamn.TabIndex = 1;
            this.lbl_efternamn.Text = "Efternamn";
            // 
            // lbl_epost
            // 
            this.lbl_epost.AutoSize = true;
            this.lbl_epost.Location = new System.Drawing.Point(64, 106);
            this.lbl_epost.Name = "lbl_epost";
            this.lbl_epost.Size = new System.Drawing.Size(37, 13);
            this.lbl_epost.TabIndex = 2;
            this.lbl_epost.Text = "E-post";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(192, 115);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(46, 13);
            this.lbl_telefon.TabIndex = 3;
            this.lbl_telefon.Text = "Nummer";
            // 
            // tbx_förnamn
            // 
            this.tbx_förnamn.Location = new System.Drawing.Point(33, 42);
            this.tbx_förnamn.Name = "tbx_förnamn";
            this.tbx_förnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_förnamn.TabIndex = 4;
            // 
            // tbx_efternamn
            // 
            this.tbx_efternamn.Location = new System.Drawing.Point(170, 42);
            this.tbx_efternamn.Name = "tbx_efternamn";
            this.tbx_efternamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_efternamn.TabIndex = 5;
            // 
            // tbx_epost
            // 
            this.tbx_epost.Location = new System.Drawing.Point(12, 140);
            this.tbx_epost.Name = "tbx_epost";
            this.tbx_epost.Size = new System.Drawing.Size(138, 20);
            this.tbx_epost.TabIndex = 6;
            // 
            // tbx_telefon
            // 
            this.tbx_telefon.Location = new System.Drawing.Point(170, 140);
            this.tbx_telefon.Name = "tbx_telefon";
            this.tbx_telefon.Size = new System.Drawing.Size(100, 20);
            this.tbx_telefon.TabIndex = 7;
            // 
            // btn_öppna
            // 
            this.btn_öppna.Location = new System.Drawing.Point(170, 200);
            this.btn_öppna.Name = "btn_öppna";
            this.btn_öppna.Size = new System.Drawing.Size(75, 23);
            this.btn_öppna.TabIndex = 8;
            this.btn_öppna.Text = "Öppna";
            this.btn_öppna.UseVisualStyleBackColor = true;
            this.btn_öppna.Click += new System.EventHandler(this.btn_öppna_Click);
            // 
            // btn_spara
            // 
            this.btn_spara.Location = new System.Drawing.Point(33, 200);
            this.btn_spara.Name = "btn_spara";
            this.btn_spara.Size = new System.Drawing.Size(75, 23);
            this.btn_spara.TabIndex = 9;
            this.btn_spara.Text = "Spara som";
            this.btn_spara.UseVisualStyleBackColor = true;
            this.btn_spara.Click += new System.EventHandler(this.btn_spara_Click);
            // 
            // dlg_öppna
            // 
            this.dlg_öppna.FileName = "text.txt";
            // 
            // dlg_spara
            // 
            this.dlg_spara.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 239);
            this.Controls.Add(this.btn_spara);
            this.Controls.Add(this.btn_öppna);
            this.Controls.Add(this.tbx_telefon);
            this.Controls.Add(this.tbx_epost);
            this.Controls.Add(this.tbx_efternamn);
            this.Controls.Add(this.tbx_förnamn);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_epost);
            this.Controls.Add(this.lbl_efternamn);
            this.Controls.Add(this.lbl_förnamn);
            this.Name = "Form1";
            this.Text = "4.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_förnamn;
        private System.Windows.Forms.Label lbl_efternamn;
        private System.Windows.Forms.Label lbl_epost;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox tbx_förnamn;
        private System.Windows.Forms.TextBox tbx_efternamn;
        private System.Windows.Forms.TextBox tbx_epost;
        private System.Windows.Forms.TextBox tbx_telefon;
        private System.Windows.Forms.Button btn_öppna;
        private System.Windows.Forms.Button btn_spara;
        private System.Windows.Forms.OpenFileDialog dlg_öppna;
        private System.Windows.Forms.SaveFileDialog dlg_spara;
    }
}


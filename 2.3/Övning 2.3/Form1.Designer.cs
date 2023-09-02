namespace Övning_2._3
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
            this.gbx_inOut = new System.Windows.Forms.GroupBox();
            this.btn_ut = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.tbx_belopp = new System.Windows.Forms.TextBox();
            this.lbl_belopp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_kredit = new System.Windows.Forms.TextBox();
            this.lbl_kredit = new System.Windows.Forms.Label();
            this.tbx_ränta = new System.Windows.Forms.TextBox();
            this.lbl_ränta = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.tbx_Pnum = new System.Windows.Forms.TextBox();
            this.lbl_Pnum = new System.Windows.Forms.Label();
            this.lbx_konton = new System.Windows.Forms.ListBox();
            this.btn_uppdatera = new System.Windows.Forms.Button();
            this.gbx_inOut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_inOut
            // 
            this.gbx_inOut.Controls.Add(this.btn_ut);
            this.gbx_inOut.Controls.Add(this.btn_in);
            this.gbx_inOut.Controls.Add(this.tbx_belopp);
            this.gbx_inOut.Controls.Add(this.lbl_belopp);
            this.gbx_inOut.Location = new System.Drawing.Point(12, 26);
            this.gbx_inOut.Name = "gbx_inOut";
            this.gbx_inOut.Size = new System.Drawing.Size(217, 207);
            this.gbx_inOut.TabIndex = 0;
            this.gbx_inOut.TabStop = false;
            this.gbx_inOut.Text = "Insättning/Uttag";
            // 
            // btn_ut
            // 
            this.btn_ut.Location = new System.Drawing.Point(113, 169);
            this.btn_ut.Name = "btn_ut";
            this.btn_ut.Size = new System.Drawing.Size(87, 23);
            this.btn_ut.TabIndex = 3;
            this.btn_ut.Text = "Uttag";
            this.btn_ut.UseVisualStyleBackColor = true;
            this.btn_ut.Click += new System.EventHandler(this.btn_ut_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(113, 125);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(87, 23);
            this.btn_in.TabIndex = 2;
            this.btn_in.Text = "Insättning";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // tbx_belopp
            // 
            this.tbx_belopp.Location = new System.Drawing.Point(77, 45);
            this.tbx_belopp.Name = "tbx_belopp";
            this.tbx_belopp.Size = new System.Drawing.Size(123, 20);
            this.tbx_belopp.TabIndex = 1;
            // 
            // lbl_belopp
            // 
            this.lbl_belopp.AutoSize = true;
            this.lbl_belopp.Location = new System.Drawing.Point(7, 45);
            this.lbl_belopp.Name = "lbl_belopp";
            this.lbl_belopp.Size = new System.Drawing.Size(40, 13);
            this.lbl_belopp.TabIndex = 0;
            this.lbl_belopp.Text = "Belopp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_kredit);
            this.groupBox1.Controls.Add(this.lbl_kredit);
            this.groupBox1.Controls.Add(this.tbx_ränta);
            this.groupBox1.Controls.Add(this.lbl_ränta);
            this.groupBox1.Controls.Add(this.btn_reg);
            this.groupBox1.Controls.Add(this.tbx_Pnum);
            this.groupBox1.Controls.Add(this.lbl_Pnum);
            this.groupBox1.Location = new System.Drawing.Point(262, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insättning/Uttag";
            // 
            // tbx_kredit
            // 
            this.tbx_kredit.Location = new System.Drawing.Point(77, 122);
            this.tbx_kredit.Name = "tbx_kredit";
            this.tbx_kredit.Size = new System.Drawing.Size(123, 20);
            this.tbx_kredit.TabIndex = 7;
            // 
            // lbl_kredit
            // 
            this.lbl_kredit.AutoSize = true;
            this.lbl_kredit.Location = new System.Drawing.Point(6, 125);
            this.lbl_kredit.Name = "lbl_kredit";
            this.lbl_kredit.Size = new System.Drawing.Size(34, 13);
            this.lbl_kredit.TabIndex = 6;
            this.lbl_kredit.Text = "Kredit";
            // 
            // tbx_ränta
            // 
            this.tbx_ränta.Location = new System.Drawing.Point(77, 85);
            this.tbx_ränta.Name = "tbx_ränta";
            this.tbx_ränta.Size = new System.Drawing.Size(123, 20);
            this.tbx_ränta.TabIndex = 5;
            // 
            // lbl_ränta
            // 
            this.lbl_ränta.AutoSize = true;
            this.lbl_ränta.Location = new System.Drawing.Point(6, 88);
            this.lbl_ränta.Name = "lbl_ränta";
            this.lbl_ränta.Size = new System.Drawing.Size(55, 13);
            this.lbl_ränta.TabIndex = 4;
            this.lbl_ränta.Text = "Räntesats";
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(113, 169);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(87, 23);
            this.btn_reg.TabIndex = 3;
            this.btn_reg.Text = "Registera";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tbx_Pnum
            // 
            this.tbx_Pnum.Location = new System.Drawing.Point(77, 45);
            this.tbx_Pnum.Name = "tbx_Pnum";
            this.tbx_Pnum.Size = new System.Drawing.Size(123, 20);
            this.tbx_Pnum.TabIndex = 1;
            // 
            // lbl_Pnum
            // 
            this.lbl_Pnum.AutoSize = true;
            this.lbl_Pnum.Location = new System.Drawing.Point(6, 48);
            this.lbl_Pnum.Name = "lbl_Pnum";
            this.lbl_Pnum.Size = new System.Drawing.Size(51, 13);
            this.lbl_Pnum.TabIndex = 0;
            this.lbl_Pnum.Text = "PersonNr";
            // 
            // lbx_konton
            // 
            this.lbx_konton.FormattingEnabled = true;
            this.lbx_konton.Location = new System.Drawing.Point(125, 266);
            this.lbx_konton.Name = "lbx_konton";
            this.lbx_konton.Size = new System.Drawing.Size(228, 147);
            this.lbx_konton.TabIndex = 2;
            // 
            // btn_uppdatera
            // 
            this.btn_uppdatera.Location = new System.Drawing.Point(125, 438);
            this.btn_uppdatera.Name = "btn_uppdatera";
            this.btn_uppdatera.Size = new System.Drawing.Size(228, 23);
            this.btn_uppdatera.TabIndex = 3;
            this.btn_uppdatera.Text = "Uppdatera med årsränta";
            this.btn_uppdatera.UseVisualStyleBackColor = true;
            this.btn_uppdatera.Click += new System.EventHandler(this.btn_uppdatera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 481);
            this.Controls.Add(this.btn_uppdatera);
            this.Controls.Add(this.lbx_konton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_inOut);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.3";
            this.gbx_inOut.ResumeLayout(false);
            this.gbx_inOut.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_inOut;
        private System.Windows.Forms.Button btn_ut;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.TextBox tbx_belopp;
        private System.Windows.Forms.Label lbl_belopp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_kredit;
        private System.Windows.Forms.Label lbl_kredit;
        private System.Windows.Forms.TextBox tbx_ränta;
        private System.Windows.Forms.Label lbl_ränta;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox tbx_Pnum;
        private System.Windows.Forms.Label lbl_Pnum;
        private System.Windows.Forms.ListBox lbx_konton;
        private System.Windows.Forms.Button btn_uppdatera;
    }
}


namespace Övning_2._8
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
            this.lbl_vara = new System.Windows.Forms.Label();
            this.tbx_vara = new System.Windows.Forms.TextBox();
            this.tbx_pris = new System.Windows.Forms.TextBox();
            this.lbl_pris = new System.Windows.Forms.Label();
            this.tbx_mangd = new System.Windows.Forms.TextBox();
            this.lbl_mangd = new System.Windows.Forms.Label();
            this.rdb_vikt = new System.Windows.Forms.RadioButton();
            this.rdb_styck = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbx_lista = new System.Windows.Forms.ListBox();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.tbx_sum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_vara
            // 
            this.lbl_vara.AutoSize = true;
            this.lbl_vara.Location = new System.Drawing.Point(104, 36);
            this.lbl_vara.Name = "lbl_vara";
            this.lbl_vara.Size = new System.Drawing.Size(29, 13);
            this.lbl_vara.TabIndex = 0;
            this.lbl_vara.Text = "Vara";
            // 
            // tbx_vara
            // 
            this.tbx_vara.Location = new System.Drawing.Point(72, 52);
            this.tbx_vara.Name = "tbx_vara";
            this.tbx_vara.Size = new System.Drawing.Size(90, 20);
            this.tbx_vara.TabIndex = 1;
            // 
            // tbx_pris
            // 
            this.tbx_pris.Location = new System.Drawing.Point(209, 52);
            this.tbx_pris.Name = "tbx_pris";
            this.tbx_pris.Size = new System.Drawing.Size(90, 20);
            this.tbx_pris.TabIndex = 3;
            // 
            // lbl_pris
            // 
            this.lbl_pris.AutoSize = true;
            this.lbl_pris.Location = new System.Drawing.Point(243, 36);
            this.lbl_pris.Name = "lbl_pris";
            this.lbl_pris.Size = new System.Drawing.Size(24, 13);
            this.lbl_pris.TabIndex = 2;
            this.lbl_pris.Text = "Pris";
            // 
            // tbx_mangd
            // 
            this.tbx_mangd.Location = new System.Drawing.Point(356, 52);
            this.tbx_mangd.Name = "tbx_mangd";
            this.tbx_mangd.Size = new System.Drawing.Size(90, 20);
            this.tbx_mangd.TabIndex = 5;
            // 
            // lbl_mangd
            // 
            this.lbl_mangd.AutoSize = true;
            this.lbl_mangd.Location = new System.Drawing.Point(376, 36);
            this.lbl_mangd.Name = "lbl_mangd";
            this.lbl_mangd.Size = new System.Drawing.Size(40, 13);
            this.lbl_mangd.TabIndex = 4;
            this.lbl_mangd.Text = "Mängd";
            // 
            // rdb_vikt
            // 
            this.rdb_vikt.AutoSize = true;
            this.rdb_vikt.Location = new System.Drawing.Point(455, 301);
            this.rdb_vikt.Name = "rdb_vikt";
            this.rdb_vikt.Size = new System.Drawing.Size(59, 17);
            this.rdb_vikt.TabIndex = 6;
            this.rdb_vikt.TabStop = true;
            this.rdb_vikt.Text = "Lösvikt";
            this.rdb_vikt.UseVisualStyleBackColor = true;
            // 
            // rdb_styck
            // 
            this.rdb_styck.AutoSize = true;
            this.rdb_styck.Location = new System.Drawing.Point(455, 338);
            this.rdb_styck.Name = "rdb_styck";
            this.rdb_styck.Size = new System.Drawing.Size(69, 17);
            this.rdb_styck.TabIndex = 7;
            this.rdb_styck.TabStop = true;
            this.rdb_styck.Text = "Stycksak";
            this.rdb_styck.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(254, 399);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Lägg till";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbx_lista
            // 
            this.lbx_lista.FormattingEnabled = true;
            this.lbx_lista.Location = new System.Drawing.Point(12, 104);
            this.lbx_lista.Name = "lbx_lista";
            this.lbx_lista.Size = new System.Drawing.Size(426, 251);
            this.lbx_lista.TabIndex = 9;
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(5, 402);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(63, 13);
            this.lbl_sum.TabIndex = 10;
            this.lbl_sum.Text = "Summa (kr):";
            // 
            // tbx_sum
            // 
            this.tbx_sum.Location = new System.Drawing.Point(85, 399);
            this.tbx_sum.Name = "tbx_sum";
            this.tbx_sum.Size = new System.Drawing.Size(126, 20);
            this.tbx_sum.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 452);
            this.Controls.Add(this.tbx_sum);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.lbx_lista);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rdb_styck);
            this.Controls.Add(this.rdb_vikt);
            this.Controls.Add(this.tbx_mangd);
            this.Controls.Add(this.lbl_mangd);
            this.Controls.Add(this.tbx_pris);
            this.Controls.Add(this.lbl_pris);
            this.Controls.Add(this.tbx_vara);
            this.Controls.Add(this.lbl_vara);
            this.Name = "Form1";
            this.Text = "2.8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vara;
        private System.Windows.Forms.TextBox tbx_vara;
        private System.Windows.Forms.TextBox tbx_pris;
        private System.Windows.Forms.Label lbl_pris;
        private System.Windows.Forms.TextBox tbx_mangd;
        private System.Windows.Forms.Label lbl_mangd;
        private System.Windows.Forms.RadioButton rdb_vikt;
        private System.Windows.Forms.RadioButton rdb_styck;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lbx_lista;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.TextBox tbx_sum;
    }
}


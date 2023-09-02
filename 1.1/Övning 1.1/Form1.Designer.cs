namespace Övning_1._1
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
            this.lbl_sif1 = new System.Windows.Forms.Label();
            this.lbl_sif2 = new System.Windows.Forms.Label();
            this.tbx_tal1 = new System.Windows.Forms.TextBox();
            this.tbx_tal2 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sif1
            // 
            this.lbl_sif1.AutoSize = true;
            this.lbl_sif1.Location = new System.Drawing.Point(51, 13);
            this.lbl_sif1.Name = "lbl_sif1";
            this.lbl_sif1.Size = new System.Drawing.Size(70, 13);
            this.lbl_sif1.TabIndex = 0;
            this.lbl_sif1.Text = "Första siffran:";
            // 
            // lbl_sif2
            // 
            this.lbl_sif2.AutoSize = true;
            this.lbl_sif2.Location = new System.Drawing.Point(51, 101);
            this.lbl_sif2.Name = "lbl_sif2";
            this.lbl_sif2.Size = new System.Drawing.Size(69, 13);
            this.lbl_sif2.TabIndex = 1;
            this.lbl_sif2.Text = "Andra siffran:";
            // 
            // tbx_tal1
            // 
            this.tbx_tal1.Location = new System.Drawing.Point(38, 37);
            this.tbx_tal1.Name = "tbx_tal1";
            this.tbx_tal1.Size = new System.Drawing.Size(100, 20);
            this.tbx_tal1.TabIndex = 2;
            // 
            // tbx_tal2
            // 
            this.tbx_tal2.Location = new System.Drawing.Point(38, 120);
            this.tbx_tal2.Name = "tbx_tal2";
            this.tbx_tal2.Size = new System.Drawing.Size(100, 20);
            this.tbx_tal2.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(176, 66);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Addera";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_resultat
            // 
            this.lbl_resultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_resultat.Location = new System.Drawing.Point(301, 66);
            this.lbl_resultat.Name = "lbl_resultat";
            this.lbl_resultat.Size = new System.Drawing.Size(100, 23);
            this.lbl_resultat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 156);
            this.Controls.Add(this.lbl_resultat);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_tal2);
            this.Controls.Add(this.tbx_tal1);
            this.Controls.Add(this.lbl_sif2);
            this.Controls.Add(this.lbl_sif1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sif1;
        private System.Windows.Forms.Label lbl_sif2;
        private System.Windows.Forms.TextBox tbx_tal1;
        private System.Windows.Forms.TextBox tbx_tal2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_resultat;
    }
}


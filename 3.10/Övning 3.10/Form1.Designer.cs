namespace Övning_3._10
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
            this.lbl_pris = new System.Windows.Forms.Label();
            this.tbx_vara = new System.Windows.Forms.TextBox();
            this.tbx_pris = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vara
            // 
            this.lbl_vara.AutoSize = true;
            this.lbl_vara.Location = new System.Drawing.Point(9, 17);
            this.lbl_vara.Name = "lbl_vara";
            this.lbl_vara.Size = new System.Drawing.Size(29, 13);
            this.lbl_vara.TabIndex = 0;
            this.lbl_vara.Text = "Vara";
            // 
            // lbl_pris
            // 
            this.lbl_pris.AutoSize = true;
            this.lbl_pris.Location = new System.Drawing.Point(173, 18);
            this.lbl_pris.Name = "lbl_pris";
            this.lbl_pris.Size = new System.Drawing.Size(24, 13);
            this.lbl_pris.TabIndex = 1;
            this.lbl_pris.Text = "Pris";
            // 
            // tbx_vara
            // 
            this.tbx_vara.Location = new System.Drawing.Point(12, 45);
            this.tbx_vara.Name = "tbx_vara";
            this.tbx_vara.Size = new System.Drawing.Size(128, 20);
            this.tbx_vara.TabIndex = 2;
            // 
            // tbx_pris
            // 
            this.tbx_pris.Location = new System.Drawing.Point(176, 46);
            this.tbx_pris.Name = "tbx_pris";
            this.tbx_pris.Size = new System.Drawing.Size(79, 20);
            this.tbx_pris.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(290, 43);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(29, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 326);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_pris);
            this.Controls.Add(this.tbx_vara);
            this.Controls.Add(this.lbl_pris);
            this.Controls.Add(this.lbl_vara);
            this.Name = "Form1";
            this.Text = "3.10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vara;
        private System.Windows.Forms.Label lbl_pris;
        private System.Windows.Forms.TextBox tbx_vara;
        private System.Windows.Forms.TextBox tbx_pris;
        private System.Windows.Forms.Button btn_add;
    }
}


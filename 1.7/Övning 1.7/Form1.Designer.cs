namespace Övning_1._7
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
            this.lbl_add = new System.Windows.Forms.Label();
            this.tbx_epos = new System.Windows.Forms.TextBox();
            this.lbl_los = new System.Windows.Forms.Label();
            this.tbx_los = new System.Windows.Forms.TextBox();
            this.btn_skapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Location = new System.Drawing.Point(18, 41);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(68, 13);
            this.lbl_add.TabIndex = 0;
            this.lbl_add.Text = "E-postadress";
            // 
            // tbx_epos
            // 
            this.tbx_epos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_epos.Location = new System.Drawing.Point(99, 33);
            this.tbx_epos.Name = "tbx_epos";
            this.tbx_epos.Size = new System.Drawing.Size(195, 26);
            this.tbx_epos.TabIndex = 1;
            // 
            // lbl_los
            // 
            this.lbl_los.AutoSize = true;
            this.lbl_los.Location = new System.Drawing.Point(32, 82);
            this.lbl_los.Name = "lbl_los";
            this.lbl_los.Size = new System.Drawing.Size(51, 13);
            this.lbl_los.TabIndex = 2;
            this.lbl_los.Text = "Lösenord";
            // 
            // tbx_los
            // 
            this.tbx_los.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_los.Location = new System.Drawing.Point(99, 74);
            this.tbx_los.Name = "tbx_los";
            this.tbx_los.Size = new System.Drawing.Size(195, 26);
            this.tbx_los.TabIndex = 3;
            // 
            // btn_skapa
            // 
            this.btn_skapa.Location = new System.Drawing.Point(229, 129);
            this.btn_skapa.Name = "btn_skapa";
            this.btn_skapa.Size = new System.Drawing.Size(75, 23);
            this.btn_skapa.TabIndex = 4;
            this.btn_skapa.Text = "Skapa";
            this.btn_skapa.UseVisualStyleBackColor = true;
            this.btn_skapa.Click += new System.EventHandler(this.btn_skapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 164);
            this.Controls.Add(this.btn_skapa);
            this.Controls.Add(this.tbx_los);
            this.Controls.Add(this.lbl_los);
            this.Controls.Add(this.tbx_epos);
            this.Controls.Add(this.lbl_add);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.TextBox tbx_epos;
        private System.Windows.Forms.Label lbl_los;
        private System.Windows.Forms.TextBox tbx_los;
        private System.Windows.Forms.Button btn_skapa;
    }
}


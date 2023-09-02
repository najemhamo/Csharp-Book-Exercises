namespace Övning_5._2_server
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
            this.btn_starta = new System.Windows.Forms.Button();
            this.tbx_medelande = new System.Windows.Forms.TextBox();
            this.btn_ta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_starta
            // 
            this.btn_starta.Location = new System.Drawing.Point(247, 26);
            this.btn_starta.Name = "btn_starta";
            this.btn_starta.Size = new System.Drawing.Size(123, 23);
            this.btn_starta.TabIndex = 0;
            this.btn_starta.Text = "Starta server";
            this.btn_starta.UseVisualStyleBackColor = true;
            this.btn_starta.Click += new System.EventHandler(this.btn_starta_Click);
            // 
            // tbx_medelande
            // 
            this.tbx_medelande.Enabled = false;
            this.tbx_medelande.Location = new System.Drawing.Point(27, 84);
            this.tbx_medelande.Multiline = true;
            this.tbx_medelande.Name = "tbx_medelande";
            this.tbx_medelande.Size = new System.Drawing.Size(343, 159);
            this.tbx_medelande.TabIndex = 1;
            // 
            // btn_ta
            // 
            this.btn_ta.Enabled = false;
            this.btn_ta.Location = new System.Drawing.Point(27, 256);
            this.btn_ta.Name = "btn_ta";
            this.btn_ta.Size = new System.Drawing.Size(343, 23);
            this.btn_ta.TabIndex = 2;
            this.btn_ta.Text = "Ta emot ett meddelande";
            this.btn_ta.UseVisualStyleBackColor = true;
            this.btn_ta.Click += new System.EventHandler(this.btn_ta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 291);
            this.Controls.Add(this.btn_ta);
            this.Controls.Add(this.tbx_medelande);
            this.Controls.Add(this.btn_starta);
            this.Name = "Form1";
            this.Text = "Server 5.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_starta;
        private System.Windows.Forms.TextBox tbx_medelande;
        private System.Windows.Forms.Button btn_ta;
    }
}


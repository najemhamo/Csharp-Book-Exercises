namespace Övning_5._3_klient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.btn_anslut = new System.Windows.Forms.Button();
            this.tbx_medelande = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(192, 41);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(130, 20);
            this.tbx_ip.TabIndex = 1;
            // 
            // btn_anslut
            // 
            this.btn_anslut.Location = new System.Drawing.Point(192, 80);
            this.btn_anslut.Name = "btn_anslut";
            this.btn_anslut.Size = new System.Drawing.Size(130, 23);
            this.btn_anslut.TabIndex = 2;
            this.btn_anslut.Text = "Anslut";
            this.btn_anslut.UseVisualStyleBackColor = true;
            this.btn_anslut.Click += new System.EventHandler(this.btn_anslut_Click);
            // 
            // tbx_medelande
            // 
            this.tbx_medelande.Location = new System.Drawing.Point(32, 138);
            this.tbx_medelande.Multiline = true;
            this.tbx_medelande.Name = "tbx_medelande";
            this.tbx_medelande.Size = new System.Drawing.Size(290, 150);
            this.tbx_medelande.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(32, 300);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(290, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Skicka";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 335);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tbx_medelande);
            this.Controls.Add(this.btn_anslut);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Klient  5.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Button btn_anslut;
        private System.Windows.Forms.TextBox tbx_medelande;
        private System.Windows.Forms.Button btn_send;
    }
}


namespace Övning_5._1
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
            this.lbl_ip = new System.Windows.Forms.Label();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.tbx_medelande = new System.Windows.Forms.TextBox();
            this.btn_skicka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(23, 22);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(96, 13);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "Serverns IP-adress";
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(239, 19);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(154, 20);
            this.tbx_ip.TabIndex = 1;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(23, 70);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(113, 13);
            this.lbl_port.TabIndex = 2;
            this.lbl_port.Text = "Servernsa portnummer";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(239, 67);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(154, 20);
            this.tbx_port.TabIndex = 3;
            // 
            // tbx_medelande
            // 
            this.tbx_medelande.Location = new System.Drawing.Point(12, 107);
            this.tbx_medelande.Multiline = true;
            this.tbx_medelande.Name = "tbx_medelande";
            this.tbx_medelande.Size = new System.Drawing.Size(381, 140);
            this.tbx_medelande.TabIndex = 4;
            // 
            // btn_skicka
            // 
            this.btn_skicka.Location = new System.Drawing.Point(12, 267);
            this.btn_skicka.Name = "btn_skicka";
            this.btn_skicka.Size = new System.Drawing.Size(381, 23);
            this.btn_skicka.TabIndex = 5;
            this.btn_skicka.Text = "skicka";
            this.btn_skicka.UseVisualStyleBackColor = true;
            this.btn_skicka.Click += new System.EventHandler(this.btn_skicka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 313);
            this.Controls.Add(this.btn_skicka);
            this.Controls.Add(this.tbx_medelande);
            this.Controls.Add(this.tbx_port);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.lbl_ip);
            this.Name = "Form1";
            this.Text = "UDB Klient 5.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.TextBox tbx_medelande;
        private System.Windows.Forms.Button btn_skicka;
    }
}


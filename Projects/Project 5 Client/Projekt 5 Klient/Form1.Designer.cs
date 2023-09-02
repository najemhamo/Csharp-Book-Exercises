namespace Projekt_5_Klient
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
            this.tbx_IP = new System.Windows.Forms.TextBox();
            this.btn_anslut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_chat = new System.Windows.Forms.TextBox();
            this.tbx_medelande = new System.Windows.Forms.TextBox();
            this.btn_skicka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Användare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // tbx_IP
            // 
            this.tbx_IP.Location = new System.Drawing.Point(149, 24);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.Size = new System.Drawing.Size(143, 20);
            this.tbx_IP.TabIndex = 1;
            // 
            // btn_anslut
            // 
            this.btn_anslut.Location = new System.Drawing.Point(323, 69);
            this.btn_anslut.Name = "btn_anslut";
            this.btn_anslut.Size = new System.Drawing.Size(75, 23);
            this.btn_anslut.TabIndex = 2;
            this.btn_anslut.Text = "Anslut";
            this.btn_anslut.UseVisualStyleBackColor = true;
            this.btn_anslut.Click += new System.EventHandler(this.btn_anslut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chatrum";
            // 
            // tbx_chat
            // 
            this.tbx_chat.Enabled = false;
            this.tbx_chat.Location = new System.Drawing.Point(16, 171);
            this.tbx_chat.Multiline = true;
            this.tbx_chat.Name = "tbx_chat";
            this.tbx_chat.ReadOnly = true;
            this.tbx_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_chat.Size = new System.Drawing.Size(382, 247);
            this.tbx_chat.TabIndex = 4;
            // 
            // tbx_medelande
            // 
            this.tbx_medelande.Enabled = false;
            this.tbx_medelande.Location = new System.Drawing.Point(16, 448);
            this.tbx_medelande.Name = "tbx_medelande";
            this.tbx_medelande.Size = new System.Drawing.Size(382, 20);
            this.tbx_medelande.TabIndex = 5;
            // 
            // btn_skicka
            // 
            this.btn_skicka.Enabled = false;
            this.btn_skicka.Location = new System.Drawing.Point(12, 474);
            this.btn_skicka.Name = "btn_skicka";
            this.btn_skicka.Size = new System.Drawing.Size(386, 23);
            this.btn_skicka.TabIndex = 6;
            this.btn_skicka.Text = "Skicka";
            this.btn_skicka.UseVisualStyleBackColor = true;
            this.btn_skicka.Click += new System.EventHandler(this.btn_skicka_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Användare namn";
            // 
            // tbx_Användare
            // 
            this.tbx_Användare.Location = new System.Drawing.Point(149, 71);
            this.tbx_Användare.Name = "tbx_Användare";
            this.tbx_Användare.Size = new System.Drawing.Size(143, 20);
            this.tbx_Användare.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 511);
            this.Controls.Add(this.tbx_Användare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_skicka);
            this.Controls.Add(this.tbx_medelande);
            this.Controls.Add(this.tbx_chat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_anslut);
            this.Controls.Add(this.tbx_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_IP;
        private System.Windows.Forms.Button btn_anslut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_chat;
        private System.Windows.Forms.TextBox tbx_medelande;
        private System.Windows.Forms.Button btn_skicka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Användare;
    }
}


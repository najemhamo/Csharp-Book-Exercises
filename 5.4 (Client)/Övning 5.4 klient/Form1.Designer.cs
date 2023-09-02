namespace Övning_5._4_klient
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
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_höger = new System.Windows.Forms.Button();
            this.btn_vänster = new System.Windows.Forms.Button();
            this.btn_ner = new System.Windows.Forms.Button();
            this.btn_anslut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // tbx_IP
            // 
            this.tbx_IP.Location = new System.Drawing.Point(125, 41);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.Size = new System.Drawing.Size(138, 20);
            this.tbx_IP.TabIndex = 1;
            // 
            // btn_up
            // 
            this.btn_up.Enabled = false;
            this.btn_up.Location = new System.Drawing.Point(153, 122);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 2;
            this.btn_up.Text = "UPP";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_höger
            // 
            this.btn_höger.Enabled = false;
            this.btn_höger.Location = new System.Drawing.Point(256, 199);
            this.btn_höger.Name = "btn_höger";
            this.btn_höger.Size = new System.Drawing.Size(75, 23);
            this.btn_höger.TabIndex = 3;
            this.btn_höger.Text = "HÖGER";
            this.btn_höger.UseVisualStyleBackColor = true;
            this.btn_höger.Click += new System.EventHandler(this.btn_höger_Click);
            // 
            // btn_vänster
            // 
            this.btn_vänster.Enabled = false;
            this.btn_vänster.Location = new System.Drawing.Point(48, 199);
            this.btn_vänster.Name = "btn_vänster";
            this.btn_vänster.Size = new System.Drawing.Size(75, 23);
            this.btn_vänster.TabIndex = 4;
            this.btn_vänster.Text = "VÄNSTER";
            this.btn_vänster.UseVisualStyleBackColor = true;
            this.btn_vänster.Click += new System.EventHandler(this.btn_vänster_Click);
            // 
            // btn_ner
            // 
            this.btn_ner.Enabled = false;
            this.btn_ner.Location = new System.Drawing.Point(153, 263);
            this.btn_ner.Name = "btn_ner";
            this.btn_ner.Size = new System.Drawing.Size(75, 23);
            this.btn_ner.TabIndex = 5;
            this.btn_ner.Text = "NER";
            this.btn_ner.UseVisualStyleBackColor = true;
            this.btn_ner.Click += new System.EventHandler(this.btn_ner_Click);
            // 
            // btn_anslut
            // 
            this.btn_anslut.Location = new System.Drawing.Point(289, 39);
            this.btn_anslut.Name = "btn_anslut";
            this.btn_anslut.Size = new System.Drawing.Size(75, 23);
            this.btn_anslut.TabIndex = 6;
            this.btn_anslut.Text = "Anslut";
            this.btn_anslut.UseVisualStyleBackColor = true;
            this.btn_anslut.Click += new System.EventHandler(this.btn_anslut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 309);
            this.Controls.Add(this.btn_anslut);
            this.Controls.Add(this.btn_ner);
            this.Controls.Add(this.btn_vänster);
            this.Controls.Add(this.btn_höger);
            this.Controls.Add(this.btn_up);
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
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_höger;
        private System.Windows.Forms.Button btn_vänster;
        private System.Windows.Forms.Button btn_ner;
        private System.Windows.Forms.Button btn_anslut;
    }
}


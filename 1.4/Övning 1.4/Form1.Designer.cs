namespace Övning_1._4
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
            this.tbxText = new System.Windows.Forms.TextBox();
            this.tbx_size = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lbl_tecken = new System.Windows.Forms.Label();
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.cbxKursiv = new System.Windows.Forms.CheckBox();
            this.cbxUnder = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbTecken = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxText
            // 
            this.tbxText.BackColor = System.Drawing.SystemColors.Control;
            this.tbxText.Location = new System.Drawing.Point(13, 13);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.ReadOnly = true;
            this.tbxText.Size = new System.Drawing.Size(381, 204);
            this.tbxText.TabIndex = 0;
            this.tbxText.Text = "Sjung O Gudinna om vreden \nSom brann hos Peliden Akilles \nOlycksdiger till tusend" +
    "e kval \nFör Akajernas söner";
            // 
            // tbx_size
            // 
            this.tbx_size.Location = new System.Drawing.Point(522, 45);
            this.tbx_size.Name = "tbx_size";
            this.tbx_size.Size = new System.Drawing.Size(61, 20);
            this.tbx_size.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(531, 22);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Storlek";
            // 
            // lbl_tecken
            // 
            this.lbl_tecken.AutoSize = true;
            this.lbl_tecken.Location = new System.Drawing.Point(471, 121);
            this.lbl_tecken.Name = "lbl_tecken";
            this.lbl_tecken.Size = new System.Drawing.Size(63, 13);
            this.lbl_tecken.TabIndex = 3;
            this.lbl_tecken.Text = "Teckensnitt";
            // 
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFet.Location = new System.Drawing.Point(416, 18);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(44, 17);
            this.cbxFet.TabIndex = 5;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            // 
            // cbxKursiv
            // 
            this.cbxKursiv.AutoSize = true;
            this.cbxKursiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKursiv.Location = new System.Drawing.Point(416, 48);
            this.cbxKursiv.Name = "cbxKursiv";
            this.cbxKursiv.Size = new System.Drawing.Size(55, 17);
            this.cbxKursiv.TabIndex = 6;
            this.cbxKursiv.Text = "Kursiv";
            this.cbxKursiv.UseVisualStyleBackColor = true;
            // 
            // cbxUnder
            // 
            this.cbxUnder.AutoSize = true;
            this.cbxUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnder.Location = new System.Drawing.Point(413, 76);
            this.cbxUnder.Name = "cbxUnder";
            this.cbxUnder.Size = new System.Drawing.Size(77, 17);
            this.cbxUnder.TabIndex = 7;
            this.cbxUnder.Text = "Understryk";
            this.cbxUnder.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(474, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbTecken
            // 
            this.cbTecken.FormattingEnabled = true;
            this.cbTecken.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbTecken.Location = new System.Drawing.Point(413, 137);
            this.cbTecken.Name = "cbTecken";
            this.cbTecken.Size = new System.Drawing.Size(190, 21);
            this.cbTecken.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 233);
            this.Controls.Add(this.cbTecken);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxUnder);
            this.Controls.Add(this.cbxKursiv);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.lbl_tecken);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.tbx_size);
            this.Controls.Add(this.tbxText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.TextBox tbx_size;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lbl_tecken;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.CheckBox cbxKursiv;
        private System.Windows.Forms.CheckBox cbxUnder;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbTecken;
    }
}


namespace Övning_5._1_Server
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
            this.lbl_port = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.tbx_medelande = new System.Windows.Forms.TextBox();
            this.btn_ta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(26, 36);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(107, 13);
            this.lbl_port.TabIndex = 0;
            this.lbl_port.Text = "Serverns portnummer";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(192, 33);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(117, 20);
            this.tbx_port.TabIndex = 1;
            // 
            // tbx_medelande
            // 
            this.tbx_medelande.Location = new System.Drawing.Point(29, 108);
            this.tbx_medelande.Multiline = true;
            this.tbx_medelande.Name = "tbx_medelande";
            this.tbx_medelande.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_medelande.Size = new System.Drawing.Size(280, 150);
            this.tbx_medelande.TabIndex = 2;
            // 
            // btn_ta
            // 
            this.btn_ta.Location = new System.Drawing.Point(29, 272);
            this.btn_ta.Name = "btn_ta";
            this.btn_ta.Size = new System.Drawing.Size(280, 23);
            this.btn_ta.TabIndex = 3;
            this.btn_ta.Text = "Tag emot";
            this.btn_ta.UseVisualStyleBackColor = true;
            this.btn_ta.Click += new System.EventHandler(this.btn_ta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 307);
            this.Controls.Add(this.btn_ta);
            this.Controls.Add(this.tbx_medelande);
            this.Controls.Add(this.tbx_port);
            this.Controls.Add(this.lbl_port);
            this.Name = "Form1";
            this.Text = "UDB server  5.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.TextBox tbx_medelande;
        private System.Windows.Forms.Button btn_ta;
    }
}


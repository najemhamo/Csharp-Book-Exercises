namespace Övning_5._3_server
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
            this.tbx_medelanden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_medelanden
            // 
            this.tbx_medelanden.Location = new System.Drawing.Point(13, 41);
            this.tbx_medelanden.Multiline = true;
            this.tbx_medelanden.Name = "tbx_medelanden";
            this.tbx_medelanden.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_medelanden.Size = new System.Drawing.Size(330, 220);
            this.tbx_medelanden.TabIndex = 0;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 288);
            this.Controls.Add(this.tbx_medelanden);
            this.Name = "Form1";
            this.Text = "Server 5.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_medelanden;
    }
}


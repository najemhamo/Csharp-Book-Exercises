namespace Övning_5._4_Server
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
            this.pbx_flygplan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_flygplan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_flygplan
            // 
            this.pbx_flygplan.Image = global::Övning_5._4_Server.Properties.Resources.Flygplan;
            this.pbx_flygplan.Location = new System.Drawing.Point(123, 103);
            this.pbx_flygplan.Name = "pbx_flygplan";
            this.pbx_flygplan.Size = new System.Drawing.Size(110, 126);
            this.pbx_flygplan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_flygplan.TabIndex = 0;
            this.pbx_flygplan.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 324);
            this.Controls.Add(this.pbx_flygplan);
            this.Name = "Form1";
            this.Text = "Server 5.4";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_flygplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_flygplan;
    }
}


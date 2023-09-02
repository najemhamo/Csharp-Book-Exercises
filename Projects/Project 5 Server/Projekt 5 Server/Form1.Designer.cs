namespace Projekt_5_Server
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
            this.lbx_chat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbx_chat
            // 
            this.lbx_chat.FormattingEnabled = true;
            this.lbx_chat.Location = new System.Drawing.Point(13, 13);
            this.lbx_chat.Name = "lbx_chat";
            this.lbx_chat.Size = new System.Drawing.Size(259, 225);
            this.lbx_chat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbx_chat);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_chat;
    }
}


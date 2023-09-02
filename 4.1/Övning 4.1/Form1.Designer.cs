namespace Övning_4._1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.dlgÖppna = new System.Windows.Forms.OpenFileDialog();
            this.dlgSpara = new System.Windows.Forms.SaveFileDialog();
            this.tbx_oldWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_newWord = new System.Windows.Forms.TextBox();
            this.btnErsätt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.stängToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Enabled = false;
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // rtb_text
            // 
            this.rtb_text.Location = new System.Drawing.Point(13, 89);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(563, 294);
            this.rtb_text.TabIndex = 1;
            this.rtb_text.Text = "";
            // 
            // dlgÖppna
            // 
            this.dlgÖppna.FileName = "Text";
            // 
            // tbx_oldWord
            // 
            this.tbx_oldWord.Location = new System.Drawing.Point(164, 53);
            this.tbx_oldWord.Name = "tbx_oldWord";
            this.tbx_oldWord.Size = new System.Drawing.Size(100, 20);
            this.tbx_oldWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "---->";
            // 
            // tbx_newWord
            // 
            this.tbx_newWord.Location = new System.Drawing.Point(347, 53);
            this.tbx_newWord.Name = "tbx_newWord";
            this.tbx_newWord.Size = new System.Drawing.Size(100, 20);
            this.tbx_newWord.TabIndex = 4;
            // 
            // btnErsätt
            // 
            this.btnErsätt.Location = new System.Drawing.Point(482, 50);
            this.btnErsätt.Name = "btnErsätt";
            this.btnErsätt.Size = new System.Drawing.Size(75, 23);
            this.btnErsätt.TabIndex = 5;
            this.btnErsätt.Text = "Ersätt";
            this.btnErsätt.UseVisualStyleBackColor = true;
            this.btnErsätt.Click += new System.EventHandler(this.btnErsätt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 395);
            this.Controls.Add(this.btnErsätt);
            this.Controls.Add(this.tbx_newWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_oldWord);
            this.Controls.Add(this.rtb_text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextFiler 4.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.OpenFileDialog dlgÖppna;
        private System.Windows.Forms.SaveFileDialog dlgSpara;
        private System.Windows.Forms.TextBox tbx_oldWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_newWord;
        private System.Windows.Forms.Button btnErsätt;
    }
}


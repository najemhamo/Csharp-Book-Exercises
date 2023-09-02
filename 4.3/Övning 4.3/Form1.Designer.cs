namespace Övning_4._3
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
            this.dlg_open = new System.Windows.Forms.OpenFileDialog();
            this.msp_menu = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_förnamn = new System.Windows.Forms.TextBox();
            this.tbx_efternamn = new System.Windows.Forms.TextBox();
            this.tbx_epost = new System.Windows.Forms.TextBox();
            this.tbx_telefon = new System.Windows.Forms.TextBox();
            this.ltb_kontakter = new System.Windows.Forms.ListBox();
            this.dlg_spara = new System.Windows.Forms.SaveFileDialog();
            this.msp_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlg_open
            // 
            this.dlg_open.FileName = "Kontakter";
            // 
            // msp_menu
            // 
            this.msp_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.redigeraToolStripMenuItem});
            this.msp_menu.Location = new System.Drawing.Point(0, 0);
            this.msp_menu.Name = "msp_menu";
            this.msp_menu.Size = new System.Drawing.Size(495, 24);
            this.msp_menu.TabIndex = 0;
            this.msp_menu.Text = "menu";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Enabled = false;
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // läggTillToolStripMenuItem
            // 
            this.läggTillToolStripMenuItem.Name = "läggTillToolStripMenuItem";
            this.läggTillToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.läggTillToolStripMenuItem.Text = "Lägg till";
            this.läggTillToolStripMenuItem.Click += new System.EventHandler(this.läggTillToolStripMenuItem_Click);
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            this.taBortToolStripMenuItem.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefonnummer";
            // 
            // tbx_förnamn
            // 
            this.tbx_förnamn.Location = new System.Drawing.Point(134, 52);
            this.tbx_förnamn.Name = "tbx_förnamn";
            this.tbx_förnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_förnamn.TabIndex = 5;
            // 
            // tbx_efternamn
            // 
            this.tbx_efternamn.Location = new System.Drawing.Point(134, 95);
            this.tbx_efternamn.Name = "tbx_efternamn";
            this.tbx_efternamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_efternamn.TabIndex = 6;
            // 
            // tbx_epost
            // 
            this.tbx_epost.Location = new System.Drawing.Point(134, 138);
            this.tbx_epost.Name = "tbx_epost";
            this.tbx_epost.Size = new System.Drawing.Size(100, 20);
            this.tbx_epost.TabIndex = 7;
            // 
            // tbx_telefon
            // 
            this.tbx_telefon.Location = new System.Drawing.Point(134, 178);
            this.tbx_telefon.Name = "tbx_telefon";
            this.tbx_telefon.Size = new System.Drawing.Size(100, 20);
            this.tbx_telefon.TabIndex = 8;
            // 
            // ltb_kontakter
            // 
            this.ltb_kontakter.FormattingEnabled = true;
            this.ltb_kontakter.Location = new System.Drawing.Point(302, 52);
            this.ltb_kontakter.Name = "ltb_kontakter";
            this.ltb_kontakter.Size = new System.Drawing.Size(181, 147);
            this.ltb_kontakter.TabIndex = 9;
            this.ltb_kontakter.SelectedIndexChanged += new System.EventHandler(this.ltb_kontakter_SelectedIndexChanged);
            // 
            // dlg_spara
            // 
            this.dlg_spara.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 241);
            this.Controls.Add(this.ltb_kontakter);
            this.Controls.Add(this.tbx_telefon);
            this.Controls.Add(this.tbx_epost);
            this.Controls.Add(this.tbx_efternamn);
            this.Controls.Add(this.tbx_förnamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msp_menu);
            this.MainMenuStrip = this.msp_menu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "En kontakt 4.3";
            this.msp_menu.ResumeLayout(false);
            this.msp_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_menu;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_förnamn;
        private System.Windows.Forms.TextBox tbx_efternamn;
        private System.Windows.Forms.TextBox tbx_epost;
        private System.Windows.Forms.TextBox tbx_telefon;
        private System.Windows.Forms.ListBox ltb_kontakter;
        private System.Windows.Forms.SaveFileDialog dlg_spara;
        private System.Windows.Forms.OpenFileDialog dlg_open;
    }
}


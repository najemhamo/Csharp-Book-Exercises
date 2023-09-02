namespace Övning_3._1
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
            this.components = new System.ComponentModel.Container();
            this.btn_farg = new System.Windows.Forms.Button();
            this.cmp_btnFarg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bytaTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baklängestextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_fil = new System.Windows.Forms.Button();
            this.cmp_btnFil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bytaFärgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bytaTeckensnittToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baklängsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tecken = new System.Windows.Forms.Button();
            this.cmp_btnTecken = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bytaFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baklängstextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFile = new System.Windows.Forms.FolderBrowserDialog();
            this.dlg_font = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.cmp_btnFarg.SuspendLayout();
            this.cmp_btnFil.SuspendLayout();
            this.cmp_btnTecken.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_farg
            // 
            this.btn_farg.ContextMenuStrip = this.cmp_btnFarg;
            this.btn_farg.Location = new System.Drawing.Point(36, 51);
            this.btn_farg.Name = "btn_farg";
            this.btn_farg.Size = new System.Drawing.Size(221, 36);
            this.btn_farg.TabIndex = 0;
            this.btn_farg.Text = "Välj en färg";
            this.ttp.SetToolTip(this.btn_farg, "Ändra knappens färg");
            this.btn_farg.UseVisualStyleBackColor = true;
            this.btn_farg.Click += new System.EventHandler(this.btn_farg_Click);
            this.btn_farg.MouseEnter += new System.EventHandler(this.btn_farg_MouseEnter);
            // 
            // cmp_btnFarg
            // 
            this.cmp_btnFarg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bytaTeckensnittToolStripMenuItem,
            this.baklängestextToolStripMenuItem,
            this.taBortToolStripMenuItem});
            this.cmp_btnFarg.Name = "cmp_btnFarg";
            this.cmp_btnFarg.Size = new System.Drawing.Size(159, 70);
            // 
            // bytaTeckensnittToolStripMenuItem
            // 
            this.bytaTeckensnittToolStripMenuItem.Name = "bytaTeckensnittToolStripMenuItem";
            this.bytaTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bytaTeckensnittToolStripMenuItem.Text = "Byta teckensnitt";
            this.bytaTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.btn_tecken_Click);
            // 
            // baklängestextToolStripMenuItem
            // 
            this.baklängestextToolStripMenuItem.Name = "baklängestextToolStripMenuItem";
            this.baklängestextToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.baklängestextToolStripMenuItem.Text = "Baklängestext";
            this.baklängestextToolStripMenuItem.Click += new System.EventHandler(this.baklängestextToolStripMenuItem_Click);
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            this.taBortToolStripMenuItem.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // btn_fil
            // 
            this.btn_fil.ContextMenuStrip = this.cmp_btnFil;
            this.btn_fil.Location = new System.Drawing.Point(36, 121);
            this.btn_fil.Name = "btn_fil";
            this.btn_fil.Size = new System.Drawing.Size(221, 34);
            this.btn_fil.TabIndex = 1;
            this.btn_fil.Text = "Välj en fil";
            this.ttp.SetToolTip(this.btn_fil, "Öppna browser och välja en fil.");
            this.btn_fil.UseVisualStyleBackColor = true;
            this.btn_fil.Click += new System.EventHandler(this.btn_fil_Click);
            this.btn_fil.MouseEnter += new System.EventHandler(this.btn_farg_MouseEnter);
            // 
            // cmp_btnFil
            // 
            this.cmp_btnFil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bytaFärgenToolStripMenuItem,
            this.bytaTeckensnittToolStripMenuItem1,
            this.baklängsToolStripMenuItem,
            this.taBortToolStripMenuItem1});
            this.cmp_btnFil.Name = "cmp_btnFil";
            this.cmp_btnFil.Size = new System.Drawing.Size(159, 92);
            // 
            // bytaFärgenToolStripMenuItem
            // 
            this.bytaFärgenToolStripMenuItem.Name = "bytaFärgenToolStripMenuItem";
            this.bytaFärgenToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bytaFärgenToolStripMenuItem.Text = "Byta färgen";
            this.bytaFärgenToolStripMenuItem.Click += new System.EventHandler(this.btn_farg_Click);
            // 
            // bytaTeckensnittToolStripMenuItem1
            // 
            this.bytaTeckensnittToolStripMenuItem1.Name = "bytaTeckensnittToolStripMenuItem1";
            this.bytaTeckensnittToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.bytaTeckensnittToolStripMenuItem1.Text = "Byta teckensnitt";
            this.bytaTeckensnittToolStripMenuItem1.Click += new System.EventHandler(this.btn_tecken_Click);
            // 
            // baklängsToolStripMenuItem
            // 
            this.baklängsToolStripMenuItem.Name = "baklängsToolStripMenuItem";
            this.baklängsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.baklängsToolStripMenuItem.Text = "Baklängstext";
            this.baklängsToolStripMenuItem.Click += new System.EventHandler(this.baklängestextToolStripMenuItem_Click);
            // 
            // taBortToolStripMenuItem1
            // 
            this.taBortToolStripMenuItem1.Name = "taBortToolStripMenuItem1";
            this.taBortToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.taBortToolStripMenuItem1.Text = "Ta bort";
            this.taBortToolStripMenuItem1.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // btn_tecken
            // 
            this.btn_tecken.ContextMenuStrip = this.cmp_btnTecken;
            this.btn_tecken.Location = new System.Drawing.Point(36, 191);
            this.btn_tecken.Name = "btn_tecken";
            this.btn_tecken.Size = new System.Drawing.Size(221, 34);
            this.btn_tecken.TabIndex = 2;
            this.btn_tecken.Text = "Välj teckensnitt";
            this.ttp.SetToolTip(this.btn_tecken, "Ändra knappens teckensnitt");
            this.btn_tecken.UseVisualStyleBackColor = true;
            this.btn_tecken.Click += new System.EventHandler(this.btn_tecken_Click);
            this.btn_tecken.MouseHover += new System.EventHandler(this.btn_farg_MouseEnter);
            // 
            // cmp_btnTecken
            // 
            this.cmp_btnTecken.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bytaFärgToolStripMenuItem,
            this.baklängstextToolStripMenuItem,
            this.taBortToolStripMenuItem2});
            this.cmp_btnTecken.Name = "cmp_btnTecken";
            this.cmp_btnTecken.Size = new System.Drawing.Size(142, 70);
            // 
            // bytaFärgToolStripMenuItem
            // 
            this.bytaFärgToolStripMenuItem.Name = "bytaFärgToolStripMenuItem";
            this.bytaFärgToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bytaFärgToolStripMenuItem.Text = "Byta färg";
            this.bytaFärgToolStripMenuItem.Click += new System.EventHandler(this.btn_farg_Click);
            // 
            // baklängstextToolStripMenuItem
            // 
            this.baklängstextToolStripMenuItem.Name = "baklängstextToolStripMenuItem";
            this.baklängstextToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.baklängstextToolStripMenuItem.Text = "Baklängstext";
            this.baklängstextToolStripMenuItem.Click += new System.EventHandler(this.baklängestextToolStripMenuItem_Click);
            // 
            // taBortToolStripMenuItem2
            // 
            this.taBortToolStripMenuItem2.Name = "taBortToolStripMenuItem2";
            this.taBortToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.taBortToolStripMenuItem2.Text = "Ta bort";
            this.taBortToolStripMenuItem2.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redigeraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem,
            this.väljMappToolStripMenuItem,
            this.väljTeckensnittToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // väljFärgToolStripMenuItem
            // 
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljFärgToolStripMenuItem.Text = "Välj färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.btn_farg_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.btn_fil_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.btn_tecken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.btn_tecken);
            this.Controls.Add(this.btn_fil);
            this.Controls.Add(this.btn_farg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3.1";
            this.cmp_btnFarg.ResumeLayout(false);
            this.cmp_btnFil.ResumeLayout(false);
            this.cmp_btnTecken.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_farg;
        private System.Windows.Forms.Button btn_fil;
        private System.Windows.Forms.Button btn_tecken;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FolderBrowserDialog dlgFile;
        private System.Windows.Forms.FontDialog dlg_font;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljMappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmp_btnFarg;
        private System.Windows.Forms.ToolStripMenuItem bytaTeckensnittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baklängestextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmp_btnFil;
        private System.Windows.Forms.ToolStripMenuItem bytaFärgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bytaTeckensnittToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem baklängsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmp_btnTecken;
        private System.Windows.Forms.ToolStripMenuItem bytaFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baklängstextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem2;
        private System.Windows.Forms.ToolTip ttp;
    }
}


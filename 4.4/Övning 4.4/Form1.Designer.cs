namespace Övning_4._4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ingrediens = new System.Windows.Forms.TextBox();
            this.tbx_mängd = new System.Windows.Forms.TextBox();
            this.tbx_mått = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_listan = new System.Windows.Forms.DataGridView();
            this.col_ingrediens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mängd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mått = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mns_menu = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_open = new System.Windows.Forms.OpenFileDialog();
            this.dlg_spara = new System.Windows.Forms.SaveFileDialog();
            this.btn_tabort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listan)).BeginInit();
            this.mns_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrediens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mängd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mått";
            // 
            // tbx_ingrediens
            // 
            this.tbx_ingrediens.Location = new System.Drawing.Point(122, 48);
            this.tbx_ingrediens.Name = "tbx_ingrediens";
            this.tbx_ingrediens.Size = new System.Drawing.Size(100, 20);
            this.tbx_ingrediens.TabIndex = 3;
            // 
            // tbx_mängd
            // 
            this.tbx_mängd.Location = new System.Drawing.Point(122, 95);
            this.tbx_mängd.Name = "tbx_mängd";
            this.tbx_mängd.Size = new System.Drawing.Size(100, 20);
            this.tbx_mängd.TabIndex = 4;
            // 
            // tbx_mått
            // 
            this.tbx_mått.Location = new System.Drawing.Point(122, 146);
            this.tbx_mått.Name = "tbx_mått";
            this.tbx_mått.Size = new System.Drawing.Size(100, 20);
            this.tbx_mått.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(319, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Lägg till";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_listan
            // 
            this.dgv_listan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ingrediens,
            this.col_mängd,
            this.col_mått});
            this.dgv_listan.Location = new System.Drawing.Point(12, 205);
            this.dgv_listan.Name = "dgv_listan";
            this.dgv_listan.RowHeadersVisible = false;
            this.dgv_listan.Size = new System.Drawing.Size(382, 240);
            this.dgv_listan.TabIndex = 7;
          
            // 
            // col_ingrediens
            // 
            this.col_ingrediens.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ingrediens.HeaderText = "Ingrediens";
            this.col_ingrediens.Name = "col_ingrediens";
            // 
            // col_mängd
            // 
            this.col_mängd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_mängd.HeaderText = "Mängd";
            this.col_mängd.Name = "col_mängd";
            // 
            // col_mått
            // 
            this.col_mått.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_mått.HeaderText = "Mått";
            this.col_mått.Name = "col_mått";
            // 
            // mns_menu
            // 
            this.mns_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.mns_menu.Location = new System.Drawing.Point(0, 0);
            this.mns_menu.Name = "mns_menu";
            this.mns_menu.Size = new System.Drawing.Size(406, 24);
            this.mns_menu.TabIndex = 8;
            this.mns_menu.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaSomToolStripMenuItem});
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
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // dlg_open
            // 
            this.dlg_open.Filter = "Recept Filer | *.rec";
            // 
            // dlg_spara
            // 
            this.dlg_spara.DefaultExt = "rec";
            this.dlg_spara.Filter = "Recept Filer | *.rec";
            // 
            // btn_tabort
            // 
            this.btn_tabort.Location = new System.Drawing.Point(319, 143);
            this.btn_tabort.Name = "btn_tabort";
            this.btn_tabort.Size = new System.Drawing.Size(75, 23);
            this.btn_tabort.TabIndex = 9;
            this.btn_tabort.Text = "Ta bort";
            this.btn_tabort.UseVisualStyleBackColor = true;
            this.btn_tabort.Click += new System.EventHandler(this.btn_tabort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 457);
            this.Controls.Add(this.btn_tabort);
            this.Controls.Add(this.dgv_listan);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_mått);
            this.Controls.Add(this.tbx_ingrediens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_mängd);
            this.Controls.Add(this.mns_menu);
            this.MainMenuStrip = this.mns_menu;
            this.Name = "Form1";
            this.Text = "Recept";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listan)).EndInit();
            this.mns_menu.ResumeLayout(false);
            this.mns_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_ingrediens;
        private System.Windows.Forms.TextBox tbx_mängd;
        private System.Windows.Forms.TextBox tbx_mått;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_listan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ingrediens;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mängd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mått;
        private System.Windows.Forms.MenuStrip mns_menu;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlg_open;
        private System.Windows.Forms.SaveFileDialog dlg_spara;
        private System.Windows.Forms.Button btn_tabort;
    }
}


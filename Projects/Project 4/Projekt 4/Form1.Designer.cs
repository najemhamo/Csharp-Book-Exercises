namespace Projekt_4
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
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.col_namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_klass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_öppna = new System.Windows.Forms.OpenFileDialog();
            this.dlg_spara = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_lista
            // 
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_namn,
            this.col_skola,
            this.col_program,
            this.col_klass});
            this.dgv_lista.Location = new System.Drawing.Point(12, 35);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(398, 312);
            this.dgv_lista.TabIndex = 0;
            // 
            // col_namn
            // 
            this.col_namn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_namn.HeaderText = "Namn";
            this.col_namn.Name = "col_namn";
            // 
            // col_skola
            // 
            this.col_skola.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_skola.HeaderText = "Skola";
            this.col_skola.Name = "col_skola";
            // 
            // col_program
            // 
            this.col_program.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_program.HeaderText = "Program";
            this.col_program.Name = "col_program";
            // 
            // col_klass
            // 
            this.col_klass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_klass.HeaderText = "Klass";
            this.col_klass.Name = "col_klass";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // dlg_öppna
            // 
            this.dlg_öppna.Filter = "Exel filer |*.csv";
            // 
            // dlg_spara
            // 
            this.dlg_spara.DefaultExt = "csv";
            this.dlg_spara.Filter = "Exel filer |*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 359);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Projekt 4";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_skola;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_program;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_klass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlg_öppna;
        private System.Windows.Forms.SaveFileDialog dlg_spara;
    }
}


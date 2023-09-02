namespace Övning_3._9
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TE17A");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TE17B");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvnLista = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_spara = new System.Windows.Forms.Button();
            this.dgvElever = new System.Windows.Forms.DataGridView();
            this.colNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKlass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElever)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvnLista);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvElever);
            this.splitContainer1.Size = new System.Drawing.Size(534, 375);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvnLista
            // 
            this.tvnLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvnLista.Location = new System.Drawing.Point(0, 0);
            this.tvnLista.Name = "tvnLista";
            treeNode3.Name = "Node0";
            treeNode3.Text = "TE17A";
            treeNode4.Name = "Node1";
            treeNode4.Text = "TE17B";
            this.tvnLista.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.tvnLista.Size = new System.Drawing.Size(178, 315);
            this.tvnLista.TabIndex = 1;
            this.tvnLista.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvnLista_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_spara);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 60);
            this.panel1.TabIndex = 0;
            // 
            // btn_spara
            // 
            this.btn_spara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_spara.Location = new System.Drawing.Point(89, 16);
            this.btn_spara.Name = "btn_spara";
            this.btn_spara.Size = new System.Drawing.Size(75, 23);
            this.btn_spara.TabIndex = 0;
            this.btn_spara.Text = "Spara";
            this.btn_spara.UseVisualStyleBackColor = true;
            this.btn_spara.Click += new System.EventHandler(this.Btn_spara_Click);
            // 
            // dgvElever
            // 
            this.dgvElever.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElever.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNamn,
            this.colKlass});
            this.dgvElever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvElever.Location = new System.Drawing.Point(0, 0);
            this.dgvElever.Name = "dgvElever";
            this.dgvElever.Size = new System.Drawing.Size(352, 375);
            this.dgvElever.TabIndex = 0;
            this.dgvElever.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElever_CellContentClick);
            // 
            // colNamn
            // 
            this.colNamn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNamn.HeaderText = "Namn";
            this.colNamn.Name = "colNamn";
            // 
            // colKlass
            // 
            this.colKlass.HeaderText = "Klass";
            this.colKlass.Name = "colKlass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 375);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 3.9";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElever)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_spara;
        private System.Windows.Forms.TreeView tvnLista;
        private System.Windows.Forms.DataGridView dgvElever;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKlass;
    }
}


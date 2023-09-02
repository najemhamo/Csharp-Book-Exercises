namespace Övning_3._7
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
            this.dvgMatcher = new System.Windows.Forms.DataGridView();
            this.colHemma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMålH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMålB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_målrikast = new System.Windows.Forms.Button();
            this.tbx_målrikast = new System.Windows.Forms.TextBox();
            this.btn_största = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_ner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgMatcher
            // 
            this.dvgMatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHemma,
            this.colBorta,
            this.colMålH,
            this.colMålB});
            this.dvgMatcher.Location = new System.Drawing.Point(12, 27);
            this.dvgMatcher.Name = "dvgMatcher";
            this.dvgMatcher.Size = new System.Drawing.Size(540, 253);
            this.dvgMatcher.TabIndex = 0;
            this.dvgMatcher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMatcher_CellClick);
            this.dvgMatcher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMatcher_CellContentClick);
            this.dvgMatcher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMatcher_CellEndEdit);
            this.dvgMatcher.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dvgMatcher_UserAddedRow);
            this.dvgMatcher.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dvgMatcher_UserDeletingRow);
            // 
            // colHemma
            // 
            this.colHemma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHemma.HeaderText = "Hemmalag";
            this.colHemma.Name = "colHemma";
            // 
            // colBorta
            // 
            this.colBorta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBorta.HeaderText = "Bortalag";
            this.colBorta.Name = "colBorta";
            // 
            // colMålH
            // 
            this.colMålH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMålH.HeaderText = "Mål (H)";
            this.colMålH.Name = "colMålH";
            // 
            // colMålB
            // 
            this.colMålB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMålB.HeaderText = "Mål (B)";
            this.colMålB.Name = "colMålB";
            // 
            // btn_målrikast
            // 
            this.btn_målrikast.Location = new System.Drawing.Point(12, 291);
            this.btn_målrikast.Name = "btn_målrikast";
            this.btn_målrikast.Size = new System.Drawing.Size(160, 29);
            this.btn_målrikast.TabIndex = 1;
            this.btn_målrikast.Text = "Målrikast";
            this.btn_målrikast.UseVisualStyleBackColor = true;
            this.btn_målrikast.Click += new System.EventHandler(this.btn_målrikast_Click);
            // 
            // tbx_målrikast
            // 
            this.tbx_målrikast.Location = new System.Drawing.Point(195, 325);
            this.tbx_målrikast.Name = "tbx_målrikast";
            this.tbx_målrikast.Size = new System.Drawing.Size(288, 20);
            this.tbx_målrikast.TabIndex = 2;
            // 
            // btn_största
            // 
            this.btn_största.Location = new System.Drawing.Point(13, 338);
            this.btn_största.Name = "btn_största";
            this.btn_största.Size = new System.Drawing.Size(159, 27);
            this.btn_största.TabIndex = 3;
            this.btn_största.Text = "Största skillnaden";
            this.btn_största.UseVisualStyleBackColor = true;
            this.btn_största.Click += new System.EventHandler(this.btn_största_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(489, 309);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(50, 23);
            this.btn_up.TabIndex = 4;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_ner
            // 
            this.btn_ner.Location = new System.Drawing.Point(489, 338);
            this.btn_ner.Name = "btn_ner";
            this.btn_ner.Size = new System.Drawing.Size(50, 23);
            this.btn_ner.TabIndex = 5;
            this.btn_ner.Text = "Ner";
            this.btn_ner.UseVisualStyleBackColor = true;
            this.btn_ner.Click += new System.EventHandler(this.btn_ner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 388);
            this.Controls.Add(this.btn_ner);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_största);
            this.Controls.Add(this.tbx_målrikast);
            this.Controls.Add(this.btn_målrikast);
            this.Controls.Add(this.dvgMatcher);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3.7";
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgMatcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHemma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMålH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMålB;
        private System.Windows.Forms.Button btn_målrikast;
        private System.Windows.Forms.TextBox tbx_målrikast;
        private System.Windows.Forms.Button btn_största;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_ner;
    }
}


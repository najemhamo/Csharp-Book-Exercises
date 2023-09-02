namespace Övning_1._2
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
            this.tbx_tab = new System.Windows.Forms.TextBox();
            this.lbl_rad = new System.Windows.Forms.Label();
            this.lbl_kolumn = new System.Windows.Forms.Label();
            this.tbx_rad = new System.Windows.Forms.TextBox();
            this.tbx_kolumn = new System.Windows.Forms.TextBox();
            this.lbl_varde = new System.Windows.Forms.Label();
            this.tbx_varde = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_tab
            // 
            this.tbx_tab.Location = new System.Drawing.Point(12, 12);
            this.tbx_tab.Multiline = true;
            this.tbx_tab.Name = "tbx_tab";
            this.tbx_tab.Size = new System.Drawing.Size(259, 216);
            this.tbx_tab.TabIndex = 0;
            // 
            // lbl_rad
            // 
            this.lbl_rad.AutoSize = true;
            this.lbl_rad.Location = new System.Drawing.Point(89, 266);
            this.lbl_rad.Name = "lbl_rad";
            this.lbl_rad.Size = new System.Drawing.Size(27, 13);
            this.lbl_rad.TabIndex = 1;
            this.lbl_rad.Text = "Rad";
            // 
            // lbl_kolumn
            // 
            this.lbl_kolumn.AutoSize = true;
            this.lbl_kolumn.Location = new System.Drawing.Point(164, 266);
            this.lbl_kolumn.Name = "lbl_kolumn";
            this.lbl_kolumn.Size = new System.Drawing.Size(42, 13);
            this.lbl_kolumn.TabIndex = 2;
            this.lbl_kolumn.Text = "Kolumn";
            // 
            // tbx_rad
            // 
            this.tbx_rad.Location = new System.Drawing.Point(80, 296);
            this.tbx_rad.Name = "tbx_rad";
            this.tbx_rad.Size = new System.Drawing.Size(52, 20);
            this.tbx_rad.TabIndex = 3;
            // 
            // tbx_kolumn
            // 
            this.tbx_kolumn.Location = new System.Drawing.Point(154, 296);
            this.tbx_kolumn.Name = "tbx_kolumn";
            this.tbx_kolumn.Size = new System.Drawing.Size(52, 20);
            this.tbx_kolumn.TabIndex = 4;
            // 
            // lbl_varde
            // 
            this.lbl_varde.AutoSize = true;
            this.lbl_varde.Location = new System.Drawing.Point(121, 358);
            this.lbl_varde.Name = "lbl_varde";
            this.lbl_varde.Size = new System.Drawing.Size(35, 13);
            this.lbl_varde.TabIndex = 5;
            this.lbl_varde.Text = "Värde";
            // 
            // tbx_varde
            // 
            this.tbx_varde.Location = new System.Drawing.Point(80, 386);
            this.tbx_varde.Name = "tbx_varde";
            this.tbx_varde.Size = new System.Drawing.Size(126, 20);
            this.tbx_varde.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_add.Location = new System.Drawing.Point(80, 443);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Ändra";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(290, 484);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbx_varde);
            this.Controls.Add(this.lbl_varde);
            this.Controls.Add(this.tbx_kolumn);
            this.Controls.Add(this.tbx_rad);
            this.Controls.Add(this.lbl_kolumn);
            this.Controls.Add(this.lbl_rad);
            this.Controls.Add(this.tbx_tab);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Övning 1.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_tab;
        private System.Windows.Forms.Label lbl_rad;
        private System.Windows.Forms.Label lbl_kolumn;
        private System.Windows.Forms.TextBox tbx_rad;
        private System.Windows.Forms.TextBox tbx_kolumn;
        private System.Windows.Forms.Label lbl_varde;
        private System.Windows.Forms.TextBox tbx_varde;
        private System.Windows.Forms.Button btn_add;
    }
}


namespace Övning_3._6
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
            this.btn_tecken = new System.Windows.Forms.Button();
            this.rdb_vänster = new System.Windows.Forms.RadioButton();
            this.rdb_center = new System.Windows.Forms.RadioButton();
            this.rdb_höger = new System.Windows.Forms.RadioButton();
            this.lbl_color = new System.Windows.Forms.Label();
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.dlg_color = new System.Windows.Forms.ColorDialog();
            this.dlg_font = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btn_tecken
            // 
            this.btn_tecken.Location = new System.Drawing.Point(510, 225);
            this.btn_tecken.Name = "btn_tecken";
            this.btn_tecken.Size = new System.Drawing.Size(105, 56);
            this.btn_tecken.TabIndex = 0;
            this.btn_tecken.Text = "Teckensnitt";
            this.btn_tecken.UseVisualStyleBackColor = true;
            this.btn_tecken.Click += new System.EventHandler(this.btn_tecken_Click);
            // 
            // rdb_vänster
            // 
            this.rdb_vänster.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdb_vänster.Location = new System.Drawing.Point(494, 12);
            this.rdb_vänster.Name = "rdb_vänster";
            this.rdb_vänster.Size = new System.Drawing.Size(27, 23);
            this.rdb_vänster.TabIndex = 1;
            this.rdb_vänster.TabStop = true;
            this.rdb_vänster.UseVisualStyleBackColor = true;
            this.rdb_vänster.CheckedChanged += new System.EventHandler(this.rdb_vänster_CheckedChanged);
            // 
            // rdb_center
            // 
            this.rdb_center.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdb_center.Location = new System.Drawing.Point(494, 51);
            this.rdb_center.Name = "rdb_center";
            this.rdb_center.Size = new System.Drawing.Size(27, 23);
            this.rdb_center.TabIndex = 2;
            this.rdb_center.TabStop = true;
            this.rdb_center.UseVisualStyleBackColor = true;
            this.rdb_center.CheckedChanged += new System.EventHandler(this.rdb_center_CheckedChanged);
            // 
            // rdb_höger
            // 
            this.rdb_höger.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdb_höger.Location = new System.Drawing.Point(494, 90);
            this.rdb_höger.Name = "rdb_höger";
            this.rdb_höger.Size = new System.Drawing.Size(27, 23);
            this.rdb_höger.TabIndex = 3;
            this.rdb_höger.TabStop = true;
            this.rdb_höger.UseVisualStyleBackColor = true;
            this.rdb_höger.CheckedChanged += new System.EventHandler(this.rdb_höger_CheckedChanged);
            // 
            // lbl_color
            // 
            this.lbl_color.Location = new System.Drawing.Point(494, 137);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(27, 23);
            this.lbl_color.TabIndex = 4;
            this.lbl_color.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // rtb_text
            // 
            this.rtb_text.Location = new System.Drawing.Point(12, 12);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(473, 290);
            this.rtb_text.TabIndex = 5;
            this.rtb_text.Text = "";
            this.rtb_text.TextChanged += new System.EventHandler(this.rtb_text_TextChanged);
            this.rtb_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_text_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 314);
            this.Controls.Add(this.rtb_text);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.rdb_höger);
            this.Controls.Add(this.rdb_center);
            this.Controls.Add(this.rdb_vänster);
            this.Controls.Add(this.btn_tecken);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3.6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tecken;
        private System.Windows.Forms.RadioButton rdb_vänster;
        private System.Windows.Forms.RadioButton rdb_center;
        private System.Windows.Forms.RadioButton rdb_höger;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.ColorDialog dlg_color;
        private System.Windows.Forms.FontDialog dlg_font;
    }
}


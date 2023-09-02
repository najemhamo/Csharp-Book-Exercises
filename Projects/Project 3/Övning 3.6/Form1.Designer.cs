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
            this.rdb_vänster = new System.Windows.Forms.RadioButton();
            this.rdb_center = new System.Windows.Forms.RadioButton();
            this.rdb_höger = new System.Windows.Forms.RadioButton();
            this.lbl_color = new System.Windows.Forms.Label();
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.dlg_color = new System.Windows.Forms.ColorDialog();
            this.cbxFont = new System.Windows.Forms.ComboBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.cbxBold = new System.Windows.Forms.CheckBox();
            this.cbxItalic = new System.Windows.Forms.CheckBox();
            this.btn_punkt = new System.Windows.Forms.Button();
            this.tbx_sök = new System.Windows.Forms.TextBox();
            this.lbl_hittade = new System.Windows.Forms.Label();
            this.lbl_sök = new System.Windows.Forms.Label();
            this.btn_nedsänkt = new System.Windows.Forms.Button();
            this.btn_upphöjt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_vänster
            // 
            this.rdb_vänster.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdb_vänster.Location = new System.Drawing.Point(428, 20);
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
            this.rdb_center.Location = new System.Drawing.Point(461, 19);
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
            this.rdb_höger.Location = new System.Drawing.Point(494, 19);
            this.rdb_höger.Name = "rdb_höger";
            this.rdb_höger.Size = new System.Drawing.Size(27, 23);
            this.rdb_höger.TabIndex = 3;
            this.rdb_höger.TabStop = true;
            this.rdb_höger.UseVisualStyleBackColor = true;
            this.rdb_höger.CheckedChanged += new System.EventHandler(this.rdb_höger_CheckedChanged);
            // 
            // lbl_color
            // 
            this.lbl_color.Location = new System.Drawing.Point(381, 20);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(27, 23);
            this.lbl_color.TabIndex = 4;
            this.lbl_color.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // rtb_text
            // 
            this.rtb_text.Location = new System.Drawing.Point(13, 81);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(805, 287);
            this.rtb_text.TabIndex = 5;
            this.rtb_text.Text = "";
            this.rtb_text.TextChanged += new System.EventHandler(this.rtb_text_TextChanged);
            this.rtb_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_text_KeyDown);
            this.rtb_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_text_KeyPress);
            // 
            // cbxFont
            // 
            this.cbxFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFont.FormattingEnabled = true;
            this.cbxFont.Location = new System.Drawing.Point(13, 24);
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(121, 21);
            this.cbxFont.TabIndex = 6;
            this.cbxFont.SelectedIndexChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // nudSize
            // 
            this.nudSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSize.Location = new System.Drawing.Point(141, 24);
            this.nudSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(34, 20);
            this.nudSize.TabIndex = 7;
            this.nudSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // cbxBold
            // 
            this.cbxBold.AutoSize = true;
            this.cbxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBold.Location = new System.Drawing.Point(206, 25);
            this.cbxBold.Name = "cbxBold";
            this.cbxBold.Size = new System.Drawing.Size(33, 17);
            this.cbxBold.TabIndex = 8;
            this.cbxBold.Text = "F";
            this.cbxBold.UseVisualStyleBackColor = true;
            this.cbxBold.CheckedChanged += new System.EventHandler(this.cbxBold_CheckedChanged);
            // 
            // cbxItalic
            // 
            this.cbxItalic.AutoSize = true;
            this.cbxItalic.Location = new System.Drawing.Point(245, 25);
            this.cbxItalic.Name = "cbxItalic";
            this.cbxItalic.Size = new System.Drawing.Size(33, 17);
            this.cbxItalic.TabIndex = 9;
            this.cbxItalic.Text = "K";
            this.cbxItalic.UseVisualStyleBackColor = true;
            this.cbxItalic.CheckedChanged += new System.EventHandler(this.cbxBold_CheckedChanged);
            // 
            // btn_punkt
            // 
            this.btn_punkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_punkt.Location = new System.Drawing.Point(293, 21);
            this.btn_punkt.Name = "btn_punkt";
            this.btn_punkt.Size = new System.Drawing.Size(82, 23);
            this.btn_punkt.TabIndex = 10;
            this.btn_punkt.Text = "Punkt lista";
            this.btn_punkt.UseVisualStyleBackColor = true;
            this.btn_punkt.Click += new System.EventHandler(this.btn_punkt_Click);
            // 
            // tbx_sök
            // 
            this.tbx_sök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_sök.Location = new System.Drawing.Point(606, 21);
            this.tbx_sök.Name = "tbx_sök";
            this.tbx_sök.Size = new System.Drawing.Size(77, 20);
            this.tbx_sök.TabIndex = 11;
            this.tbx_sök.TextChanged += new System.EventHandler(this.tbx_sök_TextChanged);
            // 
            // lbl_hittade
            // 
            this.lbl_hittade.AutoSize = true;
            this.lbl_hittade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hittade.Location = new System.Drawing.Point(603, 56);
            this.lbl_hittade.Name = "lbl_hittade";
            this.lbl_hittade.Size = new System.Drawing.Size(0, 13);
            this.lbl_hittade.TabIndex = 12;
            // 
            // lbl_sök
            // 
            this.lbl_sök.AutoSize = true;
            this.lbl_sök.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sök.Location = new System.Drawing.Point(560, 25);
            this.lbl_sök.Name = "lbl_sök";
            this.lbl_sök.Size = new System.Drawing.Size(29, 13);
            this.lbl_sök.TabIndex = 13;
            this.lbl_sök.Text = "Sök:";
            // 
            // btn_nedsänkt
            // 
            this.btn_nedsänkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nedsänkt.Image = global::Övning_3._6.Properties.Resources.Nedsänkt;
            this.btn_nedsänkt.Location = new System.Drawing.Point(731, 12);
            this.btn_nedsänkt.Name = "btn_nedsänkt";
            this.btn_nedsänkt.Size = new System.Drawing.Size(36, 36);
            this.btn_nedsänkt.TabIndex = 15;
            this.btn_nedsänkt.UseVisualStyleBackColor = true;
            this.btn_nedsänkt.Click += new System.EventHandler(this.btn_nedsänkt_Click);
            // 
            // btn_upphöjt
            // 
            this.btn_upphöjt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upphöjt.Image = global::Övning_3._6.Properties.Resources.Upphöjd;
            this.btn_upphöjt.Location = new System.Drawing.Point(689, 12);
            this.btn_upphöjt.Name = "btn_upphöjt";
            this.btn_upphöjt.Size = new System.Drawing.Size(36, 36);
            this.btn_upphöjt.TabIndex = 14;
            this.btn_upphöjt.UseVisualStyleBackColor = true;
            this.btn_upphöjt.Click += new System.EventHandler(this.btn_upphöjt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 380);
            this.Controls.Add(this.btn_nedsänkt);
            this.Controls.Add(this.btn_upphöjt);
            this.Controls.Add(this.lbl_sök);
            this.Controls.Add(this.lbl_hittade);
            this.Controls.Add(this.tbx_sök);
            this.Controls.Add(this.btn_punkt);
            this.Controls.Add(this.cbxItalic);
            this.Controls.Add(this.cbxBold);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.cbxFont);
            this.Controls.Add(this.rtb_text);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.rdb_höger);
            this.Controls.Add(this.rdb_center);
            this.Controls.Add(this.rdb_vänster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Övning 3.6";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdb_vänster;
        private System.Windows.Forms.RadioButton rdb_center;
        private System.Windows.Forms.RadioButton rdb_höger;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.ColorDialog dlg_color;
        private System.Windows.Forms.ComboBox cbxFont;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.CheckBox cbxBold;
        private System.Windows.Forms.CheckBox cbxItalic;
        private System.Windows.Forms.Button btn_punkt;
        private System.Windows.Forms.TextBox tbx_sök;
        private System.Windows.Forms.Label lbl_hittade;
        private System.Windows.Forms.Label lbl_sök;
        private System.Windows.Forms.Button btn_upphöjt;
        private System.Windows.Forms.Button btn_nedsänkt;
    }
}


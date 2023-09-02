namespace projekt_2
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
            this.pnl_tavla = new System.Windows.Forms.Panel();
            this.btn_linje = new System.Windows.Forms.Button();
            this.btn_rektangel = new System.Windows.Forms.Button();
            this.btn_cirkel = new System.Windows.Forms.Button();
            this.btn_penna = new System.Windows.Forms.Button();
            this.btn_ångra = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_stor = new System.Windows.Forms.Label();
            this.tbx_size = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_tavla
            // 
            this.pnl_tavla.BackColor = System.Drawing.Color.White;
            this.pnl_tavla.Location = new System.Drawing.Point(193, 12);
            this.pnl_tavla.Name = "pnl_tavla";
            this.pnl_tavla.Size = new System.Drawing.Size(517, 484);
            this.pnl_tavla.TabIndex = 0;
            this.pnl_tavla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_tavla_MouseDown);
            this.pnl_tavla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_tavla_MouseMove);
            this.pnl_tavla.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_tavla_MouseUp);
            // 
            // btn_linje
            // 
            this.btn_linje.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_linje.Location = new System.Drawing.Point(13, 12);
            this.btn_linje.Name = "btn_linje";
            this.btn_linje.Size = new System.Drawing.Size(174, 43);
            this.btn_linje.TabIndex = 1;
            this.btn_linje.Text = "Linje";
            this.btn_linje.UseVisualStyleBackColor = true;
            this.btn_linje.Click += new System.EventHandler(this.btn_linje_Click);
            // 
            // btn_rektangel
            // 
            this.btn_rektangel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rektangel.Location = new System.Drawing.Point(13, 61);
            this.btn_rektangel.Name = "btn_rektangel";
            this.btn_rektangel.Size = new System.Drawing.Size(174, 43);
            this.btn_rektangel.TabIndex = 2;
            this.btn_rektangel.Text = "Rektangel";
            this.btn_rektangel.UseVisualStyleBackColor = true;
            this.btn_rektangel.Click += new System.EventHandler(this.btn_rektangel_Click);
            // 
            // btn_cirkel
            // 
            this.btn_cirkel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cirkel.Location = new System.Drawing.Point(13, 110);
            this.btn_cirkel.Name = "btn_cirkel";
            this.btn_cirkel.Size = new System.Drawing.Size(174, 43);
            this.btn_cirkel.TabIndex = 3;
            this.btn_cirkel.Text = "Ellips";
            this.btn_cirkel.UseVisualStyleBackColor = true;
            this.btn_cirkel.Click += new System.EventHandler(this.btn_cirkel_Click);
            // 
            // btn_penna
            // 
            this.btn_penna.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_penna.Location = new System.Drawing.Point(12, 159);
            this.btn_penna.Name = "btn_penna";
            this.btn_penna.Size = new System.Drawing.Size(174, 43);
            this.btn_penna.TabIndex = 4;
            this.btn_penna.Text = "Penna";
            this.btn_penna.UseVisualStyleBackColor = true;
            this.btn_penna.Click += new System.EventHandler(this.btn_penna_Click);
            // 
            // btn_ångra
            // 
            this.btn_ångra.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ångra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ångra.Location = new System.Drawing.Point(12, 303);
            this.btn_ångra.Name = "btn_ångra";
            this.btn_ångra.Size = new System.Drawing.Size(174, 43);
            this.btn_ångra.TabIndex = 5;
            this.btn_ångra.Text = "Ångra";
            this.btn_ångra.UseVisualStyleBackColor = true;
            this.btn_ångra.Click += new System.EventHandler(this.btn_ångra_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.BackColor = System.Drawing.Color.Yellow;
            this.lbl_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_color.Location = new System.Drawing.Point(12, 400);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(24, 23);
            this.lbl_color.TabIndex = 6;
            this.lbl_color.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(42, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(72, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 8;
            this.label2.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(102, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 9;
            this.label3.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(132, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 23);
            this.label4.TabIndex = 10;
            this.label4.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // lbl_stor
            // 
            this.lbl_stor.AutoSize = true;
            this.lbl_stor.Location = new System.Drawing.Point(91, 369);
            this.lbl_stor.Name = "lbl_stor";
            this.lbl_stor.Size = new System.Drawing.Size(43, 13);
            this.lbl_stor.TabIndex = 11;
            this.lbl_stor.Text = "Strolek:";
            // 
            // tbx_size
            // 
            this.tbx_size.Location = new System.Drawing.Point(140, 366);
            this.tbx_size.Name = "tbx_size";
            this.tbx_size.Size = new System.Drawing.Size(45, 20);
            this.tbx_size.TabIndex = 12;
            this.tbx_size.Text = "6";
            this.tbx_size.TextChanged += new System.EventHandler(this.tbx_size_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(163, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 13;
            this.label5.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Fuchsia;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 23);
            this.label6.TabIndex = 14;
            this.label6.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.BlueViolet;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(42, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 23);
            this.label7.TabIndex = 15;
            this.label7.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(72, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 23);
            this.label8.TabIndex = 16;
            this.label8.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(102, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 23);
            this.label9.TabIndex = 17;
            this.label9.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Cyan;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(132, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 23);
            this.label10.TabIndex = 18;
            this.label10.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(163, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 23);
            this.label11.TabIndex = 19;
            this.label11.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(12, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 23);
            this.label12.TabIndex = 20;
            this.label12.Click += new System.EventHandler(this.lbl_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 508);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_size);
            this.Controls.Add(this.lbl_stor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.btn_ångra);
            this.Controls.Add(this.btn_penna);
            this.Controls.Add(this.btn_cirkel);
            this.Controls.Add(this.btn_rektangel);
            this.Controls.Add(this.btn_linje);
            this.Controls.Add(this.pnl_tavla);
            this.Name = "Form1";
            this.Text = "Ritboken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_tavla;
        private System.Windows.Forms.Button btn_linje;
        private System.Windows.Forms.Button btn_rektangel;
        private System.Windows.Forms.Button btn_cirkel;
        private System.Windows.Forms.Button btn_penna;
        private System.Windows.Forms.Button btn_ångra;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_stor;
        private System.Windows.Forms.TextBox tbx_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}


namespace Övning_2._4
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
            this.btn_Area = new System.Windows.Forms.Button();
            this.lbx_lista = new System.Windows.Forms.ListBox();
            this.gbx_skapa = new System.Windows.Forms.GroupBox();
            this.btn_linje = new System.Windows.Forms.Button();
            this.btn_cirkel = new System.Windows.Forms.Button();
            this.btn_triangel = new System.Windows.Forms.Button();
            this.tbx_höjd = new System.Windows.Forms.TextBox();
            this.tbx_bredd = new System.Windows.Forms.TextBox();
            this.lbl_höjd = new System.Windows.Forms.Label();
            this.lbl_bredd = new System.Windows.Forms.Label();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.tbx_area = new System.Windows.Forms.TextBox();
            this.gbx_skapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Area
            // 
            this.btn_Area.Location = new System.Drawing.Point(157, 501);
            this.btn_Area.Name = "btn_Area";
            this.btn_Area.Size = new System.Drawing.Size(169, 40);
            this.btn_Area.TabIndex = 7;
            this.btn_Area.Text = "Sammanlagda area";
            this.btn_Area.UseVisualStyleBackColor = true;
            this.btn_Area.Click += new System.EventHandler(this.btn_Area_Click);
            // 
            // lbx_lista
            // 
            this.lbx_lista.FormattingEnabled = true;
            this.lbx_lista.Location = new System.Drawing.Point(154, 190);
            this.lbx_lista.Name = "lbx_lista";
            this.lbx_lista.Size = new System.Drawing.Size(172, 199);
            this.lbx_lista.TabIndex = 8;
            // 
            // gbx_skapa
            // 
            this.gbx_skapa.Controls.Add(this.btn_linje);
            this.gbx_skapa.Controls.Add(this.btn_cirkel);
            this.gbx_skapa.Controls.Add(this.btn_triangel);
            this.gbx_skapa.Controls.Add(this.tbx_höjd);
            this.gbx_skapa.Controls.Add(this.tbx_bredd);
            this.gbx_skapa.Controls.Add(this.lbl_höjd);
            this.gbx_skapa.Controls.Add(this.lbl_bredd);
            this.gbx_skapa.Location = new System.Drawing.Point(23, 24);
            this.gbx_skapa.Name = "gbx_skapa";
            this.gbx_skapa.Size = new System.Drawing.Size(434, 117);
            this.gbx_skapa.TabIndex = 9;
            this.gbx_skapa.TabStop = false;
            this.gbx_skapa.Text = "Skapa";
            // 
            // btn_linje
            // 
            this.btn_linje.Location = new System.Drawing.Point(316, 88);
            this.btn_linje.Name = "btn_linje";
            this.btn_linje.Size = new System.Drawing.Size(100, 23);
            this.btn_linje.TabIndex = 13;
            this.btn_linje.Text = "Skapa Linje";
            this.btn_linje.UseVisualStyleBackColor = true;
            this.btn_linje.Click += new System.EventHandler(this.btn_linje_Click);
            // 
            // btn_cirkel
            // 
            this.btn_cirkel.Location = new System.Drawing.Point(169, 88);
            this.btn_cirkel.Name = "btn_cirkel";
            this.btn_cirkel.Size = new System.Drawing.Size(100, 23);
            this.btn_cirkel.TabIndex = 12;
            this.btn_cirkel.Text = "Skapa Cirkel";
            this.btn_cirkel.UseVisualStyleBackColor = true;
            this.btn_cirkel.Click += new System.EventHandler(this.btn_cirkel_Click);
            // 
            // btn_triangel
            // 
            this.btn_triangel.Location = new System.Drawing.Point(33, 88);
            this.btn_triangel.Name = "btn_triangel";
            this.btn_triangel.Size = new System.Drawing.Size(100, 23);
            this.btn_triangel.TabIndex = 11;
            this.btn_triangel.Text = "Skapa Triangel";
            this.btn_triangel.UseVisualStyleBackColor = true;
            this.btn_triangel.Click += new System.EventHandler(this.btn_triangel_Click);
            // 
            // tbx_höjd
            // 
            this.tbx_höjd.Location = new System.Drawing.Point(255, 39);
            this.tbx_höjd.Name = "tbx_höjd";
            this.tbx_höjd.Size = new System.Drawing.Size(100, 20);
            this.tbx_höjd.TabIndex = 10;
            // 
            // tbx_bredd
            // 
            this.tbx_bredd.Location = new System.Drawing.Point(111, 39);
            this.tbx_bredd.Name = "tbx_bredd";
            this.tbx_bredd.Size = new System.Drawing.Size(100, 20);
            this.tbx_bredd.TabIndex = 9;
            // 
            // lbl_höjd
            // 
            this.lbl_höjd.AutoSize = true;
            this.lbl_höjd.Location = new System.Drawing.Point(286, 23);
            this.lbl_höjd.Name = "lbl_höjd";
            this.lbl_höjd.Size = new System.Drawing.Size(29, 13);
            this.lbl_höjd.TabIndex = 8;
            this.lbl_höjd.Text = "Höjd";
            // 
            // lbl_bredd
            // 
            this.lbl_bredd.AutoSize = true;
            this.lbl_bredd.Location = new System.Drawing.Point(144, 23);
            this.lbl_bredd.Name = "lbl_bredd";
            this.lbl_bredd.Size = new System.Drawing.Size(35, 13);
            this.lbl_bredd.TabIndex = 7;
            this.lbl_bredd.Text = "Bredd";
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Location = new System.Drawing.Point(207, 174);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(48, 13);
            this.lbl_lista.TabIndex = 10;
            this.lbl_lista.Text = "Figurlista";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(157, 415);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(98, 13);
            this.lbl_area.TabIndex = 11;
            this.lbl_area.Text = "Sammanlagda area";
            // 
            // tbx_area
            // 
            this.tbx_area.Location = new System.Drawing.Point(160, 434);
            this.tbx_area.Name = "tbx_area";
            this.tbx_area.Size = new System.Drawing.Size(166, 20);
            this.tbx_area.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 586);
            this.Controls.Add(this.tbx_area);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_lista);
            this.Controls.Add(this.gbx_skapa);
            this.Controls.Add(this.lbx_lista);
            this.Controls.Add(this.btn_Area);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.4";
            this.gbx_skapa.ResumeLayout(false);
            this.gbx_skapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Area;
        private System.Windows.Forms.ListBox lbx_lista;
        private System.Windows.Forms.GroupBox gbx_skapa;
        private System.Windows.Forms.Button btn_linje;
        private System.Windows.Forms.Button btn_cirkel;
        private System.Windows.Forms.Button btn_triangel;
        private System.Windows.Forms.TextBox tbx_höjd;
        private System.Windows.Forms.TextBox tbx_bredd;
        private System.Windows.Forms.Label lbl_höjd;
        private System.Windows.Forms.Label lbl_bredd;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.TextBox tbx_area;
    }
}


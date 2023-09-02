namespace Övning_1._6
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
            this.lbl_namn = new System.Windows.Forms.Label();
            this.lbl_klass = new System.Windows.Forms.Label();
            this.lbl_kurs = new System.Windows.Forms.Label();
            this.tbx_namn = new System.Windows.Forms.TextBox();
            this.tbx_klass = new System.Windows.Forms.TextBox();
            this.tbx_kurs = new System.Windows.Forms.TextBox();
            this.btn_öppna = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_imp = new System.Windows.Forms.Button();
            this.btn_spa = new System.Windows.Forms.Button();
            this.tbx_rad = new System.Windows.Forms.TextBox();
            this.lbl_rad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_namn
            // 
            this.lbl_namn.AutoSize = true;
            this.lbl_namn.Location = new System.Drawing.Point(82, 23);
            this.lbl_namn.Name = "lbl_namn";
            this.lbl_namn.Size = new System.Drawing.Size(35, 13);
            this.lbl_namn.TabIndex = 0;
            this.lbl_namn.Text = "Namn";
            // 
            // lbl_klass
            // 
            this.lbl_klass.AutoSize = true;
            this.lbl_klass.Location = new System.Drawing.Point(260, 23);
            this.lbl_klass.Name = "lbl_klass";
            this.lbl_klass.Size = new System.Drawing.Size(32, 13);
            this.lbl_klass.TabIndex = 1;
            this.lbl_klass.Text = "Klass";
            // 
            // lbl_kurs
            // 
            this.lbl_kurs.AutoSize = true;
            this.lbl_kurs.Location = new System.Drawing.Point(444, 23);
            this.lbl_kurs.Name = "lbl_kurs";
            this.lbl_kurs.Size = new System.Drawing.Size(28, 13);
            this.lbl_kurs.TabIndex = 2;
            this.lbl_kurs.Text = "Kurs";
            // 
            // tbx_namn
            // 
            this.tbx_namn.Location = new System.Drawing.Point(46, 50);
            this.tbx_namn.Name = "tbx_namn";
            this.tbx_namn.Size = new System.Drawing.Size(120, 20);
            this.tbx_namn.TabIndex = 3;
            // 
            // tbx_klass
            // 
            this.tbx_klass.Location = new System.Drawing.Point(217, 50);
            this.tbx_klass.Name = "tbx_klass";
            this.tbx_klass.Size = new System.Drawing.Size(120, 20);
            this.tbx_klass.TabIndex = 4;
            // 
            // tbx_kurs
            // 
            this.tbx_kurs.Location = new System.Drawing.Point(393, 50);
            this.tbx_kurs.Name = "tbx_kurs";
            this.tbx_kurs.Size = new System.Drawing.Size(120, 20);
            this.tbx_kurs.TabIndex = 5;
            // 
            // btn_öppna
            // 
            this.btn_öppna.Location = new System.Drawing.Point(217, 123);
            this.btn_öppna.Name = "btn_öppna";
            this.btn_öppna.Size = new System.Drawing.Size(120, 23);
            this.btn_öppna.TabIndex = 6;
            this.btn_öppna.Text = "Öppna Excel";
            this.btn_öppna.UseVisualStyleBackColor = true;
            this.btn_öppna.Click += new System.EventHandler(this.btn_öppna_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(258, 200);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(75, 23);
            this.btn_exp.TabIndex = 7;
            this.btn_exp.Text = "Exportera";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_imp
            // 
            this.btn_imp.Location = new System.Drawing.Point(356, 200);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(75, 23);
            this.btn_imp.TabIndex = 8;
            this.btn_imp.Text = "Importera";
            this.btn_imp.UseVisualStyleBackColor = true;
            this.btn_imp.Click += new System.EventHandler(this.btn_imp_Click);
            // 
            // btn_spa
            // 
            this.btn_spa.Location = new System.Drawing.Point(217, 267);
            this.btn_spa.Name = "btn_spa";
            this.btn_spa.Size = new System.Drawing.Size(120, 23);
            this.btn_spa.TabIndex = 9;
            this.btn_spa.Text = "Spara och stäng";
            this.btn_spa.UseVisualStyleBackColor = true;
            this.btn_spa.Click += new System.EventHandler(this.btn_spa_Click);
            // 
            // tbx_rad
            // 
            this.tbx_rad.Location = new System.Drawing.Point(172, 200);
            this.tbx_rad.Name = "tbx_rad";
            this.tbx_rad.Size = new System.Drawing.Size(64, 20);
            this.tbx_rad.TabIndex = 10;
            // 
            // lbl_rad
            // 
            this.lbl_rad.AutoSize = true;
            this.lbl_rad.Location = new System.Drawing.Point(82, 200);
            this.lbl_rad.Name = "lbl_rad";
            this.lbl_rad.Size = new System.Drawing.Size(64, 13);
            this.lbl_rad.TabIndex = 11;
            this.lbl_rad.Text = "Radnummer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 312);
            this.Controls.Add(this.lbl_rad);
            this.Controls.Add(this.tbx_rad);
            this.Controls.Add(this.btn_spa);
            this.Controls.Add(this.btn_imp);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_öppna);
            this.Controls.Add(this.tbx_kurs);
            this.Controls.Add(this.tbx_klass);
            this.Controls.Add(this.tbx_namn);
            this.Controls.Add(this.lbl_kurs);
            this.Controls.Add(this.lbl_klass);
            this.Controls.Add(this.lbl_namn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 1.6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_namn;
        private System.Windows.Forms.Label lbl_klass;
        private System.Windows.Forms.Label lbl_kurs;
        private System.Windows.Forms.TextBox tbx_namn;
        private System.Windows.Forms.TextBox tbx_klass;
        private System.Windows.Forms.TextBox tbx_kurs;
        private System.Windows.Forms.Button btn_öppna;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_imp;
        private System.Windows.Forms.Button btn_spa;
        private System.Windows.Forms.TextBox tbx_rad;
        private System.Windows.Forms.Label lbl_rad;
    }
}


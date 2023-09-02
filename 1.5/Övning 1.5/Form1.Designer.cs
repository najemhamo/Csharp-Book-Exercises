namespace Övning_1._5
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
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_typ = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_mar = new System.Windows.Forms.Label();
            this.tbx_num = new System.Windows.Forms.TextBox();
            this.tbx_mark = new System.Windows.Forms.TextBox();
            this.tbx_mod = new System.Windows.Forms.TextBox();
            this.cb_typ = new System.Windows.Forms.ComboBox();
            this.lib_regester = new System.Windows.Forms.ListBox();
            this.gbx_visa = new System.Windows.Forms.GroupBox();
            this.rdb_MC = new System.Windows.Forms.RadioButton();
            this.rdb_bil = new System.Windows.Forms.RadioButton();
            this.rdb_alla = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.gbx_visa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(22, 42);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(39, 13);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Reg-nr";
            // 
            // lbl_typ
            // 
            this.lbl_typ.AutoSize = true;
            this.lbl_typ.Location = new System.Drawing.Point(22, 174);
            this.lbl_typ.Name = "lbl_typ";
            this.lbl_typ.Size = new System.Drawing.Size(25, 13);
            this.lbl_typ.TabIndex = 1;
            this.lbl_typ.Text = "Typ";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(22, 124);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(38, 13);
            this.lbl_model.TabIndex = 2;
            this.lbl_model.Text = "Modell";
            // 
            // lbl_mar
            // 
            this.lbl_mar.AutoSize = true;
            this.lbl_mar.Location = new System.Drawing.Point(22, 80);
            this.lbl_mar.Name = "lbl_mar";
            this.lbl_mar.Size = new System.Drawing.Size(37, 13);
            this.lbl_mar.TabIndex = 3;
            this.lbl_mar.Text = "Märke";
            // 
            // tbx_num
            // 
            this.tbx_num.Location = new System.Drawing.Point(104, 39);
            this.tbx_num.Name = "tbx_num";
            this.tbx_num.Size = new System.Drawing.Size(100, 20);
            this.tbx_num.TabIndex = 4;
            // 
            // tbx_mark
            // 
            this.tbx_mark.Location = new System.Drawing.Point(104, 77);
            this.tbx_mark.Name = "tbx_mark";
            this.tbx_mark.Size = new System.Drawing.Size(100, 20);
            this.tbx_mark.TabIndex = 5;
            // 
            // tbx_mod
            // 
            this.tbx_mod.Location = new System.Drawing.Point(104, 121);
            this.tbx_mod.Name = "tbx_mod";
            this.tbx_mod.Size = new System.Drawing.Size(100, 20);
            this.tbx_mod.TabIndex = 6;
            // 
            // cb_typ
            // 
            this.cb_typ.FormattingEnabled = true;
            this.cb_typ.Items.AddRange(new object[] {
            "Bil\t",
            "Motor"});
            this.cb_typ.Location = new System.Drawing.Point(104, 171);
            this.cb_typ.Name = "cb_typ";
            this.cb_typ.Size = new System.Drawing.Size(100, 21);
            this.cb_typ.TabIndex = 7;
            // 
            // lib_regester
            // 
            this.lib_regester.FormattingEnabled = true;
            this.lib_regester.Location = new System.Drawing.Point(267, 42);
            this.lib_regester.Name = "lib_regester";
            this.lib_regester.Size = new System.Drawing.Size(175, 290);
            this.lib_regester.TabIndex = 8;
            // 
            // gbx_visa
            // 
            this.gbx_visa.Controls.Add(this.rdb_MC);
            this.gbx_visa.Controls.Add(this.rdb_bil);
            this.gbx_visa.Controls.Add(this.rdb_alla);
            this.gbx_visa.Location = new System.Drawing.Point(46, 283);
            this.gbx_visa.Name = "gbx_visa";
            this.gbx_visa.Size = new System.Drawing.Size(175, 49);
            this.gbx_visa.TabIndex = 9;
            this.gbx_visa.TabStop = false;
            this.gbx_visa.Text = "Visa";
            // 
            // rdb_MC
            // 
            this.rdb_MC.AutoSize = true;
            this.rdb_MC.Location = new System.Drawing.Point(114, 19);
            this.rdb_MC.Name = "rdb_MC";
            this.rdb_MC.Size = new System.Drawing.Size(41, 17);
            this.rdb_MC.TabIndex = 2;
            this.rdb_MC.TabStop = true;
            this.rdb_MC.Text = "MC";
            this.rdb_MC.UseVisualStyleBackColor = true;
            this.rdb_MC.CheckedChanged += new System.EventHandler(this.rdb_alla_CheckedChanged);
            // 
            // rdb_bil
            // 
            this.rdb_bil.AutoSize = true;
            this.rdb_bil.Location = new System.Drawing.Point(63, 19);
            this.rdb_bil.Name = "rdb_bil";
            this.rdb_bil.Size = new System.Drawing.Size(45, 17);
            this.rdb_bil.TabIndex = 1;
            this.rdb_bil.TabStop = true;
            this.rdb_bil.Text = "Bilar";
            this.rdb_bil.UseVisualStyleBackColor = true;
            this.rdb_bil.CheckedChanged += new System.EventHandler(this.rdb_alla_CheckedChanged);
            // 
            // rdb_alla
            // 
            this.rdb_alla.AutoSize = true;
            this.rdb_alla.Location = new System.Drawing.Point(16, 19);
            this.rdb_alla.Name = "rdb_alla";
            this.rdb_alla.Size = new System.Drawing.Size(42, 17);
            this.rdb_alla.TabIndex = 0;
            this.rdb_alla.TabStop = true;
            this.rdb_alla.Text = "Alla";
            this.rdb_alla.UseVisualStyleBackColor = true;
            this.rdb_alla.CheckedChanged += new System.EventHandler(this.rdb_alla_CheckedChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(87, 232);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(100, 23);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "Registera";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 344);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.gbx_visa);
            this.Controls.Add(this.lib_regester);
            this.Controls.Add(this.cb_typ);
            this.Controls.Add(this.tbx_mod);
            this.Controls.Add(this.tbx_mark);
            this.Controls.Add(this.tbx_num);
            this.Controls.Add(this.lbl_mar);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_typ);
            this.Controls.Add(this.lbl_num);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.5";
            this.gbx_visa.ResumeLayout(false);
            this.gbx_visa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_typ;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_mar;
        private System.Windows.Forms.TextBox tbx_num;
        private System.Windows.Forms.TextBox tbx_mark;
        private System.Windows.Forms.TextBox tbx_mod;
        private System.Windows.Forms.ComboBox cb_typ;
        private System.Windows.Forms.ListBox lib_regester;
        private System.Windows.Forms.GroupBox gbx_visa;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.RadioButton rdb_MC;
        private System.Windows.Forms.RadioButton rdb_bil;
        private System.Windows.Forms.RadioButton rdb_alla;
    }
}


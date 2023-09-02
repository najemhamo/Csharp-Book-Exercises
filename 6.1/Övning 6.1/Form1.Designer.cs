namespace Övning_6._1
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
            this.pnl_person = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_resultat = new System.Windows.Forms.TextBox();
            this.btn_sök = new System.Windows.Forms.Button();
            this.tbx_personnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_person = new System.Windows.Forms.RadioButton();
            this.rdb_sql = new System.Windows.Forms.RadioButton();
            this.pnl_sql = new System.Windows.Forms.Panel();
            this.tbx_sqlResultat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tbx_sql = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_person.SuspendLayout();
            this.pnl_sql.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_person
            // 
            this.pnl_person.Controls.Add(this.label2);
            this.pnl_person.Controls.Add(this.tbx_resultat);
            this.pnl_person.Controls.Add(this.btn_sök);
            this.pnl_person.Controls.Add(this.tbx_personnummer);
            this.pnl_person.Controls.Add(this.label1);
            this.pnl_person.Location = new System.Drawing.Point(12, 62);
            this.pnl_person.Name = "pnl_person";
            this.pnl_person.Size = new System.Drawing.Size(345, 279);
            this.pnl_person.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sökresultat";
            // 
            // tbx_resultat
            // 
            this.tbx_resultat.Location = new System.Drawing.Point(20, 101);
            this.tbx_resultat.Multiline = true;
            this.tbx_resultat.Name = "tbx_resultat";
            this.tbx_resultat.Size = new System.Drawing.Size(309, 166);
            this.tbx_resultat.TabIndex = 3;
            // 
            // btn_sök
            // 
            this.btn_sök.Location = new System.Drawing.Point(254, 11);
            this.btn_sök.Name = "btn_sök";
            this.btn_sök.Size = new System.Drawing.Size(75, 23);
            this.btn_sök.TabIndex = 2;
            this.btn_sök.Text = "Sök";
            this.btn_sök.UseVisualStyleBackColor = true;
            this.btn_sök.Click += new System.EventHandler(this.btn_sök_Click);
            // 
            // tbx_personnummer
            // 
            this.tbx_personnummer.Location = new System.Drawing.Point(117, 13);
            this.tbx_personnummer.Name = "tbx_personnummer";
            this.tbx_personnummer.Size = new System.Drawing.Size(121, 20);
            this.tbx_personnummer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnummer";
            // 
            // rdb_person
            // 
            this.rdb_person.AutoSize = true;
            this.rdb_person.Location = new System.Drawing.Point(32, 12);
            this.rdb_person.Name = "rdb_person";
            this.rdb_person.Size = new System.Drawing.Size(139, 17);
            this.rdb_person.TabIndex = 1;
            this.rdb_person.TabStop = true;
            this.rdb_person.Text = "Sök med personnummer";
            this.rdb_person.UseVisualStyleBackColor = true;
            this.rdb_person.CheckedChanged += new System.EventHandler(this.rdb_person_CheckedChanged);
            // 
            // rdb_sql
            // 
            this.rdb_sql.AutoSize = true;
            this.rdb_sql.Checked = true;
            this.rdb_sql.Location = new System.Drawing.Point(213, 13);
            this.rdb_sql.Name = "rdb_sql";
            this.rdb_sql.Size = new System.Drawing.Size(46, 17);
            this.rdb_sql.TabIndex = 2;
            this.rdb_sql.TabStop = true;
            this.rdb_sql.Text = "SQL";
            this.rdb_sql.UseVisualStyleBackColor = true;
            this.rdb_sql.CheckedChanged += new System.EventHandler(this.rdb_sql_CheckedChanged);
            // 
            // pnl_sql
            // 
            this.pnl_sql.Controls.Add(this.tbx_sqlResultat);
            this.pnl_sql.Controls.Add(this.label4);
            this.pnl_sql.Controls.Add(this.btn_select);
            this.pnl_sql.Controls.Add(this.btn_insert);
            this.pnl_sql.Controls.Add(this.tbx_sql);
            this.pnl_sql.Controls.Add(this.label3);
            this.pnl_sql.Location = new System.Drawing.Point(12, 62);
            this.pnl_sql.Name = "pnl_sql";
            this.pnl_sql.Size = new System.Drawing.Size(342, 279);
            this.pnl_sql.TabIndex = 5;
            // 
            // tbx_sqlResultat
            // 
            this.tbx_sqlResultat.Location = new System.Drawing.Point(26, 160);
            this.tbx_sqlResultat.Multiline = true;
            this.tbx_sqlResultat.Name = "tbx_sqlResultat";
            this.tbx_sqlResultat.Size = new System.Drawing.Size(303, 107);
            this.tbx_sqlResultat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sökresultat";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(254, 87);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(172, 88);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tbx_sql
            // 
            this.tbx_sql.Location = new System.Drawing.Point(59, 20);
            this.tbx_sql.Multiline = true;
            this.tbx_sql.Name = "tbx_sql";
            this.tbx_sql.Size = new System.Drawing.Size(270, 62);
            this.tbx_sql.TabIndex = 1;
            this.tbx_sql.Text = "SELECT * FROM Kunder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 353);
            this.Controls.Add(this.pnl_sql);
            this.Controls.Add(this.rdb_sql);
            this.Controls.Add(this.rdb_person);
            this.Controls.Add(this.pnl_person);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6.1";
            this.pnl_person.ResumeLayout(false);
            this.pnl_person.PerformLayout();
            this.pnl_sql.ResumeLayout(false);
            this.pnl_sql.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_person;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_resultat;
        private System.Windows.Forms.Button btn_sök;
        private System.Windows.Forms.TextBox tbx_personnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_person;
        private System.Windows.Forms.RadioButton rdb_sql;
        private System.Windows.Forms.Panel pnl_sql;
        private System.Windows.Forms.TextBox tbx_sqlResultat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tbx_sql;
        private System.Windows.Forms.Label label3;
    }
}


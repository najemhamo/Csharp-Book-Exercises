namespace Övning_2._1
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.tbx_title = new System.Windows.Forms.TextBox();
            this.lbl_sidor = new System.Windows.Forms.Label();
            this.tbx_sidor = new System.Windows.Forms.TextBox();
            this.tbx_tid = new System.Windows.Forms.TextBox();
            this.tbx_Uppplösning = new System.Windows.Forms.TextBox();
            this.lbl_tid = new System.Windows.Forms.Label();
            this.lbl_Upplösning = new System.Windows.Forms.Label();
            this.rdb_bok = new System.Windows.Forms.RadioButton();
            this.rdb_ljud = new System.Windows.Forms.RadioButton();
            this.rdb_film = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbx_lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(83, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(30, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Titel ";
            // 
            // tbx_title
            // 
            this.tbx_title.Location = new System.Drawing.Point(52, 43);
            this.tbx_title.Name = "tbx_title";
            this.tbx_title.Size = new System.Drawing.Size(100, 20);
            this.tbx_title.TabIndex = 1;
            // 
            // lbl_sidor
            // 
            this.lbl_sidor.AutoSize = true;
            this.lbl_sidor.Location = new System.Drawing.Point(75, 92);
            this.lbl_sidor.Name = "lbl_sidor";
            this.lbl_sidor.Size = new System.Drawing.Size(56, 13);
            this.lbl_sidor.TabIndex = 2;
            this.lbl_sidor.Text = "Antal sidor";
            // 
            // tbx_sidor
            // 
            this.tbx_sidor.Location = new System.Drawing.Point(56, 117);
            this.tbx_sidor.Name = "tbx_sidor";
            this.tbx_sidor.Size = new System.Drawing.Size(100, 20);
            this.tbx_sidor.TabIndex = 3;
            // 
            // tbx_tid
            // 
            this.tbx_tid.Location = new System.Drawing.Point(56, 197);
            this.tbx_tid.Name = "tbx_tid";
            this.tbx_tid.Size = new System.Drawing.Size(100, 20);
            this.tbx_tid.TabIndex = 4;
            // 
            // tbx_Uppplösning
            // 
            this.tbx_Uppplösning.Location = new System.Drawing.Point(56, 265);
            this.tbx_Uppplösning.Name = "tbx_Uppplösning";
            this.tbx_Uppplösning.Size = new System.Drawing.Size(100, 20);
            this.tbx_Uppplösning.TabIndex = 5;
            // 
            // lbl_tid
            // 
            this.lbl_tid.AutoSize = true;
            this.lbl_tid.Location = new System.Drawing.Point(83, 167);
            this.lbl_tid.Name = "lbl_tid";
            this.lbl_tid.Size = new System.Drawing.Size(39, 13);
            this.lbl_tid.TabIndex = 6;
            this.lbl_tid.Text = "Speltid";
            // 
            // lbl_Upplösning
            // 
            this.lbl_Upplösning.AutoSize = true;
            this.lbl_Upplösning.Location = new System.Drawing.Point(74, 240);
            this.lbl_Upplösning.Name = "lbl_Upplösning";
            this.lbl_Upplösning.Size = new System.Drawing.Size(60, 13);
            this.lbl_Upplösning.TabIndex = 7;
            this.lbl_Upplösning.Text = "Upplösning";
            // 
            // rdb_bok
            // 
            this.rdb_bok.AutoSize = true;
            this.rdb_bok.Location = new System.Drawing.Point(31, 313);
            this.rdb_bok.Name = "rdb_bok";
            this.rdb_bok.Size = new System.Drawing.Size(44, 17);
            this.rdb_bok.TabIndex = 8;
            this.rdb_bok.TabStop = true;
            this.rdb_bok.Text = "Bok";
            this.rdb_bok.UseVisualStyleBackColor = true;
            // 
            // rdb_ljud
            // 
            this.rdb_ljud.AutoSize = true;
            this.rdb_ljud.Location = new System.Drawing.Point(86, 313);
            this.rdb_ljud.Name = "rdb_ljud";
            this.rdb_ljud.Size = new System.Drawing.Size(65, 17);
            this.rdb_ljud.TabIndex = 9;
            this.rdb_ljud.TabStop = true;
            this.rdb_ljud.Text = "Ljudspår";
            this.rdb_ljud.UseVisualStyleBackColor = true;
            // 
            // rdb_film
            // 
            this.rdb_film.AutoSize = true;
            this.rdb_film.Location = new System.Drawing.Point(157, 313);
            this.rdb_film.Name = "rdb_film";
            this.rdb_film.Size = new System.Drawing.Size(43, 17);
            this.rdb_film.TabIndex = 10;
            this.rdb_film.TabStop = true;
            this.rdb_film.Text = "Film";
            this.rdb_film.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(31, 362);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(169, 23);
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "Registera";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbx_lista
            // 
            this.lbx_lista.FormattingEnabled = true;
            this.lbx_lista.Location = new System.Drawing.Point(216, 29);
            this.lbx_lista.Name = "lbx_lista";
            this.lbx_lista.Size = new System.Drawing.Size(234, 355);
            this.lbx_lista.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 407);
            this.Controls.Add(this.lbx_lista);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rdb_film);
            this.Controls.Add(this.rdb_ljud);
            this.Controls.Add(this.rdb_bok);
            this.Controls.Add(this.lbl_Upplösning);
            this.Controls.Add(this.lbl_tid);
            this.Controls.Add(this.tbx_Uppplösning);
            this.Controls.Add(this.tbx_tid);
            this.Controls.Add(this.tbx_sidor);
            this.Controls.Add(this.lbl_sidor);
            this.Controls.Add(this.tbx_title);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tbx_title;
        private System.Windows.Forms.Label lbl_sidor;
        private System.Windows.Forms.TextBox tbx_sidor;
        private System.Windows.Forms.TextBox tbx_tid;
        private System.Windows.Forms.TextBox tbx_Uppplösning;
        private System.Windows.Forms.Label lbl_tid;
        private System.Windows.Forms.Label lbl_Upplösning;
        private System.Windows.Forms.RadioButton rdb_bok;
        private System.Windows.Forms.RadioButton rdb_ljud;
        private System.Windows.Forms.RadioButton rdb_film;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.ListBox lbx_lista;
    }
}


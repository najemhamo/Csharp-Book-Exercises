namespace Övning_2._2
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
            this.gbx_säljare = new System.Windows.Forms.GroupBox();
            this.btn_registeraS = new System.Windows.Forms.Button();
            this.tbx_för = new System.Windows.Forms.TextBox();
            this.tbx_prov = new System.Windows.Forms.TextBox();
            this.tbx_namnSäljare = new System.Windows.Forms.TextBox();
            this.lbl_för = new System.Windows.Forms.Label();
            this.lbl_prov = new System.Windows.Forms.Label();
            this.lbl_namn = new System.Windows.Forms.Label();
            this.gbx_kon = new System.Windows.Forms.GroupBox();
            this.btn_registeraK = new System.Windows.Forms.Button();
            this.tbx_arbetadTid = new System.Windows.Forms.TextBox();
            this.tbx_timlön = new System.Windows.Forms.TextBox();
            this.tbx_namnKonsult = new System.Windows.Forms.TextBox();
            this.lbl_arbetadTid = new System.Windows.Forms.Label();
            this.lbl_timlön = new System.Windows.Forms.Label();
            this.lbl_namnKonsult = new System.Windows.Forms.Label();
            this.gbx_kontorist = new System.Windows.Forms.GroupBox();
            this.btn_registerako = new System.Windows.Forms.Button();
            this.tbx_månadLön = new System.Windows.Forms.TextBox();
            this.tbx_namnKontorist = new System.Windows.Forms.TextBox();
            this.lbl_månad = new System.Windows.Forms.Label();
            this.lbl_namnKontorist = new System.Windows.Forms.Label();
            this.lbx_reg = new System.Windows.Forms.ListBox();
            this.lbx_lön = new System.Windows.Forms.ListBox();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_lön = new System.Windows.Forms.Label();
            this.btn_beräkna = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tbx_lön = new System.Windows.Forms.TextBox();
            this.gbx_säljare.SuspendLayout();
            this.gbx_kon.SuspendLayout();
            this.gbx_kontorist.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_säljare
            // 
            this.gbx_säljare.Controls.Add(this.btn_registeraS);
            this.gbx_säljare.Controls.Add(this.tbx_för);
            this.gbx_säljare.Controls.Add(this.tbx_prov);
            this.gbx_säljare.Controls.Add(this.tbx_namnSäljare);
            this.gbx_säljare.Controls.Add(this.lbl_för);
            this.gbx_säljare.Controls.Add(this.lbl_prov);
            this.gbx_säljare.Controls.Add(this.lbl_namn);
            this.gbx_säljare.Location = new System.Drawing.Point(22, 25);
            this.gbx_säljare.Name = "gbx_säljare";
            this.gbx_säljare.Size = new System.Drawing.Size(195, 170);
            this.gbx_säljare.TabIndex = 0;
            this.gbx_säljare.TabStop = false;
            this.gbx_säljare.Text = "Säljare";
            // 
            // btn_registeraS
            // 
            this.btn_registeraS.Location = new System.Drawing.Point(10, 136);
            this.btn_registeraS.Name = "btn_registeraS";
            this.btn_registeraS.Size = new System.Drawing.Size(179, 23);
            this.btn_registeraS.TabIndex = 6;
            this.btn_registeraS.Text = "Registera försäljning";
            this.btn_registeraS.UseVisualStyleBackColor = true;
            this.btn_registeraS.Click += new System.EventHandler(this.btn_registeraS_Click);
            // 
            // tbx_för
            // 
            this.tbx_för.Location = new System.Drawing.Point(89, 102);
            this.tbx_för.Name = "tbx_för";
            this.tbx_för.Size = new System.Drawing.Size(100, 20);
            this.tbx_för.TabIndex = 5;
            // 
            // tbx_prov
            // 
            this.tbx_prov.Location = new System.Drawing.Point(89, 65);
            this.tbx_prov.Name = "tbx_prov";
            this.tbx_prov.Size = new System.Drawing.Size(100, 20);
            this.tbx_prov.TabIndex = 4;
            // 
            // tbx_namnSäljare
            // 
            this.tbx_namnSäljare.Location = new System.Drawing.Point(89, 29);
            this.tbx_namnSäljare.Name = "tbx_namnSäljare";
            this.tbx_namnSäljare.Size = new System.Drawing.Size(100, 20);
            this.tbx_namnSäljare.TabIndex = 3;
            // 
            // lbl_för
            // 
            this.lbl_för.AutoSize = true;
            this.lbl_för.Location = new System.Drawing.Point(7, 105);
            this.lbl_för.Name = "lbl_för";
            this.lbl_för.Size = new System.Drawing.Size(62, 13);
            this.lbl_för.TabIndex = 2;
            this.lbl_för.Text = "Försäljnings";
            // 
            // lbl_prov
            // 
            this.lbl_prov.AutoSize = true;
            this.lbl_prov.Location = new System.Drawing.Point(7, 68);
            this.lbl_prov.Name = "lbl_prov";
            this.lbl_prov.Size = new System.Drawing.Size(50, 13);
            this.lbl_prov.TabIndex = 1;
            this.lbl_prov.Text = "Provision";
            // 
            // lbl_namn
            // 
            this.lbl_namn.AutoSize = true;
            this.lbl_namn.Location = new System.Drawing.Point(7, 32);
            this.lbl_namn.Name = "lbl_namn";
            this.lbl_namn.Size = new System.Drawing.Size(35, 13);
            this.lbl_namn.TabIndex = 0;
            this.lbl_namn.Text = "Namn";
            // 
            // gbx_kon
            // 
            this.gbx_kon.Controls.Add(this.btn_registeraK);
            this.gbx_kon.Controls.Add(this.tbx_arbetadTid);
            this.gbx_kon.Controls.Add(this.tbx_timlön);
            this.gbx_kon.Controls.Add(this.tbx_namnKonsult);
            this.gbx_kon.Controls.Add(this.lbl_arbetadTid);
            this.gbx_kon.Controls.Add(this.lbl_timlön);
            this.gbx_kon.Controls.Add(this.lbl_namnKonsult);
            this.gbx_kon.Location = new System.Drawing.Point(243, 25);
            this.gbx_kon.Name = "gbx_kon";
            this.gbx_kon.Size = new System.Drawing.Size(195, 170);
            this.gbx_kon.TabIndex = 1;
            this.gbx_kon.TabStop = false;
            this.gbx_kon.Text = "Konsult";
            // 
            // btn_registeraK
            // 
            this.btn_registeraK.Location = new System.Drawing.Point(10, 136);
            this.btn_registeraK.Name = "btn_registeraK";
            this.btn_registeraK.Size = new System.Drawing.Size(179, 23);
            this.btn_registeraK.TabIndex = 6;
            this.btn_registeraK.Text = "Registera arbetspass";
            this.btn_registeraK.UseVisualStyleBackColor = true;
            this.btn_registeraK.Click += new System.EventHandler(this.btn_registeraK_Click);
            // 
            // tbx_arbetadTid
            // 
            this.tbx_arbetadTid.Location = new System.Drawing.Point(89, 102);
            this.tbx_arbetadTid.Name = "tbx_arbetadTid";
            this.tbx_arbetadTid.Size = new System.Drawing.Size(100, 20);
            this.tbx_arbetadTid.TabIndex = 5;
            // 
            // tbx_timlön
            // 
            this.tbx_timlön.Location = new System.Drawing.Point(89, 65);
            this.tbx_timlön.Name = "tbx_timlön";
            this.tbx_timlön.Size = new System.Drawing.Size(100, 20);
            this.tbx_timlön.TabIndex = 4;
            // 
            // tbx_namnKonsult
            // 
            this.tbx_namnKonsult.Location = new System.Drawing.Point(89, 29);
            this.tbx_namnKonsult.Name = "tbx_namnKonsult";
            this.tbx_namnKonsult.Size = new System.Drawing.Size(100, 20);
            this.tbx_namnKonsult.TabIndex = 3;
            // 
            // lbl_arbetadTid
            // 
            this.lbl_arbetadTid.AutoSize = true;
            this.lbl_arbetadTid.Location = new System.Drawing.Point(7, 105);
            this.lbl_arbetadTid.Name = "lbl_arbetadTid";
            this.lbl_arbetadTid.Size = new System.Drawing.Size(58, 13);
            this.lbl_arbetadTid.TabIndex = 2;
            this.lbl_arbetadTid.Text = "Arbetad tid";
            // 
            // lbl_timlön
            // 
            this.lbl_timlön.AutoSize = true;
            this.lbl_timlön.Location = new System.Drawing.Point(7, 68);
            this.lbl_timlön.Name = "lbl_timlön";
            this.lbl_timlön.Size = new System.Drawing.Size(38, 13);
            this.lbl_timlön.TabIndex = 1;
            this.lbl_timlön.Text = "Timlön";
            // 
            // lbl_namnKonsult
            // 
            this.lbl_namnKonsult.AutoSize = true;
            this.lbl_namnKonsult.Location = new System.Drawing.Point(7, 32);
            this.lbl_namnKonsult.Name = "lbl_namnKonsult";
            this.lbl_namnKonsult.Size = new System.Drawing.Size(35, 13);
            this.lbl_namnKonsult.TabIndex = 0;
            this.lbl_namnKonsult.Text = "Namn";
            // 
            // gbx_kontorist
            // 
            this.gbx_kontorist.Controls.Add(this.btn_registerako);
            this.gbx_kontorist.Controls.Add(this.tbx_månadLön);
            this.gbx_kontorist.Controls.Add(this.tbx_namnKontorist);
            this.gbx_kontorist.Controls.Add(this.lbl_månad);
            this.gbx_kontorist.Controls.Add(this.lbl_namnKontorist);
            this.gbx_kontorist.Location = new System.Drawing.Point(455, 25);
            this.gbx_kontorist.Name = "gbx_kontorist";
            this.gbx_kontorist.Size = new System.Drawing.Size(195, 170);
            this.gbx_kontorist.TabIndex = 2;
            this.gbx_kontorist.TabStop = false;
            this.gbx_kontorist.Text = "Kontorist";
            // 
            // btn_registerako
            // 
            this.btn_registerako.Location = new System.Drawing.Point(10, 136);
            this.btn_registerako.Name = "btn_registerako";
            this.btn_registerako.Size = new System.Drawing.Size(179, 23);
            this.btn_registerako.TabIndex = 6;
            this.btn_registerako.Text = "Registera månadslön";
            this.btn_registerako.UseVisualStyleBackColor = true;
            this.btn_registerako.Click += new System.EventHandler(this.btn_registerako_Click);
            // 
            // tbx_månadLön
            // 
            this.tbx_månadLön.Location = new System.Drawing.Point(89, 65);
            this.tbx_månadLön.Name = "tbx_månadLön";
            this.tbx_månadLön.Size = new System.Drawing.Size(100, 20);
            this.tbx_månadLön.TabIndex = 4;
            // 
            // tbx_namnKontorist
            // 
            this.tbx_namnKontorist.Location = new System.Drawing.Point(89, 29);
            this.tbx_namnKontorist.Name = "tbx_namnKontorist";
            this.tbx_namnKontorist.Size = new System.Drawing.Size(100, 20);
            this.tbx_namnKontorist.TabIndex = 3;
            // 
            // lbl_månad
            // 
            this.lbl_månad.AutoSize = true;
            this.lbl_månad.Location = new System.Drawing.Point(7, 68);
            this.lbl_månad.Name = "lbl_månad";
            this.lbl_månad.Size = new System.Drawing.Size(59, 13);
            this.lbl_månad.TabIndex = 1;
            this.lbl_månad.Text = "Månadslön";
            // 
            // lbl_namnKontorist
            // 
            this.lbl_namnKontorist.AutoSize = true;
            this.lbl_namnKontorist.Location = new System.Drawing.Point(7, 32);
            this.lbl_namnKontorist.Name = "lbl_namnKontorist";
            this.lbl_namnKontorist.Size = new System.Drawing.Size(35, 13);
            this.lbl_namnKontorist.TabIndex = 0;
            this.lbl_namnKontorist.Text = "Namn";
            // 
            // lbx_reg
            // 
            this.lbx_reg.FormattingEnabled = true;
            this.lbx_reg.Location = new System.Drawing.Point(22, 236);
            this.lbx_reg.Name = "lbx_reg";
            this.lbx_reg.Size = new System.Drawing.Size(189, 134);
            this.lbx_reg.TabIndex = 3;
            // 
            // lbx_lön
            // 
            this.lbx_lön.FormattingEnabled = true;
            this.lbx_lön.Location = new System.Drawing.Point(243, 236);
            this.lbx_lön.Name = "lbx_lön";
            this.lbx_lön.Size = new System.Drawing.Size(189, 134);
            this.lbx_lön.TabIndex = 4;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.Location = new System.Drawing.Point(67, 209);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(79, 24);
            this.lbl_register.TabIndex = 5;
            this.lbl_register.Text = "Register";
            // 
            // lbl_lön
            // 
            this.lbl_lön.AutoSize = true;
            this.lbl_lön.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lön.Location = new System.Drawing.Point(239, 209);
            this.lbl_lön.Name = "lbl_lön";
            this.lbl_lön.Size = new System.Drawing.Size(206, 24);
            this.lbl_lön.TabIndex = 6;
            this.lbl_lön.Text = "LÖNUTBETALNINGAR";
            // 
            // btn_beräkna
            // 
            this.btn_beräkna.Location = new System.Drawing.Point(491, 236);
            this.btn_beräkna.Name = "btn_beräkna";
            this.btn_beräkna.Size = new System.Drawing.Size(128, 23);
            this.btn_beräkna.TabIndex = 7;
            this.btn_beräkna.Text = "Beräkna löner";
            this.btn_beräkna.UseVisualStyleBackColor = true;
            this.btn_beräkna.Click += new System.EventHandler(this.btn_beräkna_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(491, 289);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(95, 13);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "Total lönekostnad:";
            // 
            // tbx_lön
            // 
            this.tbx_lön.Location = new System.Drawing.Point(494, 315);
            this.tbx_lön.Name = "tbx_lön";
            this.tbx_lön.Size = new System.Drawing.Size(125, 20);
            this.tbx_lön.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 388);
            this.Controls.Add(this.tbx_lön);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_beräkna);
            this.Controls.Add(this.lbl_lön);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.lbx_lön);
            this.Controls.Add(this.lbx_reg);
            this.Controls.Add(this.gbx_kontorist);
            this.Controls.Add(this.gbx_kon);
            this.Controls.Add(this.gbx_säljare);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.2";
            this.gbx_säljare.ResumeLayout(false);
            this.gbx_säljare.PerformLayout();
            this.gbx_kon.ResumeLayout(false);
            this.gbx_kon.PerformLayout();
            this.gbx_kontorist.ResumeLayout(false);
            this.gbx_kontorist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_säljare;
        private System.Windows.Forms.Button btn_registeraS;
        private System.Windows.Forms.TextBox tbx_för;
        private System.Windows.Forms.TextBox tbx_prov;
        private System.Windows.Forms.TextBox tbx_namnSäljare;
        private System.Windows.Forms.Label lbl_för;
        private System.Windows.Forms.Label lbl_prov;
        private System.Windows.Forms.Label lbl_namn;
        private System.Windows.Forms.GroupBox gbx_kon;
        private System.Windows.Forms.Button btn_registeraK;
        private System.Windows.Forms.TextBox tbx_arbetadTid;
        private System.Windows.Forms.TextBox tbx_timlön;
        private System.Windows.Forms.TextBox tbx_namnKonsult;
        private System.Windows.Forms.Label lbl_arbetadTid;
        private System.Windows.Forms.Label lbl_timlön;
        private System.Windows.Forms.Label lbl_namnKonsult;
        private System.Windows.Forms.GroupBox gbx_kontorist;
        private System.Windows.Forms.Button btn_registerako;
        private System.Windows.Forms.TextBox tbx_månadLön;
        private System.Windows.Forms.TextBox tbx_namnKontorist;
        private System.Windows.Forms.Label lbl_månad;
        private System.Windows.Forms.Label lbl_namnKontorist;
        private System.Windows.Forms.ListBox lbx_reg;
        private System.Windows.Forms.ListBox lbx_lön;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_lön;
        private System.Windows.Forms.Button btn_beräkna;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox tbx_lön;
    }
}


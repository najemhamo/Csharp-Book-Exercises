namespace Övning_3._8
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bataljon");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvwBataljon = new System.Windows.Forms.TreeView();
            this.ImgBataljon = new System.Windows.Forms.ImageList(this.components);
            this.gbxNyEnhet = new System.Windows.Forms.GroupBox();
            this.tbxAntalSoldater = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.lbl_antal = new System.Windows.Forms.Label();
            this.lbl_namn = new System.Windows.Forms.Label();
            this.btnNyEnhet = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.btn_TaBort = new System.Windows.Forms.Button();
            this.btn_ångra = new System.Windows.Forms.Button();
            this.gbxNyEnhet.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwBataljon
            // 
            this.tvwBataljon.ImageIndex = 0;
            this.tvwBataljon.ImageList = this.ImgBataljon;
            this.tvwBataljon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tvwBataljon.Location = new System.Drawing.Point(13, 13);
            this.tvwBataljon.Name = "tvwBataljon";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Bataljon";
            this.tvwBataljon.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvwBataljon.SelectedImageIndex = 0;
            this.tvwBataljon.Size = new System.Drawing.Size(280, 260);
            this.tvwBataljon.TabIndex = 0;
            this.tvwBataljon.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwBataljon_AfterSelect);
            // 
            // ImgBataljon
            // 
            this.ImgBataljon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgBataljon.ImageStream")));
            this.ImgBataljon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgBataljon.Images.SetKeyName(0, "Bataljon.jpg");
            this.ImgBataljon.Images.SetKeyName(1, "Kompani.jpg");
            this.ImgBataljon.Images.SetKeyName(2, "Pluton.jpg");
            this.ImgBataljon.Images.SetKeyName(3, "Grupp.jpg");
            // 
            // gbxNyEnhet
            // 
            this.gbxNyEnhet.Controls.Add(this.tbxAntalSoldater);
            this.gbxNyEnhet.Controls.Add(this.tbxNamn);
            this.gbxNyEnhet.Controls.Add(this.lbl_antal);
            this.gbxNyEnhet.Controls.Add(this.lbl_namn);
            this.gbxNyEnhet.Controls.Add(this.btnNyEnhet);
            this.gbxNyEnhet.Location = new System.Drawing.Point(315, 13);
            this.gbxNyEnhet.Name = "gbxNyEnhet";
            this.gbxNyEnhet.Size = new System.Drawing.Size(285, 172);
            this.gbxNyEnhet.TabIndex = 1;
            this.gbxNyEnhet.TabStop = false;
            this.gbxNyEnhet.Text = "Lägg till ny enhet";
            // 
            // tbxAntalSoldater
            // 
            this.tbxAntalSoldater.Location = new System.Drawing.Point(135, 81);
            this.tbxAntalSoldater.Name = "tbxAntalSoldater";
            this.tbxAntalSoldater.Size = new System.Drawing.Size(144, 20);
            this.tbxAntalSoldater.TabIndex = 4;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(135, 37);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(144, 20);
            this.tbxNamn.TabIndex = 3;
            // 
            // lbl_antal
            // 
            this.lbl_antal.AutoSize = true;
            this.lbl_antal.Location = new System.Drawing.Point(29, 89);
            this.lbl_antal.Name = "lbl_antal";
            this.lbl_antal.Size = new System.Drawing.Size(74, 13);
            this.lbl_antal.TabIndex = 2;
            this.lbl_antal.Text = "Antal soldater:";
            // 
            // lbl_namn
            // 
            this.lbl_namn.AutoSize = true;
            this.lbl_namn.Location = new System.Drawing.Point(26, 40);
            this.lbl_namn.Name = "lbl_namn";
            this.lbl_namn.Size = new System.Drawing.Size(38, 13);
            this.lbl_namn.TabIndex = 1;
            this.lbl_namn.Text = "Namn:";
            // 
            // btnNyEnhet
            // 
            this.btnNyEnhet.Location = new System.Drawing.Point(158, 133);
            this.btnNyEnhet.Name = "btnNyEnhet";
            this.btnNyEnhet.Size = new System.Drawing.Size(121, 23);
            this.btnNyEnhet.TabIndex = 0;
            this.btnNyEnhet.Text = "Ny enhet";
            this.btnNyEnhet.UseVisualStyleBackColor = true;
            this.btnNyEnhet.Click += new System.EventHandler(this.btnNyEnhet_Click);
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.tbxInfo);
            this.gbxInfo.Location = new System.Drawing.Point(315, 205);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(279, 140);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Information om den valda enhet";
            // 
            // tbxInfo
            // 
            this.tbxInfo.Enabled = false;
            this.tbxInfo.Location = new System.Drawing.Point(7, 20);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(266, 114);
            this.tbxInfo.TabIndex = 0;
            // 
            // btn_TaBort
            // 
            this.btn_TaBort.Location = new System.Drawing.Point(13, 315);
            this.btn_TaBort.Name = "btn_TaBort";
            this.btn_TaBort.Size = new System.Drawing.Size(280, 30);
            this.btn_TaBort.TabIndex = 3;
            this.btn_TaBort.Text = "Ta bort";
            this.btn_TaBort.UseVisualStyleBackColor = true;
            this.btn_TaBort.Click += new System.EventHandler(this.btn_TaBort_Click);
            // 
            // btn_ångra
            // 
            this.btn_ångra.Location = new System.Drawing.Point(13, 279);
            this.btn_ångra.Name = "btn_ångra";
            this.btn_ångra.Size = new System.Drawing.Size(280, 30);
            this.btn_ångra.TabIndex = 4;
            this.btn_ångra.Text = "Ångra";
            this.btn_ångra.UseVisualStyleBackColor = true;
            this.btn_ångra.Click += new System.EventHandler(this.btn_ångra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 357);
            this.Controls.Add(this.btn_ångra);
            this.Controls.Add(this.btn_TaBort);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.gbxNyEnhet);
            this.Controls.Add(this.tvwBataljon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3.8";
            this.gbxNyEnhet.ResumeLayout(false);
            this.gbxNyEnhet.PerformLayout();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwBataljon;
        private System.Windows.Forms.GroupBox gbxNyEnhet;
        private System.Windows.Forms.Label lbl_antal;
        private System.Windows.Forms.Label lbl_namn;
        private System.Windows.Forms.Button btnNyEnhet;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxAntalSoldater;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Button btn_TaBort;
        private System.Windows.Forms.ImageList ImgBataljon;
        private System.Windows.Forms.Button btn_ångra;
    }
}


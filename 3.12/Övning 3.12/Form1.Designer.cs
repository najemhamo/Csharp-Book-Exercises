namespace Övning_3._12
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
            this.lbxTitle = new Övning_3._12.LabeledTextBox();
            this.lbxEfterNamn = new Övning_3._12.LabeledTextBox();
            this.lbxFörnamn = new Övning_3._12.LabeledTextBox();
            this.SuspendLayout();
            // 
            // lbxTitle
            // 
            this.lbxTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbxTitle.LedText = "Titel";
            this.lbxTitle.Location = new System.Drawing.Point(27, 108);
            this.lbxTitle.Name = "lbxTitle";
            this.lbxTitle.Size = new System.Drawing.Size(146, 20);
            this.lbxTitle.TabIndex = 2;
            this.lbxTitle.Text = "Titel";
            // 
            // lbxEfterNamn
            // 
            this.lbxEfterNamn.ForeColor = System.Drawing.Color.Gray;
            this.lbxEfterNamn.LedText = "Efternamn";
            this.lbxEfterNamn.Location = new System.Drawing.Point(27, 73);
            this.lbxEfterNamn.Name = "lbxEfterNamn";
            this.lbxEfterNamn.Size = new System.Drawing.Size(146, 20);
            this.lbxEfterNamn.TabIndex = 1;
            this.lbxEfterNamn.Text = "Efternamn";
            // 
            // lbxFörnamn
            // 
            this.lbxFörnamn.ForeColor = System.Drawing.Color.Gray;
            this.lbxFörnamn.LedText = "Förnamn";
            this.lbxFörnamn.Location = new System.Drawing.Point(27, 34);
            this.lbxFörnamn.Name = "lbxFörnamn";
            this.lbxFörnamn.Size = new System.Drawing.Size(146, 20);
            this.lbxFörnamn.TabIndex = 0;
            this.lbxFörnamn.Text = "Förnamn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 150);
            this.Controls.Add(this.lbxTitle);
            this.Controls.Add(this.lbxEfterNamn);
            this.Controls.Add(this.lbxFörnamn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3.12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabeledTextBox lbxFörnamn;
        private LabeledTextBox lbxEfterNamn;
        private LabeledTextBox lbxTitle;
    }
}


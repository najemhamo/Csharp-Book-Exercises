namespace Övning_3._11
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
            this.textBoxCharacterCount3 = new Övning_3._11.TextBoxCharacterCount();
            this.textBoxCharacterCount2 = new Övning_3._11.TextBoxCharacterCount();
            this.textBoxCharacterCount1 = new Övning_3._11.TextBoxCharacterCount();
            this.SuspendLayout();
            // 
            // textBoxCharacterCount3
            // 
            this.textBoxCharacterCount3.Location = new System.Drawing.Point(40, 241);
            this.textBoxCharacterCount3.Name = "textBoxCharacterCount3";
            this.textBoxCharacterCount3.Size = new System.Drawing.Size(301, 76);
            this.textBoxCharacterCount3.TabIndex = 2;
            // 
            // textBoxCharacterCount2
            // 
            this.textBoxCharacterCount2.Location = new System.Drawing.Point(40, 139);
            this.textBoxCharacterCount2.Name = "textBoxCharacterCount2";
            this.textBoxCharacterCount2.Size = new System.Drawing.Size(301, 80);
            this.textBoxCharacterCount2.TabIndex = 1;
            // 
            // textBoxCharacterCount1
            // 
            this.textBoxCharacterCount1.Location = new System.Drawing.Point(40, 33);
            this.textBoxCharacterCount1.Name = "textBoxCharacterCount1";
            this.textBoxCharacterCount1.Size = new System.Drawing.Size(301, 77);
            this.textBoxCharacterCount1.TabIndex = 0;
            this.textBoxCharacterCount1.Load += new System.EventHandler(this.textBoxCharacterCount1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 329);
            this.Controls.Add(this.textBoxCharacterCount3);
            this.Controls.Add(this.textBoxCharacterCount2);
            this.Controls.Add(this.textBoxCharacterCount1);
            this.Name = "Form1";
            this.Text = "3.11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxCharacterCount textBoxCharacterCount1;
        private TextBoxCharacterCount textBoxCharacterCount2;
        private TextBoxCharacterCount textBoxCharacterCount3;
    }
}


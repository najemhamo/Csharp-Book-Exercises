using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._12
{
    class LabeledTextBox : TextBox
    {

        private string ledText;
        public string LedText
        {
            get { return ledText; }
            set { ledText = value; Text = value; ForeColor = System.Drawing.Color.Gray; }
        }
        

       [Category("Appearnace"), Description("Label text."), DefaultValue("...")]

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            
            if (Text.Equals(ledText))
            {
                Text = "";
                
            }
           
            ForeColor = System.Drawing.Color.Black;
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
          
            if (Text.Equals(""))
            {
                ForeColor = System.Drawing.Color.Gray;
                Text = ledText;
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

           
            if (Text.Equals(ledText))
            {
                SelectionStart = 0;

            }
        }
    }
}

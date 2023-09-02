using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._8
{
    public partial class Form1 : Form
    {

        const int BATALJON = 0, KOMPANI = 1, PLUTON = 2, GRUPP = 3;

      
        Stack<TreeNode> nodar = new Stack<TreeNode>();

        private string[] info = { "Bataljon", "Kompani", "Pluton", "Grupp" };

       

        public Form1()
        {
            InitializeComponent();
            
            tvwBataljon.SelectedNode = tvwBataljon.Nodes[0];

            
            
        }

        private void btn_ångra_Click(object sender, EventArgs e)
        {
            
                nodar.Pop().Remove();
            
            
            
            
        }

        private void btnNyEnhet_Click(object sender, EventArgs e)
        {
           
            TreeNode valdNode = tvwBataljon.SelectedNode;
            

            if (valdNode != null)
            {
                TreeNode NyNode = new TreeNode(tbxNamn.Text);
                valdNode.Nodes.Add(NyNode);
                nodar.Push(NyNode);

                
                NyNode.ImageIndex = NyNode.Level;

                
                if (NyNode.Level == GRUPP)
                {
                    NyNode.Tag = int.Parse(tbxAntalSoldater.Text);
                    
                }

            }
        }

        private void tvwBataljon_AfterSelect(object sender, TreeViewEventArgs e)
        {

            
            TreeNode valdNode = tvwBataljon.SelectedNode;

            
            
            tbxInfo.Text = info[valdNode.Level];
            tbxInfo.AppendText("\r\nNamn: " + valdNode.Text);
            
            
            tbxInfo.AppendText("\r\nSoldater: " + RäknaSoldater(valdNode));
            
          
            if(valdNode.Level == GRUPP)
            {
                gbxNyEnhet.Enabled = false;
               

            }else
            {
             
                
                gbxNyEnhet.Enabled = true;
            }

            
            if(valdNode.Level == PLUTON)
            {
                tbxAntalSoldater.Enabled = true;
            }else
            {
                tbxAntalSoldater.Enabled = false;
            }

            

        }

        private void btn_TaBort_Click(object sender, EventArgs e)
        {
            TreeNode valdNode = tvwBataljon.SelectedNode;
            valdNode.Remove();
        }

     
        private int RäknaSoldater(TreeNode t)
        {
            int soldater = 0;
            if (t.Level == GRUPP)
            {
                soldater = int.Parse(t.Tag.ToString());
            }
            else
            {
                foreach (TreeNode n in t.Nodes)
                {
                    if (n.Level == GRUPP)
                    {
                        soldater += int.Parse(n.Tag.ToString());
                    }
                    else
                    {
                        soldater += RäknaSoldater(n);
                    }
                }
            }
            return soldater;
        }
    }
}

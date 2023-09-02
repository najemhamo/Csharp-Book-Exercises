using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Övning_5._1_Server
{
    public partial class Form1 : Form
    {
        bool doi = true;
        UdpClient klient;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ta_Click(object sender, EventArgs e)
        {
         
            IPEndPoint motagaren = new IPEndPoint(IPAddress.Any, 0);

           
            if (doi)
            {
                klient = new UdpClient(int.Parse(tbx_port.Text));
                doi = false;
            }

            
            string text = Encoding.Unicode.GetString(klient.Receive(ref motagaren));

            tbx_medelande.Text = text;
        }
    }
}

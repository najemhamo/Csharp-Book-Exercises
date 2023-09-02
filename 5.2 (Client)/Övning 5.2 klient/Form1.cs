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

namespace Övning_5._2_klient
{
    public partial class Form1 : Form
    {
        TcpClient klient;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_anslut_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(tbx_ip.Text);

          
            klient = new TcpClient();
            klient.NoDelay = true;

            klient.Connect(adress, port);

            btn_send.Enabled = true;
            btn_anslut.Enabled = false;

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            
            byte []data = Encoding.Unicode.GetBytes(tbx_medelande.Text);

           
            klient.GetStream().Write(data,0,data.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_skicka_Click(object sender, EventArgs e)
        {
           
            IPAddress ip = IPAddress.Parse(tbx_ip.Text);

            
            IPEndPoint destination = new IPEndPoint(ip, int.Parse(tbx_port.Text));

            
            UdpClient klient = new UdpClient();

            
            byte[] data = Encoding.Unicode.GetBytes(tbx_medelande.Text);

            
            klient.Send(data,data.Length,destination);
        }
    }
}

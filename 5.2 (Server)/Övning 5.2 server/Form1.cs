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

namespace Övning_5._2_server
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient klient;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ta_Click(object sender, EventArgs e)
        {
            
            byte[] bytes = new byte[1000];
            int längd = klient.GetStream().Read(bytes,0,bytes.Length);

            string text = Encoding.Unicode.GetString(bytes,0,längd);

            tbx_medelande.Text = text;
        }

        private void btn_starta_Click(object sender, EventArgs e)
        {
            
            listener = new TcpListener(IPAddress.Any,port);
            listener.Start();

            klient = listener.AcceptTcpClient();

            btn_starta.Enabled = false;
            btn_ta.Enabled = true;
        }
    }
}

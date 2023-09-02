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

namespace Övning_5._3_klient
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
           
                StartaAnslutning();
            
        }

        public async void StartaAnslutning()
        {
            try
            {
                klient = new TcpClient();
                klient.NoDelay = true;

                IPAddress ip = IPAddress.Parse(tbx_ip.Text);
                await klient.ConnectAsync(ip,port);

                btn_anslut.Enabled = false;
                btn_send.Enabled = true;
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            skicka();
        }

        public async void skicka()
        {
            byte[] Data = Encoding.Unicode.GetBytes(tbx_medelande.Text);

            try
            {
                await klient.GetStream().WriteAsync(Data,0,Data.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

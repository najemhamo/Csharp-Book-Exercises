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

namespace Övning_5._4_klient
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
            connect();
        }

        public async void connect()
        {
            IPAddress ip = IPAddress.Parse(tbx_IP.Text);

            klient = new TcpClient();
            klient.NoDelay = true;

            try
            {
                
                await klient.ConnectAsync(ip,port);

                btn_höger.Enabled = true;
                btn_ner.Enabled = true;
                btn_up.Enabled = true;
                btn_vänster.Enabled = true;

                
                btn_anslut.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        
        public async void skicka(int YX, int Data)
        {
            
                  
            byte[] yx = BitConverter.GetBytes(YX);
            byte[] data = BitConverter.GetBytes(Data);

            try
            {
           
                await klient.GetStream().WriteAsync(yx, 0, yx.Length);
                await klient.GetStream().WriteAsync(data, 0, data.Length);
                
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            
            skicka(1, -10);
        }

        private void btn_höger_Click(object sender, EventArgs e)
        {
            
            skicka(0, 10);
        }

        private void btn_ner_Click(object sender, EventArgs e)
        {
            
            skicka(1, 10);
        }

        private void btn_vänster_Click(object sender, EventArgs e)
        {
          
            skicka(0,-10);
        }
    }
}

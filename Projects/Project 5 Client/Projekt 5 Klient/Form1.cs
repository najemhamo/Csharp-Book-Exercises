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

namespace Projekt_5_Klient
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
            // Metoden Anslut anrops 
            Anslut();
        }
        // Metoden anslut ansluter klienten till servern
        public async void Anslut()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(tbx_IP.Text);
           
            klient = new TcpClient();
            klient.NoDelay = true;

            
                await klient.ConnectAsync(ip, port);
                
                // Metoden Läsa anrops för att läsa meddelande från servern  
                Läsa();
                tbx_chat.Enabled = true;
                tbx_medelande.Enabled = true;
                btn_skicka.Enabled = true;

                btn_anslut.Enabled = false;
                tbx_IP.Enabled = false;
                tbx_Användare.Enabled = false;
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        // Metoden Läsa läser allt som skickas från servern
        public async void Läsa()
        {
            try
            {
                
                byte[] data = new byte[1000];


                int n = await klient.GetStream().ReadAsync(data,0,data.Length);

                // Bytes omvandlas till string här
                string text = Encoding.Unicode.GetString(data,0,n);

               
                tbx_chat.AppendText(text);

                // Metoden Läsa anrops igen för att vänta nya medelande från servern
                Läsa();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Metoden Skriva skickar medelanden till servern
        public async void Skriva()
        {
            // Medelandet innehåller användarnamnet och medelandet, de omvandlas till byte
            byte[] data = Encoding.Unicode.GetBytes(tbx_Användare.Text + "> " + tbx_medelande.Text + "\n");

            try
            {
                await klient.GetStream().WriteAsync(data,0,data.Length);
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Knappen skicka anropar metoden Skriva
        private void btn_skicka_Click(object sender, EventArgs e)
        {
            
            Skriva();
        }
    }
}

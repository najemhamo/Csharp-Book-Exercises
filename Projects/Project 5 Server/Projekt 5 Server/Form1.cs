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

namespace Projekt_5_Server
{
    public partial class Form1 : Form
    {
       
        int port = 12345;
        TcpListener Lysnare;

        // Listan klient ska innehålla alla klienter som konektar servern
        List<TcpClient> klient = new List<TcpClient>();
       
        public Form1()
        {
            InitializeComponent();
            Lysnare = new TcpListener(IPAddress.Any, port);

            Lysnare.Start();
            Anslut();
        }
        // Metoden Anslut ansluter servern med klienten 
        public async void Anslut()
        {
           try
            {
                TcpClient klent = await Lysnare.AcceptTcpClientAsync();
                klient.Add(klent);


                Skriva(klent);
                Läsa(klent);

                // Metoden Anslut anropas igen för att ansluta servern med andra klienter
                Anslut();

                
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Metoden Läsa vänter på medelande från klienten och skickar den till alla klienter i listan
        public async void Läsa(TcpClient k)
        {
            byte[] data = new byte[1000];

            try
            {
               
                int n = await k.GetStream().ReadAsync(data,0,data.Length);

                string medelande = Encoding.Unicode.GetString(data);
                lbx_chat.Items.Add(medelande);

                foreach (TcpClient kl in klient)
                {
                    if (kl.Connected)
                    {
                        await kl.GetStream().WriteAsync(data, 0, data.Length);
                    }
                    
                }
                // Metoden Läsa anrops igen för att vänta på nästa meddelande från klienten
                Läsa(k);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoden Skriva är för att skicka alla gamla texter till den nya klienten.
        public async void Skriva(TcpClient k)
        {
            try
            {
                foreach(string text in lbx_chat.Items)
                {
                    byte[] data = Encoding.Unicode.GetBytes(text);
                    await k.GetStream().WriteAsync(data, 0, data.Length);
                }
                


            }catch(Exception error)
            {
                MessageBox.Show(error.Message,null,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

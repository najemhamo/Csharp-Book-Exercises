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

namespace Övning_5._3_server
{
    public partial class Form1 : Form
    {
        TcpListener lisnare;
        TcpClient klient;
        int port = 12345;

        
        public Form1()
        {
            InitializeComponent();

            Anslut();

        }

        public async void Anslut()
        {
            try
            {
                lisnare = new TcpListener(IPAddress.Any, port);

                lisnare.Start();

                klient = await lisnare.AcceptTcpClientAsync();

                Vänta(klient);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }


        }

        public async void Vänta(TcpClient k)
        {
            try
            {
                byte[] data = new byte[1000];
                int längd =await k.GetStream().ReadAsync(data,0,data.Length);

                tbx_medelanden.AppendText(Encoding.Unicode.GetString(data,0,längd) + "\n");

                Vänta(k);
            }catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

      
    }
}

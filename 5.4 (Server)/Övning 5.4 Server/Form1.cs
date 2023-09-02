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

namespace Övning_5._4_Server
{
    public partial class Form1 : Form
    {
        TcpListener Lysnare;
        TcpClient klient;
        int port = 12345;
        int YX = 0;

        public Form1()
        {
            InitializeComponent();
            Anslut();
        }
        
        public async void Anslut()
        {
            
            Lysnare = new TcpListener(IPAddress.Any,port);

            Lysnare.Start();

            try
            {
                
                klient = await Lysnare.AcceptTcpClientAsync();

             
                Move();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
       
        public async void Move()
        {
            byte[] data = new byte[1000];

            try
            {
                
                int n = await klient.GetStream().ReadAsync(data, 0, data.Length);

                
                int siff = BitConverter.ToInt32(data,0);

               
                
                if(siff == 0)
                {
                    YX = 0;
                }else if(siff == 1)
                {
                    YX = 1;
                }else
                {
                  
                    if(YX == 0)
                    {
                        pbx_flygplan.Location = new Point(pbx_flygplan.Location.X + siff,pbx_flygplan.Location.Y);
                    }else if(YX == 1)
                    {
                        pbx_flygplan.Location = new Point(pbx_flygplan.Location.X, pbx_flygplan.Location.Y + siff);
                    }
                }

                
                Move();
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       
    }
}

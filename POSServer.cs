using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSIL_POS
{
    public partial class POSServer : Form
    {
        IPAddress IP;
        int Port;
        bool open = false;
        TcpListener m_listener;
        TcpClient m_client;
        NetworkStream m_stream;
        NetworkStream temp_stream;
        StreamReader m_read;
        StreamWriter temp_write;
        StreamWriter m_write;
        Thread t_server;
        Thread t_read;
        bool connected;
        public POSServer()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (BtnOpen.Text == "서버 끄기")
            {
                try
                {
                    methodClose();
                }
                catch
                { }
                BtnOpen.Text = "서버 켜기";
            }
            else
            {
                try
                {
                    IP = IPAddress.Parse(TxtIP.Text);
                    Port = int.Parse(TxtPort.Text);
                    m_listener = new TcpListener(IP, Port);
                    m_listener.Start();
                    t_server = new Thread(new ThreadStart(Server));
                    t_server.Start();
                    open = true;
                    BtnOpen.Text = "서버 끄기";
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("잘못된 IP / PORT 입력 혹은 Port가 사용 중인 번호입니다.");
                }
            }
        }

        private void Server()
        {
            while(true)
            {
                try
                {
                    m_client = m_listener.AcceptTcpClient();
                    if (connected)
                    {
                        temp_stream = m_client.GetStream();
                        temp_write = new StreamWriter(temp_stream);
                        temp_write.WriteLine("AlreadyConnected");
                        temp_write.Close();
                        temp_stream.Close();
                        return;
                    }
                    else
                    {
                        m_stream = m_client.GetStream();
                        m_write = new StreamWriter(m_stream);
                        m_read = new StreamReader(m_stream);
                        t_read = new Thread(new ThreadStart(reader));
                        t_read.Start();
                        connected = true;
                    }
                }
                catch
                {
                }

            }
        }

        public void reader()
        {
            String Message;
            while(true)
            {
                Message = m_read.ReadLine();
                if (Message == "Disconnect")
                {
                    m_write.Close();
                    m_read.Close();
                    m_stream.Close();
                    connected = false;
                    return;
                }
            }
        }

        public void sendrequest(string m)
        {
            if (connected)
            {
                m_write.WriteLine(m);
                m_write.Flush();
            }
        }

        private void POSServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void methodClose()
        {
            try
            {
                m_write.WriteLine("Serverclosed");
                m_write.Flush();
                m_write.Close();
                m_read.Close();
                m_stream.Close();
                m_listener.Stop();
                t_read.Abort();
                t_server.Abort();
            }
            catch
            {

            }
        }
    }
}

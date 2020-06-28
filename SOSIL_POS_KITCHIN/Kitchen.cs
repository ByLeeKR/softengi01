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

namespace SOSIL_POS_KITCHIN
{
    public partial class Kitchen : Form
    {
        int num = 1;
        IPAddress IP;
        int Port;
        bool connected = false;
        TcpClient m_client;
        NetworkStream m_stream;
        StreamReader m_read;
        StreamWriter m_write;
        string Message;
        string[] order;
        Thread Receiver;
        ServerLogin Parents;
        public Kitchen(ServerLogin Father)
        {
            InitializeComponent();
            Parents = Father;
        }

        public void OpenRequest(IPAddress I, int P)
        {
            m_client = new TcpClient();
            if (connected)
            {
                MessageBox.Show("이미 연결되어있습니다.");
                return;
            }
            try
            {
                m_client.Connect(I, P);
                m_stream = m_client.GetStream();
                m_read = new StreamReader(m_stream);
                m_write = new StreamWriter(m_stream);
                Receiver = new Thread(new ThreadStart(Receive));
                Receiver.Start();
                connected = true;
            }
            catch
            {
                MessageBox.Show("서버에 연결 실패");
                Parents.Show();
                this.Close();
                return;
            }
        }

        public void Receive()
        {
            while(true)
            {
                Message = m_read.ReadLine();
                if (Message == "AlreadyConnected")
                {
                    MessageBox.Show("이미 다른 클라이언트가 연결되어있습니다");
                    return;
                }
                else if (Message == "Serverclosed")
                {
                    m_read.Close();
                    m_write.Close();
                    m_client.Close();
                    connected = false;
                    MessageBox.Show("서버가 종료되었습니다");
                    return;

                }
                else
                {
                    ChkLBox.Items.Add(num.ToString() + " " + Message);
                    num++;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int a = ChkLBox.CheckedItems.Count;
            for (int i=0; i<a; i++)
            {
                ChkLBox.Items.Remove(ChkLBox.CheckedItems[0]);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (m_read != null)
            {
                m_read.Close();
                m_client.Close();
                Receiver.Abort();
            }
            Parents.Show();
            this.Close();
        }

        private void Kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(m_read != null)
            {
                m_write.WriteLine("Disconnect");
                m_write.Flush();
                m_read.Close();
                m_write.Close();
                m_client.Close();
                Receiver.Abort();
            }
            Parents.Show();
        }
    }
}

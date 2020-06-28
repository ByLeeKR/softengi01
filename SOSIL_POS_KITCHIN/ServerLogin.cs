using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSIL_POS_KITCHIN
{
    public partial class ServerLogin : Form
    {
        IPAddress IP;
        int Port;
        public ServerLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtIP.Text == "" || TxtPort.Text == "")
            {
                MessageBox.Show("IP, Port를 입력해주세요");
                return;
            }
            try
            {
                IP = IPAddress.Parse(TxtIP.Text);
                Port = int.Parse(TxtPort.Text);
            }
            catch
            {
                MessageBox.Show("잘못된 IP / PORT 입력입니다");
                return;
            }
            Kitchen form = new Kitchen(this);
            this.Hide();
            form.Show();
            form.OpenRequest(IP, Port);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//MySQL NuGet패키지 인스톨 및 라이브러리 선언
//MySQL 설치 시 가급적 Uid / Password는 root로 부탁드립니다.
//DB 포트는 3306으로 이용 부탁드립니다.

namespace SOSIL_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PicLogin.Image = Properties.Resources.SchoolLogo;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtID.Text == "" || TxtPW.Text == "" || TxtPort.Text == "")  // 입력되지 않은 경우
            {
                MessageBox.Show("ID, 패스워드 혹은 Root가 입력되지 않았습니다.");
            }
            else //DB 연결 시도
            {
                string SQLLOGIN = "Server=Localhost; Port=" + TxtPort.Text + "; Database=test; Uid="
                    + TxtID.Text + "; Pwd=" + TxtPW.Text;
                MySqlConnection connection = new MySqlConnection(SQLLOGIN);

                try
                {
                    connection.Open();  // 연결 시도
                    MessageBox.Show("연결되었습니다! POS프로그램을 실행합니다");
                    connection.Close(); //차후 연결이 필요할때마다 연결? 일단 Form 1에서는 Disconnect
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("연결이 거부되었습니다! \r\n" + ex);
                }
            }
        }
    }
}

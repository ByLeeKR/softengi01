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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtID.Text == "" || TxtPW.Text == "" || TxtPort.Text == "")  // 입력되지 않은 경우
            {
                MessageBox.Show("ID, 패스워드 혹은 Root가 입력되지 않았습니다.");
            }
            else //입력된 값이 있을 경우 DB 연결 시도
            {
                string SQLLOGIN = "Server=Localhost; Port=" + TxtPort.Text + "; Database=test; Uid="
                    + TxtID.Text + "; Pwd=" + TxtPW.Text;
                MySqlConnection connection = new MySqlConnection(SQLLOGIN);

                try
                {
                    connection.Open();  // 연결 시도
                    MessageBox.Show("연결되었습니다! POS프로그램을 실행합니다");
                    connection.Close(); //차후 연결이 필요할때마다 연결? 일단 Form 1에서는 Disconnect
                    POSMain Form = new POSMain();
                    Form.LoginDataLoad(SQLLOGIN, this);   //또한 SQL 정보를 자식 폼에게 전달
                    Form.Show();
                    this.Hide();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("연결이 거부되었습니다! \r\n" + ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unknown Exception: \r\n" + ex);
                }
            }
        }

        private void BtnOffline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("설계 중...");
        }
    }
}

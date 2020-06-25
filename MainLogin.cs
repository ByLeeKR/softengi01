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
                string SQLLOGIN = "Server=Localhost; Port=" + TxtPort.Text + "; Database=; Uid="
                    + TxtID.Text + "; Pwd=" + TxtPW.Text;
                MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                try
                {
                    connection.Open();  // 연결 시도
                    MessageBox.Show("연결되었습니다! POS프로그램을 실행합니다");
                    string query = "USE SOSIL_POS";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch //DB가 없을 때, DB와 테이블을 만든다
                    {
                        string DBcreate = "CREATE DATABASE SOSIL_POS default CHARACTER SET UTF8";
                        MySqlCommand createDB = new MySqlCommand(DBcreate, connection);
                        createDB.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                        DBcreate = "CREATE TABLE MENUDATA(`name` VARCHAR(20) PRIMARY KEY NOT NULL," +
                        "`price` INT NOT NULL);";
                        createDB = new MySqlCommand(DBcreate, connection);
                        createDB.ExecuteNonQuery();
                        command.ExecuteNonQuery(); // 만들고 다시 연결
                    }

                    //오늘 날짜의 매출 기록용 DB
                    string date = DateTime.Now.ToString("yyyyMMdd");
                    //DB 생성 여부를 질의
                    query = "SHOW TABLES LIKE '" + date + "'";
                    command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    try 
                    {
                        //이미 생성되어있는 경우
                        if (reader[0] != DBNull.Value)
                        {
                            reader.Close();
                        }
                    }
                    catch (MySqlException)
                    {
                        //생성되지 않아 Exception 발생 시 새로 생성
                        reader.Close();
                        query = "CREATE TABLE `" + date + "`(num INT PRIMARY KEY AUTO_INCREMENT," +
                                "`times` CHAR(10) NOT NULL," +
                                "`sales` INT NOT NULL);";
                        MySqlCommand CreateDaily = new MySqlCommand(query, connection);
                        CreateDaily.ExecuteNonQuery();
                        MessageBox.Show("좋은 하루 되세요."); //첫 기동시에만 나옴
                    }

                    connection.Close();
                    SQLLOGIN = "Server=Localhost; Port=" + TxtPort.Text + "; Database=SOSIL_POS; Uid="
                    + TxtID.Text + "; Pwd=" + TxtPW.Text;
                    POSMain Form = new POSMain(SQLLOGIN, this);
                    Form.Show();
                    this.Hide();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("연결이 거부되었습니다! \r\n 로그인 데이터 및 MYSQL상태를 확인해주세요." + ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unknown Exception: \r\n" + ex);
                }
            }
        }

        private void BtnOffline_Click(object sender, EventArgs e)
        {
            POSMain Form = new POSMain("Offline", this);
            Form.Show();
            this.Hide();
            //MessageBox.Show("설계 중...");
        }

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dev.mysql.com/downloads/mysql/");
        }
    }
}

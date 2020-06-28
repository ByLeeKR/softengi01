using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSIL_POS
{
    public partial class MenuManage : Form
    {
        private string SQLLOGIN;
        DataSet dataset = new DataSet();
        public MenuManage(string sql)
        {
            SQLLOGIN = sql;
            InitializeComponent();
        }

        private void MenuManage_Load(object sender, EventArgs e)
        {
            if (SQLLOGIN != "Offline")
            {
                MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                string query = "SELECT * FROM menudata";
                MySqlDataAdapter adapt = new MySqlDataAdapter(query, connection);
                adapt.Fill(dataset, "menudata");

                //메뉴에 출력
                MenuView.DataSource = dataset.Tables["menudata"];
            }
            else
            {
                MessageBox.Show("MySQL에 연결되지 않았습니다.");
            }
        }

        //입력된 내용 DB에 추가하기
        private void BtnMenuAdd_Click(object sender, EventArgs e)
        {
            if (TxtMenuName.Text == "" && TxtMenuPrice.Text == "")
            {
                MessageBox.Show("메뉴 이름 혹은 금액이 미입력되었습니다.");
                return;
            }
            if (SQLLOGIN != "Offline")
            {
                //일단 숫자가 맞는지 확인
                try
                {
                    int.Parse(TxtMenuPrice.Text);
                }
                catch
                {
                    MessageBox.Show("입력된 메뉴의 Price가 숫자가 아닙니다");
                    return;
                }
                try
                {
                    //SQL에 로그인하여 추가 질의
                    MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                    connection.Open();
                    string query = "INSERT INTO menudata VALUES('" + TxtMenuName.Text + "', " + TxtMenuPrice.Text + ");";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    //뷰 갱신
                    dataset.Tables["menudata"].Clear();
                    query = "SELECT * FROM menudata";
                    MySqlDataAdapter adapt = new MySqlDataAdapter(query, connection);
                    adapt.Fill(dataset, "menudata");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("이미 생성되어 있는 메뉴입니다");
                }
            }
            else
            {
                MessageBox.Show("MySQL에 연결되지 않으면 동작하지 않습니다");
            }
        }

        //선택된 메뉴를 DB에서 삭제
        private void BtnMenuDelete_Click(object sender, EventArgs e)
        {
            if (SQLLOGIN != "Offline")
            {
                //선택된 메뉴 이름 가지고 오기
                string name = MenuView.CurrentRow.Cells["name"].Value.ToString();

                //SQL에 로그인하여 삭제 질의
                MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                connection.Open();
                string query = "DELETE FROM menudata WHERE NAME = '" + name + "';";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                //뷰 갱신
                dataset.Tables["menudata"].Clear();
                query = "SELECT * FROM menudata";
                MySqlDataAdapter adapt = new MySqlDataAdapter(query, connection);
                adapt.Fill(dataset, "menudata");
                connection.Close();
            }
            else
            {
                MessageBox.Show("MySQL에 연결되지 않으면 동작하지 않습니다");
            }

        }
    }
}

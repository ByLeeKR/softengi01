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
    public partial class Pay : Form
    {
        int TableNumber;
        int Fullcost;
        string SQLLOGIN;
        POSMain father;
        public Pay(int cost, int tnumber, string sql, POSMain parent)
        {
            TableNumber = tnumber;
            SQLLOGIN = sql;
            Fullcost = cost;
            father = parent;
            InitializeComponent();
        }



        private void BtnPad_Click(object sender, EventArgs e)
        {
            int cost;
            //만약 입력된 값이 없으면
            if(TxtPay.TextLength == 0)
            {
                switch(((Button)sender).Text)
                {
                    case "0":
                    case "00":
                    case "000":
                        break;
                    case "1":
                        TxtPay.Text = "1";
                        break;
                    case "2":
                        TxtPay.Text = "2";
                        break;
                    case "3":
                        TxtPay.Text = "3";
                        break;
                    case "4":
                        TxtPay.Text = "4";
                        break;
                    case "5":
                        TxtPay.Text = "5";
                        break;
                    case "6":
                        TxtPay.Text = "6";
                        break;
                    case "7":
                        TxtPay.Text = "7";
                        break;
                    case "8":
                        TxtPay.Text = "8";
                        break;
                    case "9":
                        TxtPay.Text = "9";
                        break;
                }
            }
            else
            {
                cost = int.Parse(TxtPay.Text);
                switch (((Button)sender).Text)
                {
                    case "0":
                        cost = cost * 10;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "00":
                        cost = cost * 100;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "000":
                        cost = cost * 1000;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "1":
                        cost = cost * 10;
                        cost = cost + 1;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "2":
                        cost = cost * 10;
                        cost = cost + 2;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "3":
                        cost = cost * 10;
                        cost = cost + 3;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "4":
                        cost = cost * 10;
                        cost = cost + 4;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "5":
                        cost = cost * 10;
                        cost = cost + 5;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "6":
                        cost = cost * 10;
                        cost = cost + 6;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "7":
                        cost = cost * 10;
                        cost = cost + 7;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "8":
                        cost = cost * 10;
                        cost = cost + 8;
                        TxtPay.Text = cost.ToString();
                        break;
                    case "9":
                        cost = cost * 10;
                        cost = cost + 9;
                        TxtPay.Text = cost.ToString();
                        break;
                }
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            LblTableNum.Text = "테이블 번호: " + TableNumber + "번";
            TxtCost.Text = Fullcost.ToString();
        }

        private void TxtPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cost = int.Parse(TxtCost.Text);
                int pay = int.Parse(TxtPay.Text);
                int change = cost - pay;
                TxtChange.Text = change.ToString();
            }
            catch
            { }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtPay.Text = "0";
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int change = int.Parse(TxtChange.Text);
                string date = DateTime.Now.ToString("yyyyMMdd");
                string time = DateTime.Now.ToString("HH:mm:ss");
                if (change <= 0)
                {
                    if (MessageBox.Show("거스름돈은 "+ change*-1 + "원 입니다. \r\n결제 하시겠습니까?", "결제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //DB에 접속해서 매출 기록 남기기 (결제 금액 기반)
                        MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                        connection.Open();
                        string query = "INSERT INTO `" + date + "` (times, sales) VALUES('" + time + "', " + TxtCost.Text + ");";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        //메인 화면의 테이블 정보 및 표기를 삭제
                        father.TableListViewInitialize();
                        father.TableInitialize(TableNumber - 1);
                        father.TableCostEdit(0, TableNumber - 1);
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (change > 0)
                {
                    //강제 결제 여부 확인
                    if (MessageBox.Show("충분한 금액이 지불되지 않았습니다.\r\n강제 결제 하시겠습니까?", "결제 경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                        connection.Open();
                        string query = "INSERT INTO `" + date + "` (times, sales) VALUES('" + time + "', " + TxtPay.Text + ");";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        //메인 화면의 테이블 정보 및 표기를 삭제
                        father.TableListViewInitialize();
                        father.TableInitialize(TableNumber - 1);
                        father.TableCostEdit(0, TableNumber - 1);
                        this.Close();
                    }
                    else
                    {
                        return;
                    } 
                }
            }
            catch
            {
                MessageBox.Show("결제 오류: 결제 요청 값이 없습니다");
            }
            
        }
    }
}

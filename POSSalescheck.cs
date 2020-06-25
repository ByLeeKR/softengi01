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

namespace SOSIL_POS
{
    public partial class POSSalescheck : Form
    {
        int year = int.Parse(DateTime.Now.ToString("yyyy"));
        int Month = int.Parse(DateTime.Now.ToString("MM"));
        int Day = int.Parse(DateTime.Now.ToString("dd"));
        DataSet dataset = new DataSet();
        private string SQLLOGIN;

        public POSSalescheck(string sql)
        {
            SQLLOGIN = sql;
            InitializeComponent();
            ComboYear.Items.Clear();
            for (int i = year - 10; i < year + 10; i++)
            {
                ComboYear.Items.Add(i.ToString());
            }
            ComboYear.Text = year.ToString();
            ComboMonth.Text = Month.ToString();
            ComboDay.Text = Day.ToString();
            callSales(); //당일 매출을 일단 불러옴
        }

        private void ComboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Month 선택에 따라 아이템 추가
            ComboDay.Items.Clear(); //Day 아이템 모두 제거
            switch(ComboMonth.SelectedIndex)
            {
                //1월부터~12월
                case 0:
                    for(int i =1; i<32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 1:
                    try
                    {
                        if (int.Parse(ComboYear.SelectedItem.ToString()) % 4 == 0)
                        {
                            for (int i = 1; i < 29; i++)
                            {
                                ComboDay.Items.Add(i.ToString());
                            }
                            break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("2월은 윤달로 인해 Year 입력이 없으면 계산이 불가능합니다.");
                    }
                    for (int i = 1; i < 29; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 2:
                    for (int i = 1; i < 32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 3:
                    for (int i = 1; i < 31; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 4:
                    for (int i = 1; i < 32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 5:
                    for (int i = 1; i < 31; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 6:
                    for (int i = 1; i < 32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 7:
                    for (int i = 1; i < 32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 8:
                    for (int i = 1; i < 31; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 9:
                    for (int i = 1; i < 32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 10:
                    for (int i = 1; i < 31; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
                case 11:
                    for (int i = 1; i < 32; i++)
                    {
                        ComboDay.Items.Add(i.ToString());
                    }
                    break;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            callSales();
        }

        private void callSales()
        {
            string TMonth = ComboMonth.SelectedItem.ToString();
            string TDay = ComboDay.SelectedItem.ToString();
            int totalsales = 0;
            //현재 체크된 날짜 가지고 오기
            //글자 길이가 한 글자인 경우 (1~9월, 1~9일)
            if (TMonth.Length < 2)
            {
                TMonth = "0" + TMonth;
            }
            if (TDay.Length < 2)
            {
                TDay = "0" + TDay;
            }

            string Date = ComboYear.SelectedItem.ToString() 
                + TMonth
                + TDay;
            if(SQLLOGIN == "Offline")
            {
                MessageBox.Show("오프라인 모드에서는 지원되지 않는 기능입니다");
                return;
            }
            MySqlConnection connection = new MySqlConnection(SQLLOGIN);
            string query = "SELECT * FROM `" + Date + "`";
            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter(query, connection);
                adapt.Fill(dataset, "salesdata");

                //메뉴에 출력
                SalesView.DataSource = dataset.Tables["salesdata"];
            }
            catch
            {
                MessageBox.Show("해당 날짜에 매출 기록이 없습니다. \r\n 매출 기록이 있어야하는 경우 개발자에게 문의하세요");
            }
            foreach (DataGridViewColumn column in SalesView.Columns)
            {
                SalesView.Columns[column.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            //일일 매출 총액 계산
            foreach (DataGridViewRow Row in SalesView.Rows)
            {
                if(SalesView.Rows[Row.Index].Cells[2].Value == null)
                {
                    break;
                }
                totalsales = int.Parse(SalesView.Rows[Row.Index].Cells[2].Value.ToString()) + totalsales;
            }
            TxtTotalsales.Text = totalsales.ToString();
        }
    }
}

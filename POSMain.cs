using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySqlX.XDevAPI.Relational;

namespace SOSIL_POS
{
    public partial class POSMain : Form
    {
        private MainLogin Father;    // 부모 폼에 동작을 전달하기 위해 선언
        private string SQLLOGIN; // SQL 정보를 전달받기 위한 변수, 부모 폼에서 전달 받음

        List<DataSet> DataTable = new List<DataSet>();

        public POSMain(string sql, MainLogin parent)
        {
            //생성과 동시에 SQL로그인 정보와 부모를 받아옴
            SQLLOGIN = sql;
            Father = parent;
            InitializeComponent();
            for (int i = 0; i < 20; i++)    // DataTable 초기화
            {
                DataTable.Add(new DataSet());
            }
            DataTable[0].Tables["TableData"].Rows.Add(new object[] { "김밥", 5, 5000 });
            //MessageBox.Show(DataTable[0].Tables["TableData"].Rows[0][0].ToString()); //김밥이 출력댐!
            //int v = DataTable[1].Tables["Person"].Rows.Count;
            //string a = DataTable[1].Tables["Person"].Rows[0][0].ToString(); // 값 가져오는 법
        }

        private void POSMain_FormClosed(object sender, FormClosedEventArgs e)   // 자식 POS가 닫혔을 때 Login 폼도 같이 닫기
        {
            Father.Close();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HO!");
            int TableNumber = 0;
            //테이블 번호 찾기
            for (int i = 1; i <= 20; i++)
            {
                if (((Label)sender).Name == "Table" + i.ToString()) //라벨 이름과 i의 비교
                {
                    TableNumber = i-1;
                }
            }
            TableListViewShow(TableNumber);
        }

        public void TableListViewShow(int TableNumber)
        {
            string[] data = new string[3];
            int rowcount = DataTable[TableNumber].Tables["TableData"].Rows.Count;
            int cost = 0;
            int fullcost = 0;
            TableListView.Items.Clear();
            TableNumLbl.Text = "테이블 번호: " + (TableNumber + 1).ToString(); ;
            for (int i = 0; i < rowcount; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = DataTable[TableNumber].Tables["TableData"].Rows[i][0].ToString();
                item.SubItems.Add(DataTable[TableNumber].Tables["TableData"].Rows[i][1].ToString());
                item.SubItems.Add(DataTable[TableNumber].Tables["TableData"].Rows[i][2].ToString());
                TableListView.Items.Add(item);
                cost = int.Parse(DataTable[TableNumber].Tables["TableData"].Rows[i][2].ToString());
                fullcost = fullcost + cost;
            }
            FullcostTxt.Text = fullcost.ToString();
            TableCostEdit(fullcost, TableNumber);
        }

        public void TableCostEdit(int fullcost, int TableNumber)
        {
            switch(TableNumber)
            {
                case 0:
                    Table1.Text = "\r\n1번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 1:
                    Table2.Text = "\r\n2번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 2:
                    Table3.Text = "\r\n3번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 3:
                    Table4.Text = "\r\n4번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 4:
                    Table5.Text = "\r\n5번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 5:
                    Table6.Text = "\r\n6번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 6:
                    Table7.Text = "\r\n7번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 7:
                    Table8.Text = "\r\n8번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 8:
                    Table9.Text = "\r\n9번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 9:
                    Table10.Text = "\r\n10번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 10:
                    Table11.Text = "\r\n11번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 11:
                    Table12.Text = "\r\n12번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 12:
                    Table13.Text = "\r\n13번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 13:
                    Table14.Text = "\r\n14번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 14:
                    Table15.Text = "\r\n15번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 15:
                    Table16.Text = "\r\n16번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 16:
                    Table17.Text = "\r\n17번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 17:
                    Table18.Text = "\r\n18번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 18:
                    Table19.Text = "\r\n19번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                case 19:
                    Table20.Text = "\r\n20번 테이블\r\n\r\n" + fullcost.ToString() + "원\r\n";
                    break;
                default:
                    MessageBox.Show("프로그램에 문제가 있습니다:  TableCostEdit");
                    break;
            }
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            //테이블의 데이터 셋을 보내고, 
            //변수: 테이블 번호
            int TableNumber = 0;
            //테이블 번호 찾기
            for (int i = 1; i<=20; i++)
            {
                if( ((Label)sender).Name == "Table"+i.ToString()) //라벨 이름과 i의 비교
                {
                    TableNumber = i;
                }
            }
            if(TableNumber == 0) //못 찾은 경우 (구조 에러)
            {
                MessageBox.Show("프로그램에 문제가 있습니다 (TableDoubleClick)");
                return;
            }


            //변수: 해당 테이블의 현재 선택된 메뉴 개수
            int Menus = DataTable[TableNumber - 1].Tables["TableData"].Rows.Count;
            if (Menus < 1) //메뉴가 없는 경우
            {
                //MessageBox.Show(DataTable[TableNumber - 1].Tables["TableData"].Rows.Count.ToString());
                MenuSelect SelectMenu = new MenuSelect(SQLLOGIN, this, TableNumber);
                SelectMenu.Show();
            }
            else //메뉴가 있는 경우
            {
                //변수: 리스트 뷰 아이템, 하위 폼 생성
                string[] senddata = new string[3];
                MenuSelect SelectMenu = new MenuSelect(SQLLOGIN, this, TableNumber);

                for (int i = 0; i<Menus; i++)
                {
                    //값이 있다고 판단, 해당 데이터들을 찾고 반복문으로 ListViewItem에 하나씩 쌓고 전송
                    senddata[0] = DataTable[0].Tables["TableData"].Rows[i][0].ToString();
                    senddata[1] = DataTable[TableNumber - 1].Tables["TableData"].Rows[i][1].ToString();
                    senddata[2] = DataTable[TableNumber - 1].Tables["TableData"].Rows[i][2].ToString();
                    SelectMenu.GetFatherList(senddata);
                }
                SelectMenu.Show();
            }
        }

        private void POSMain_Load(object sender, EventArgs e)
        {
            if (SQLLOGIN == "Offline")
            {
                MessageBox.Show("오프라인 모드에서는 일부 기능이 작동하지 않습니다");
            }
            else 
            {
                try
                {
                    // DB 연결 시도
                }
                catch
                {
                    // DB 연결 실패시?
                }
            }
        }

        public void TableInitialize(int i)
        {
            DataTable[i].Clear(); //데이터셋 초기화 (사고 발생 가능 지점)
        }

        public void MenuSelectAccess(int i, string[] receive)
        {
            MessageBox.Show(receive[0]);
            DataTable[i].Tables["TableData"].Rows.Add(new object[] { receive[0], receive[1], receive[2] });
        }

        private void PriceMenuChangeBtn_Click(object sender, EventArgs e)
        {
        }

    }
}

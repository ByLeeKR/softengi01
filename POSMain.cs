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
            DataTable[0].Tables["TableData"].Rows.Add(new object[] { 1, "kim", 30 });
            MessageBox.Show(DataTable[0].Tables["TableData"].Rows[0][0].ToString());
            //int v = DataTable[1].Tables["Person"].Rows.Count;
            //string a = DataTable[1].Tables["Person"].Rows[0][0].ToString(); // 값 가져오는 법
        }

        private void POSMain_FormClosed(object sender, FormClosedEventArgs e)   // 자식 POS가 닫혔을 때 Login 폼도 같이 닫기
        {
            Father.Close();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            // 클릭 시 좌측에 현재 메뉴 목록 출현
            // 포인팅할 부분을 정의 (변수 설정)
            // 결제 버튼을 누를 시 해당 테이블의 정보를 바탕으로 결제창으로 넘어가고, 결제 완료 버튼 클릭 시 초기화
            // 데이터의 관리는? 구조체 배열 활용? (25개의 구조체 배열 길이
            // 구조체에서 저장할 데이터는? 메뉴 데이터?

            //혹은 invisible 속성으로 리스트뷰를 만들고
            //로그인과 동시에 리스트 뷰에 DB에서 읽은 데이터를 하나하나 삽입?

            //해결해야하는 점 1. 메뉴를 어떻게 저장할 것인가
            //해결해야하는 점 2. DB상의 메뉴를 읽고, 읽은 데이터의 저장 방식
            // ㄴ 노드와 노드의 sub노드를 추가하는 방식을 사용? ListView?
            // 메뉴 설정 모드 (테이블 더블 클릭)에서 나오는 ListView에서 더블클릭하면
            // 더블 클릭한 메뉴가 왼쪽으로 

            // 1번 안 배열 + ArrayList형태의 2차원 배열로 생성
            // Table마다 ArrayList를 추가하고, 메뉴가 추가될 때 마다 ArrayList를 추가?
            // 정정: 첫 ArrayList는 범위 20으로 설정하고, 테이블 번호를 지정
            // 메뉴가 추가될 때 마다 해당 ArrayList에 String[3]의 길이의 메뉴 수량 금액을 설정
            //ㄴ 중복 추가를 막기 위해, ArrayList의 요소와 메뉴 이름을 비교, (2차원 ArrayList[0] == "입력된 메뉴 이름")
            //ㄴ 같을 시 수량만 증가
            //ㄴ 다를 시 새로운 메뉴를 ArrayList에 추가
            //ArrayList arr = new ArrayList();
            //ArrayList k = new ArrayList();
            //arr.Add(k);
            //arr.Add(10);
            //k.Add(100);
            //int a = arr.Count;
            //string b = (String)((ArrayList)arr[0])[0];  // 2차원 ArrayList 내 내용물 가지고 오기

            //2번 안 ArrayList를 두 개 만들어서, label과 Listview를 각각 배열 요소처럼 사용
            //클릭한게 몇 번 라벨인지 반복문으로 확인, 1번 라벨이 클릭됬으면 1번 ListView의 요소들을 가지고 와서 좌측 출력
           // List<Label> TableNumber = new List<Label>();
            //TableNumber.Add(this.Table1);
            //List<ListView> TableListNumber = new List<ListView>();
            //int i = 0;
            //if (TableNumber[i].Name.ToString() == ("Table" + (i+1).ToString()))
            //{
            //    //해당 테이블에 매칭하는 ListView의 아이템을 모조리 좌측 리스트 뷰에서 출력 (초기화도 필요)
            //    //MessageBox.Show("작동함");
            //}
            //Dictionary<Label, ListView> abc = new Dictionary<Label, ListView>(); // Dictionary로 연결도 가능

            //0601 방향의 수정
            //ListView가 아니라 DataSet을 사용하는건?
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            //변수: 테이블 번호
            int TableNumber = 0;
            //테이블 번호 찾기
            for (int i = 1; i<20; i++)
            {
                if( ((Label)sender).Name == "Table"+i.ToString())
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
                MessageBox.Show(DataTable[TableNumber - 1].Tables["TableData"].Rows.Count.ToString());
                MenuSelect SelectMenu = new MenuSelect(SQLLOGIN, this, TableNumber);
                SelectMenu.Show();
            }
            else //메뉴가 있는 경우
            {
                //변수: 리스트 뷰 아이템, 하위 폼 생성
                ListViewItem senddata = new ListViewItem();
                MenuSelect SelectMenu = new MenuSelect(SQLLOGIN, this, TableNumber);

                for (int i = 0; i<Menus; i++)
                {
                    //값이 있다고 판단, 해당 데이터들을 찾고 반복문으로 ListViewItem에 하나씩 쌓고 전송
                    senddata.Text = DataTable[0].Tables["TableData"].Rows[0][0].ToString();
                    senddata.SubItems.Add(DataTable[TableNumber - 1].Tables["TableData"].Rows[i][1].ToString());
                    senddata.SubItems.Add(DataTable[TableNumber - 1].Tables["TableData"].Rows[i][2].ToString());
                    SelectMenu.GetFatherList(senddata);
                }
                MessageBox.Show("뭔가가 있습니다");
                SelectMenu.Show();
            }
        }

        private void POSMain_Load(object sender, EventArgs e)
        {
            if (SQLLOGIN == "Offline")
            {
                MessageBox.Show("오프라인 모드에서는 정상 작동하지 않습니다 (개발 중)");
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

        private void PriceMenuChangeBtn_Click(object sender, EventArgs e)
        {
        }

    }
}

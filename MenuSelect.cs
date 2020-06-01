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
    public partial class MenuSelect : Form
    {
        private POSMain father;
        private int tablenumber;
        private string SQLLOGIN;
        DataSet dataset = new DataSet();

        public MenuSelect(string sql, POSMain parent, int tablenum)
        {
            //SQL로그인 정보 / 부모 정보 / 테이블 번호
            SQLLOGIN = sql;
            father = parent;
            tablenumber = tablenum;
            InitializeComponent();
        }

        public void GetFatherList(ListViewItem item)
        {
            MenuList.Items.Add(item);
        }

        private void MenuSelect_Load(object sender, EventArgs e)
        {
            //SQL에 질의를 통해 메뉴 목록을 가지고 옴
            //메뉴 목록을 하나씩 DataSet에 추가
            //dataset.Tables["MenuData"].Rows.Add(new object[] { 메뉴 이름, 가격 });
            //GridDataView에 Dataset을 지정
        }

        private void MenuView_CellContentDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex, e.RowIndex로 행렬 좌표 잡기 가능, Column은 고정값, Row는 0부터 1까지
            // 먼저 Row[0]와 동일한 이름의 아이템이 있는지 탐색, 있으면 해당 아이템 수량 + 1 / 가격 + 가격
            // 동일한 이름의 아이템이 없는 경우 이름,수량(1),가격으로 아이템 추가
        }

        private void MenuList_DoubleClick(object sender, EventArgs e)
        {
            //더블 클릭 된 (focus되어있는) 아이템을 제거
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //부모 폼에 배열로 ListView 요소 하나씩 전달
            String[] send = new String[3];
            //반복문 ListView 아이템 요소를 하나 쭉 읽고
            //해당 내용을 배열에 저장
            //저장된 내용을 바탕으로 부모 폼의 Dataset에 요소를 추가하도록 메소드 호출 (테이블 넘버, 배열 전송)
            //ListView 아이템이 떨어질 때 까지 반복
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //취소 버튼 클릭 시 폼 닫음
            this.Close();
        }
    }
}

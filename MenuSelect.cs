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
using MySqlX.XDevAPI.Relational;

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

        public void GetFatherList(string[] receive)
        {
            //전송받은 배열로 아이템 추가
            ListViewItem item = new ListViewItem();
            item.Text = receive[0];
            item.SubItems.Add(receive[1]);
            item.SubItems.Add(receive[2]);
            MenuList.Items.Add(item);
        }

        private void MenuSelect_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(tablenumber.ToString() + "번 테이블입니다");
            //쿼리로부터 데이터를 읽어오고, 데이터셋에 삽입
            if (SQLLOGIN != "Offline")
            {
                MySqlConnection connection = new MySqlConnection(SQLLOGIN);
                string query = "SELECT * FROM menudata";
                MySqlDataAdapter adapt = new MySqlDataAdapter(query, connection);
                adapt.Fill(dataset, "menudata");

                //메뉴에 출력
                MenuView.DataSource = dataset.Tables["menudata"];
            }

            //DB가 없으면 작동 X
        }

        private void MenuView_CellContentDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {

            // 동일한 이름의 아이템이 있는지 탐색, 있으면 해당 아이템 수량 + 1 / 가격 + 가격
            ListViewItem Check = MenuList.FindItemWithText(this.MenuView.CurrentRow.Cells["name"].Value.ToString());
            if(Check != null)
            {
                int amount = int.Parse(Check.SubItems[1].Text.ToString());
                int price = int.Parse(Check.SubItems[2].Text.ToString());
                price = price / amount;
                amount++;
                price = price * amount;
                Check.SubItems[1].Text = amount.ToString();
                Check.SubItems[2].Text = price.ToString();
            }
            // 동일한 이름의 아이템이 없는 경우 이름,수량(1),가격으로 아이템 추가
            else
            {
                ListViewItem input = new ListViewItem();
                input.Text = this.MenuView.CurrentRow.Cells["name"].Value.ToString();
                input.SubItems.Add("1");
                input.SubItems.Add(this.MenuView.CurrentRow.Cells["price"].Value.ToString());
                MenuList.Items.Add(input);
            }
        }

        private void MenuList_DoubleClick(object sender, EventArgs e)
        {
            int amount = int.Parse(MenuList.FocusedItem.SubItems[1].Text);
            int price = int.Parse(MenuList.FocusedItem.SubItems[2].Text);
            if(amount > 1) //개수가 많은 경우 개수만 줄임
            {
                price = price / amount; //개당 가격으로 환상
                amount--;
                price = price * amount; //다시 개수 개산
                MenuList.FocusedItem.SubItems[1].Text = amount.ToString();
                MenuList.FocusedItem.SubItems[2].Text = price.ToString();
            }
            else //하나만 남은 경우 삭제
            {
                MenuList.FocusedItem.Remove();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //부모 DataSet을 초기화 (메소드 호출)
            //반복문: ListView 길이 만큼 (foreach)
            //반복마다 String[3]배열에 삽입
            //부모에서 작성된(할) 메소드를 반복문 내에서 호출, 전달하는 값은 String배열과 테이블 번호
            //부모는 해당 값을 바탕으로 해당 테이블DataSet에 요소 추가 
            //테이블 번호를 바탕으로 해당 테이블 DataSet 초기화
            
            String[] send = new String[3];
            father.TableInitialize(tablenumber-1);
            foreach(ListViewItem item in MenuList.Items)
            {
                MessageBox.Show("전송" + item.Text);
                send[0] = item.Text;
                send[1] = item.SubItems[1].Text;
                send[2] = item.SubItems[2].Text;
                father.MenuSelectAccess(tablenumber - 1, send);
            }

            father.TableListViewShow(tablenumber - 1);
            //MenuList.Items.Clear();
            
            //부모 폼에 배열로 ListView 요소 하나씩 전달
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

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
    public partial class POSMain : Form
    {
        private MainLogin Father;    // 부모 폼에 동작을 전달하기 위해 선언
        private string SQLLOGIN; // SQL 정보를 전달받기 위한 변수, 부모 폼에서 전달 받음
        public POSMain()
        {
            InitializeComponent();
        }

        public void LoginDataLoad(string loginkey, MainLogin parent)
        {
            Father = parent;
            SQLLOGIN = loginkey;
        }

        private void POSMain_FormClosed(object sender, FormClosedEventArgs e)   // 자식 POS가 닫혔을 때 Login 폼도 같이 닫기
        {
            Father.Close();
        }
    }
}

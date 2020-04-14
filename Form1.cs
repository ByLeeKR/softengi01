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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}

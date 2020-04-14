using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//MySQL NuGet패키지 인스톨 및 라이브러리 선언
//MySQL 설치 시 가급적 Uid / Password는 root로 부탁드립니다.
//DB 포트는 3306으로 이용 부탁드립니다.

namespace SOSIL_POS
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSIL_POS
{
    public partial class POSSend : Form
    {
        int tnum;
        POSServer serv;
        string Message;
        int amount;
        public POSSend(POSServer ps, int num)
        {
            InitializeComponent();
            serv = ps;
            tnum = num;
        }

        public void GetFatherList(string[] receive)
        {
            ListViewItem item = new ListViewItem();
            item.Text = receive[0];
            item.SubItems.Add(receive[1]);
            item.SubItems.Add(receive[2]);
            MenuList.Items.Add(item);
        }

        private void MenuList_DoubleClick(object sender, EventArgs e)
        {
            Message = tnum.ToString() + MenuList.FocusedItem.Text;
            serv.sendrequest(Message);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MenuList.Items.Count; i++)
            {
                amount = int.Parse(MenuList.Items[i].SubItems[1].Text);
                for (int j = 1; j <= amount; j++)
                {
                    Message = tnum.ToString() + MenuList.Items[i].Text;
                    serv.sendrequest(Message);
                }
            }
        }
    }
}

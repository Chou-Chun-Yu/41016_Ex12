using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_Ex10 {
    public partial class Search : Form {
        public Search() {
            InitializeComponent();
        }

        static public Form1 S;

        internal void Bt_OK_Click(object sender, EventArgs e) {
            S.Person.Find(x => x.Id.Contains(Tb_Search.Text));
            MessageBox.Show(
                "ID : " + S.Person.Find(x => x.Id.Contains(Tb_Search.Text)).Id + "\r\n" +
                "Name : " + S.Person.Find(x => x.Id.Contains(Tb_Search.Text)).Name + "\r\n" +
                "Chinese : " + S.Person.Find(x => x.Id.Contains(Tb_Search.Text)).Chi + "\r\n" +
                "English : " + S.Person.Find(x => x.Id.Contains(Tb_Search.Text)).Eng + "\r\n" +
                "Math : " + S.Person.Find(x => x.Id.Contains(Tb_Search.Text)).Math + "\r\n" +
                "Total : " + S.Person.Find(x => x.Id.Contains(Tb_Search.Text)).Total + "\r\n"
                );
             //MessageBox.Show("不存在" + Tb_Search.Text);
        }
    }
}
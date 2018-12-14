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
    public partial class Newdata : Form {
        public bool ok = false;
        public Newdata() {
            InitializeComponent();
        }

        private void Bt_OK_Click(object sender, EventArgs e) {
            ok = true;
            this.Close();
        }
    }
}

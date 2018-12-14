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
    public partial class Delete : Form {
        public bool ok = false;
        public Delete() {
            InitializeComponent();
        }

        private void Bt_delete_Click(object sender, EventArgs e) {
            ok = true;
            this.Close();
        }
    }
}

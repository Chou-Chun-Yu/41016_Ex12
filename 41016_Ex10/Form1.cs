using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _41016_Ex10 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            Search.S = this;
        }

        public List<Student> Person = new List<Student>();

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Newdata add = new Newdata();
                add.ShowDialog();
                if (add.ok) {
                    int ChiScore, EngScore, MathScore, total; 
                    if (Person.Exists(x => x.Id == add.Tb_id.Text)) {
                        MessageBox.Show("學號重複!");
                    } else {
                        ChiScore = Convert.ToInt32(add.Tb_chi.Text);
                        EngScore = Convert.ToInt32(add.Tb_eng.Text);
                        MathScore = Convert.ToInt32(add.Tb_math.Text);
                        total = ChiScore + EngScore + MathScore;
                        Person.Add(new Student() {
                            Id = add.Tb_id.Text,
                            Name = add.Tb_name.Text,
                            Chi = add.Tb_chi.Text,
                            Eng = add.Tb_eng.Text,
                            Math = add.Tb_math.Text,
                            Total = total.ToString()
                        });
                        searchToolStripMenuItem.Enabled = true;
                        updateToolStripMenuItem.Enabled = true;
                        queryToolStripMenuItem.Enabled = true;
                        deleteToolStripMenuItem.Enabled = true;
                        MessageBox.Show("資料新增成功!");
                    }
                } else MessageBox.Show("取消新增!");
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            Search find = new Search();
            find.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Newdata add = new Newdata();
                add.ShowDialog();
                if (add.ok) {
                    int ChiScore, EngScore, MathScore, total; 
                    if (Person.Exists(x => x.Id == add.Tb_id.Text)) {
                        ChiScore = Convert.ToInt32(add.Tb_chi.Text);
                        EngScore = Convert.ToInt32(add.Tb_eng.Text);
                        MathScore = Convert.ToInt32(add.Tb_math.Text);
                        total = ChiScore + EngScore + MathScore;
                        Person.First(x => x.Id == add.Tb_id.Text).Name = add.Tb_name.Text;
                        Person.First(x => x.Id == add.Tb_id.Text).Chi = add.Tb_chi.Text;
                        Person.First(x => x.Id == add.Tb_id.Text).Eng = add.Tb_eng.Text;
                        Person.First(x => x.Id == add.Tb_id.Text).Math = add.Tb_math.Text;
                        Person.First(x => x.Id == add.Tb_id.Text).Total = total.ToString();
                        MessageBox.Show("修改成功!");
                    }
                } else MessageBox.Show("取消修改!");
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e) {
            Sort sort = new Sort();
            Sort result = sort;
            result.S = this;
            Tb_show.Text = result.Sorted();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Delete remove = new Delete();
                remove.ShowDialog();
                if (remove.ok) {
                    if (Person.Exists(x => x.Id == remove.Tb_delete.Text)) {
                        var itemToRemove = Person.Single(r => r.Id == remove.Tb_delete.Text);
                        Person.Remove(itemToRemove);
                        MessageBox.Show("刪除成功!");
                    }
                } else MessageBox.Show("取消刪除!");
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }

    public class Student {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Chi { get; set; }
        public string Eng { get; set; }
        public string Math { get; set; }
        public string Total { get; set; }
    }
}
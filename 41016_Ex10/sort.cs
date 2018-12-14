using System;
using System.Windows.Forms;

namespace _41016_Ex10 {

    class Sort {
        public Form1 S;

        public string Sorted() {
            string result;
            string line = "-------------------------------------------------------------------\r\n";

            result = "學號\t姓名\t國文\t英文\t數學\t總分\r\n";
            result += line;

            S.Person.Sort(delegate(Student s1, Student s2) { return s1.Total.CompareTo(s2.Total); });
            for (int i = S.Person.Count - 1; i >= 0; i--) {
                result += S.Person[i].Id.ToString() + "\t" +
                          S.Person[i].Name.ToString() + "\t" +
                          S.Person[i].Chi.ToString() + "\t" +
                          S.Person[i].Eng.ToString() + "\t" +
                          S.Person[i].Math.ToString() + "\t" +
                          S.Person[i].Total.ToString() + "\r\n";
            }
            return result;
        }

    }
}
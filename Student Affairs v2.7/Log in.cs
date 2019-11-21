using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Affairs_v2._7.Classes;

namespace Student_Affairs_v2._7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void buttonSignIN_Click(object sender, EventArgs e) {
            dataContext data = new dataContext();
            bool findUser = false;
            try {
                findUser= data.Users.FirstOrDefault(u => u._userName == boxUserName.Text)._password == boxPassword.Text;
                if (findUser == true) {
                    new Excel_Show().ShowDialog();
                }
                else new Message("No Such User & Password", 1).ShowDialog();
            }
            catch {
                new Message("No Such User & Password", 1).ShowDialog();
            }
        }
    }
}

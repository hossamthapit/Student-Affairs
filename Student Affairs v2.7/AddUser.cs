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
    public partial class AddUser : Form {
        public AddUser() {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e) {

        }

        private void buttonAddUser_Click(object sender, EventArgs e) {
            dataContext data = new dataContext();
            User newUser = new User() {
                _name = boxName.Text,
                _userName = boxUserName.Text,
                _password = boxPassword.Text
            };
            data.Users.Add(newUser);
            data.SaveChanges();
    }

        private void labelExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void radioBlack_CheckedChanged(object sender, EventArgs e) {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Hossam\Documents\Visual Studio 2015\Projects\Student Affairs v2.7\Data\default.jpg");
        }

        private void radioWhite_CheckedChanged(object sender, EventArgs e) {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Hossam\Documents\Visual Studio 2015\Projects\Student Affairs v2.7\Data\blue.jpg");
        }
    }
}

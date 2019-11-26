using Student_Affairs_v2._7.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Affairs_v2._7 {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            new Excel_Show().ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e) {
        }

        private void labelExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            new AddUser().ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e) {
            new Excel_Compare().ShowDialog();
        }
    }
}

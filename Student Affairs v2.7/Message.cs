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
    public partial class Message : Form {
        int id;
        string msg;

        public Message() {
            InitializeComponent();
        }
        public Message(string message , int id) {
            InitializeComponent();
            msg = message;
            this.id = id;
        }

        private void Message_Load(object sender, EventArgs e) {
            buttonMessage.Text = msg;
            if (id == 1)
                buttonMessage.BackColor = Color.Red;
            else if (id == 2)
                buttonMessage.BackColor = Color.DarkGreen;
            labelExit.BackColor = buttonMessage.BackColor;
        }

        private void labelExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void labelExit_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}

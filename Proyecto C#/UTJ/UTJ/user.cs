using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class user : Form {
        public user() {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                txtPassAct.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
            }
            else {
                txtPassAct.PasswordChar = '*';
                txtPassNew.PasswordChar = '*';
            }
        }
    }
}

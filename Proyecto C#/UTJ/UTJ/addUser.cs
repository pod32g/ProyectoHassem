using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {

    public partial class addUser : Form {

        private db d = new db();

        public addUser() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(combUsrType.SelectedIndex == 1) {
                d.addUser(txtUserName.Text, txtPasswd.Text);
            }
        }

        private void combUsrType_SelectedIndexChanged(object sender, EventArgs e) {
            if(combUsrType.SelectedIndex > 1) {
                txtCode.Enabled = false;
                txtPhone.Enabled = true;
                txtPosition.Enabled = true;
                txtMail.Enabled = true;
            }
            else {
                if (combUsrType.SelectedIndex != 0) {
                    txtPhone.Enabled = false;
                    txtPosition.Enabled = false;
                    txtMail.Enabled = false;
                } else {
                    txtPhone.Enabled = true;
                    txtPosition.Enabled = true;
                    txtMail.Enabled = true;
                }
                txtCode.Enabled = true;
            }
        }
    }
}

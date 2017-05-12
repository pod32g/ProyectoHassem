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
            combUsrType.SelectedIndex = 0;
        }

        private void clear() {
            txtEmpresa.Text = "";
            txtCarrera.Text = "";
            txtCode.Text = "";
            txtMail.Text = "";
            txtMat.Text = "";
            txtName.Text = "";
            txtName2.Text = "";
            txtNivel.Text = "";
            txtPasswd.Text = "";
            txtPat.Text = "";
            txtPhone.Text = "";
            txtPosition.Text = "";
            txtTurno.Text = "";
            txtUserName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            int h = d.addUser(txtUserName.Text, txtPasswd.Text);
            d.addData(h,txtName.Text, txtName2.Text, txtPat.Text, txtMat.Text);

            switch(combUsrType.SelectedIndex) {
                case 0:
                    d.addTeacher(h, int.Parse(txtCode.Text), txtCarrera.Text);
                    d.addContact(h, txtMail.Text, txtPosition.Text, txtPhone.Text);
                    d.setUsrType(h, "teach");
                    break;
                case 1:
                    d.addStudent(h, int.Parse(txtCode.Text), txtCarrera.Text, txtNivel.Text, txtTurno.Text);
                    d.setUsrType(h, "student");
                    break;
                case 2:
                    d.addCompany(h, txtEmpresa.Text);
                    d.addContact(h, txtMail.Text, txtPosition.Text, txtPhone.Text);
                    d.setUsrType(h, "enter");
                    break;
                case 3:
                    d.addContact(h, txtMail.Text, txtPosition.Text, txtPhone.Text);
                    d.setUsrType(h, "admin");
                    break;
            }
            this.clear();
            MessageBox.Show("Usuario creado");


        }

        private void combUsrType_SelectedIndexChanged(object sender, EventArgs e) {
            if(combUsrType.SelectedIndex > 1) {
                txtCode.Enabled = false;
                txtPhone.Enabled = true;
                txtPosition.Enabled = true;
                txtMail.Enabled = true;
                txtNivel.Enabled = false;
                txtCarrera.Enabled = false;
                txtTurno.Enabled = false;
                txtEmpresa.Enabled = false;
                if (combUsrType.SelectedIndex == 2) {
                    txtEmpresa.Enabled = true;
                } 
            }
            else {
                if (combUsrType.SelectedIndex != 0) {
                    txtPhone.Enabled = false;
                    txtPosition.Enabled = false;
                    txtMail.Enabled = false;
                    txtNivel.Enabled = true;
                    txtCarrera.Enabled = true;
                    txtTurno.Enabled = true;
                    txtEmpresa.Enabled = false;
                } else {
                    txtPhone.Enabled = true;
                    txtPosition.Enabled = true;
                    txtMail.Enabled = true;
                    txtNivel.Enabled = false;
                    txtCarrera.Enabled = true;
                    txtTurno.Enabled = false;
                    txtEmpresa.Enabled = false;

                }
                txtCode.Enabled = true;
            }
        }
    }
}

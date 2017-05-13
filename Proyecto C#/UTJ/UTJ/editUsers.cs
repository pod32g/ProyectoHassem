using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UTJ {
    public partial class editUsers : Form {

        private db d = new db();
        private int cId;

        public editUsers() {
            InitializeComponent();
            btnSave.Enabled = false;
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
            btnSave.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                Dictionary<string, string> data = d.getUserData(txtName.Text);
                Dictionary<string, string> user = d.getUserNameP(int.Parse(data["id"]));
                switch (d.getType(int.Parse(data["id"]))) {
                    case "teach":
                        Dictionary<string, string> t = d.getTeacher(int.Parse(data["id"]));
                        Dictionary<string, string> c = d.getContact(int.Parse(data["id"]));
                        txtName.Text = data["nombre1"];
                        txtName2.Text = data["nombre2"];
                        txtMat.Text = data["mat"];
                        txtPat.Text = data["pat"];
                        txtUserName.Text = user["username"];
                        txtPasswd.Text = user["password"];
                        txtCode.Text = t["codigo"];
                        txtCarrera.Text = t["carrera"];
                        txtMail.Text = c["correo"];
                        txtPhone.Text = c["telefono"];
                        txtPosition.Text = c["cargo"];
                        combUsrType.SelectedIndex = 0;
                        break;
                    case "student":
                        Dictionary<string, string> s = d.getStudent(int.Parse(data["id"]));
                        txtName.Text = data["nombre1"];
                        txtName2.Text = data["nombre2"];
                        txtMat.Text = data["mat"];
                        txtPat.Text = data["pat"];
                        txtUserName.Text = user["username"];
                        txtPasswd.Text = user["password"];
                        txtCode.Text = s["matricula"];
                        txtCarrera.Text = s["carrera"];
                        txtNivel.Text = s["nivel"];
                        txtTurno.Text = s["turno"];
                        combUsrType.SelectedIndex = 1;
                        break;
                    case "enter":
                        Dictionary<string, string> en = d.getCompany(int.Parse(data["id"]));
                        Dictionary<string, string> co = d.getContact(int.Parse(data["id"]));
                        txtName.Text = data["nombre1"];
                        txtName2.Text = data["nombre2"];
                        txtMat.Text = data["mat"];
                        txtPat.Text = data["pat"];
                        txtUserName.Text = user["username"];
                        txtPasswd.Text = user["password"];
                        txtMail.Text = co["correo"];
                        txtPhone.Text = co["telefono"];
                        txtPosition.Text = co["cargo"];
                        txtEmpresa.Text = en["nombre"];
                        combUsrType.SelectedIndex = 2;

                        break;
                    case "admin":
                        Dictionary<string, string> coo = d.getContact(int.Parse(data["id"]));
                        txtName.Text = data["nombre1"];
                        txtName2.Text = data["nombre2"];
                        txtMat.Text = data["mat"];
                        txtPat.Text = data["pat"];
                        txtUserName.Text = user["username"];
                        txtPasswd.Text = user["password"];
                        txtMail.Text = coo["correo"];
                        txtPhone.Text = coo["telefono"];
                        txtPosition.Text = coo["cargo"];
                        combUsrType.SelectedIndex = 3;
                        break;
                }
                txtName.Enabled = true;
                txtName2.Enabled = true;
                txtPat.Enabled = true;
                txtMat.Enabled = true;
                txtUserName.Enabled = true;
                txtPasswd.Enabled = true;
                combUsrType.Enabled = true;
                cId = int.Parse(data["id"]);
                btnSave.Enabled = true;
            } catch(Exception ex) {
                this.clear();
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combUsrType_SelectedIndexChanged(object sender, EventArgs e) {
            if (combUsrType.SelectedIndex > 1) {
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
                }
                else {
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

        private void btnSave_Click(object sender, EventArgs e) {
            d.updateUserPass(cId, txtUserName.Text, txtPasswd.Text);
            d.updateData(cId, txtName.Text, txtName2.Text, txtPat.Text, txtMat.Text);

            switch (combUsrType.SelectedIndex) {
                case 0:
                    d.updateTeacher(cId, int.Parse(txtCode.Text), txtCarrera.Text);
                    d.updateContact(cId, txtMail.Text, txtPosition.Text, txtPhone.Text);
                    d.updateUsrType(cId, "teach");
                    break;
                case 1:
                    d.updateStudent(cId, int.Parse(txtCode.Text), txtCarrera.Text, txtNivel.Text, txtTurno.Text);
                    d.updateUsrType(cId, "student");
                    break;
                case 2:
                    d.updateCompany(cId, txtEmpresa.Text);
                    d.updateContact(cId, txtMail.Text, txtPosition.Text, txtPhone.Text);
                    d.updateUsrType(cId, "enter");
                    break;
                case 3:
                    d.updateContact(cId, txtMail.Text, txtPosition.Text, txtPhone.Text);
                    d.updateUsrType(cId, "admin");
                    break;
            }
            this.clear();
            MessageBox.Show("Usuario creado");
        }
    }
}

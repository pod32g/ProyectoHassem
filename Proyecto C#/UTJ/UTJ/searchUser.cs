using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class searchUser : Form {

        private db d = new db();

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



        public searchUser() {
            InitializeComponent();
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

            } catch (Exception ex) {
                this.clear();
                MessageBox.Show("Usuario no encontrado", "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

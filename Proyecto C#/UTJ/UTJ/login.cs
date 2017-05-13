/*
 * Created by SharpDevelop.
 * User: David
 * Date: 10/05/2017
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UTJ
{
	/// <summary>
	/// Description of login.
	/// </summary>
	public partial class login : Form
	{
        private db d = new db();

        private void loggedIn() {
            string type = Properties.Settings.Default.user_type;
            this.Hide();
            if (type == "admin") {
                var admin = new admin();
                admin.Closed += (s, args) => this.Close();
                admin.Show();
            }else if(type == "teach") {
                var teach = new teacher();
                teach.Closed += (s, args) => this.Close();
                teach.Show();
            } else if(type == "enter") {
                var enter = new company();
                enter.Closed += (s, args) => this.Close();
                enter.Show();
            } else if(type == "student") {
                var stud = new user();
                stud.Closed += (s, args) => this.Close();
                stud.Show();
            }
        }

		public login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            Program.closedSession = false;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        private void login_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.user_type != "none") {
                this.loggedIn();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUser.Text == "" || txtPass.Text == "") {
                MessageBox.Show("Error, Se requiere nombre de usuario y contraseña para continuar.");
            } else {
                if(d.userExists(txtUser.Text)) {
                    if(d.passwordCheck(txtPass.Text)) {
                        int id = d.getID(txtUser.Text);
                        Properties.Settings.Default.user_id = id;
                        Properties.Settings.Default.user_type = d.getType(id);
                        Properties.Settings.Default.Save();
                        loggedIn();
                    } else {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                } else {
                    MessageBox.Show("Usuario incorrecto");
                }
            }
        }

        private void lblMain_Click(object sender, EventArgs e) {

        }
    }
}
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
	/// Description of admin.
	/// </summary>
	public partial class admin : Form
	{
        private db d = new db();
		public admin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void clean() {
            txtPassAct.Text = "";
            txtPassNew.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                txtPassAct.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
            } else {
                txtPassAct.PasswordChar = '*';
                txtPassNew.PasswordChar = '*';
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e) {
            Properties.Settings.Default.user_type = "none";
            Properties.Settings.Default.user_id = 0;
            Properties.Settings.Default.Save();
            Program.closedSession = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(!d.changePassword(txtPassAct.Text, txtPassNew.Text)) {
                MessageBox.Show("Error al cambiar la contraseña");
            } else {
                MessageBox.Show("Contraseña cambiada");
                clean();
            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
            var add = new addUser();
            add.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void agregarProyectoToolStripMenuItem_Click(object sender, EventArgs e) {
            var add = new addProject();
            add.Show();
        }

        private void modificarProyectToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void eliminarProyectoToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void buscarProyectoToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}

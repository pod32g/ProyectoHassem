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

        private db d = new db();

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

        private void clean() {
            txtPassAct.Text = "";
            txtPassNew.Text = "";
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e) {
            Properties.Settings.Default.user_type = "none";
            Properties.Settings.Default.user_id = 0;
            Properties.Settings.Default.Save();
            Program.closedSession = true;
            this.Close();
        }

        private void verProyectosToolStripMenuItem_Click(object sender, EventArgs e) {
            var pro = new userProject(0);
            try {
                pro.Show();
            } catch (Exception ex) {

            }
        }

        private void agregarResultadosToolStripMenuItem_Click(object sender, EventArgs e) {
            var r = new addResults();
            try {
                r.Show();
            } catch (Exception ex) {

            }

        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!d.changePassword(txtPassAct.Text, txtPassNew.Text)) {
                MessageBox.Show("Error al cambiar la contraseña");
            } else {
                MessageBox.Show("Contraseña cambiada");
                clean();
            }
        }
    }
}

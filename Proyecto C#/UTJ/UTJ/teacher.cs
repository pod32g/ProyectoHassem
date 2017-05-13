using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class teacher : Form {
        public teacher() {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e) {
            Properties.Settings.Default.user_type = "none";
            Properties.Settings.Default.user_id = 0;
            Properties.Settings.Default.Save();
            Program.closedSession = true;
            this.Close();
        }

        private void modificarProyectToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void verProyectosToolStripMenuItem_Click(object sender, EventArgs e) {
            var show = new teacherProjects();
            show.Show();
        }

        private void verEstadisticasToolStripMenuItem_Click(object sender, EventArgs e) {
            var show = new statistics();
            show.Show();
        }
    }
}

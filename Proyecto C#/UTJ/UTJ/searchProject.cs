using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class searchProject : Form {

        private db d = new db();
        private string name;

        private void disable() {
            txtCompany.Enabled = false;
            txtObjective.Enabled = false;
            txtResult.Enabled = false;
            txtStudent.Enabled = false;
            txtTeacher.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            statusBox.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private int getIndex(string data) {
            switch (data) {
                case "en marcha":
                    return 0;
                    break;
                case "suspendido":
                    return 1;
                    break;
                case "cancelado":
                    return 2;
                    break;
                case "completado":
                    return 3;
                    break;
            }
            return -1;
        }

        public searchProject() {
            InitializeComponent();
            this.disable();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                Dictionary<string, string> data = d.getProyect(txtName.Text);
                txtName.Text = data["nombre"];
                this.name = data["nombre"];
                dateStart.Value = DateTime.Parse(data["inicio"]);
                dateEnd.Value = DateTime.Parse(data["fin"]);
                statusBox.SelectedIndex = this.getIndex(data["estatus"]);
                txtResult.Text = data["result"];
                txtObjective.Text = data["objetivo"];
                txtStudent.Text = data["alumno"];
                txtTeacher.Text = data["maestro"];
                txtCompany.Text = data["empresa"];
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                var f = new editProject(this.name);
                f.Show();
            } catch(Exception ex) { }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                var f = new deleteProject(this.name);
                f.Show();
            } catch (Exception ex) { }
        }
    }
}

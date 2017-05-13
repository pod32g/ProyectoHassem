using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class deleteProject : Form {

        private db d = new db();
        private int cId;

        private void disable() {
            txtCompany.Enabled = false;
            txtObjective.Enabled = false;
            txtResult.Enabled = false;
            txtStudent.Enabled = false;
            txtTeacher.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            btnSave.Enabled = false;
            statusBox.Enabled = false;
        }

        private void clear() {
            txtCompany.Text = "";
            txtName.Text = "";
            txtObjective.Text = "";
            txtResult.Text = "";
            txtStudent.Text = "";
            txtTeacher.Text = "";
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            btnSave.Enabled = false;
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

        public deleteProject(string name) {
            InitializeComponent();
            try {
                Dictionary<string, string> data = d.getProyect(name);
                cId = int.Parse(data["id"]);
                txtName.Text = data["nombre"];
                dateStart.Value = DateTime.Parse(data["inicio"]);
                dateEnd.Value = DateTime.Parse(data["fin"]);
                statusBox.SelectedIndex = this.getIndex(data["estatus"]);
                txtResult.Text = data["result"];
                txtObjective.Text = data["objetivo"];
                txtStudent.Text = data["alumno"];
                txtTeacher.Text = data["maestro"];
                txtCompany.Text = data["empresa"];
                btnSave.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea elimiar el proyecto?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try {
                    d.deleteProject(cId);
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show("Ocurrio un error al procesar los datos, verifique que los datos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Proyecto eliminado");
                this.clear();
            } else if (dialogResult == DialogResult.No) {
                MessageBox.Show("Proyecto no eliminado");
            }
            
        }
    }
}

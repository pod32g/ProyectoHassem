using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class editProject : Form {

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

        private void enable() {
            statusBox.Enabled = true;
            txtCompany.Enabled = true;
            txtObjective.Enabled = true;
            txtResult.Enabled = true;
            txtStudent.Enabled = true;
            txtTeacher.Enabled = true;
            dateStart.Enabled = true;
            dateEnd.Enabled = true;
            btnSave.Enabled = true;
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
            switch(data) {
                case "en marcha":
                    return 0;
                    break;
                case "suspendido":
                    return 1;
                    break;
                case "cancelado":
                    return 2;
                    break;
            }
            return -1;
        }

        private string getStatus(int index) {
            switch (index) {
                case 0:
                    return "en marcha";
                    break;
                case 1:
                    return "suspendido";
                    break;
                case 2:
                    return "cancelado";
                    break;
            }
            return "none";
        }

        public editProject() {
            InitializeComponent();
            this.disable();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                Dictionary<string, string> data = d.getProyect(txtName.Text);
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
                this.enable();
            } catch (Exception ex) {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (d.updateProject(cId, txtName.Text, dateStart.Value.ToString("yyyy-MM-dd"), dateEnd.Value.ToString("yyyy-MM-dd"), this.getStatus(statusBox.SelectedIndex), txtResult.Text, txtObjective.Text, int.Parse(txtStudent.Text), int.Parse(txtTeacher.Text), txtCompany.Text)) {
                MessageBox.Show("Proyecto Modificado");
                this.clear();
            } else {
                MessageBox.Show("Hubo un error al modificar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try {
                
            } catch (Exception ex) {
                MessageBox.Show("Ocurrio un error al procesar los datos, verifique que los datos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

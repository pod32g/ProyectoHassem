using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class userProject : Form {

        private db d = new db();

        private void disable() {
            txtName.Enabled = false;
            txtCompany.Enabled = false;
            txtObjective.Enabled = false;
            txtResult.Enabled = false;
            txtStudent.Enabled = false;
            txtTeacher.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            statusBox.Enabled = false;
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

        public void student() {
            this.disable();
            int id = Properties.Settings.Default.user_id;
            Console.WriteLine("++++ID++++ " + id);
            int matricula = d.getUserCode(id);
            try {
                Dictionary<string, string> data = d.getUserProyect(matricula);
                txtName.Text = data["nombre"];
                dateStart.Value = DateTime.Parse(data["inicio"]);
                dateEnd.Value = DateTime.Parse(data["fin"]);
                statusBox.SelectedIndex = this.getIndex(data["estatus"]);
                txtResult.Text = data["result"];
                txtObjective.Text = data["objetivo"];
                txtStudent.Text = data["alumno"];
                txtTeacher.Text = data["maestro"];
                txtCompany.Text = data["empresa"];
            } catch (Exception ex) {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void other(int id) {
            this.disable();
            Console.WriteLine("++++ID++++ " + id);
            try {
                Dictionary<string, string> data = d.getProyect(id);
                txtName.Text = data["nombre"];
                dateStart.Value = DateTime.Parse(data["inicio"]);
                dateEnd.Value = DateTime.Parse(data["fin"]);
                statusBox.SelectedIndex = this.getIndex(data["estatus"]);
                txtResult.Text = data["result"];
                txtObjective.Text = data["objetivo"];
                txtStudent.Text = data["alumno"];
                txtTeacher.Text = data["maestro"];
                txtCompany.Text = data["empresa"];
            } catch (Exception ex) {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public userProject(int id) {
            InitializeComponent();
            if (id == 0) {
                student();
            } else {
                other(id);
            }
        }
    }
}


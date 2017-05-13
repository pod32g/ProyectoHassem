using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTJ {
    public partial class addResults : Form {

        private db d = new db();
        private int cId;

        private void clear() {
            txtData.Text = "";
            txtName.Text = "";
            txtResults.Text = "";
        }

        private void disable() {
            txtName.Enabled = false;
            txtData.Enabled = false;
           
        }

        private void enable() {
            txtResults.Enabled = true;
            btnSave.Enabled = true;
        }

        public addResults() {
            InitializeComponent();
            this.disable();
            int usrid = Properties.Settings.Default.user_id;
            string type = Properties.Settings.Default.user_type;

            Console.WriteLine(type);

            string name = "" ;
            if (type == "student") {
                name = d.getProjectNameStudent(d.getUserCode(usrid));
            } else if (type == "teach") {
                name = d.getProjectNameTeacher(usrid);
            }
            Dictionary<string, string> data = d.getProyect(name);
            txtName.Text = data["nombre"];
            cId = int.Parse(data["id"]);
            txtData.AppendText("Empresa que lo pide: " + data["empresa"]);
            txtData.AppendText(Environment.NewLine);
            txtData.AppendText("Alumno responsable(matricula): " + data["alumno"]);
            txtData.AppendText(Environment.NewLine);
            txtData.AppendText("Maestro responsable (codigo): " + data["maestro"]);
            txtData.AppendText(Environment.NewLine);
            txtData.AppendText("Fecha de inicio: " + data["inicio"]);
            txtData.AppendText(Environment.NewLine);
            txtData.AppendText("Fecha de finalizacion " + data["fin"]);
            try {
                
            } catch (Exception ex) {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {


        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                d.updateProjectResults(cId, txtResults.Text);
                MessageBox.Show("Resultados guardados");
                this.Close();
            } catch(Exception ex) {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
	/// Description of addProject.
	/// </summary>
	public partial class addProject : Form
	{
        private db d = new db();

        private void clear() {
            txtCompany.Text = "";
            txtName.Text = "";
            txtObjective.Text = "";
            txtStudent.Text = "";
            txtTeacher.Text = "";
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
        }

		public addProject()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                if (d.addProject(txtName.Text, dateStart.Value.ToString("yyyy-MM-dd"), dateEnd.Value.ToString("yyyy-MM-dd"), "en marcha", "", txtObjective.Text, int.Parse(txtStudent.Text), int.Parse(txtTeacher.Text), txtCompany.Text)) {
                    MessageBox.Show("Proyecto Agregado");
                    this.clear();
                } else {
                    MessageBox.Show("Hubo un error al agregar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex) {
                MessageBox.Show("Ocurrio un error al procesar los datos, verifique que los datos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    }
}

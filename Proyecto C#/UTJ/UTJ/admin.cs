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

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                txtPassAct.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
            } else {
                txtPassAct.PasswordChar = '*';
                txtPassNew.PasswordChar = '*';
            }
        }
    }
}

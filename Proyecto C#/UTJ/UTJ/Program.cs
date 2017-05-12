/*
 * Created by SharpDevelop.
 * User: David
 * Date: 10/05/2017
 * Time: 19:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace UTJ
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
        public static bool closedSession { get; set; }

        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
		private static void Main(string[] args)
		{


            string type = Properties.Settings.Default.user_type;
            closedSession = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (type == "admin") {
                Application.Run(new admin());
            }
            else if (type == "teach") {
                Application.Run(new teacher());
            }
            else if (type == "enter") {
                Application.Run(new company());
            }
            else if (type == "student") {
                Application.Run(new user());
            }
            else {
                Application.Run(new login());
            }

            if(closedSession) {
                Application.Run(new login());
            }

		}
		
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UTJ {
    public partial class adminProjects : Form {

        private db d = new db();

        public adminProjects() {
            InitializeComponent();
            MySqlConnection con = d.connect();
            MySqlCommand com = new MySqlCommand(String.Format("SELECT id, nombre, empresa, estatus FROM Proyecto"), con);
            con.Open();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                int i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["dtgId"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridView1.Rows[i].Cells["dtgName"].Value = reader.GetString(reader.GetOrdinal("nombre"));
                dataGridView1.Rows[i].Cells["dtgCompany"].Value = reader.GetString(reader.GetOrdinal("empresa"));
                dataGridView1.Rows[i].Cells["dtgStatus"].Value = reader.GetString(reader.GetOrdinal("estatus"));
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                try {
                    if(senderGrid.Columns[e.ColumnIndex].Name == "dtgSee") {
                        var x = new userProject(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["dtgId"].Value.ToString()));
                        x.Show();
                    } else if(senderGrid.Columns[e.ColumnIndex].Name == "dtgDelete") {
                        var x = new deleteProject(dataGridView1.Rows[e.RowIndex].Cells["dtgName"].Value.ToString());
                        x.Show();
                    } else if(senderGrid.Columns[e.ColumnIndex].Name == "dtgModify") {
                        var x = new editProject(dataGridView1.Rows[e.RowIndex].Cells["dtgName"].Value.ToString());
                        x.Show();
                    }
                } catch (Exception ex) {

                }
            }

        }
    }
}

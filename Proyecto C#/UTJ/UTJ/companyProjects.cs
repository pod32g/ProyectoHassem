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
    public partial class companyProjects : Form {

        db d = new db();

        public companyProjects() {
            InitializeComponent();
            MySqlConnection con = d.connect();
            int id = Properties.Settings.Default.user_id;
            string nombre = d.getCompanyName(id);
            MySqlCommand com = new MySqlCommand(String.Format("SELECT id, nombre, estatus, fechaFin FROM Proyecto WHERE empresa='{0}'", nombre), con);
            con.Open();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                int i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["dtgId"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridView1.Rows[i].Cells["dtgName"].Value = reader.GetString(reader.GetOrdinal("nombre"));
                dataGridView1.Rows[i].Cells["dtgStatus"].Value = reader.GetString(reader.GetOrdinal("estatus"));
                dataGridView1.Rows[i].Cells["dtgEnd"].Value = reader.GetString(reader.GetOrdinal("fechaFin"));
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                try {
                    var x = new userProject(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["dtgId"].Value.ToString()));
                    x.Show();
                } catch (Exception ex) {

                }
            }
        }
    }
}

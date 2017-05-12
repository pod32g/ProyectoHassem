using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace UTJ {
    /// <summary>
    /// Description of db.
    /// </summary>
    public class db {

        private MySqlConnection connect() {
            MySqlConnection conection = new MySqlConnection();
            conection.ConnectionString = "Server=localhost;Uid=root;Pwd=theriata;Database=proyecto;";
            return conection;
        }

        public bool userExists(string username) {
            MySqlConnection con = this.connect();
            bool exists = false;
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand(String.Format("select count(*) from Usuario where userName = '{0}'", username), con)) {
                object result = cmd.ExecuteScalar();
                if (result != null) {
                    Console.WriteLine("result: " + result);
                    if (int.Parse(string.Format("{0}", result)) > 0) {
                        exists = true;
                    }
                }
            }
            if (exists) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool passwordCheck(string passwd) {
            MySqlConnection con = this.connect();
            bool exists = false;
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand(String.Format("select count(*) from Usuario where password = '{0}'", passwd), con)) {
                object result = cmd.ExecuteScalar();
                if (result != null) {
                    if (int.Parse(string.Format("{0}", result)) > 0) {
                        exists = true;
                    }
                }
            }
            if (exists) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public int getID(string username) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT id FROM Usuario WHERE userName='{0}'", username), con);
            MySqlDataReader myReader = comando.ExecuteReader();
            int id = new int();
            while (myReader.Read()) {
                id = myReader.GetInt32(myReader.GetOrdinal("id"));
            }

            con.Close();
            return id;
        }

        public string getType(int id) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT tipo FROM TipoUsuario WHERE usuario_id='{0}'", id), con);
            MySqlDataReader myReader = comando.ExecuteReader();
            string type = "";
            while (myReader.Read()) {
                type = myReader.GetString(myReader.GetOrdinal("tipo"));
            }
            con.Close();
            return type;
        }

        public bool changePassword(string old, string up) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE Usuario SET password = '{1}' WHERE password = '{0}'", old, up), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Updated Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public int addUser(string user, string passwd) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO Usuario(userName, password) VALUES ('{0}', '{1}');", user, passwd), con);
            comando.ExecuteNonQuery();
            con.Close();
            return this.getID(user);
        }

        public bool addData(int id, string name, string name2, string pat, string mat) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO DatosUsuario VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                                                    id, name, name2, pat, mat), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Datos usuario Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool addContact(int id, string correo, string cargo, string telefono) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO DatosContacto VALUES ('{0}', '{1}', '{2}', '{3}');",
                                                    id, correo, cargo, telefono), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Datos contacto Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool addTeacher(int id, int codigo, string carrera) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO Profesores VALUES ('{0}', '{1}', '{2}');",
                                                    codigo, id, carrera), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Profesores Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool addCompany(int id, string name) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO Empresa VALUES ('{0}', '{1}');",
                                                    id, name), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Empresa Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool addStudent(int id, int matricula, string carrera, string nivel, string turno) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO Alumnos VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                                                    matricula, id, carrera, nivel, turno), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Alumno Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool setUsrType(int id, string type) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO TipoUsuario VALUES ('{0}', '{1}');",
                                                    id, type), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Tipo Usuario Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool addProject(string nombre, string inicio, string fin, string status, string result, string objective, int student, int teacher, string company) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO Proyecto (nombre, fechaInicio, fechaFin, estatus, resultados, objetivo, alumno_encargado, maestro_encargado, empresa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                                                    nombre, inicio, fin, status, result, objective, student, teacher, company), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Proyecto Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }


        public bool updateData(int id, string name, string name2, string pat, string mat) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE DatosUsuario SET nombre1 = '{0}', nombre2 = '{1}', apellidoPaterno = '{2}', apellidoMaterno = '{3}' WHERE usuario_id = '{4}';",
                                                    name, name2, pat, mat, id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Datos usuario Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool updateContact(int id, string correo, string cargo, string telefono) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE DatosContacto SET correo = '{0}', cargo = '{1}', telefono = '{2}' WHERE id_usuario = '{3}';",
                                                    correo, cargo, telefono, id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Datos contacto Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool updateTeacher(int id, int codigo, string carrera) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE Profesores SET codigo = '{0}', carrera = '{1}' WHERE usuario_id = '{2}';",
                                                    codigo, carrera, id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Profesores Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool updateCompany(int id, string name) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE Empresa VALUES SET nombre = '{0}' WHERE id_usuario = '{1}';",
                                                    id, name), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Empresa Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool updateStudent(int id, int matricula, string carrera, string nivel, string turno) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE Alumnos SET matricula = '{0}', carrera = '{1}', nivel = '{2}', turno = '{3}' WHERE usuario_id = '{4}';",
                                                    matricula, carrera, nivel, turno, id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Alumno Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool updateProject(int id, string nombre, string inicio, string fin, string status, string result, string objective, int student, int teacher, string company) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE Proyecto SET nombre = '{0}', fechaInicio='{1}', fechaFin='{2}', estatus'{3}', resultados='{4}', objetivo='{5}', alumno_encargado='{6}', maestro_encargado='{7}', empresa='{9}' WHERE id = '{8}';",
                                                    nombre, inicio, fin, status, result, objective, student, teacher, id, company), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Proyecto Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool updateUsrType(int id, string type) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE TipoUsuario SET tipo = '{0}' WHERE usuario_id = '{1}';",
                                                    type, id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("TipoUsuario Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        } 

        public bool updateUserPass(int id, string user, string pass) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE Usuario SET userName = '{0}', password = '{1}' WHERE id = '{2}';",
                                                    user, pass, id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("TipoUsuario Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public int getProjectId(string name) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT id FROM Proyecto WHERE nombre='{0}'", name), con);
            MySqlDataReader myReader = comando.ExecuteReader();
            int id = new int();
            while (myReader.Read()) {
                id = myReader.GetInt32(myReader.GetOrdinal("id"));
            }

            con.Close();
            return id;
        }

        public int getIDN(string name) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT usuario_id FROM DatosUsuario WHERE nombre1='{0}'", name), con);
            MySqlDataReader myReader = comando.ExecuteReader();
            int id = new int();
            while (myReader.Read()) {
                id = myReader.GetInt32(myReader.GetOrdinal("usuario_id"));
            }

            con.Close();
            return id;
        }

        public Dictionary<string, string> getUserData(string name) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM DatosUsuario WHERE nombre1 = '{0}';", name), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["id"] = myReader.GetInt32(myReader.GetOrdinal("usuario_id")).ToString();
                data["nombre1"] = myReader.GetString(myReader.GetOrdinal("nombre1"));
                data["nombre2"] = myReader.GetString(myReader.GetOrdinal("nombre2"));
                data["mat"] = myReader.GetString(myReader.GetOrdinal("apellidoMaterno"));
                data["pat"] = myReader.GetString(myReader.GetOrdinal("apellidoPaterno"));
            }
            return data;
        }

        public Dictionary<string, string> getStudent(int id) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Alumnos WHERE usuario_id = '{0}';", id), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["matricula"] = myReader.GetInt32(myReader.GetOrdinal("matricula")).ToString();
                data["carrera"] = myReader.GetString(myReader.GetOrdinal("carrera"));
                data["nivel"] = myReader.GetString(myReader.GetOrdinal("nivel"));
                data["turno"] = myReader.GetString(myReader.GetOrdinal("turno"));
            }
            return data;
        } 

        public Dictionary<string, string> getTeacher(int id) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Profesores WHERE usuario_id = '{0}';", id), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["codigo"] = myReader.GetInt32(myReader.GetOrdinal("codigo")).ToString();
                data["carrera"] = myReader.GetString(myReader.GetOrdinal("carrera"));
            }
            return data;
        }

        public Dictionary<string, string> getCompany(int id) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Empresa WHERE id_usuario = '{0}';", id), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["nombre"] = myReader.GetString(myReader.GetOrdinal("nombre"));
            }
            return data;
        }

        public Dictionary<string, string> getContact(int id) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM DatosContacto WHERE id_usuario = '{0}';", id), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["telefono"] = myReader.GetInt32(myReader.GetOrdinal("telefono")).ToString();
                data["correo"] = myReader.GetString(myReader.GetOrdinal("correo"));
                data["cargo"] = myReader.GetString(myReader.GetOrdinal("cargo"));
            }
            return data;
        }

        public Dictionary<string, string> getUserNameP(int id) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Usuario WHERE id = '{0}';", id), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["username"] = myReader.GetString(myReader.GetOrdinal("userName"));
                data["password"] = myReader.GetString(myReader.GetOrdinal("password"));
            }
            return data;
        }

        public Dictionary<string, string> getProyect(string nombre) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            MySqlConnection conexion = this.connect();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Proyecto WHERE nombre = '{0}';", nombre), conexion);
            conexion.Open();
            MySqlDataReader myReader;
            myReader = comando.ExecuteReader();
            while (myReader.Read()) {
                data["id"] = myReader.GetInt32(myReader.GetOrdinal("id")).ToString();
                data["nombre"] = myReader.GetString(myReader.GetOrdinal("nombre"));
                data["inicio"] = myReader.GetString(myReader.GetOrdinal("fechaInicio"));
                data["fin"] = myReader.GetString(myReader.GetOrdinal("fechaFin"));
                data["estatus"] = myReader.GetString(myReader.GetOrdinal("estatus"));
                data["result"] = myReader.GetString(myReader.GetOrdinal("resultados"));
                data["objetivo"] = myReader.GetString(myReader.GetOrdinal("objetivo"));
                data["alumno"] = myReader.GetString(myReader.GetOrdinal("alumno_encargado"));
                data["maestro"] = myReader.GetString(myReader.GetOrdinal("maestro_encargado"));
                data["empresa"] = myReader.GetString(myReader.GetOrdinal("empresa"));
            }
            return data;
        }

        public bool deleteUser(int id) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM Usuario WHERE id='{0}';",
                                                    id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Usuario Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public bool deleteProject(int id) {
            MySqlConnection con = this.connect();
            con.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("DELETE FROM Proyecto WHERE id='{0}';",
                                                    id), con);
            int updatedRows = comando.ExecuteNonQuery();
            Console.WriteLine("Proyecto Rows: " + updatedRows);
            if (updatedRows > 0) {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public db() {
		}
	}
}

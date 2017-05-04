import MySQLdb

conexion = MySQLdb.connect('localhost','root','Lizbeth','ProyectoHassem')

cursor = conexion.cursor()

sentencia = 'SELECT * FROM Tabla1;'
cursor.execute(sentencia)
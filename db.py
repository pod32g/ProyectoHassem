import MySQLdb

conexion = MySQLdb.connect('localhost','root','','ProyectoHassem')

cursor = conexion.cursor()

sentencia = 'INSERT INTO Usuario (nonbre) VALUES (Gerardo Vega)'
cursor.execute(sentencia)
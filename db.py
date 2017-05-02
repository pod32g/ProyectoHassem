import MySQLdb

conexion = MySQLdb.connect('192.168.137.187','root','','ProyectoHassem')

cursor = conexion.cursor()

sentencia = 'INSERT INTO Usuario (nonbre) VALUES (Gerardo Vega)'
cursor.execute(sentencia)
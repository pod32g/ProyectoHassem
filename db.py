import MySQLdb

def consulta(sentencia):
	lista = []
	conexion = MySQLdb.connect('host','usuario','password','database')
	cursor = conexion.cursor()
	cursor.execute(sentencia)
	filas = cursor.fetchall() #fetchall() extrae todos los registros que cumplen la condicion especificada
	for fila in filas:
		fila = list(fila)
		for element in fila:
			if(type(element) == long):
				element = int(element)
		fila = tuple(fila)
		lista.append(fila)
	conexion.commit()
	conexion.close()
	return lista

sentencia = "SELECT * FROM test WHERE ciudad = 'Guadalajara';"
datos = consulta(sentencia)

datos = consulta(sentencia)
print(datos)
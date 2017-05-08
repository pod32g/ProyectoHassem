import MySQLdb
#Funcion que retorna en una lista todos los registros de la tabla
def consulta(sentencia):
	lista = []
	conexion = MySQLdb.connect('localhost','root','Lizbeth','ProyectoHassem')
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

#sentencia = "SELECT * FROM test WHERE ciudad = 'Guadalajara';"
#datos = consulta(sentencia)

#datos = consulta(sentencia)
#print(datos)

#Funcion que verifica si un regisrtro ya existe
def existe(tabla,atributo,valor):
	sentencia = "SELECT * FROM " + tabla + " WHERE " + atributo + " = " + valor + ";"
	print(sentencia)
	conexion = MySQLdb.connect('localhost','root','Lizbeth','ProyectoHassem')
	cursor = conexion.cursor()
	cursor.execute(sentencia)
	conexion.commit()
	conexion.close()
	print obtenido #Quiero saber el valor obtenido para saber que retornar, pero no llega hasta aqui men, truena en el execute

existe('test','nombre','Jorge')

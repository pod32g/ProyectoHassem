import MySQLdb
#Funcion que retorna en una lista todos los registros de la tabla
def consulta(sentencia):
	lista = []
	conexion = MySQLdb.connect('pod32g.mysql.pythonanywhere-services.com','pod32g','q35eJUXUZmjXSXs','pod32g$ProyectoUTJ')
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

#Funcion que verifica si un nombre de usuario ya existe
def existeUsuario(userName):
	sentencia = "SELECT * FROM Usuario WHERE userName = '" + userName + "';"
	#print(sentencia)
	conexion = MySQLdb.connect('pod32g.mysql.pythonanywhere-services.com','pod32g','q35eJUXUZmjXSXs','pod32g$ProyectoUTJ')
	cursor = conexion.cursor()
	cursor.execute(sentencia)
	obtenido = cursor.fetchall()
	conexion.commit()
	conexion.close()
	if (len(obtenido)==0):
		return False
	else:
		return True

#Funcion que verifica si un password esta correcto
def correctPassword(userName,password):
	conexion = MySQLdb.connect('pod32g.mysql.pythonanywhere-services.com','pod32g','q35eJUXUZmjXSXs','pod32g$ProyectoUTJ')
	#print(sentencia)
	conexion = MySQLdb.connect('localhost','root','Lizbeth','ProyectoHassem')
	cursor = conexion.cursor()
	cursor.execute(sentencia)
	obtenido = cursor.fetchall()
	conexion.commit()
	conexion.close()
	if (len(obtenido)==0):
		return False
	else:
		return True

#Insert de la tabla 'Usuario'
def nuevoUsuario(userName,password):
	sentencia = "INSERT INTO Usuario (userName,password) VALUES ('"+ userName +"','"+ password + "');"
	#print(sentencia)
	conexion = MySQLdb.connect('pod32g.mysql.pythonanywhere-services.com','pod32g','q35eJUXUZmjXSXs','pod32g$ProyectoUTJ')
	cursor = conexion.cursor()
	cursor.execute(sentencia)
	conexion.commit()
	conexion.close()

llamada = nuevoUsuario('Vega','QwertY')
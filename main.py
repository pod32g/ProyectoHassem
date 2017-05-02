from flask import Flask, render_template, request, json
from werkzeug import generate_password_hash, check_password_hash


app = Flask(__name__)

@app.route("/")
def main():
	return render_template('index.html')

@app.route("/signup", methods=['POST'])
def showSignUp():
	#Insertar codigo sign up aqui :v
	'''
		To get data from UI
			request.form['Variable Name']

		To deliver data to UI
			json.dumps({Json data})

		To store passwords
			generate_password_hash(_password)
	'''

	return render_template('signup.html')



if __name__ == '__main__':
	app.run()
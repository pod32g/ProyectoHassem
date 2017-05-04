from flask import Flask, render_template, request, json, session, redirect, url_for
from werkzeug import generate_password_hash, check_password_hash


app = Flask(__name__)

app.config.update(dict(
    DEBUG=True,
    SECRET_KEY='cyka blyat'
))

@app.route("/")
def main():
	return render_template('index.html')

"""
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
"""

@app.route('/login', methods=['GET', 'POST'])
def login():
    error = None
    if request.method == 'POST':
    	session['logged_in'] = True
    	return redirect('/')
    	'''
        if request.form['username']:
            error = 'Invalid username'
        elif request.form['password']:
            error = 'Invalid password'
        else:
            session['logged_in'] = True
            flash('You were logged in')
            return redirect(url_for('show_entries'))
        '''
    return render_template('login.html', error=error)

@app.route('/logout')
def logout():
	if session['logged_in']:
		session.clear()
		return redirect('/')

if __name__ == '__main__':
	app.run()
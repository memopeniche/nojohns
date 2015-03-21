using System;

namespace hackaton
{
	public class UserClass
	{
		//Parametros
		string name, lname, phone, mail, address, user, password;

		public UserClass (string n, string l, string p, string m, string a, string u, string pass)
		{
			name = n;
			lname = l;
			phone = p;
			mail = m;
			address = a;
			user = u;
			password = pass;
		}
		public void AddUser(){
			//send to mysql
			string aux = " ";
			aux += "begin call Agrega_Usuario(";
			aux += "'" + name + "'";
			aux += "'" + lname + "'";
			aux += "'" + phone + "'";
			aux += "'" + mail + "'";
			aux += "'" + address + "'";
			aux += "'" + name + "'";
			aux += "'" + user + "'";
			aux += "'" + password + "'";
			aux += "'" + "123" + "'";
			aux += "); end";
		}
		public void FetchUser(){
			//fetch user from mysql
		}

	}
}


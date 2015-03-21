using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;
using System.Data;

namespace hackaton
{
	public class MySqlClass
	{

		MySqlConnection _Conn;

		public void Conectar(string pUsr, string pPsw)
		{
			string SC;

			SC = "User Id=" + pUsr + ";pwd=" + pPsw + ";Server=192.168.1.103;Port=3306;database=MYBDATOS";

			_Conn = new MySqlConnection(SC);

			_Conn.Open();
		}

	}
}


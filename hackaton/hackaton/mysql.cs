using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackaton
{
	public class mysql
	{
		MySqlConnection conn = null;
		MySqlDataReader rdr = null;

		public mysql(string server)
		{
		}

		static string myS(string c)
		{
			string cs = @"server=192.168.23.68;userid=memo;
            password=culo;database=tarea";

			try
			{
				conn = new MySqlConnection(cs);
				conn.Open();

				string stm = c;
				MySqlCommand cmd = new MySqlCommand(stm, conn);


			}
			catch (MySqlException ex)
			{
				Console.WriteLine("Error: {0}", ex.ToString());

			}
			finally
			{
				if (conn != null)
				{
					conn.Close();
				}

			}
		}
	}
}
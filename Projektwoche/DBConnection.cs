using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projektwoche
{
	class DBConnection
	{
		public static string server = "";
		public static string user = "";
		public static string pw = "";
		public static string database = "";
		public static bool isProjektwoche = true;

		public static void saveData()
		{
			Properties.Settings.Default.server = DBConnection.server;
			Properties.Settings.Default.user = DBConnection.user;
			Properties.Settings.Default.pw = DBConnection.pw;
			Properties.Settings.Default.database = DBConnection.database;
			Properties.Settings.Default.isProjektwoche = DBConnection.isProjektwoche;
			Properties.Settings.Default.Save();
		}

		public static void getData()
		{
			DBConnection.server = Properties.Settings.Default.server;
			DBConnection.user = Properties.Settings.Default.user;
			DBConnection.pw = Properties.Settings.Default.pw;
			DBConnection.database = Properties.Settings.Default.database;
			DBConnection.isProjektwoche = Properties.Settings.Default.isProjektwoche;
		}

		public static string createConnectionString()
		{
			return String.Format("server={0};uid={1};pw={2};database={3}",
				DBConnection.server, DBConnection.user, DBConnection.pw, DBConnection.database);
		}
		public static MySqlConnection createConnection()
		{
			return new MySqlConnection(DBConnection.createConnectionString());
		}
	}
}

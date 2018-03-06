using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projektwoche.UserControls
{
	public partial class Wahl : UserControl
	{
		public Wahl()
		{
			InitializeComponent();
		}

		public void loadSchueler()
		{
			try
			{
				MySqlConnection db = DBConnection.getConnection();
				MySqlCommand datenbanken = new MySqlCommand("SELECT * FROM schueler", db);

				db.Open();
				MySqlDataReader reader = datenbanken.ExecuteReader();
				this.listBoxSchueler.Items.Clear();
				while (reader.Read())
				{
					string schueler = String.Format("{0}: {1}, {2}", reader["schuelerID"].ToString(), reader["nachname"].ToString(), reader["vorname"].ToString());
					this.listBoxSchueler.Items.Add(schueler);
				}
				db.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void loadWorkshops()
		{
			try
			{
				MySqlConnection db = DBConnection.getConnection();
				MySqlCommand datenbanken = new MySqlCommand("SELECT * FROM workshop", db);

				db.Open();
				MySqlDataReader reader = datenbanken.ExecuteReader();
				this.comboBox9Uhr.Items.Clear();
				while (reader.Read())
				{
					this.comboBox9Uhr.Items.Add(reader["titel"].ToString());
				}
				db.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void buttonSpeichern_Click(object sender, EventArgs e)
		{
			try
			{
				string wahl_query = String.Format("SELECT * FROM rel_workshop_schueler_wahl WHERE schuelerID = {0}", this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]);
				string query = "";
				MySqlConnection db = DBConnection.getConnection();
				MySqlCommand wahl_exists = new MySqlCommand(wahl_query, db);

				db.Open();
				MySqlDataReader reader = wahl_exists.ExecuteReader();
				if (reader.HasRows)
				{
					query = String.Format("UPDATE rel_workshop_schueler_wahl SET workshopID = (SELECT workshopID FROM workshop WHERE titel = '{0}') WHERE schuelerID = {1}",
						this.comboBox9Uhr.SelectedItem.ToString(),
						this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]
					);
				}
				else
				{
					query = String.Format("INSERT INTO rel_workshop_schueler_wahl SET workshopID = (SELECT workshopID FROM workshop WHERE titel = '{0}'), schuelerID = {1}",
						this.comboBox9Uhr.SelectedItem.ToString(),
						this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]
					);
				}
				reader.Close();

				MySqlCommand wahl = new MySqlCommand(query, db);
				wahl.ExecuteNonQuery();
				db.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void listBoxSchueler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBoxSchueler.SelectedIndex == -1)
			{
				return;
			}
			try
			{
				string query = String.Format("SELECT titel FROM workshop WHERE workshopID = (SELECT workshopID FROM rel_workshop_schueler_wahl WHERE schuelerID = {0})", this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]);

				MySqlConnection db = DBConnection.getConnection();
				MySqlCommand workshop = new MySqlCommand(query, db);

				db.Open();
				MySqlDataReader reader = workshop.ExecuteReader();
				reader.Read();
				if (reader.HasRows)
				{
					this.comboBox9Uhr.SelectedIndex = this.comboBox9Uhr.Items.IndexOf(reader["titel"].ToString());
				}
				else
				{
					this.comboBox9Uhr.SelectedIndex = -1;
				}
				db.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}

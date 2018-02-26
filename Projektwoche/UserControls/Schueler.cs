using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projektwoche.UserControls
{
	public partial class Schueler : UserControl
	{
		public Schueler()
		{
			InitializeComponent();
		}

		public void loadSchueler()
		{
			try
			{
				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand datenbanken = new MySqlCommand("SELECT * FROM schueler", db);

				db.Open();
				MySqlDataReader reader = datenbanken.ExecuteReader();
				this.listBoxSchueler.Items.Clear();
				while (reader.Read())
				{
					string schueler = String.Format("{0}: {1}, {2}", reader["schuelerID"].ToString(), reader["nachname"].ToString(), reader["vorname"].ToString());
					this.listBoxSchueler.Items.Add(schueler);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void loadCLasses()
		{
			try
			{
				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand datenbanken = new MySqlCommand("SELECT * FROM klasse", db);

				db.Open();
				MySqlDataReader reader = datenbanken.ExecuteReader();
				while (reader.Read())
				{
					this.comboBoxKlasse.Items.Add(reader["bezeichnung"].ToString());
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void buttonNeu_Click(object sender, EventArgs e)
		{
			this.clearTextboxes();
			this.listBoxSchueler.ClearSelected();
		}

		public void clearTextboxes()
		{
			this.textBoxVorname.Text = "";
			this.textBoxNachname.Text = "";
			this.textBoxEmail.Text = "";

			this.comboBoxKlasse.SelectedIndex = -1;
		}

		private void listBoxSchueler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBoxSchueler.SelectedIndex == -1)
			{
				return;
			}
			try
			{
				string query = String.Format("SELECT * FROM schueler s INNER JOIN klasse k ON k.klasseID = s.klasseID WHERE schuelerID = '{0}' ORDER BY nachname, vorname", this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]);

				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand workshop = new MySqlCommand(query, db);

				db.Open();
				MySqlDataReader reader = workshop.ExecuteReader();
				while (reader.Read())
				{
					this.textBoxVorname.Text = reader["vorname"].ToString();
					this.textBoxNachname.Text = reader["nachname"].ToString();
					this.textBoxEmail.Text = reader["email"].ToString();
					this.comboBoxKlasse.SelectedIndex = this.comboBoxKlasse.Items.IndexOf(reader["bezeichnung"]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void buttonSpeichern_Click(object sender, EventArgs e)
		{

			try
			{
				MySqlConnection db = DBConnection.createConnection();
				string query = "";
				if (this.listBoxSchueler.SelectedIndex == -1)
				{
					query = String.Format("INSERT INTO schueler SET vorname = '{0}', nachname = '{1}', email = '{2}', klasseID = (SELECT klasseID FROM klasse WHERE bezeichnung = '{3}')",
						this.textBoxVorname.Text,
						this.textBoxNachname.Text,
						this.textBoxEmail.Text,
						this.comboBoxKlasse.SelectedItem.ToString()
					);
				}
				else
				{
					query = String.Format("UPDATE schueler SET vorname = '{0}', nachname = '{1}', email = '{2}', klasseID = (SELECT klasseID FROM klasse WHERE bezeichnung = '{3}') WHERE schuelerid = {4}",
						this.textBoxVorname.Text,
						this.textBoxNachname.Text,
						this.textBoxEmail.Text,
						this.comboBoxKlasse.SelectedItem.ToString(),
						this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]
					);
				}
				MySqlCommand schueler = new MySqlCommand(query, db);

				db.Open();
				schueler.ExecuteNonQuery();
				if (this.listBoxSchueler.SelectedIndex != -1)
				{
					int currIndex = this.listBoxSchueler.SelectedIndex;
					this.loadSchueler();
					this.listBoxSchueler.SelectedIndex = currIndex;
				}
				else
				{
					this.loadSchueler();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void buttonLöschen_Click(object sender, EventArgs e)
		{
			if (this.listBoxSchueler.SelectedIndex == -1)
			{
				return;
			}

			try
			{
				string query = String.Format("DELETE FROM schueler WHERE schuelerID = '{0}'", this.listBoxSchueler.SelectedItem.ToString().Split(new string[] { ":" }, StringSplitOptions.None)[0]);

				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand schueler = new MySqlCommand(query, db);

				db.Open();
				schueler.ExecuteNonQuery();
				this.loadSchueler();
				this.clearTextboxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

	}
}

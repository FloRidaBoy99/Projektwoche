using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projektwoche.UserControls
{
	public partial class EditWorkshop : UserControl
	{
		private bool isNewEntry = true;

		public EditWorkshop()
		{
			InitializeComponent();
			this.listBoxWorkshops.Focus();
		}
		
		public void loadWorkshops()
		{
			try
			{
				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand alleWorkshops = new MySqlCommand("SELECT titel FROM workshop ORDER BY titel asc", db);

				db.Open();
				MySqlDataReader reader = alleWorkshops.ExecuteReader();
				this.listBoxWorkshops.Items.Clear();
				while (reader.Read())
				{
					this.listBoxWorkshops.Items.Add(reader["titel"].ToString());
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void listBoxWorkshops_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string query = String.Format("SELECT * FROM workshop WHERE titel = '{0}'", this.listBoxWorkshops.Text.ToString());

				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand workshop = new MySqlCommand(query, db);

				db.Open();
				MySqlDataReader reader = workshop.ExecuteReader();
				while (reader.Read())
				{
					this.textBoxNr.Text = reader["nr"].ToString();
					this.textBoxTitel.Text = reader["titel"].ToString();
					this.textBoxKosten.Text = reader["kosten"].ToString();
					this.textBoxBeschreibung.Text = reader["beschreibung"].ToString();
					this.textBoxVoraussetzungen.Text = reader["voraussetzungen"].ToString();
					this.textBoxTeilnehmerMin.Text = reader["teilnehmerMin"].ToString();
					this.textBoxTeilnehmerMax.Text = reader["teilnehmerMax"].ToString();
				}
				this.isNewEntry = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void clearTextboxes()
		{
			this.textBoxNr.Text = "";
			this.textBoxTitel.Text = "";
			this.textBoxKosten.Text = "";
			this.textBoxBeschreibung.Text = "";
			this.textBoxVoraussetzungen.Text = "";
			this.textBoxTeilnehmerMin.Text = "";
			this.textBoxTeilnehmerMax.Text = "";
		}

		private void buttonNeu_Click(object sender, EventArgs e)
		{
			this.clearTextboxes();
			this.isNewEntry = true;			
		}

		private void buttonSpeichern_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlConnection db = DBConnection.createConnection();
				string query = "";
				if (isNewEntry)
				{
					query = String.Format("INSERT INTO workshop SET nr = {0}, titel = '{1}', kosten = '{2}', beschreibung = '{3}', voraussetzungen = '{4}', teilnehmerMin = {5}, teilnehmerMax = {6}",
						Convert.ToInt32(this.textBoxNr.Text),
						this.textBoxTitel.Text,
						this.textBoxKosten.Text,
						this.textBoxBeschreibung.Text,
						this.textBoxVoraussetzungen.Text,
						Convert.ToInt32(this.textBoxTeilnehmerMin.Text),
						Convert.ToInt32(this.textBoxTeilnehmerMax.Text)
					);
				}
				else
				{
					query = String.Format("UPDATE workshop SET nr = {0}, titel = '{1}', kosten = '{2}', beschreibung = '{3}', voraussetzungen = '{4}', teilnehmerMin = {5}, teilnehmerMax = {6} WHERE titel = '{7}'",
						Convert.ToInt32(this.textBoxNr.Text),
						this.textBoxTitel.Text,
						this.textBoxKosten.Text,
						this.textBoxBeschreibung.Text,
						this.textBoxVoraussetzungen.Text,
						Convert.ToInt32(this.textBoxTeilnehmerMin.Text),
						Convert.ToInt32(this.textBoxTeilnehmerMax.Text),
						this.listBoxWorkshops.Text.ToString()
					);
				}
				MySqlCommand workshop = new MySqlCommand(query, db);

				db.Open();
				workshop.ExecuteNonQueryAsync();
				if (this.listBoxWorkshops.SelectedIndex != -1 && isNewEntry == false)
				{
					int currIndex = this.listBoxWorkshops.SelectedIndex;
					this.loadWorkshops();
					this.listBoxWorkshops.SelectedIndex = currIndex;
				}
				else
				{
					this.loadWorkshops();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void buttonLoeschen_Click(object sender, EventArgs e)
		{
			try
			{
				string query = String.Format("DELETE FROM workshop WHERE titel = '{0}'", this.listBoxWorkshops.Text.ToString());

				MySqlConnection db = DBConnection.createConnection();
				MySqlCommand workshop = new MySqlCommand(query, db);

				db.Open();
				workshop.ExecuteNonQuery();
				this.loadWorkshops();
				this.clearTextboxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}

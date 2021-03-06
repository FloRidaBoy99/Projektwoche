﻿using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Projektwoche
{
	public partial class FormOeffnen : Form
	{
		public FormOeffnen()
		{
			InitializeComponent();
			try
			{
				MySqlConnection db = DBConnection.getConnection();
				MySqlCommand datenbanken = new MySqlCommand("SHOW DATABASES", db);

				db.Open();
				MySqlDataReader reader = datenbanken.ExecuteReader();
				while (reader.Read())
				{
					this.comboBoxAuswahl.Items.Add(reader["database"].ToString());
				}
				db.Close();
				this.comboBoxAuswahl.SelectedIndex = 0;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				this.Close();
			}

		}

		private void buttonOeffnen_Click(object sender, EventArgs e)
		{
			DBConnection.database = this.comboBoxAuswahl.SelectedItem.ToString();
			DBConnection.saveData();
			this.Close();
		}
	}
}

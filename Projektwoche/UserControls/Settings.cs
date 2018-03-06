using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Projektwoche.UserControls
{
	public partial class Settings : UserControl
	{
		public Settings()
		{
			InitializeComponent();
		}

		public void loadData()
		{
			this.textBoxDatenbank.Text = DBConnection.database;
			this.textBoxPasswort.Text = DBConnection.pw;
			this.textBoxServer.Text = DBConnection.server;
			this.textBoxUserID.Text = DBConnection.user;
		}

		private void textBoxServer_Validating(object sender, CancelEventArgs e)
		{
			saveServer();
		}

		private void saveServer()
		{
			DBConnection.server = this.textBoxServer.Text;
			DBConnection.saveData();
		}

		private void textBoxUserID_Validating(object sender, CancelEventArgs e)
		{
			saveUser();
		}

		private void saveUser()
		{
			DBConnection.user = this.textBoxUserID.Text;
			DBConnection.saveData();
		}

		private void textBoxPasswort_Validating(object sender, CancelEventArgs e)
		{
			savePW();
		}

		private void savePW()
		{
			DBConnection.pw = this.textBoxPasswort.Text;
			DBConnection.saveData();
		}

		private void textBoxDatenbank_Validating(object sender, CancelEventArgs e)
		{
			saveDB();
		}

		private void saveDB()
		{
			DBConnection.database = this.textBoxDatenbank.Text;
			DBConnection.saveData();
		}

		private void textBoxServer_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.saveServer();
			}
		}

		private void textBoxUserID_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.saveUser();
			}
		}

		private void textBoxPasswort_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.savePW();
			}
		}

		private void textBoxDatenbank_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.saveDB();
			}
		}
	}
}

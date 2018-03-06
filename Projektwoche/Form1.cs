using System;
using System.Windows.Forms;

namespace Projektwoche
{
	public partial class Form1 : Form
	{
		private UserControls.EditWorkshop ucWorkshop = new UserControls.EditWorkshop();
		private UserControls.Settings ucSettings = new UserControls.Settings();
		private UserControls.Schueler ucSchueler = new UserControls.Schueler();
		private UserControls.Wahl ucWahl = new UserControls.Wahl();

		public Form1()
		{
			InitializeComponent();
			DBConnection.getData();
			DBConnection.createConnection();

			this.ucWorkshop.Dock = DockStyle.Fill;
			this.ucSettings.Dock = DockStyle.Fill;
			this.ucSchueler.Dock = DockStyle.Fill;
			this.ucWahl.Dock = DockStyle.Fill;
		}

		private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormOeffnen formOeffnen = new FormOeffnen();
			formOeffnen.ShowDialog();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DBConnection.saveData();
		}

		private void workshopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.ucWorkshop.loadWorkshops();
			this.panel1.Controls.Add(this.ucWorkshop);
		}

		private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.ucSettings.loadData();
			this.panel1.Controls.Add(this.ucSettings);
		}

		private void neuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormNeu formNeu = new FormNeu();
			formNeu.ShowDialog();
		}

		private void schülerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.ucSchueler.loadCLasses();
			this.ucSchueler.loadSchueler();
			this.panel1.Controls.Add(this.ucSchueler);
		}

		private void wahlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.ucWahl.loadSchueler();
			this.ucWahl.loadWorkshops();
			this.panel1.Controls.Add(this.ucWahl);
		}
	}
}

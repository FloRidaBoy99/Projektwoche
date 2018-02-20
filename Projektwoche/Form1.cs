using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektwoche
{
	public partial class Form1 : Form
	{
		private UserControls.EditWorkshop ucWorkshop = new UserControls.EditWorkshop();
		private UserControls.Settings ucSettings = new UserControls.Settings();

		public Form1()
		{
			InitializeComponent();
			DBConnection.getData();


			this.ucWorkshop.Dock = DockStyle.Fill;
			this.ucSettings.Dock = DockStyle.Fill;
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
			this.panel1.Controls.Add(this.ucSettings);
		}
	}
}

namespace Projektwoche
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.workshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.schülerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wahlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.ansichtToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(688, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// neuToolStripMenuItem
			// 
			this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
			this.neuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.neuToolStripMenuItem.Text = "Neu";
			this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
			// 
			// öffnenToolStripMenuItem
			// 
			this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
			this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.öffnenToolStripMenuItem.Text = "Öffnen";
			this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
			// 
			// einstellungenToolStripMenuItem
			// 
			this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
			this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.einstellungenToolStripMenuItem.Text = "Einstellungen";
			this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
			// 
			// ansichtToolStripMenuItem
			// 
			this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workshopToolStripMenuItem,
            this.schülerToolStripMenuItem,
            this.wahlToolStripMenuItem});
			this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
			this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.ansichtToolStripMenuItem.Text = "Ansicht";
			// 
			// workshopToolStripMenuItem
			// 
			this.workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
			this.workshopToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.workshopToolStripMenuItem.Text = "Workshop";
			this.workshopToolStripMenuItem.Click += new System.EventHandler(this.workshopToolStripMenuItem_Click);
			// 
			// schülerToolStripMenuItem
			// 
			this.schülerToolStripMenuItem.Name = "schülerToolStripMenuItem";
			this.schülerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.schülerToolStripMenuItem.Text = "Schüler";
			// 
			// wahlToolStripMenuItem
			// 
			this.wahlToolStripMenuItem.Name = "wahlToolStripMenuItem";
			this.wahlToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.wahlToolStripMenuItem.Text = "Wahl";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 357);
			this.panel1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 396);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Projektwoche";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem workshopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem schülerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wahlToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
	}
}


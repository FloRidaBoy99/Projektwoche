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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.workshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.schülerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wahlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(13, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(552, 357);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.ansichtToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(577, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// neuToolStripMenuItem
			// 
			this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
			this.neuToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.neuToolStripMenuItem.Text = "Neu";
			// 
			// öffnenToolStripMenuItem
			// 
			this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
			this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.öffnenToolStripMenuItem.Text = "Öffnen";
			// 
			// einstellungenToolStripMenuItem
			// 
			this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
			this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.einstellungenToolStripMenuItem.Text = "Einstellungen";
			// 
			// ansichtToolStripMenuItem
			// 
			this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workshopToolStripMenuItem,
            this.schülerToolStripMenuItem,
            this.wahlToolStripMenuItem});
			this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
			this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.ansichtToolStripMenuItem.Text = "Ansicht";
			// 
			// workshopToolStripMenuItem
			// 
			this.workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
			this.workshopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.workshopToolStripMenuItem.Text = "Workshop";
			// 
			// schülerToolStripMenuItem
			// 
			this.schülerToolStripMenuItem.Name = "schülerToolStripMenuItem";
			this.schülerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.schülerToolStripMenuItem.Text = "Schüler";
			// 
			// wahlToolStripMenuItem
			// 
			this.wahlToolStripMenuItem.Name = "wahlToolStripMenuItem";
			this.wahlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.wahlToolStripMenuItem.Text = "Wahl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 396);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Projektwoche";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem workshopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem schülerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wahlToolStripMenuItem;
	}
}


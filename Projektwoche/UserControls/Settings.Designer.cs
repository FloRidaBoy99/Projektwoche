namespace Projektwoche.UserControls
{
	partial class Settings
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

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxServer = new System.Windows.Forms.TextBox();
			this.textBoxUserID = new System.Windows.Forms.TextBox();
			this.textBoxPasswort = new System.Windows.Forms.TextBox();
			this.textBoxDatenbank = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "UserID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Passwort";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Datenbank";
			// 
			// textBoxServer
			// 
			this.textBoxServer.Location = new System.Drawing.Point(64, 4);
			this.textBoxServer.Name = "textBoxServer";
			this.textBoxServer.Size = new System.Drawing.Size(100, 20);
			this.textBoxServer.TabIndex = 4;
			// 
			// textBoxUserID
			// 
			this.textBoxUserID.Location = new System.Drawing.Point(64, 30);
			this.textBoxUserID.Name = "textBoxUserID";
			this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
			this.textBoxUserID.TabIndex = 5;
			// 
			// textBoxPasswort
			// 
			this.textBoxPasswort.Location = new System.Drawing.Point(64, 56);
			this.textBoxPasswort.Name = "textBoxPasswort";
			this.textBoxPasswort.Size = new System.Drawing.Size(100, 20);
			this.textBoxPasswort.TabIndex = 6;
			// 
			// textBoxDatenbank
			// 
			this.textBoxDatenbank.Location = new System.Drawing.Point(64, 82);
			this.textBoxDatenbank.Name = "textBoxDatenbank";
			this.textBoxDatenbank.Size = new System.Drawing.Size(100, 20);
			this.textBoxDatenbank.TabIndex = 7;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxDatenbank);
			this.Controls.Add(this.textBoxPasswort);
			this.Controls.Add(this.textBoxUserID);
			this.Controls.Add(this.textBoxServer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Settings";
			this.Size = new System.Drawing.Size(195, 169);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxServer;
		private System.Windows.Forms.TextBox textBoxUserID;
		private System.Windows.Forms.TextBox textBoxPasswort;
		private System.Windows.Forms.TextBox textBoxDatenbank;
	}
}

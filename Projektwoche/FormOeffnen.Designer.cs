namespace Projektwoche
{
	partial class FormOeffnen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxAuswahl = new System.Windows.Forms.ComboBox();
			this.buttonOeffnen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxAuswahl
			// 
			this.comboBoxAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAuswahl.FormattingEnabled = true;
			this.comboBoxAuswahl.Location = new System.Drawing.Point(41, 26);
			this.comboBoxAuswahl.Name = "comboBoxAuswahl";
			this.comboBoxAuswahl.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAuswahl.TabIndex = 0;
			// 
			// buttonOeffnen
			// 
			this.buttonOeffnen.Location = new System.Drawing.Point(65, 53);
			this.buttonOeffnen.Name = "buttonOeffnen";
			this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
			this.buttonOeffnen.TabIndex = 1;
			this.buttonOeffnen.Text = "Öffnen";
			this.buttonOeffnen.UseVisualStyleBackColor = true;
			// 
			// FormOeffnen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 114);
			this.Controls.Add(this.buttonOeffnen);
			this.Controls.Add(this.comboBoxAuswahl);
			this.Name = "FormOeffnen";
			this.Text = "FormOeffnen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxAuswahl;
		private System.Windows.Forms.Button buttonOeffnen;
	}
}
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.buttonOeffnen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(41, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
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
			this.Controls.Add(this.comboBox1);
			this.Name = "FormOeffnen";
			this.Text = "FormOeffnen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonOeffnen;
	}
}
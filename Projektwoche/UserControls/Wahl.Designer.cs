namespace Projektwoche.UserControls
{
	partial class Wahl
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
			this.listBoxSchueler = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox9Uhr = new System.Windows.Forms.ComboBox();
			this.comboBox10Uhr = new System.Windows.Forms.ComboBox();
			this.comboBox11Uhr = new System.Windows.Forms.ComboBox();
			this.comboBox12Uhr = new System.Windows.Forms.ComboBox();
			this.buttonSpeichern = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxSchueler
			// 
			this.listBoxSchueler.FormattingEnabled = true;
			this.listBoxSchueler.Location = new System.Drawing.Point(4, 4);
			this.listBoxSchueler.Name = "listBoxSchueler";
			this.listBoxSchueler.Size = new System.Drawing.Size(404, 121);
			this.listBoxSchueler.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Workshop 9:00 Uhr";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Workshop 10:00 Uhr";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Workshop 11:00 Uhr";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Workshop 12:00 Uhr";
			// 
			// comboBox9Uhr
			// 
			this.comboBox9Uhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox9Uhr.FormattingEnabled = true;
			this.comboBox9Uhr.Location = new System.Drawing.Point(134, 132);
			this.comboBox9Uhr.Name = "comboBox9Uhr";
			this.comboBox9Uhr.Size = new System.Drawing.Size(197, 21);
			this.comboBox9Uhr.TabIndex = 8;
			// 
			// comboBox10Uhr
			// 
			this.comboBox10Uhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox10Uhr.FormattingEnabled = true;
			this.comboBox10Uhr.Location = new System.Drawing.Point(134, 159);
			this.comboBox10Uhr.Name = "comboBox10Uhr";
			this.comboBox10Uhr.Size = new System.Drawing.Size(197, 21);
			this.comboBox10Uhr.TabIndex = 9;
			// 
			// comboBox11Uhr
			// 
			this.comboBox11Uhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox11Uhr.FormattingEnabled = true;
			this.comboBox11Uhr.Location = new System.Drawing.Point(134, 186);
			this.comboBox11Uhr.Name = "comboBox11Uhr";
			this.comboBox11Uhr.Size = new System.Drawing.Size(197, 21);
			this.comboBox11Uhr.TabIndex = 10;
			// 
			// comboBox12Uhr
			// 
			this.comboBox12Uhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox12Uhr.FormattingEnabled = true;
			this.comboBox12Uhr.Location = new System.Drawing.Point(134, 213);
			this.comboBox12Uhr.Name = "comboBox12Uhr";
			this.comboBox12Uhr.Size = new System.Drawing.Size(197, 21);
			this.comboBox12Uhr.TabIndex = 11;
			// 
			// buttonSpeichern
			// 
			this.buttonSpeichern.Location = new System.Drawing.Point(173, 252);
			this.buttonSpeichern.Name = "buttonSpeichern";
			this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
			this.buttonSpeichern.TabIndex = 12;
			this.buttonSpeichern.Text = "Speichern";
			this.buttonSpeichern.UseVisualStyleBackColor = true;
			// 
			// Wahl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonSpeichern);
			this.Controls.Add(this.comboBox12Uhr);
			this.Controls.Add(this.comboBox11Uhr);
			this.Controls.Add(this.comboBox10Uhr);
			this.Controls.Add(this.comboBox9Uhr);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxSchueler);
			this.Name = "Wahl";
			this.Size = new System.Drawing.Size(428, 285);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxSchueler;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox9Uhr;
		private System.Windows.Forms.ComboBox comboBox10Uhr;
		private System.Windows.Forms.ComboBox comboBox11Uhr;
		private System.Windows.Forms.ComboBox comboBox12Uhr;
		private System.Windows.Forms.Button buttonSpeichern;
	}
}

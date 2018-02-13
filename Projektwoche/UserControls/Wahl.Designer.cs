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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
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
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(134, 132);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(197, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(134, 159);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(197, 21);
			this.comboBox2.TabIndex = 9;
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(134, 186);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(197, 21);
			this.comboBox3.TabIndex = 10;
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(134, 213);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(197, 21);
			this.comboBox4.TabIndex = 11;
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
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
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
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Button buttonSpeichern;
	}
}

namespace Projektwoche.UserControls
{
	partial class Schueler
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
			this.buttonNeu = new System.Windows.Forms.Button();
			this.buttonLöschen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxVorname = new System.Windows.Forms.TextBox();
			this.textBoxNachname = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxSchule = new System.Windows.Forms.TextBox();
			this.textBoxLehrkraft = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxKlasse = new System.Windows.Forms.ComboBox();
			this.comboBoxAbschluss = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonSpeichern = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxSchueler
			// 
			this.listBoxSchueler.FormattingEnabled = true;
			this.listBoxSchueler.Location = new System.Drawing.Point(4, 4);
			this.listBoxSchueler.Name = "listBoxSchueler";
			this.listBoxSchueler.Size = new System.Drawing.Size(157, 212);
			this.listBoxSchueler.TabIndex = 0;
			this.listBoxSchueler.SelectedIndexChanged += new System.EventHandler(this.listBoxSchueler_SelectedIndexChanged);
			// 
			// buttonNeu
			// 
			this.buttonNeu.Location = new System.Drawing.Point(4, 223);
			this.buttonNeu.Name = "buttonNeu";
			this.buttonNeu.Size = new System.Drawing.Size(75, 23);
			this.buttonNeu.TabIndex = 1;
			this.buttonNeu.Text = "Neu";
			this.buttonNeu.UseVisualStyleBackColor = true;
			this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
			// 
			// buttonLöschen
			// 
			this.buttonLöschen.Location = new System.Drawing.Point(85, 223);
			this.buttonLöschen.Name = "buttonLöschen";
			this.buttonLöschen.Size = new System.Drawing.Size(75, 23);
			this.buttonLöschen.TabIndex = 2;
			this.buttonLöschen.Text = "Löschen";
			this.buttonLöschen.UseVisualStyleBackColor = true;
			this.buttonLöschen.Click += new System.EventHandler(this.buttonLöschen_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(182, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Vorname";
			// 
			// textBoxVorname
			// 
			this.textBoxVorname.Location = new System.Drawing.Point(325, 4);
			this.textBoxVorname.Name = "textBoxVorname";
			this.textBoxVorname.Size = new System.Drawing.Size(121, 20);
			this.textBoxVorname.TabIndex = 5;
			// 
			// textBoxNachname
			// 
			this.textBoxNachname.Location = new System.Drawing.Point(325, 31);
			this.textBoxNachname.Name = "textBoxNachname";
			this.textBoxNachname.Size = new System.Drawing.Size(121, 20);
			this.textBoxNachname.TabIndex = 6;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(325, 58);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
			this.textBoxEmail.TabIndex = 7;
			// 
			// textBoxSchule
			// 
			this.textBoxSchule.Enabled = false;
			this.textBoxSchule.Location = new System.Drawing.Point(325, 140);
			this.textBoxSchule.Name = "textBoxSchule";
			this.textBoxSchule.Size = new System.Drawing.Size(121, 20);
			this.textBoxSchule.TabIndex = 8;
			// 
			// textBoxLehrkraft
			// 
			this.textBoxLehrkraft.Enabled = false;
			this.textBoxLehrkraft.Location = new System.Drawing.Point(325, 167);
			this.textBoxLehrkraft.Name = "textBoxLehrkraft";
			this.textBoxLehrkraft.Size = new System.Drawing.Size(121, 20);
			this.textBoxLehrkraft.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(182, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Nachname";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(182, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Email";
			// 
			// comboBoxKlasse
			// 
			this.comboBoxKlasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKlasse.FormattingEnabled = true;
			this.comboBoxKlasse.Location = new System.Drawing.Point(325, 85);
			this.comboBoxKlasse.Name = "comboBoxKlasse";
			this.comboBoxKlasse.Size = new System.Drawing.Size(121, 21);
			this.comboBoxKlasse.TabIndex = 12;
			// 
			// comboBoxAbschluss
			// 
			this.comboBoxAbschluss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAbschluss.Enabled = false;
			this.comboBoxAbschluss.FormattingEnabled = true;
			this.comboBoxAbschluss.Location = new System.Drawing.Point(325, 113);
			this.comboBoxAbschluss.Name = "comboBoxAbschluss";
			this.comboBoxAbschluss.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAbschluss.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(182, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Klasse";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(182, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "vorausichtlicher Abschluss";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(182, 143);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Schule";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(182, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "betreuende Lehrkraft";
			// 
			// buttonSpeichern
			// 
			this.buttonSpeichern.Location = new System.Drawing.Point(185, 223);
			this.buttonSpeichern.Name = "buttonSpeichern";
			this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
			this.buttonSpeichern.TabIndex = 18;
			this.buttonSpeichern.Text = "Speichern";
			this.buttonSpeichern.UseVisualStyleBackColor = true;
			this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
			// 
			// Schueler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonSpeichern);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxAbschluss);
			this.Controls.Add(this.comboBoxKlasse);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxLehrkraft);
			this.Controls.Add(this.textBoxSchule);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxNachname);
			this.Controls.Add(this.textBoxVorname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLöschen);
			this.Controls.Add(this.buttonNeu);
			this.Controls.Add(this.listBoxSchueler);
			this.Name = "Schueler";
			this.Size = new System.Drawing.Size(509, 282);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxSchueler;
		private System.Windows.Forms.Button buttonNeu;
		private System.Windows.Forms.Button buttonLöschen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxVorname;
		private System.Windows.Forms.TextBox textBoxNachname;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxSchule;
		private System.Windows.Forms.TextBox textBoxLehrkraft;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxKlasse;
		private System.Windows.Forms.ComboBox comboBoxAbschluss;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonSpeichern;
	}
}

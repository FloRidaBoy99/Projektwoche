namespace Projektwoche.UserControls
{
	partial class EditWorkshop
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
			this.listBoxWorkshops = new System.Windows.Forms.ListBox();
			this.buttonNeu = new System.Windows.Forms.Button();
			this.buttonLoeschen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNr = new System.Windows.Forms.TextBox();
			this.textBoxTitel = new System.Windows.Forms.TextBox();
			this.textBoxBeschreibung = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxKosten = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxVoraussetzungen = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxTeilnehmerMin = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTeilnehmerMax = new System.Windows.Forms.TextBox();
			this.buttonSpeichern = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxWorkshops
			// 
			this.listBoxWorkshops.FormattingEnabled = true;
			this.listBoxWorkshops.Location = new System.Drawing.Point(4, 4);
			this.listBoxWorkshops.Name = "listBoxWorkshops";
			this.listBoxWorkshops.Size = new System.Drawing.Size(120, 225);
			this.listBoxWorkshops.TabIndex = 0;
			this.listBoxWorkshops.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkshops_SelectedIndexChanged);
			// 
			// buttonNeu
			// 
			this.buttonNeu.Location = new System.Drawing.Point(4, 236);
			this.buttonNeu.Name = "buttonNeu";
			this.buttonNeu.Size = new System.Drawing.Size(120, 23);
			this.buttonNeu.TabIndex = 1;
			this.buttonNeu.Text = "Neu";
			this.buttonNeu.UseVisualStyleBackColor = true;
			this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
			// 
			// buttonLoeschen
			// 
			this.buttonLoeschen.Location = new System.Drawing.Point(4, 266);
			this.buttonLoeschen.Name = "buttonLoeschen";
			this.buttonLoeschen.Size = new System.Drawing.Size(120, 23);
			this.buttonLoeschen.TabIndex = 2;
			this.buttonLoeschen.Text = "Löschen";
			this.buttonLoeschen.UseVisualStyleBackColor = true;
			this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(128, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nr";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(255, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Titel";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(130, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Beschreibung";
			// 
			// textBoxNr
			// 
			this.textBoxNr.Location = new System.Drawing.Point(131, 21);
			this.textBoxNr.Name = "textBoxNr";
			this.textBoxNr.Size = new System.Drawing.Size(100, 20);
			this.textBoxNr.TabIndex = 6;
			// 
			// textBoxTitel
			// 
			this.textBoxTitel.Location = new System.Drawing.Point(258, 20);
			this.textBoxTitel.Name = "textBoxTitel";
			this.textBoxTitel.Size = new System.Drawing.Size(403, 20);
			this.textBoxTitel.TabIndex = 7;
			// 
			// textBoxBeschreibung
			// 
			this.textBoxBeschreibung.Location = new System.Drawing.Point(130, 72);
			this.textBoxBeschreibung.Multiline = true;
			this.textBoxBeschreibung.Name = "textBoxBeschreibung";
			this.textBoxBeschreibung.Size = new System.Drawing.Size(531, 80);
			this.textBoxBeschreibung.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(130, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Kosten";
			// 
			// textBoxKosten
			// 
			this.textBoxKosten.Location = new System.Drawing.Point(133, 184);
			this.textBoxKosten.Name = "textBoxKosten";
			this.textBoxKosten.Size = new System.Drawing.Size(100, 20);
			this.textBoxKosten.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(255, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Voraussetzungen";
			// 
			// textBoxVoraussetzungen
			// 
			this.textBoxVoraussetzungen.Location = new System.Drawing.Point(258, 183);
			this.textBoxVoraussetzungen.Name = "textBoxVoraussetzungen";
			this.textBoxVoraussetzungen.Size = new System.Drawing.Size(100, 20);
			this.textBoxVoraussetzungen.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(376, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Teilnehmer Min";
			// 
			// textBoxTeilnehmerMin
			// 
			this.textBoxTeilnehmerMin.Location = new System.Drawing.Point(379, 183);
			this.textBoxTeilnehmerMin.Name = "textBoxTeilnehmerMin";
			this.textBoxTeilnehmerMin.Size = new System.Drawing.Size(100, 20);
			this.textBoxTeilnehmerMin.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(511, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Teilnehmer Max";
			// 
			// textBoxTeilnehmerMax
			// 
			this.textBoxTeilnehmerMax.Location = new System.Drawing.Point(514, 183);
			this.textBoxTeilnehmerMax.Name = "textBoxTeilnehmerMax";
			this.textBoxTeilnehmerMax.Size = new System.Drawing.Size(100, 20);
			this.textBoxTeilnehmerMax.TabIndex = 16;
			// 
			// buttonSpeichern
			// 
			this.buttonSpeichern.Location = new System.Drawing.Point(133, 266);
			this.buttonSpeichern.Name = "buttonSpeichern";
			this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
			this.buttonSpeichern.TabIndex = 17;
			this.buttonSpeichern.Text = "Speichern";
			this.buttonSpeichern.UseVisualStyleBackColor = true;
			this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
			// 
			// EditWorkshop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonSpeichern);
			this.Controls.Add(this.textBoxTeilnehmerMax);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxTeilnehmerMin);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxVoraussetzungen);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxKosten);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxBeschreibung);
			this.Controls.Add(this.textBoxTitel);
			this.Controls.Add(this.textBoxNr);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLoeschen);
			this.Controls.Add(this.buttonNeu);
			this.Controls.Add(this.listBoxWorkshops);
			this.Name = "EditWorkshop";
			this.Size = new System.Drawing.Size(664, 323);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxWorkshops;
		private System.Windows.Forms.Button buttonNeu;
		private System.Windows.Forms.Button buttonLoeschen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNr;
		private System.Windows.Forms.TextBox textBoxTitel;
		private System.Windows.Forms.TextBox textBoxBeschreibung;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxKosten;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxVoraussetzungen;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTeilnehmerMin;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxTeilnehmerMax;
		private System.Windows.Forms.Button buttonSpeichern;
	}
}

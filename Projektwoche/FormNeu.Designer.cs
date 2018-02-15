namespace Projektwoche
{
	partial class FormNeu
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButtonMMT = new System.Windows.Forms.RadioButton();
			this.radioButtonProjektWoche = new System.Windows.Forms.RadioButton();
			this.buttonAnlegen = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(82, 13);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(134, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// radioButtonMMT
			// 
			this.radioButtonMMT.AutoSize = true;
			this.radioButtonMMT.Location = new System.Drawing.Point(22, 28);
			this.radioButtonMMT.Name = "radioButtonMMT";
			this.radioButtonMMT.Size = new System.Drawing.Size(91, 17);
			this.radioButtonMMT.TabIndex = 1;
			this.radioButtonMMT.TabStop = true;
			this.radioButtonMMT.Text = "Mach-Mit-Tag";
			this.radioButtonMMT.UseVisualStyleBackColor = true;
			// 
			// radioButtonProjektWoche
			// 
			this.radioButtonProjektWoche.AutoSize = true;
			this.radioButtonProjektWoche.Location = new System.Drawing.Point(22, 51);
			this.radioButtonProjektWoche.Name = "radioButtonProjektWoche";
			this.radioButtonProjektWoche.Size = new System.Drawing.Size(90, 17);
			this.radioButtonProjektWoche.TabIndex = 0;
			this.radioButtonProjektWoche.TabStop = true;
			this.radioButtonProjektWoche.Text = "Projektwoche";
			this.radioButtonProjektWoche.UseVisualStyleBackColor = true;
			// 
			// buttonAnlegen
			// 
			this.buttonAnlegen.Location = new System.Drawing.Point(66, 145);
			this.buttonAnlegen.Name = "buttonAnlegen";
			this.buttonAnlegen.Size = new System.Drawing.Size(75, 23);
			this.buttonAnlegen.TabIndex = 3;
			this.buttonAnlegen.Text = "Anlegen";
			this.buttonAnlegen.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonMMT);
			this.groupBox1.Controls.Add(this.radioButtonProjektWoche);
			this.groupBox1.Location = new System.Drawing.Point(12, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Art";
			// 
			// FormNeu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 179);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonAnlegen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxName);
			this.Name = "FormNeu";
			this.Text = "Neu";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtonMMT;
		private System.Windows.Forms.RadioButton radioButtonProjektWoche;
		private System.Windows.Forms.Button buttonAnlegen;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
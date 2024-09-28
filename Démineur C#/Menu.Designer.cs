namespace Démineur_C_
{
	partial class Menu
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
			boutonDebutant = new Button();
			boutonintermédiaire = new Button();
			boutonAvancé = new Button();
			Titre = new Label();
			SuspendLayout();
			// 
			// boutonDebutant
			// 
			boutonDebutant.BackColor = Color.FromArgb(33, 157, 200);
			boutonDebutant.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			boutonDebutant.Location = new Point(100, 267);
			boutonDebutant.Name = "boutonDebutant";
			boutonDebutant.Size = new Size(400, 400);
			boutonDebutant.TabIndex = 0;
			boutonDebutant.Text = "Débutant";
			boutonDebutant.UseVisualStyleBackColor = false;
			// 
			// boutonintermédiaire
			// 
			boutonintermédiaire.BackColor = Color.FromArgb(118, 177, 23);
			boutonintermédiaire.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			boutonintermédiaire.Location = new Point(724, 267);
			boutonintermédiaire.Name = "boutonintermédiaire";
			boutonintermédiaire.Size = new Size(400, 400);
			boutonintermédiaire.TabIndex = 1;
			boutonintermédiaire.Text = "Intermédiaire";
			boutonintermédiaire.UseVisualStyleBackColor = false;
			// 
			// boutonAvancé
			// 
			boutonAvancé.BackColor = Color.FromArgb(250, 163, 24);
			boutonAvancé.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			boutonAvancé.Location = new Point(1360, 267);
			boutonAvancé.Name = "boutonAvancé";
			boutonAvancé.Size = new Size(400, 400);
			boutonAvancé.TabIndex = 2;
			boutonAvancé.Text = "Avancé";
			boutonAvancé.UseVisualStyleBackColor = false;
			// 
			// Titre
			// 
			Titre.AutoSize = true;
			Titre.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			Titre.Location = new Point(900, 70);
			Titre.Name = "Titre";
			Titre.Size = new Size(256, 62);
			Titre.TabIndex = 3;
			Titre.Text = "Démineur";
			// 
			// Menu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(188, 196, 208);
			ClientSize = new Size(1760, 1055);
			Controls.Add(Titre);
			Controls.Add(boutonAvancé);
			Controls.Add(boutonintermédiaire);
			Controls.Add(boutonDebutant);
			Name = "Menu";
			Text = "Menu";
			WindowState = FormWindowState.Maximized;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button boutonDebutant;
		private Button boutonintermédiaire;
		private Button boutonAvancé;
		private Label Titre;
	}
}
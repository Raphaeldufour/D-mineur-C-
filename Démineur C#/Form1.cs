using System.Diagnostics;

namespace Démineur_C_
{
	public partial class Form1 : Form
	{
		private Button[,]? boutons;
		private int buttonSize = 55;
		private Jeu jeu;

		public Form1(Jeu.Difficulty difficulty)
		{
			InitializeComponent();
			jeu = new Jeu(difficulty);
			jeu.InitialiserTimer();
			AddButtons(jeu.Grille.NombreLignes, jeu.Grille.NombreColonnes);
			minesRestantes.Text = jeu.Grille.NombreMines.ToString();
		}

		private void reintialiserBoutons()
		{
			for (int i = 0; i < jeu.Grille.NombreLignes; i++)
			{
				for (int j = 0; j < jeu.Grille.NombreColonnes; j++)
				{
					boutons[i, j].BackColor = Color.White;
					boutons[i, j].Text = "";
					boutons[i, j].Enabled = true;
				}
			}
		}

		private void AddButtons(int nbColonne, int nbLigne)
		{

			boutons = new Button[nbColonne, nbLigne];

			int tableauWidth = nbColonne * buttonSize;
			int tableauHeight = nbLigne * buttonSize;

			int x = (ClientSize.Width - tableauWidth) / 2;
			int y = (ClientSize.Height - tableauHeight) / 2;

			for (int i = 0; i < nbColonne * nbLigne; i++)
			{
				int xIndex = i % nbColonne;
				int yIndex = i / nbColonne;
				Button bouton = new Button
				{
					Width = buttonSize,
					Height = buttonSize,
					Margin = new Padding(0),
					Font = new Font("Arial", 10, FontStyle.Bold),
					BackColor = Color.White,
					Text = "",
					Tag = new Point(xIndex, yIndex),
					Anchor = AnchorStyles.None,
					Location = new Point(x + xIndex * buttonSize, y + yIndex * buttonSize)
				};

				bouton.Click += button_Click;
				bouton.MouseDown += button_MouseDown;

				Controls.Add(bouton);
				boutons[xIndex, yIndex] = bouton;
			}
		}

		private void button_Click(object sender, EventArgs e)
		{
			jeu.DémarrerTimer();
			Button bouton = (Button)sender;
			Point coordonnees = (Point)bouton.Tag;

			var caseCourante = jeu.Grille.Cases[coordonnees.X, coordonnees.Y];

			if (caseCourante.EstMarquée)
			{
				return;
			}

			caseCourante.Reveler();

			if (caseCourante is CaseMine)
			{
				FinDeJeu("Vous avez perdu !");
			}
			else if (caseCourante is CaseVide)
			{
				jeu.Grille.RevelerCasesAdjacentes(coordonnees.X, coordonnees.Y);
			}

			if (jeu.isWin())
			{
				FinDeJeu("Vous avez gagné !");
			}

			MiseAJourBoutons();
		}

		private void compteARebours(Button button)
		{
			Point coordonnees = (Point)button.Tag;
			Label tempsRestant = new Label();
			tempsRestant.Text = "Temps restant : " + jeu.Grille.Cases[coordonnees.X, coordonnees.Y].ToString();
		}

		private void FinDeJeu(string message)
		{
			jeu.Terminer();
			MiseAJourBoutons();
			MessageBox.Show(message, "Démineur", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ResetGame();
		}



		private void MiseAJourBoutons()
		{
			for (int i = 0; i < jeu.Grille.NombreLignes; i++)
			{
				for (int j = 0; j < jeu.Grille.NombreColonnes; j++)
				{
					Button bouton = boutons[i, j];
					Case caseCourante = jeu.Grille.Cases[i, j];
					bool estMarquee = caseCourante.EstMarquée;
					bool estRevelee = caseCourante.EstRévélée;

					if (estRevelee)
					{
						bouton.BackColor = Color.LightGray;
						bouton.Enabled = false;

						switch (caseCourante)
						{
							case CaseChiffre:
								bouton.Text = caseCourante.MinesAdjacentes.ToString();
								break;
							case CaseMine:
								bouton.BackColor = Color.Red;
								bouton.Text = "💣";
								break;
							case CaseVide:
								bouton.Text = "";
								break;
						}
					}
					else if (estMarquee)
					{
						bouton.BackColor = Color.Yellow;
						bouton.Text = "🚩";
					}
					else
					{
						bouton.BackColor = Color.White;
						bouton.Text = "";
					}
				}
			}
		}


		private void CalculerNombreDrapeaux()
		{
			int nombreDrapeaux = 0;
			for (int x = 0; x < jeu.Grille.NombreLignes; x++)
			{
				for (int y = 0; y < jeu.Grille.NombreColonnes; y++)
				{
					if (jeu.Grille.Cases[x, y].EstMarquée)
					{
						nombreDrapeaux++;
					}
				}
			}
			minesRestantes.Text = (jeu.Grille.NombreMines - nombreDrapeaux).ToString();
			if (jeu.Grille.NombreMines - nombreDrapeaux < 0)
			{
				minesRestantes.Text = "0";
			}
		}

		private void button_MouseDown(object sender, MouseEventArgs e)
		{
			if (sender is Button bouton)
			{
				int x = ((Point)bouton.Tag).X;
				int y = ((Point)bouton.Tag).Y;

				if (e.Button == MouseButtons.Right)
				{
					jeu.Grille.Cases[x, y].EstMarquée ^= true;

					MiseAJourBoutons();
					CalculerNombreDrapeaux();
				}
			}
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			tempsEcoule.Text = jeu.texteTimer();
		}

		private void ResetGame()
		{
			
			jeu.InitialiserTimer();
			reintialiserBoutons();
			jeu.Recommencer();
			MiseAJourBoutons();
			minesRestantes.Text = jeu.Grille.NombreMines.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}
	}
}
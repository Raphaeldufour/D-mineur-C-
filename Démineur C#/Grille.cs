using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur_C_
{
	public class Grille
	{
		private int nombreColonnes;
		private int nombreLignes;
		private int nombreMines;
		private Case[,]? cases;

		public int NombreColonnes
		{
			get { return nombreColonnes; }
		}

		public int NombreLignes
		{
			get { return nombreLignes; }
		}

		public int NombreMines
		{
			get { return nombreMines; }
		}

		public Case[,] Cases
		{
			get { return cases; }
		}

		public Grille(int nombreLignes, int nombreColonnes, int nombreMines)
		{
			this.nombreColonnes = nombreColonnes;
			this.nombreLignes = nombreLignes;
			this.nombreMines = nombreMines;
			InitialiserGrille();
		}

		private void InitialiserGrille()
		{
			cases = new Case[nombreLignes, nombreColonnes];

			// Création des cases vides et mines
			Random random = new Random();
			int minesPlacées = 0;
			while (minesPlacées < nombreMines)
			{
				int x = random.Next(nombreLignes);
				int y = random.Next(nombreColonnes);


				if (cases[x, y] is not CaseMine)
				{
					cases[x, y] = new CaseMine();
					minesPlacées++;
				}
			}

			// Remplissage des cases vides et calcul des mines adjacentes
			for (int x = 0; x < nombreLignes; x++)
			{
				for (int y = 0; y < nombreColonnes; y++)
				{
					if (cases[x, y] is not CaseMine)
					{
						int minesAdjacentes = 0;

						for (int dx = -1; dx <= 1; dx++)
						{
							for (int dy = -1; dy <= 1; dy++)
							{
								int newX = x + dx;
								int newY = y + dy;

								if (newX >= 0 && newX < nombreLignes && newY >= 0 && newY < nombreColonnes && (cases[newX, newY] is CaseMine))
								{
									minesAdjacentes++;
								}
							}
						}

						if (minesAdjacentes > 0)
						{
							cases[x, y] = new CaseChiffre(minesAdjacentes);
						}
						else
						{
							cases[x, y] = new CaseVide();
						}
					}
				}
			}
		}


		public void RevelerCasesAdjacentes(int x, int y)
		{
			for (int dx = -1; dx <= 1; dx++)
			{
				for (int dy = -1; dy <= 1; dy++)
				{
					int newX = x + dx;
					int newY = y + dy;

					if (newX >= 0 && newX < nombreLignes && newY >= 0 && newY < nombreColonnes)
					{
						if (!cases[newX, newY].EstRévélée) // Ajout d'un '!' pour vérifier si la case n'est PAS révélée
						{
							cases[newX, newY].Reveler();
							if (cases[newX, newY].EstMarquée)
							{
								cases[newX, newY].Démarquer();
							}

							if (cases[newX, newY] is CaseVide) // Ajout d'une condition pour vérifier si la case n'est pas une mine
							{
								RevelerCasesAdjacentes(newX, newY);
							}
						}
					}
				}
			}
		}


		
	}
}

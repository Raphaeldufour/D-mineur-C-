using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur_C_
{
	public class Jeu
	{
		public enum Difficulty
		{
			Beginner,
			Intermediate,
			Advanced
		}

		private Grille grille;
		private Difficulty difficulty;
		private Stopwatch timer;

		public Grille Grille
		{
			get { return grille; }
		}

		public Jeu(Difficulty difficulty)
		{
			this.difficulty = difficulty;
			InitialiserJeu();
		}

		private void InitialiserJeu()
		{
			switch (this.difficulty)
			{
				case Difficulty.Beginner:
					grille = new Grille(9, 9, 10);
					break;
				case Difficulty.Intermediate:
					grille = new Grille(16, 16, 40);
					break;
				case Difficulty.Advanced:
					grille = new Grille(30, 16, 99);
					break;
			}
		}
		

		public void InitialiserTimer()
		{
			timer = new Stopwatch();
		}

		public void DémarrerTimer()
		{
			timer.Start();
		}

		public void Recommencer()
		{
			InitialiserJeu();
		}

		public void Terminer()
		{
			timer.Stop();
		}

		public string texteTimer()
		{
			return timer.Elapsed.ToString(@"mm\:ss");
		}

		public bool isWin()
		{
			for (int x = 0; x < grille.NombreLignes; x++)
			{
				for (int y = 0; y < grille.NombreColonnes; y++)
				{
					// Vérifier si toutes les cases sans mines ont été révélées
					if (grille.Cases[x, y] is not CaseMine && !grille.Cases[x, y].EstRévélée)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}

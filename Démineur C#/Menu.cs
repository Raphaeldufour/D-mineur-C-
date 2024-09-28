using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Démineur_C_
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();

			boutonDebutant.Click += boutonDebutant_Click;
			boutonintermédiaire.Click += boutonIntermédiaire_Click;
			boutonAvancé.Click += boutonAvancé_Click;


			this.Controls.AddRange(new Control[] { boutonDebutant, boutonintermédiaire, boutonAvancé });
		}
		private void boutonDebutant_Click(object sender, EventArgs e)
		{
			Form1 demineurForm = new Form1(Jeu.Difficulty.Beginner );
			demineurForm.ShowDialog();
		}

		private void boutonIntermédiaire_Click(object sender, EventArgs e)
		{
			Form1 demineurForm = new Form1(Jeu.Difficulty.Intermediate);
			demineurForm.ShowDialog();
		}

		private void boutonAvancé_Click(object sender, EventArgs e)
		{
			Form1 demineurForm = new Form1(Jeu.Difficulty.Advanced);
			demineurForm.ShowDialog();
		}
	}
}

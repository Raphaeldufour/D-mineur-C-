using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Démineur_C_
{
	public class Case
	{
		public bool EstRévélée { get; set; }
		public bool EstMarquée { get; set; }
		public int MinesAdjacentes { get; set; }


		public Case()
		{
			EstRévélée = false;
			EstMarquée = false;
		}

		public virtual void Reveler()
		{
			EstRévélée = true;
		}

		public void Marquer()
		{
			EstMarquée = true;
		}

		public void Démarquer()
		{
			EstMarquée = false;
		}
	}
	class CaseMine : Case
	{
	}

	class CaseVide : Case
	{
		public CaseVide() : base()
		{
			MinesAdjacentes = 0;
		}
	}

	class CaseChiffre : Case
	{
		public CaseChiffre(int minesAdjacentes)
		{
			MinesAdjacentes = minesAdjacentes;
		}
	}

}

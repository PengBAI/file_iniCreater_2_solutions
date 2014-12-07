using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
	{
	class Program
		{
		static void Main(string[] Args)
			{
			// Args[0]: répertoire du Fichier EXCEL
			// Agrs[1]: répertoire du Fichier la base de données
				Core MyCore = new Core(Args[1]);
				MyCore.XLS2BdD(Args[0]);
				Console.In.ReadLine();
			}
		}
	}

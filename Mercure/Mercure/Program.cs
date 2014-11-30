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
				Core MyCore = new Core();
				MyCore.XLS2BdD(Args[0]);
				Console.In.ReadLine();
			}
		}
	}

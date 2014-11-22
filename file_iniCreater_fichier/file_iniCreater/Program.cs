using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TPnet
	{
	class Program
	{
		static void Main(string[] Args)
			{
				Console.Out.WriteLine("Nombre de parametres: " + Args.Length);
				
				//Ouverture d'un ficher et lecture d'une valeur
				for(int Cpt = 0; Cpt < Args.Length; Cpt++){
					Console.Out.WriteLine(Args[Cpt]);
				}

				// lecture tous les contenues du fichier
				if(Args.Length > 0 && File.Exists(Args[0])){
					// lectueur du fichier
					using(StreamReader sr = File.OpenText(Args[0])){
						string Line;
						while((Line = sr.ReadLine()) != null){
							Console.Out.WriteLine(Line);
						}
					}
				}else{
					Console.Out.WriteLine("Fichier non trouvé: " + Args[0]);
				}

				Console.Out.WriteLine(IniFile.GetString(Args[0], "MCI  Extensions.BAK", "mp4"));
				
				// modifications du fichier
				if(Args.Length <= 4){
					try{
						IniFile.Write(Args[0], "fonts", "baipeng ", 12254);
						IniFile.RemoveSection(Args[0], "MCI Extensions.BAK");
						IniFile.Write(Args[0], "MCI Extensions.BAK", "mp4", 4444444444444);
						IniFile.RemoveName(Args[0], "MCI Extensions.BAK", "mp4");
					}
					catch(ArgumentException Err)
					{
						Console.Out.WriteLine(Err.Message);
					}
					catch (FileNotFoundException Err)
					{
						Console.Out.WriteLine(Err.Message);
					}
					catch (Exception Err)
					{
						Console.Out.WriteLine(Err.Message);
					}
				}
				Console.In.Read();
		   }
	}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace TPnet
	{
	class IniFile
		{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="Filename"></param>
		/// <param name="Section"></param>
		/// <param name="Name"></param>
		/// <returns></returns>
		public static string GetString(string Filename, string Section, string Name)
			{
			return GetString(Filename, Section, Name, null);
			}

		/// <summary>
		/// lire la valeur d'un nom dans une section, retourner la première
		/// </summary>
		/// <param name="Filename"></param>
		/// <param name="Section"></param>
		/// <param name="Name"></param>
		/// <param name="Default"></param>
		/// <returns></returns>
		public static string GetString(string Filename, string Section, string Name, string Default)
			{
			if (File.Exists(Filename))
				{
				bool SectionFound = false;
				/* lire le fichier */
				using (StreamReader sr = File.OpenText(Filename))
					{
					string Line = "";

					while ((Line = sr.ReadLine()) != null)
						{
						/* La partie section */
						if (Line.TrimStart().StartsWith("["))
							{
							if (Line.StartsWith("[" + Section + "]"))
								{
								SectionFound = true;
								}
							}
						else
							{
							/* si la section a trouvé */
							if (SectionFound)
								{
								/* Les éléments de la section */
								int Pos = Line.IndexOf("=");
								if (Pos != -1)
									{
									/* récupérer le name */
									string NameFound = Line.Substring(0, Pos).TrimStart();
									/* récupérer le value */
									string IsValue = Line.Substring(Pos + 1).TrimStart();
									if (NameFound.TrimStart().Equals(Name.TrimStart()))
										{
										return IsValue;
										}
									}
								}
							}
						}
					}
				if (!SectionFound)
					{
					// section non existe
					Console.Out.WriteLine("La section: [" + Section + "] pas trouvé!");
					}
				else
					{
					// section existe, mais Name non existe
					Console.Out.WriteLine("Pas trouvé: " + Name + " dans la section: " + Section);
					}
				return null;
				}
			else
				{
				throw new FileNotFoundException(Filename + " non trouvé");
				}

			}

		public static int GetInteger(string Filename, string Section, string Name)
			{
			return GetInteger(Filename, Section, Name);
			}

		public static int GetInteger(string Filename, string Section, string Name, int Default)
			{
			throw new NotImplementedException();
			}

		/// <summary>
		/// Ecrit une valeur dans le ficher ini
		/// </summary>
		/// <param name="Filename">Nom et chemin du ficher ini.</param>
		/// <param name="Section">Nom de la Section.</param>
		/// <param name="Name">Nom de la valeur.</param>
		/// <param name="Value">Contenue de la valeur.</param>
		/// <exception cref="ArgumentException">...</exception>
		/// <exception cref="FileNotFoundException">...</exception>
		public static void Write(string Filename, string Section, string Name, object Value)
			{
			if (string.IsNullOrEmpty(Filename))
				{
				throw new ArgumentException("Filename est vide");
				}
			if (string.IsNullOrEmpty(Section))
				{
				throw new ArgumentException("Section est vide");
				}
			if (string.IsNullOrEmpty(Name))
				{
				throw new ArgumentException("Name est vide");
				}
			if (!File.Exists(Filename))
				{
				throw new FileNotFoundException("Fichier non trouvé");
				}
			if (Value is string)
				{
				WriteString(Filename, Section, Name, (string)Value);
				}
			else
				{
				WriteString(Filename, Section, Name, Value.ToString());
				}
			}

		/// <summary>
		/// si Section n'exite pas, alors l'ajouter
		/// sinon la Section exite déja, ajouter le Name=Value
		/// ou modifier la valeur de Name à Value
		/// </summary>
		/// <param name="Filename">repertoire du fichier</param>
		/// <param name="Section">la Section</param>
		/// <param name="Name">le nom</param>
		/// <param name="Value">la valeur</param>
		public static void WriteString(string Filename, string Section, string Name, string Value)
			{
			string Line = "";
			bool SectionFound = false;
			bool NameFound = false;
			// créer un fichier temporaire
			using (StreamWriter Sw = new StreamWriter("tmp.ini", false))
				{
				using (StreamReader Sr = File.OpenText(Filename))
					{
					while ((Line = Sr.ReadLine()) != null)
						{
						/* section trouvé et Name nontrvoué, l'ajouter dans la section */
						if (!NameFound && SectionFound)
							{
							Sw.WriteLine(Name + "=" + Value);
							NameFound = true;
							}
						/* la partie commentaire */
						if (Line.TrimStart().StartsWith(";"))
							{
							Sw.WriteLine(Line);
							continue;
							}
						/* La partie section */
						if (Line.TrimStart().StartsWith("["))
							{
							if (Line.StartsWith("[" + Section + "]"))
								{
								SectionFound = true;
								}
							Sw.WriteLine(Line);
							}
						else
							{
							/* si la section a trouvé */
							if (SectionFound)
								{
								/* Les éléments de la section */
								int Pos = Line.IndexOf("=");
								if (Pos != -1)
									{
									/* récupérer le name */
									string tmpName = Line.Substring(0, Pos).TrimStart();
									if (tmpName.TrimStart().Equals(Name.TrimStart()))
										{
										Sw.WriteLine(Name + "=" + Value);
										/* dans la sectuon Name trouvé et modifié */
										NameFound = true;
										}
									else
										{
										/* Name non trouvé copy la ligne */
										Sw.WriteLine(Line);
										}
									}
								}else{
								Sw.WriteLine(Line);
								}
							}
						}
					/* section n'existe pas , l'ajoute à la fin*/
					if (!SectionFound)
						{
						Sw.WriteLine("[" + Section.TrimStart() + "]");
						Sw.WriteLine(Name.TrimStart() + "=" + Value.Trim());
						}
					/* pour la dernière section */
					/* section trouvé et Name nontrvoué, l'ajouter dans la section */
					if (SectionFound && !NameFound)
						{
						Sw.WriteLine(Name + "=" + Value);
						}
					}
				}
			}
		/// <summary>
		/// écrire un Interger dans le fichier
		/// </summary>
		/// <param name="Filename"></param>
		/// <param name="Section"></param>
		/// <param name="Name"></param>
		/// <param name="Value"></param>
		public static void WriteInteger(string Filename, string Section, string Name, int Value)
			{
			WriteString(Filename, Section, Name, Value.ToString());
			}

		/// <summary>
		/// supprimer la Section ainsi que tous les éléments
		/// </summary>
		/// <param name="Filename"></param>
		/// <param name="Section">Section's name</param>
		/// <exception cref="KeyNotFoundException">Section non trouvé</exception>
		public static void RemoveSection(string Filename, string Section)
			{
			string Line = "";
			bool IsSection = false;
			// créer un fichier temporaire à écrire
			using (StreamWriter Sw = new StreamWriter("tmp.ini", false))
				{
				using (StreamReader Sr = File.OpenText(Filename))
					{
					while ((Line = Sr.ReadLine()) != null)
						{
						/* la partie commentaire */
						if (Line.TrimStart().StartsWith(";"))
							{
							Sw.WriteLine(Line);
							continue;
							}
						/* La partie section */
						if (Line.TrimStart().StartsWith("["))
							{
							if (Line.StartsWith("[" + Section + "]"))
								{
								IsSection = true;
								}
								else{
								IsSection = false;
								Sw.WriteLine(Line);
								}
							}
						else
							{
							/* si la section a trouvé */
							if (IsSection)
								{
								/* écrire riens*/
								}
							else
								{
								Sw.WriteLine(Line);
								}
							}
						}
					}
				}
		}
		/// <summary>
		/// supprimer le Name=Value dans une Section
		/// </summary>
		/// <param name="Filename"></param>
		/// <param name="Section"></param>
		/// <param name="name"></param>
		/// <exception cref="KeyNotFoundException">name dans la Section non trouvé</exception>
		/// <exception cref="KeyNotFoundException">Section non trouvé</exception>
		public static void RemoveName(string Filename, string Section, string Name)
			{
			string Line = "";
			bool SectionFound = false;
			// créer un fichier temporaire
			using (StreamWriter Sw = new StreamWriter("tmp.ini", false))
				{
				using (StreamReader Sr = File.OpenText(Filename))
					{
					while ((Line = Sr.ReadLine()) != null)
						{
						/* la partie commentaire */
						if (Line.TrimStart().StartsWith(";"))
							{
							Sw.WriteLine(Line);
							continue;
							}
						/* La partie section */
						if (Line.TrimStart().StartsWith("["))
							{
							if (Line.StartsWith("[" + Section + "]"))
								{
								SectionFound = true;
								}
							Sw.WriteLine(Line);
							}
						else
							{
							/* si la section a trouvé */
							if (SectionFound)
								{
								/* Les éléments de la section */
								int Pos = Line.IndexOf("=");
								if (Pos != -1)
									{
									/* récupérer le name */
									string tmpName = Line.Substring(0, Pos).TrimStart();
									/* Name dans la Section trouvé */
									if (tmpName.TrimStart().Equals(Name.TrimStart()))
										{/* écrire riens*/
										}
									else
										{
										/* Name non trouvé copy la ligne */
										Sw.WriteLine(Line);
										}
									}
								}
							else
								{
								Sw.WriteLine(Line);
								}
							}
						}
					}
				}
			}
		}
	}

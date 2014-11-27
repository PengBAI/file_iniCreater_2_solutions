using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace Mercure
	{
	class Core
		{
		// definir les index globals
		private int INDEX_MARQUE = 2;
		private int INDEX_FAMILLE = 3;
		private int INDEX_SOUSFAMILLE = 4;
		
		// constructeur
		public Core()
			{

			}

		public void ReadFichierXLS(string FilePath)
			{
			// initialiser une connexion Excel
			string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 8.0\";";
			OleDbConnection connection = new OleDbConnection(connectionString);
			string cmdText = "SELECT * FROM [Matériels$]";
			OleDbCommand command = new OleDbCommand(cmdText, connection);
			// démarrer la connexion 
			command.Connection.Open();
			OleDbDataReader Reader = command.ExecuteReader();

			if (Reader.HasRows)
				{
				while (Reader.Read())
					{
					// the ids
					int IDmarque, IDfamille, IDsousfamille;
					IDmarque = insertMercure(INDEX_MARQUE, Reader[INDEX_MARQUE].ToString());
					IDfamille = insertMercure(INDEX_FAMILLE, Reader[INDEX_FAMILLE].ToString());
					IDsousfamille = insertMercure(INDEX_SOUSFAMILLE, Reader[INDEX_SOUSFAMILLE].ToString());

					if (IDmarque != -1 && IDfamille != -1 && IDsousfamille != -1){
					using (SqlCeConnection conn = new SqlCeConnection(@"Data Source = 'C:/Users/Administrateur/Desktop/Mercure/Mercure/Mercure.sdf'"))
							{
							// open la connexion
							conn.Open();
							SqlCeCommand Cmd = new SqlCeCommand(null, conn);
							Cmd.CommandText = "INSERT INTO Articles(DescriptionArticle, RefArticle, IdMarque, " +
							 "IdFamille, IdSousFamille, PrixHT) VALUES(@description_article, @ref, @id_marque, @id_famille, @id_sousfamille, @prixht)";
							Cmd.Parameters.AddWithValue("@description_article", Reader[0]);
							Cmd.Parameters.AddWithValue("@ref", Reader[1]);
							Cmd.Parameters.AddWithValue("@id_marque", IDmarque);
							Cmd.Parameters.AddWithValue("@id_famille", IDfamille);
							Cmd.Parameters.AddWithValue("@id_sousfamille", IDsousfamille);
							Cmd.Parameters.AddWithValue("@prixht", Reader[5]);
							Cmd.ExecuteNonQuery();
							Console.WriteLine("Article Ref:\"{0}\" is inserted into table Articles.", Reader[1].ToString());
							}
					}else{
						Console.Out.WriteLine("Insert into Mercure échec!");
					}
				}
			}
			// fermer la connexion
			command.Connection.Close();
			}

		/// <summary>
		/// trouver Id de Marque, Famille et SousFamille
		/// </summary>
		/// <param name="Index">dans quel colonne qu'on trouve attribut</param>
		/// <param name="DataExl"> la valeur</param>
		/// <returns>Id, concernant la valeur qui est insérée. -1, si dans autre cas</returns>
		private int insertMercure(int Index, string DataExl)
			{
			using (SqlCeConnection conn = new SqlCeConnection(@"Data Source = 'C:/Users/Administrateur/Desktop/Mercure/Mercure/Mercure.sdf'"))
				{
				// open la connexion
				try
					{
					conn.Open();
					}
				catch (Exception ex)
					{
					Console.Out.WriteLine("Base de donnée connexion erreur!");
					return -1;
					}
				SqlCeDataReader Reader = null;
				SqlCeCommand Cmd = new SqlCeCommand(null, conn);
				// marque
				if (Index == INDEX_MARQUE)
					{
					// tester si the marque existe déja
					Cmd.CommandText = "SELECT * FROM Marques WHERE NomMarque = @marque";
					Cmd.Parameters.AddWithValue("@marque", DataExl);
					Reader = Cmd.ExecuteReader();
					if (Reader.Read())
						{
						// si nom existe déja, retourner id
						return (int)Reader["IdMarque"];
						}
					else
						{
						// préparer la commande insert string marques
						Cmd.CommandText = "INSERT INTO Marques(NomMarque) VALUES(@marque)";
						Cmd.ExecuteNonQuery();
						Console.Out.WriteLine(DataExl + " is inserted into table Marques.");
						// retourner IdMarque
						Cmd.CommandText = "SELECT IdMarque FROM Marques WHERE NomMarque=@marque";
						// exécuter le requête
						Reader = Cmd.ExecuteReader();
						if (Reader.Read())
							{
							// retourner nouvelle id
							return (int)Reader[0];
							}
						}
					}
				// familles
				if (Index == INDEX_FAMILLE)
					{
					// test if the famille existe déja
					Cmd.CommandText = "SELECT * FROM Familles WHERE NomFamille = @famille";
					Cmd.Parameters.AddWithValue("@famille", DataExl);
					Reader = Cmd.ExecuteReader();
					if (Reader.Read())
						{
						// if nom existe déja, return the id
						return (int)Reader["IdFamille"];
						}
					else
						{
						// prepare command insert string marques
						Cmd.CommandText = "INSERT INTO Familles(NomFamille) VALUES(@famille)";
						Cmd.ExecuteNonQuery();
						Console.Out.WriteLine(DataExl + " is inserted into table Familles.");
						// retourner IdFamille
						Cmd.CommandText = "SELECT IdFamille FROM Familles WHERE NomFamille=@famille";
						// exécuter le requête
						Reader = Cmd.ExecuteReader();
						if (Reader.Read())
							{
							
							// return nouvelle id
							return (int)Reader[0];
							}
						}
					}
				//sousfamilles
				if (Index == INDEX_SOUSFAMILLE)
					{
					// test if the famille existe déja
					Cmd.CommandText = "SELECT * FROM SousFamilles WHERE NomSousFamille = @sousfamille";
					Cmd.Parameters.AddWithValue("@sousfamille", DataExl);
					Reader = Cmd.ExecuteReader();
					if (Reader.Read())
						{
						// if nom existe déja, return the id
						return (int)Reader["IdSousFamille"];
						}
					else
						{
						// prepare command insert string marques
						Cmd.CommandText = "INSERT INTO SousFamilles(NomSousFamille) VALUES(@sousfamille)";
						Cmd.ExecuteNonQuery();
						Console.Out.WriteLine(DataExl + " is inserted into table SousFamilles.");
						// retourner IdSousFamille
						Cmd.CommandText = "SELECT IdSousFamille FROM SousFamilles WHERE NomSousFamille=@sousfamille";
						// exécuter le requête
						Reader = Cmd.ExecuteReader();
						if (Reader.Read())
							{
							// return nouvelle id
							return (int)Reader[0];
							}
						}
					}
				Reader.Close();
				Reader.Dispose();
				Cmd.Dispose();
				return -1;
				}
			}
		}
	}

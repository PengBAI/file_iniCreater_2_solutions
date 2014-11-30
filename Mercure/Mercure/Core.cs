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
		// definir les variables globales
		private int INDEX_MARQUE = 2;
		private int INDEX_FAMILLE = 3;
		private int INDEX_SOUSFAMILLE = 4;
		private string NOM_EXCEL_TABLE = "Matériels";
		private string PATH_DATABASE = "Data Source = 'C:/Users/Administrateur/Desktop/Mercure/Mercure/Mercure.sdf'";

		// constructeur
		public Core()
			{

			}

		public void XLS2BdD(string FilePath)
			{
			// initialiser une connexion Excel
			string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties=\"Excel 8.0\";";
			OleDbConnection connection = new OleDbConnection(connectionString);
			string cmdText = "SELECT * FROM [" + NOM_EXCEL_TABLE + "$]";
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

					if (IDmarque != -1 && IDfamille != -1 && IDsousfamille != -1)
						{
						using (SqlCeConnection conn = new SqlCeConnection(@PATH_DATABASE))
							{
							// open la connexion
							conn.Open();
							SqlCeCommand Cmd = new SqlCeCommand(null, conn);
							SqlCeDataReader ReaderSql = null;
							// test if the famille existe déja
							Cmd.CommandText = "SELECT * FROM Articles WHERE RefArticle = @ref";
							Cmd.Parameters.AddWithValue("@description_article", Reader[0]);
							Cmd.Parameters.AddWithValue("@ref", Reader[1]);
							Cmd.Parameters.AddWithValue("@id_marque", IDmarque);
							Cmd.Parameters.AddWithValue("@id_famille", IDfamille);
							Cmd.Parameters.AddWithValue("@id_sousfamille", IDsousfamille);
							Cmd.Parameters.AddWithValue("@prixht", Reader[5]);
							ReaderSql = Cmd.ExecuteReader();
							if (ReaderSql.Read())
								{
								// if article existe déja, return the ref
								Console.Out.WriteLine("Article déja existe Ref: " + Reader[1].ToString());
								}
							else
								{
								// insert into l'article dans la table Articles
								Cmd.CommandText = "INSERT INTO Articles(DescriptionArticle, RefArticle, IdMarque, " +
								 "IdFamille, IdSousFamille, PrixHT) VALUES(@description_article, @ref, @id_marque, " +
								 "@id_famille, @id_sousfamille, @prixht)";
								Cmd.ExecuteNonQuery();
								Console.WriteLine("Article Ref:\"{0}\" is inserted into table Articles.", Reader[1].ToString());
								}
							}
						}
					else
						{
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
			using (SqlCeConnection conn = new SqlCeConnection(@PATH_DATABASE))
				{
				// open la connexion
				try
					{
					conn.Open();
					}
				catch (Exception)
					{
					Console.Out.WriteLine("Base de donnée connexion erreur!");
					return -1;
					}
				SqlCeDataReader ReaderSql = null;
				SqlCeCommand Cmd = new SqlCeCommand(null, conn);
				// marque
				if (Index == INDEX_MARQUE)
					{
					// tester si the marque existe déja
					Cmd.CommandText = "SELECT * FROM Marques WHERE NomMarque = @marque";
					Cmd.Parameters.AddWithValue("@marque", DataExl);
					ReaderSql = Cmd.ExecuteReader();
					if (ReaderSql.Read())
						{
						// si nom existe déja, retourner id
						return (int)ReaderSql["IdMarque"];
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
						ReaderSql = Cmd.ExecuteReader();
						if (ReaderSql.Read())
							{
							// retourner nouvelle id
							return (int)ReaderSql[0];
							}
						}
					}
				// familles
				if (Index == INDEX_FAMILLE)
					{
					// test if the famille existe déja
					Cmd.CommandText = "SELECT * FROM Familles WHERE NomFamille = @famille";
					Cmd.Parameters.AddWithValue("@famille", DataExl);
					ReaderSql = Cmd.ExecuteReader();
					if (ReaderSql.Read())
						{
						// if nom existe déja, return the id
						return (int)ReaderSql["IdFamille"];
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
						ReaderSql = Cmd.ExecuteReader();
						if (ReaderSql.Read())
							{

							// return nouvelle id
							return (int)ReaderSql[0];
							}
						}
					}
				//sousfamilles
				if (Index == INDEX_SOUSFAMILLE)
					{
					// test if the famille existe déja
					Cmd.CommandText = "SELECT * FROM SousFamilles WHERE NomSousFamille = @sousfamille";
					Cmd.Parameters.AddWithValue("@sousfamille", DataExl);
					ReaderSql = Cmd.ExecuteReader();
					if (ReaderSql.Read())
						{
						// if nom existe déja, return the id
						return (int)ReaderSql["IdSousFamille"];
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
						ReaderSql = Cmd.ExecuteReader();
						if (ReaderSql.Read())
							{
							// return nouvelle id
							return (int)ReaderSql[0];
							}
						}
					}
				ReaderSql.Close();
				ReaderSql.Dispose();
				Cmd.Dispose();
				return -1;
				}
			}
		}
	}

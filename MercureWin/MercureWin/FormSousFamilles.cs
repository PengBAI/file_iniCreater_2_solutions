using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mercure;

namespace MercureWin
	{
	public partial class FormSousFamilles : Form
		{
		MercureService Service;
		int SelectedRefSousFamille = 0;
		public FormSousFamilles(string MyURL)
			{
			InitializeComponent();
			//-------------------------------------------------------------------------------------
			// Connexion au Service-Web
			//-------------------------------------------------------------------------------------
			Service = new MercureService();
			Service.Url = MyURL;
			}

		private void FormSousFamilles_Load(object sender, EventArgs e)
			{
			LsvSousFamilles.View = View.Details;
			LsvSousFamilles.GridLines = true;
			LsvSousFamilles.FullRowSelect = true;
			// ajouter les noms de colonnes de listview 
			LsvSousFamilles.Columns.Add("RéfSousFamille", 80);
			LsvSousFamilles.Columns.Add("NomSousFamille", 200);
			LsvSousFamilles.Columns.Add("RéfFamille", 70);
			LsvSousFamilles.Columns.Add("NomFamille", 150);
			this.ShowSousFamilles();
			}

		private string GetNomFamille(int RefFamille)
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles
			//-------------------------------------------------------------------------------------
			List<string[]> Familles = new List<string[]>();
			Familles = Service.GetFamilles();
			foreach (string[] Datas in Familles)
				{
				if (int.Parse(Datas[0]) == RefFamille)
					{
					return Datas[1];
					}
				}
			return null;
			}
		private void ShowSousFamilles()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> SousFamilles = new List<string[]>();
			SousFamilles = Service.GetSousFamilles();
			foreach (string[] Datas in SousFamilles)
				{
				ListViewItem Item;
				string[] NewItem = { Datas[0], Datas[2], Datas[1], GetNomFamille(int.Parse(Datas[1])) };
				//add items to ListView
				Item = new ListViewItem(NewItem);
				LsvSousFamilles.Items.Add(Item);
				}
			}
		}
	}

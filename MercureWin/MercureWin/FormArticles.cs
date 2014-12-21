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
	public partial class FormArticles : Form
		{
		MercureService Service;
		public FormArticles(string MyURL)
			{
			InitializeComponent();
			//-------------------------------------------------------------------------------------
			// Connexion au Service-Web
			//-------------------------------------------------------------------------------------
			Service = new MercureService();
			Service.Url = MyURL;
			this.ShowArticles();
			}

		private void FormArticles_Load(object sender, EventArgs e)
			{

			LstViewArticles.View = View.Details;
			LstViewArticles.GridLines = true;
			LstViewArticles.FullRowSelect = true;
			// ajouter les noms de colonnes de listview par l'ordre suivant:
			// 'RefArticle', 'Description', 'RefFamille', 'NomFamille', 
			// 'RefSousFamille', 'NomSousFamille', 'RefMarque', 'NomMarque', 'PrixHT'.
			LstViewArticles.Columns.Add("RéfArticle", 80);
			LstViewArticles.Columns.Add("Déscription", 300);
			LstViewArticles.Columns.Add("RéfFamille", 80);
			LstViewArticles.Columns.Add("NomFamille", 150);
			LstViewArticles.Columns.Add("RéfSousFamille", 80);
			LstViewArticles.Columns.Add("NomSousFamille", 200);
			LstViewArticles.Columns.Add("RéfMarque", 80);
			LstViewArticles.Columns.Add("NomMarque", 100);
			LstViewArticles.Columns.Add("Prix H.T.", 80);
			}

		private void ShowArticles()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Articles = new List<string[]>();
			Articles = Service.GetArticles();
			foreach (string[] Datas in Articles)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				LstViewArticles.Items.Add(Item);
				}
			}

		/// <summary>
		/// Supprimer les articles
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSuppArticle_Click(object sender, EventArgs e)
			{
			if (LstViewArticles.SelectedItems.Count != 0)
				{
				string Message = "Supprimer " + LstViewArticles.SelectedItems.Count + " articles sélectionés ?";
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					//-------------------------------------------------------------------------------------
					// Supprimer les items sélectionés
					//-------------------------------------------------------------------------------------
					foreach (ListViewItem Item in LstViewArticles.SelectedItems)
						{
						// supprimer les articles sélectionés dans ListView
						LstViewArticles.Items[Item.Index].Remove();
						// supprimer les articles sélectionés dans la base de données
						Service.DeleteArticle(Item.SubItems[0].Text);
						}
					// refresh ListView
					LstViewArticles.Refresh();
					}
				}
			}

		/// <summary>
		/// Ajouter un article
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouterArticle_Click(object sender, EventArgs e)
			{
			FormUnArticle UnArticle = new FormUnArticle(LstViewArticles, Service);
			UnArticle.Text = "Ajouter un nouveau Article";
			UnArticle.ShowDialog();
			}

		/// <summary>
		/// Modifier l'article sélectionné
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnModifierArticle_Click(object sender, EventArgs e)
			{
			if (LstViewArticles.SelectedItems.Count != 0)
				{
				ListViewItem Item = LstViewArticles.SelectedItems[0];
				FormUnArticle UnArticle = new FormUnArticle(LstViewArticles, Service, Item.SubItems[0].Text,
															Item.SubItems[1].Text, Item.SubItems[5].Text,
															Item.SubItems[7].Text, Item.SubItems[8].Text);
				UnArticle.Text = "Modifier Article réf: " + Item.SubItems[0].Text;
				UnArticle.ShowDialog();
				}
			}
		}
	}

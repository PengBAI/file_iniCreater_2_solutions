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
			}

		private void FormArticles_Load(object sender, EventArgs e)
			{
			this.ShowArticles();
			}

		private void ShowArticles()
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

		private void BtnSuppArticle_Click(object sender, EventArgs e)
			{
			// Initializes the variables to pass to the MessageBox.Show method.
			string message = "Supprimer " + LstViewArticles.SelectedItems.Count + " articles sélectionés ?";
			string caption = "Attention";
			MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
			DialogResult result;

			// Displays the MessageBox.
			result = MessageBox.Show(message, caption, buttons);

			if (result == DialogResult.OK)
				{
				foreach (ListViewItem Item in LstViewArticles.SelectedItems)
					{
					// supprimer les articles sélectionés dans ListView
					LstViewArticles.Items[Item.Index].Remove();
					// supprimer les articles sélectionés dans la base de données
					Service.DeleteArticle(Item.SubItems[0].Text);
					}
				// refresh ListView
				this.Refresh();
				}

			}

		private void BtnAjouterArticle_Click(object sender, EventArgs e)
			{
			FormUnArticle UnArticle = new FormUnArticle(LstViewArticles, Service);
			UnArticle.Text = "Ajouter un nouveau Article";
			UnArticle.Show();
			}

		private void BtnModifierArticle_Click(object sender, EventArgs e)
			{
			ListViewItem Item = LstViewArticles.SelectedItems[0];
			FormUnArticle UnArticle = new FormUnArticle(LstViewArticles, Service, Item.SubItems[0].Text,
														Item.SubItems[1].Text, Item.SubItems[5].Text, Item.SubItems[7].Text,
														Item.SubItems[8].Text);
			UnArticle.Text = "Modifier un Article";
			UnArticle.Show();
			}
		}
	}

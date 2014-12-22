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
	public partial class FormFactureArticles : Form
		{
		MercureService Service;
		string RefFacture;
		List<string[]> Articles = new List<string[]>();

		public FormFactureArticles(string IsRefFacture, MercureService IsService)
			{
			InitializeComponent();
			Service = IsService;
			RefFacture = IsRefFacture;
			this.InitComboBox();
			ShowFactureArticles();
			}

		/// <summary>
		/// Remplir les combobox Articles
		/// </summary>
		private void InitComboBox()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des Articles
			//-------------------------------------------------------------------------------------
			Articles = Service.GetArticles();
			foreach (string[] Article in Articles)
				{
				CbBoxArticles.Items.Add(Article[0] + ": " + Article[1]);
				}
			}

		private void FormFactureArticles_Load(object sender, EventArgs e)
			{
			//-------------------------------------------------------------------------------------
			// Initialisation de ListView du client
			//-------------------------------------------------------------------------------------
			LstFactureArticles.View = View.Details;
			LstFactureArticles.GridLines = true;
			LstFactureArticles.FullRowSelect = true;
			// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefFacture', 
			// 'RefArticle', 'Description', 'RefFamille', 'NomFamille', 'RefSousFamille', 
			// 'NomSousFamille', 'RefMarque', 'NomMarque', 'Quantity'.
			LstFactureArticles.Columns.Add("RefFacture", 80);
			LstFactureArticles.Columns.Add("RefArticle", 80);
			LstFactureArticles.Columns.Add("Description", 150);
			LstFactureArticles.Columns.Add("RefFamille", 80);
			LstFactureArticles.Columns.Add("NomFamille", 80);
			LstFactureArticles.Columns.Add("RefSousFamille", 80);
			LstFactureArticles.Columns.Add("NomSousFamille", 80);
			LstFactureArticles.Columns.Add("RefMarque", 80);
			LstFactureArticles.Columns.Add("NomMarque", 80);
			LstFactureArticles.Columns.Add("Quantity", 80);
			}

		/// <summary>
		/// Récupérer les données et les ajouter dans le ListView
		/// </summary>
		private void ShowFactureArticles()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des FactureArtuicles & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> FactureArticles = new List<string[]>();
			FactureArticles = Service.GetFactureArticles(RefFacture);
			foreach (string[] Datas in FactureArticles)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				LstFactureArticles.Items.Add(Item);
				}
			}

		private void textBoxQuantitiy_KeyPress(object sender, KeyPressEventArgs e)
			{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			}

		/// <summary>
		/// Retourner le prix d'article
		/// </summary>
		/// <param name="RefArticle"></param>
		/// <returns></returns>
		private float GetPrix(string RefArticle)
			{
			foreach(string[] Article in Articles){
				if(Article[0] == RefArticle){
				return float.Parse(Article[8]);
				}
			}
			throw new WarningException("Prix non trouvé");
			}

		/// <summary>
		/// Ajouter un article à facture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouterFacture_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.CbBoxArticles.Text == "" || this.TxtBoxQuantity.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Remplissez toutes les cases!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{

				try
					{
					string RefArticle = CbBoxArticles.Text.Substring(0, CbBoxArticles.Text.IndexOf(":"));
					Service.AddFactureArticle(RefFacture, RefArticle, int.Parse(TxtBoxQuantity.Text), GetPrix(RefArticle));
					//----------------------------------------
					// Ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau Article avec Réf: " + RefArticle;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi");
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						this.TxtBoxQuantity.Text = "";
						
						LstFactureArticles.Items.Clear();
						ShowFactureArticles();
						}
					}
				catch
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}

		/// <summary>
		/// Supprimer un article d'une facture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSupprimer_Click(object sender, EventArgs e)
			{
			if (LstFactureArticles.SelectedItems.Count != 0)
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Supprimer " + LstFactureArticles.SelectedItems.Count + " FactureArticle sélectionés ?";
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					foreach (ListViewItem Item in LstFactureArticles.SelectedItems)
						{
							{
							try
								{
								// supprimer les factures sélectionés dans la base de données
								Service.DeleteFactureArticle(RefFacture, Item.SubItems[1].Text);
								// supprimer les factures sélectionés dans ListView
								LstFactureArticles.Items[Item.Index].Remove();
								}
							catch
								{
								MessageBox.Show("Erreur détéctée! Echèc à supprimer", "Ehcèc");
								}
							}
						}
					// refresh ListView
					this.LstFactureArticles.Refresh();
					}
				}
			}

		}
	}

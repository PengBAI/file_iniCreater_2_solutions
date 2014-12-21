using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mercure;
using System.Globalization;

namespace MercureWin
	{
	public partial class FormUnArticle : Form
		{
		ListView MyListView;
		MercureService MyService;
		List<string[]> Marques = new List<string[]>();
		List<string[]> SousFammilles = new List<string[]>();

		/// <summary>
		/// Constructeur pour ajouter un article
		/// </summary>
		/// <param name="IsListView"></param>
		/// <param name="IsService"></param>
		public FormUnArticle(ListView IsListView, MercureService IsService)
			{
			InitializeComponent();
			MyListView = IsListView;
			MyService = IsService;
			InitComboBox();
			// manquer le bouton de modifier
			this.BtnModifier.Visible = false;
			}

		/// <summary>
		/// Constructeur pour modifier un article
		/// </summary>
		/// <param name="IsListView"></param>
		/// <param name="IsService"></param>
		/// <param name="RefArticle"></param>
		/// <param name="Description"></param>
		/// <param name="SousFamille"></param>
		/// <param name="Marque"></param>
		/// <param name="PrixHT"></param>
		public FormUnArticle(ListView IsListView, MercureService IsService,
							string RefArticle, string Description, string SousFamille, string Marque, string PrixHT)
			{
			InitializeComponent();
			MyListView = IsListView;
			MyService = IsService;
			InitComboBox();
			// manquer le bouton de modifier
			this.BtnAjouter.Visible = false;
			TxtBoxRefArticle.Enabled = false;
			LabelRefArticle.Text = "";
			TxtBoxRefArticle.Text = RefArticle;
			TxtBoxDescription.Text = Description;
			TxtBoxPrix.Text = PrixHT;
			CbBoxMarque.Text = Marque;
			CbBoxSousFamille.Text = SousFamille;
			}


		/// <summary>
		/// Remplir les combobox Marques et SousFamilles
		/// </summary>
		private void InitComboBox()
			{

			//-------------------------------------------------------------------------------------
			// Récupération des marques
			//-------------------------------------------------------------------------------------

			Marques = MyService.GetMarques();
			foreach (string[] Marque in Marques)
				{
				CbBoxMarque.Items.Add(Marque[1]);
				}
			//-------------------------------------------------------------------------------------
			// Récupération des sousFamille
			//-------------------------------------------------------------------------------------

			// Les champs retournés sont dans l'ordre : 
			// 'RefSousFamille', 'RefFamille', 'NomSousFamille'.
			SousFammilles = MyService.GetSousFamilles();
			foreach (string[] SousFamille in SousFammilles)
				{
				CbBoxSousFamille.Items.Add(SousFamille[2]);
				}
			}

		private void BtnAnnuler_Click(object sender, EventArgs e)
			{
			this.Close();
			}

		/// <summary>
		/// Retourner le référence de nom marque
		/// </summary>
		/// <param name="NomMarque"></param>
		/// <returns></returns>
		/// <exception cref="WarningException">si nom marque n'existe pas</exception>
		private int GetRefMarque(string NomMarque)
			{
			// trouver le référence de marque
			foreach (string[] Marque in Marques)
				{
				if (Marque[1] == NomMarque)
					{
					return int.Parse(Marque[0]);
					}
				}
			throw new WarningException("NomMarque non trouvé");
			}

		/// <summary>
		/// Retourner le référence de sousfamille
		/// </summary>
		/// <param name="RefSousFamille"></param>
		/// <returns></returns>
		/// <exception cref="WarningException"></exception>
		private int GetRefSousFamille(string NomSousFamille)
			{
			// trouver le référence de sousfamille
			foreach (string[] SousFamille in SousFammilles)
				{
				if (SousFamille[2] == NomSousFamille)
					{
					return int.Parse(SousFamille[0]);
					}
				}
			throw new WarningException("NomSousFamille non trouvé");
			}

		/// <summary>
		/// Ajouter un nouveau article
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouter_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxDescription.Text == "" || this.TxtBoxRefArticle.Text == ""
						|| this.TxtBoxPrix.Text == "" || this.CbBoxSousFamille.Text == "" || this.CbBoxMarque.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Remplissez toutes les cases vides, s'il vous plait!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{
				try
					{
					MyService.AddArticle(TxtBoxRefArticle.Text, TxtBoxDescription.Text, this.GetRefSousFamille(CbBoxSousFamille.Text),
											this.GetRefMarque(CbBoxMarque.Text), float.Parse(TxtBoxPrix.Text));
					//----------------------------------------
					// ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau Article avec Réf: " + TxtBoxRefArticle.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi");
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						MyListView.Items.Clear();
						ReloadArticles();
						this.Close();
						}
					}
				catch
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}

		/// <summary>
		/// Ajouter les items dans le ListView
		/// </summary>
		private void ReloadArticles()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Articles = new List<string[]>();
			Articles = MyService.GetArticles();
			foreach (string[] Datas in Articles)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				MyListView.Items.Add(Item);
				}
			}

		/// <summary>
		/// Modifier l'article
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnModifier_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxDescription.Text == "" || this.TxtBoxRefArticle.Text == ""
							|| this.TxtBoxPrix.Text == "" || this.CbBoxSousFamille.Text == "" || this.CbBoxMarque.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Remplissez toutes les cases vides, s'il vous plait!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{
				try
					{
					// update 
					MyService.UpdateArticle(TxtBoxRefArticle.Text, TxtBoxDescription.Text, this.GetRefSousFamille(CbBoxSousFamille.Text),
											this.GetRefMarque(CbBoxMarque.Text), float.Parse(TxtBoxPrix.Text));
					//----------------------------------------
					// modifier avec succès
					//----------------------------------------
					string Message = "Réussi! Modifié un Article avec Réf: " + TxtBoxRefArticle.Text;
					DialogResult Result = MessageBox.Show(Message, "Réussi", MessageBoxButtons.OK);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						MyListView.Items.Clear();
						ReloadArticles();
						this.Close();
						}
					}
				catch
					{
					// Displays the MessageBox.
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}
		}
	}

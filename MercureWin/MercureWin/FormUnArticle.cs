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
	public partial class FormUnArticle : Form
		{
		ListView MyListView;
		MercureService MyService;
		List<string[]> Marques = new List<string[]>();
		List<string[]> SousFammilles = new List<string[]>();

		public FormUnArticle(ListView IsListView, MercureService IsService)
			{
			InitializeComponent();
			MyListView = IsListView;
			MyService = IsService;
			InitComboBox();
			// manquer le bouton de modifier
			this.BtnModifier.Visible = false;
			}

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
			TxtBoxRefArticle.Text = RefArticle;
			TxtBoxDescription.Text = Description;
			TxtBoxPrix.Text = PrixHT;
			CbBoxMarque.Text = Marque;
			CbBoxSousFamille.Text = SousFamille;
			}


		/// <summary>
		/// remplir les combobox Marques et SousFamilles
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

		private void BtnAjouter_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxDescription.Text == "" || this.TxtBoxRefArticle.Text == ""
												|| this.TxtBoxPrix.Text == "" || this.CbBoxSousFamille.Text == "" || this.CbBoxMarque.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string message = "Remplissez toutes les cases vides, s'il vous plait!";
				string caption = "Attention";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				// Displays the MessageBox.
				MessageBox.Show(message, caption, buttons);
				}
			else
				{
				int IdMarque = 0;
				int IdSousFamille = 0;
				try
					{
					foreach (string[] Marque in Marques)
						{
						if (Marque[1] == CbBoxMarque.Text)
							{
							IdMarque = int.Parse(Marque[0]);
							}
						}
					foreach (string[] SousFamille in SousFammilles)
						{
						if (SousFamille[2] == CbBoxSousFamille.Text)
							{
							IdSousFamille = int.Parse(SousFamille[0]);
							}
						}
					MyService.AddArticle(TxtBoxRefArticle.Text, TxtBoxDescription.Text, IdSousFamille, IdMarque, float.Parse(TxtBoxPrix.Text));
					//----------------------------------------
					// ajouter avec succès
					//----------------------------------------
					string message = "Succès! Ajouté un nouveau Article avec Réf: " + TxtBoxRefArticle.Text;
					string caption = "Succès";
					DialogResult Result;
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					// Displays the MessageBox.
					Result = MessageBox.Show(message, caption, buttons);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						MyListView.Items.Clear();
						ReloadArticles();
						this.Close();
						}
					}
				catch (Exception Ex)
					{
					string message = "Les cases remplit non valides!";
					string caption = "Attention";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					// Displays the MessageBox.
					MessageBox.Show(message, caption, buttons);
					}

				}
			}

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

		private void TxtBoxRefArticle_TextChanged(object sender, EventArgs e)
			{
			if (TxtBoxRefArticle.Text.Length > 8)
				{
				TxtBoxRefArticle.Text = TxtBoxRefArticle.Text.Substring(0, 8);
				}
			}

		private void BtnModifier_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxDescription.Text == "" || this.TxtBoxRefArticle.Text == ""
												|| this.TxtBoxPrix.Text == "" || this.CbBoxSousFamille.Text == "" || this.CbBoxMarque.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string message = "Remplissez toutes les cases vides, s'il vous plait!";
				string caption = "Attention";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				// Displays the MessageBox.
				MessageBox.Show(message, caption, buttons);
				}
			else
				{
				int IdMarque = 0;
				int IdSousFamille = 0;
				try
					{
					foreach (string[] Marque in Marques)
						{
						if (Marque[1] == CbBoxMarque.Text)
							{
							IdMarque = int.Parse(Marque[0]);
							}
						}
					foreach (string[] SousFamille in SousFammilles)
						{
						if (SousFamille[2] == CbBoxSousFamille.Text)
							{
							IdSousFamille = int.Parse(SousFamille[0]);
							}
						}
					MyService.UpdateArticle(TxtBoxRefArticle.Text, TxtBoxDescription.Text, IdSousFamille, IdMarque, float.Parse(TxtBoxPrix.Text));
					//----------------------------------------
					// ajouter avec succès
					//----------------------------------------
					string message = "Succès! Modifié un Article avec Réf: " + TxtBoxRefArticle.Text;
					string caption = "Succès";
					DialogResult Result;
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					// Displays the MessageBox.
					Result = MessageBox.Show(message, caption, buttons);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						MyListView.Items.Clear();
						ReloadArticles();
						this.Close();
						}
					}
				catch (Exception Ex)
					{
					string message = "Les cases remplit non valides!";
					string caption = "Attention";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					// Displays the MessageBox.
					MessageBox.Show(message, caption, buttons);
					}

				}

			}
		}
	}

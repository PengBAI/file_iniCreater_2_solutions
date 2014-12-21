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
		List<string[]> Familles = new List<string[]>();

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
			//-------------------------------------------------------------------------------------
			// Initialisation du ListView et remplir le comboBox
			//-------------------------------------------------------------------------------------
			LsvSousFamilles.View = View.Details;
			LsvSousFamilles.GridLines = true;
			LsvSousFamilles.FullRowSelect = true;
			// ajouter les noms de colonnes de listview 
			LsvSousFamilles.Columns.Add("RéfSousFamille", 80);
			LsvSousFamilles.Columns.Add("NomSousFamille", 200);
			LsvSousFamilles.Columns.Add("RéfFamille", 70);
			LsvSousFamilles.Columns.Add("NomFamille", 150);
			this.ShowSousFamilles();
			InitComboBox();
			}

		/// <summary>
		/// Remplir les combobox Familles
		/// </summary>
		private void InitComboBox()
			{

			//-------------------------------------------------------------------------------------
			// Récupération des Familles
			//-------------------------------------------------------------------------------------
			Familles = Service.GetFamilles();
			foreach (string[] Famille in Familles)
				{
				CbBoxFamille.Items.Add(Famille[1]);
				CbBoxModifier.Items.Add(Famille[1]);
				}
			}
		/// <summary>
		/// Retourner le nom de famille
		/// </summary>
		/// <param name="RefFamille"> référence de famille</param>
		/// <returns></returns>
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

		/// <summary>
		/// Ajouter les sousfamilles dans le ListView, en ajoutent le NomFamille
		/// </summary>
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
				Item = new ListViewItem(NewItem);
				LsvSousFamilles.Items.Add(Item);
				}
			}

		/// <summary>
		/// Retourner le réfrence d'une famille donnée
		/// </summary>
		/// <param name="NomFamille"></param>
		/// <returns></returns>
		/// <exception cref="WarningException">NomFamille non trouvé</exception>
		private int GetRefFamille(string NomFamille)
			{

			// trouver le référence de marque
			foreach (string[] Famille in Familles)
				{
				if (Famille[1] == NomFamille)
					{
					return int.Parse(Famille[0]);
					}
				}
			throw new WarningException("Famille non trouvée");
			}

		/// <summary>
		/// Ajouter la nouvelle sousfamille
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouter_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.CbBoxFamille.Text == "" || this.TxtBoxNomSousFamille.Text == "")
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
					Service.AddSousFamille(this.GetRefFamille(this.CbBoxFamille.Text), TxtBoxNomSousFamille.Text);
					//----------------------------------------
					// Ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau SousFamille avec Nom: " + TxtBoxNomSousFamille.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi");
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						LsvSousFamilles.Items.Clear();
						this.CbBoxFamille.Text = "";
						this.CbBoxModifier.Text = "";
						this.TxtBoxModifierNom.Text = "";
						this.TxtBoxNomSousFamille.Text = "";

						ShowSousFamilles();
						}
					}
				catch
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}

		/// <summary>
		/// Modifier une sousfamille
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnModifier_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxModifierNom.Text == "" || this.CbBoxModifier.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Choisissez un SousFamille dans la Liste!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{
				try
					{
					// Update 
					Service.UpdateSousFamille(int.Parse(LabelRefSousFamille.Text), GetRefFamille(CbBoxModifier.Text), TxtBoxModifierNom.Text);
					//----------------------------------------
					// Modifier avec succès
					//----------------------------------------
					string Message = "Réussi! Modifié un SousFamille avec Réf: " + LabelRefSousFamille.Text + " Nom: " + TxtBoxModifierNom.Text;
					DialogResult Result = MessageBox.Show(Message, "Réussi", MessageBoxButtons.OK);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						LsvSousFamilles.Items.Clear();
						ShowSousFamilles();
						CbBoxModifier.Text ="";
						TxtBoxModifierNom.Text = "";
						LabelRefSousFamille.Text = "";
						}
					}
				catch
					{
					// Displays the MessageBox.
					MessageBox.Show("Choisissez un Marque dans la Liste!", "Attention");
					}
				}
			}

		private void LsvSousFamilles_SelectedIndexChanged(object sender, EventArgs e)
			{
			if (LsvSousFamilles.SelectedItems.Count == 1)
				{
				this.LabelRefSousFamille.Text = LsvSousFamilles.SelectedItems[0].SubItems[0].Text;
				this.CbBoxModifier.Text = LsvSousFamilles.SelectedItems[0].SubItems[3].Text;
				this.TxtBoxModifierNom.Text = LsvSousFamilles.SelectedItems[0].SubItems[1].Text;
				}
			}

		/// <summary>
		/// Vérifier si le NomSousFamille est déjà utilisé dans articles
		/// </summary>
		/// <param name="NomMarque"></param>
		/// <returns></returns>
		private bool IsSousFamilleUsed(int RefMarque)
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles
			//-------------------------------------------------------------------------------------
			List<string[]> Articles = new List<string[]>();
			Articles = Service.GetArticles();
			foreach (string[] Datas in Articles)
				{
				if (int.Parse(Datas[4]) == RefMarque)
					{
					return true;
					}
				}
			return false;
			}

		/// <summary>
		/// Supprimer les sousfamilles sélectionnées
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSupprimer_Click(object sender, EventArgs e)
			{
			if (LsvSousFamilles.SelectedItems.Count != 0)
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Supprimer " + LsvSousFamilles.SelectedItems.Count + " sousfamilles sélectionés ?";
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					foreach (ListViewItem Item in LsvSousFamilles.SelectedItems)
						{
						if (IsSousFamilleUsed(int.Parse(Item.SubItems[0].Text)))
							{
							MessageBox.Show(Item.SubItems[1].Text + " est utilisé dans Articles.\nSupprimer l'article d'abord.", "Echèc");
							}
						else
							{
							// supprimer les articles sélectionés dans ListView
							LsvSousFamilles.Items[Item.Index].Remove();
							// supprimer les articles sélectionés dans la base de données
							Service.DeleteSousFamille(int.Parse(Item.SubItems[0].Text));
							}
						}
					TxtBoxModifierNom.Text = "";
					LabelRefSousFamille.Text = "";
					CbBoxModifier.Text = "";
					// refresh ListView
					LsvSousFamilles.Refresh();
					}
				}
			}
		}
	}

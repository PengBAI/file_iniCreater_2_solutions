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
	public partial class FormFamilles : Form
		{
		MercureService Service;
		
		public FormFamilles(string MyURL)
			{
			InitializeComponent();
			Service = new MercureService();
			Service.Url = MyURL;
			}

		private void FormFamilles_Load(object sender, EventArgs e)
			{
			LsvFamilles.View = View.Details;
			LsvFamilles.GridLines = true;
			LsvFamilles.FullRowSelect = true;
			// ajouter les noms de colonnes de listview par l'ordre suivant:
			// 'RefMarque', 'NomMarque'
			LsvFamilles.Columns.Add("RéfFamille", 70);
			LsvFamilles.Columns.Add("NomFamille", 150);
			this.ShowFamilles();
			}

		private void ShowFamilles()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Familles = new List<string[]>();
			Familles = Service.GetFamilles();
			foreach (string[] Datas in Familles)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				LsvFamilles.Items.Add(Item);
				}
			}

		private void BtnAjouter_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxNomFamille.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Remplissez nom de la nouvelle famille!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{
				try
					{
					Service.AddFamille(TxtBoxNomFamille.Text);
					//----------------------------------------
					// ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau Famille: " + TxtBoxNomFamille.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi", MessageBoxButtons.OK);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						TxtBoxNomFamille.Text = "";
						TxtBoxModifierNom.Text = "";
						LabelRefFamille.Text = "";
						LsvFamilles.Items.Clear();
						ShowFamilles();
						}
					}
				catch (Exception)
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}

				}
			}

		/// <summary>
		/// vérifier si le NomFamille est déjà utilisé dans SousFamille
		/// </summary>
		/// <param name="NomMarque"></param>
		/// <returns></returns>
		private bool IsMarqueUsed(int RefFamille)
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles
			//-------------------------------------------------------------------------------------
			List<string[]> SousFamilles = new List<string[]>();
			SousFamilles = Service.GetSousFamilles();
			foreach (string[] Datas in SousFamilles)
				{
				if (int.Parse(Datas[1]) == RefFamille)
					{
					return true;
					}
				}
			return false;
			}

		private void BtnSupprimer_Click(object sender, EventArgs e)
			{
			if (LsvFamilles.SelectedItems.Count != 0)
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Supprimer " + LsvFamilles.SelectedItems.Count + " familles sélectionés ?";
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					foreach (ListViewItem Item in LsvFamilles.SelectedItems)
						{
						if (IsMarqueUsed(int.Parse(Item.SubItems[0].Text)))
							{
							MessageBox.Show(Item.SubItems[1].Text + " est utilisé dans SouFamilles.\nSupprimer la sousfamille d'abord.", "Echec");
							}
						else
							{
							// supprimer les articles sélectionés dans ListView
							LsvFamilles.Items[Item.Index].Remove();
							// supprimer les articles sélectionés dans la base de données
							Service.DeleteFamille(int.Parse(Item.SubItems[0].Text));
							}
						}
					TxtBoxModifierNom.Text = "";
					LabelRefFamille.Text = "";
					// refresh ListView
					LsvFamilles.Refresh();
					}
				}
			}

		private void BtnModifier_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxModifierNom.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Choisissez un Marque dans la Liste!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{
				try
					{
					// update 
					Service.UpdateFamille(int.Parse(this.LabelRefFamille.Text), TxtBoxModifierNom.Text);
					//----------------------------------------
					// modifier avec succès
					//----------------------------------------
					string Message = "Réussi! Modifié un Marque avec Réf: " + this.LabelRefFamille.Text + " Nom: " + TxtBoxModifierNom.Text;
					DialogResult Result = MessageBox.Show(Message, "Réussi", MessageBoxButtons.OK);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						LsvFamilles.Items.Clear();
						ShowFamilles();
						this.TxtBoxModifierNom.Text = "";
						this.LabelRefFamille.Text = "";
						}
					}
				catch (Exception)
					{
					// Displays the MessageBox.
					MessageBox.Show("Choisissez un Marque dans la Liste!", "Attention");
					}
				}
			}

		private void LsvFamilles_SelectedIndexChanged(object sender, EventArgs e)
			{
			if (LsvFamilles.SelectedItems.Count == 1)
				{
				this.LabelRefFamille.Text = LsvFamilles.SelectedItems[0].SubItems[0].Text;
				this.TxtBoxModifierNom.Text = LsvFamilles.SelectedItems[0].SubItems[1].Text;
				}
			}
		}
	}

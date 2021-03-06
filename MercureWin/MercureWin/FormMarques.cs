﻿using System;
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
	public partial class FormMarques : Form
		{
		MercureService Service;

		public FormMarques(string MyURL)
			{
			InitializeComponent();
			//-------------------------------------------------------------------------------------
			// Connexion au Service-Web
			//-------------------------------------------------------------------------------------
			Service = new MercureService();
			Service.Url = MyURL;
			}

		private void FormMarques_Load(object sender, EventArgs e)
			{
			//-------------------------------------------------------------------------------------
			// Initialisation du ListView
			//-------------------------------------------------------------------------------------
			LsvMarques.View = View.Details;
			LsvMarques.GridLines = true;
			LsvMarques.FullRowSelect = true;
			// ajouter les noms de colonnes de listview par l'ordre suivant:
			// 'RefMarque', 'NomMarque'
			LsvMarques.Columns.Add("RéfMarque", 80);
			LsvMarques.Columns.Add("NomMarque", 100);
			this.ShowMarques();
			}

		/// <summary>
		/// Récupérer les données et ajouter dans le ListView
		/// </summary>
		private void ShowMarques()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des marques & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Marques = new List<string[]>();
			Marques = Service.GetMarques();
			foreach (string[] Datas in Marques)
				{
				ListViewItem Item;
				Item = new ListViewItem(Datas);
				LsvMarques.Items.Add(Item);
				}
			}

		/// <summary>
		/// Ajouter une nouvelle marque
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouter_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxNomMarque.Text == "")
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Remplissez nom de la nouvelle marque!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Attention");
				}
			else
				{
				try
					{
					Service.AddMarque(TxtBoxNomMarque.Text);
					//----------------------------------------
					// ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau Marque: " + TxtBoxNomMarque.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi", MessageBoxButtons.OK);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						TxtBoxNomMarque.Text = "";
						TxtBoxModifierNom.Text = "";
						LabelRefMarque.Text = "";
						LsvMarques.Items.Clear();
						ShowMarques();
						}
					}
				catch (Exception)
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}

				}
			}

		/// <summary>
		/// Vérifier si le NomMarque est déjà utilisé dans articles
		/// </summary>
		/// <param name="NomMarque"></param>
		/// <returns></returns>
		private bool IsMarqueUsed(int RefMarque)
			{
			//-------------------------------------------------------------------------------------
			// Récupération des articles
			//-------------------------------------------------------------------------------------
			List<string[]> Articles = new List<string[]>();
			Articles = Service.GetArticles();
			foreach (string[] Datas in Articles)
				{
				if (int.Parse(Datas[6]) == RefMarque)
					{
					return true;
					}
				}
			return false;
			}

		/// <summary>
		/// Supprimer la marque sélectionnée dans la liste
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSupprimer_Click(object sender, EventArgs e)
			{
			if (LsvMarques.SelectedItems.Count != 0)
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Supprimer " + LsvMarques.SelectedItems.Count + " marques sélectionés ?";
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					foreach (ListViewItem Item in LsvMarques.SelectedItems)
						{
						if (IsMarqueUsed(int.Parse(Item.SubItems[0].Text)))
							{
							MessageBox.Show(Item.SubItems[1].Text + " est utilisé dans Articles.\nSupprimer l'article d'abord.", "Echèc");
							}
						else
							{
							try
								{
								// supprimer les marques sélectionés dans la base de données
								Service.DeleteMarque(int.Parse(Item.SubItems[0].Text));
								// supprimer les marques sélectionés dans ListView
								LsvMarques.Items[Item.Index].Remove();
								}
							catch
								{
								MessageBox.Show("Erreur détéctée! Echèc à supprimer", "Ehcèc");
								}
							}
						}
					TxtBoxModifierNom.Text = "";
					LabelRefMarque.Text = "";
					// refresh ListView
					LsvMarques.Refresh();
					}
				}
			}

		/// <summary>
		/// Modifier la marque sélectionnée
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
					Service.UpdateMarque(int.Parse(LabelRefMarque.Text), TxtBoxModifierNom.Text);
					//----------------------------------------
					// modifier avec succès
					//----------------------------------------
					string Message = "Réussi! Modifié un Marque avec Réf: " + LabelRefMarque.Text + " Nom: " + TxtBoxModifierNom.Text;
					DialogResult Result = MessageBox.Show(Message, "Réussi", MessageBoxButtons.OK);
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						LsvMarques.Items.Clear();
						ShowMarques();
						TxtBoxModifierNom.Text = "";
						LabelRefMarque.Text = "";
						}
					}
				catch (Exception)
					{
					// Displays the MessageBox.
					MessageBox.Show("Choisissez un Marque dans la Liste!", "Attention");
					}
				}
			}

		/// <summary>
		/// Changer les données dans le groupe "modifier" dans cette fenêtre
		/// en temp réel quand choisir une marque dans la liste
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LsvMarques_SelectedIndexChanged(object sender, EventArgs e)
			{
			if (LsvMarques.SelectedItems.Count == 1)
				{
				this.LabelRefMarque.Text = LsvMarques.SelectedItems[0].SubItems[0].Text;
				this.TxtBoxModifierNom.Text = LsvMarques.SelectedItems[0].SubItems[1].Text;
				}
			}
		}
	}

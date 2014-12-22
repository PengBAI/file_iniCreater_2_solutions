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
	public partial class FormFactures : Form
		{
		MercureService Service;
		List<string[]> Clients = new List<string[]>();

		public FormFactures(string MyURL)
			{
			InitializeComponent();
			Service = new MercureService();
			Service.Url = MyURL;
			this.ShowFactures();
			this.InitComboBox();
			}

		private void FormFactures_Load(object sender, EventArgs e)
			{
			//-------------------------------------------------------------------------------------
			// Initialisation de ListView du client
			//-------------------------------------------------------------------------------------
			LstViewFactures.View = View.Details;
			LstViewFactures.GridLines = true;
			LstViewFactures.FullRowSelect = true;
			// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefFacture', 
			// 'RefClient', 'RaisonSocial', 'Nom', 'Prenom', 'Adresse', 'CodePostal', 'Ville', 
			// 'Pays', 'CreateDate'.
			LstViewFactures.Columns.Add("RefFacture", 80);
			LstViewFactures.Columns.Add("RefClient", 100);
			LstViewFactures.Columns.Add("RaisonSocial", 100);
			LstViewFactures.Columns.Add("Nom", 80);
			LstViewFactures.Columns.Add("Prenom", 80);
			LstViewFactures.Columns.Add("Adresse", 150);
			LstViewFactures.Columns.Add("CodePostal", 80);
			LstViewFactures.Columns.Add("Ville", 80);
			LstViewFactures.Columns.Add("Pays", 80);
			LstViewFactures.Columns.Add("CreateDate", 150);
			}

		/// <summary>
		/// Récupérer les données et les ajouter dans le ListView
		/// </summary>
		private void ShowFactures()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des Factures & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Factures = new List<string[]>();
			Factures = Service.GetFactures();
			foreach (string[] Datas in Factures)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				LstViewFactures.Items.Add(Item);
				}
			}

		/// <summary>
		/// Remplir les combobox Familles
		/// </summary>
		private void InitComboBox()
			{

			//-------------------------------------------------------------------------------------
			// Récupération des Clients
			//-------------------------------------------------------------------------------------
			Clients = Service.GetClients();
			foreach (string[] Client in Clients)
				{
				CbBoxClients.Items.Add("Réf: " + Client[0] + " Nom: " + Client[2]);
				}
			}

		/// <summary>
		/// Retourner le Référence du client dans le combobox
		/// </summary>
		/// <param name="InfoClient"></param>
		/// <returns></returns>
		private int GetRefClient(string InfoClient)
			{
			int IndexNom = InfoClient.IndexOf("Nom: ");
			int Length = IndexNom - 5 - 1;
			return int.Parse(InfoClient.Substring(5, Length));
			}

		/// <summary>
		/// Ajouter une facture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouterFacture_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.CbBoxClients.Text == "" || this.TxtBoxRefFacture.Text == "")
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
					Service.AddFacture(TxtBoxRefFacture.Text, GetRefClient(CbBoxClients.Text));
					//----------------------------------------
					// Ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau Facture avec Réf: " + TxtBoxRefFacture.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi");
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						TxtBoxRefFacture.Text = "";
						CbBoxClients.Text = "";
						LstViewFactures.Items.Clear();
						ShowFactures();
						}
					}
				catch
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}

		/// <summary>
		/// vérifier si facture est utilisé dans FactureArticle
		/// </summary>
		/// <returns></returns>
		private bool IsFactureUsed(string RefFacture)
			{
			//-------------------------------------------------------------------------------------
			// Récupération des FactureArticles
			//-------------------------------------------------------------------------------------
			List<string[]> FactureArticles = new List<string[]>();
			FactureArticles = Service.GetFactureArticles(RefFacture);
			if (FactureArticles != null && FactureArticles.Count != 0)
				{
				return true;
				}
			else
				{
				return false;
				}
			}

		/// <summary>
		/// Supprimer une facture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSuppFacture_Click(object sender, EventArgs e)
			{
			if (LstViewFactures.SelectedItems.Count != 0)
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Supprimer " + LstViewFactures.SelectedItems.Count + " Factures sélectionés ?";
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					foreach (ListViewItem Item in LstViewFactures.SelectedItems)
						{
						if (IsFactureUsed(Item.SubItems[0].Text))
							{
							MessageBox.Show("Réf: "+Item.SubItems[0].Text + " est utilisé dans FactureArticle.\nSupprimer FactureArticle d'abord.", "Echèc");
							}
						else
							{
							try
								{
								// supprimer les factures sélectionés dans la base de données
								Service.DeleteFacture(Item.SubItems[0].Text);
								// supprimer les factures sélectionés dans ListView
								LstViewFactures.Items[Item.Index].Remove();
								}
							catch
								{
								MessageBox.Show("Erreur détéctée! Echèc à supprimer", "Ehcèc");
								}
							}
						}
					TxtBoxRefFacture.Text = "";
					// refresh ListView
					this.LstViewFactures.Refresh();
					}
				}
			}

		private void LstViewFactures_SelectedIndexChanged(object sender, EventArgs e)
			{
			if (LstViewFactures.SelectedItems.Count == 1)
				{
				this.LabelRefFacture.Text = "Réf: " + LstViewFactures.SelectedItems[0].SubItems[0].Text;
				}
			}

		/// <summary>
		/// Voir les détaille d'une facture sélectionnée
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGestion_Click(object sender, EventArgs e)
			{
			if (LabelRefFacture.Text.Length > 5)
				{
				FormFactureArticles FactureArticles = new FormFactureArticles(LabelRefFacture.Text.Substring(5), Service);
				FactureArticles.Text = "Les articles da la Facture " + LabelRefFacture.Text;
				FactureArticles.ShowDialog();
				LabelRefFacture.Text = "Réf: ";
				}
			}
			
		/// <summary>
		/// RéfFacture est nomber only
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TxtBoxRefFacture_KeyPress(object sender, KeyPressEventArgs e)
			{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			}
		}
	}

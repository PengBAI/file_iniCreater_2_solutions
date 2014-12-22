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
	public partial class FormClients : Form
		{
		MercureService Service;
		public FormClients(string MyURL)
			{
			InitializeComponent();
			//-------------------------------------------------------------------------------------
			// Connexion au Service-Web
			//-------------------------------------------------------------------------------------
			Service = new MercureService();
			Service.Url = MyURL;
			this.ShowClients();
			}

		private void FormClients_Load(object sender, EventArgs e)
			{
			//-------------------------------------------------------------------------------------
			// Initialisation de ListView du client
			//-------------------------------------------------------------------------------------
			LstViewClients.View = View.Details;
			LstViewClients.GridLines = true;
			LstViewClients.FullRowSelect = true;
			// ajouter les noms de colonnes de listview par l'ordre suivant:
			// 'RefClient', 'RaisonSocial', 'Nom', 'Prenom', 
			// 'Adresse', 'CodePostal', 'Ville', 'Pays'.
			LstViewClients.Columns.Add("RéfClient", 80);
			LstViewClients.Columns.Add("RaisonSocial", 100);
			LstViewClients.Columns.Add("Nom", 80);
			LstViewClients.Columns.Add("Prenom", 80);
			LstViewClients.Columns.Add("Adresse", 300);
			LstViewClients.Columns.Add("CodePostal", 80);
			LstViewClients.Columns.Add("Ville", 80);
			LstViewClients.Columns.Add("Pays", 80);
			}

		/// <summary>
		/// Récupérer les données et les ajouter dans le ListView
		/// </summary>
		private void ShowClients()
			{

			//-------------------------------------------------------------------------------------
			// Récupération des clients & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Clients = new List<string[]>();
			Clients = Service.GetClients();
			foreach (string[] Datas in Clients)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				LstViewClients.Items.Add(Item);
				}
			}

		/// <summary>
		/// Ajouter un nouveau client
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouterClient_Click(object sender, EventArgs e)
			{
			FormUnClient UnArticle = new FormUnClient(LstViewClients, Service);
			UnArticle.Text = "Ajouter un nouveau Client";
			UnArticle.ShowDialog();
			}

		/// <summary>
		/// Modifier un client sélectionné
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnModifierClient_Click(object sender, EventArgs e)
			{
			if (LstViewClients.SelectedItems.Count != 0)
				{
				ListViewItem Item = LstViewClients.SelectedItems[0];
				FormUnClient UnArticle = new FormUnClient(LstViewClients, Service, int.Parse(Item.SubItems[0].Text), Item.SubItems[1].Text,
															Item.SubItems[2].Text, Item.SubItems[3].Text,
															Item.SubItems[4].Text, Item.SubItems[5].Text,
															Item.SubItems[6].Text, Item.SubItems[7].Text);
				UnArticle.Text = "Modifier Client réf: " + Item.SubItems[0].Text;
				UnArticle.ShowDialog();
				}
			}

		/// <summary>
		/// Vérifier si le client est dans le table Facture
		/// </summary>
		/// <param name="RefClient"></param>
		/// <returns></returns>
		private bool IsClientUsed(int RefClient)
			{
			//-------------------------------------------------------------------------------------
			// Récupération des Facture
			//-------------------------------------------------------------------------------------
			List<string[]> Factures = new List<string[]>();
			Factures = Service.GetFactures();
			foreach (string[] Datas in Factures)
				{
				if (int.Parse(Datas[1]) == RefClient)
					{
					return true;
					}
				}
			return false;
			}

		/// <summary>
		/// Supprimer un client
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSuppClient_Click(object sender, EventArgs e)
			{
			if (LstViewClients.SelectedItems.Count != 0)
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "Supprimer " + LstViewClients.SelectedItems.Count + " clients sélectionés ?";
				// Displays the MessageBox.
				DialogResult result = MessageBox.Show(Message, "Attention", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
					{
					foreach (ListViewItem Item in LstViewClients.SelectedItems)
						{
						if (IsClientUsed(int.Parse(Item.SubItems[0].Text)))
							{
							MessageBox.Show("Réf: " + Item.SubItems[0].Text + " est utilisé dans Facture.\nSupprimer facture d'abord.", "Echèc");
							}
						else
							{
							// supprimer les articles sélectionés dans ListView
							LstViewClients.Items[Item.Index].Remove();
							// supprimer les articles sélectionés dans la base de données
							Service.DeleteClient(int.Parse(Item.SubItems[0].Text));
							}
						}
					// refresh ListView
					LstViewClients.Refresh();
					}
				}
			}
		}
	}


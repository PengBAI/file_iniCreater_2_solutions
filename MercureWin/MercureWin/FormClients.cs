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

		}
	}

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
	public partial class FormUnClient : Form
		{
		ListView MyListView;
		MercureService MyService;

		/// <summary>
		/// Constructeur pour ajouter un client
		/// </summary>
		/// <param name="IsListView"></param>
		/// <param name="IsService"></param>
		public FormUnClient(ListView IsListView, MercureService IsService)
			{
			InitializeComponent();
			MyListView = IsListView;
			MyService = IsService;
			// manquer le bouton de modifier
			this.BtnModifier.Visible = false;
			this.LabelRefClient.Visible = false;
			}

		/// <summary>
		/// Constructeur pour modifier un client
		/// 'RefClient', 'RaisonSocial', 'Nom', 'Prenom', 
		/// 'Adresse', 'CodePostal', 'Ville', 'Pays'.
		/// </summary>
		/// <param name="IsListView"></param>
		/// <param name="IsService"></param>
		public FormUnClient(ListView IsListView, MercureService IsService, int RefClient, string RaisonSocial, string Nom,
					  string Prenom, string Adresse, string CodePostal, string Ville, string Pays)
			{
			InitializeComponent();
			MyListView = IsListView;
			MyService = IsService;
			// manquer le bouton de modifier
			this.BtnAjouter.Visible = false;
			// ajouter le référence label
			this.LabelRefClient.Visible = true;
			this.LabelRefClient.Text = "RéfClient: " + RefClient;
			this.TxtBoxRaisonSocial.Text = RaisonSocial;
			this.TxtBoxNom.Text = Nom;
			this.TxtBoxPrenom.Text = Prenom;
			this.TxtBoxAdresse.Text = Adresse;
			this.TxtBoxCodePostal.Text = CodePostal;
			this.TxtBoxVille.Text = Ville;
			this.TxtBoxPays.Text = Pays;
			}
		
		/// <summary>
		/// Ajouter les items dans le ListView
		/// </summary>
		private void ReloadClients()
			{
			//-------------------------------------------------------------------------------------
			// Récupération des clients & Affichage
			//-------------------------------------------------------------------------------------
			List<string[]> Clients = new List<string[]>();
			Clients = MyService.GetClients();
			foreach (string[] Datas in Clients)
				{
				ListViewItem Item;
				//add items to ListView
				Item = new ListViewItem(Datas);
				MyListView.Items.Add(Item);
				}
			}

		/// <summary>
		/// Ajouter un nouveau client
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAjouter_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxAdresse.Text == "" || this.TxtBoxNom.Text == ""
						|| this.TxtBoxCodePostal.Text == "" || this.TxtBoxPrenom.Text == ""
						|| this.TxtBoxPays.Text == "" || this.TxtBoxRaisonSocial.Text == "" || this.TxtBoxVille.Text == "")
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
					MyService.AddClient(this.TxtBoxRaisonSocial.Text, this.TxtBoxNom.Text, 
										this.TxtBoxPrenom.Text, this.TxtBoxAdresse.Text, this.TxtBoxCodePostal.Text, 
										this.TxtBoxVille.Text, this.TxtBoxPays.Text);
					//----------------------------------------
					// ajouter avec succès
					//----------------------------------------
					string Message = "Réussi! Ajouté un nouveau client: " + TxtBoxNom.Text + " " + TxtBoxPrenom.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi");
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						MyListView.Items.Clear();
						ReloadClients();
						this.Close();
						}
					}
				catch
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}

		private void BtnAnnuler_Click(object sender, EventArgs e)
			{
			this.Close();
			}

		/// <summary>
		/// Modifier un client 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnModifier_Click(object sender, EventArgs e)
			{
			// Il existe case non remplit
			if (this.TxtBoxAdresse.Text == "" || this.TxtBoxNom.Text == ""
						|| this.TxtBoxCodePostal.Text == "" || this.TxtBoxPrenom.Text == ""
						|| this.TxtBoxPays.Text == "" || this.TxtBoxRaisonSocial.Text == "" || this.TxtBoxVille.Text == "")
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
					MyService.UpdateClient(int.Parse(this.LabelRefClient.Text.Substring(11)),this.TxtBoxRaisonSocial.Text, this.TxtBoxNom.Text,
										this.TxtBoxPrenom.Text, this.TxtBoxAdresse.Text, this.TxtBoxCodePostal.Text,
										this.TxtBoxVille.Text, this.TxtBoxPays.Text);
					//----------------------------------------
					// modifier avec succès
					//----------------------------------------
					string Message = "Réussi! Modifier le client avec "+ this.LabelRefClient.Text;
					// Displays the MessageBox.
					DialogResult Result = MessageBox.Show(Message, "Réussi");
					if (Result == System.Windows.Forms.DialogResult.OK)
						{
						MyListView.Items.Clear();
						ReloadClients();
						this.Close();
						}
					}
				catch
					{
					MessageBox.Show("Les cases remplit non valides!", "Attention");
					}
				}
			}
		}
	}

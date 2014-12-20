using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercureWin
	{
	public partial class FormMain : Form
		{
		public FormMain()
			{
			InitializeComponent();
			}

		private void FormMain_Load(object sender, EventArgs e)
			{
			toolStripStatusLabelMain.Text = "";
			}

		private void editURLToolStripMenuItem_Click(object sender, EventArgs e)
			{
			FormURL UrlMDIChildWin = new FormURL(this.toolStripStatusLabelMain);
			// Set the Parent Form of the Child window.
			UrlMDIChildWin.MdiParent = this;
			// Display the new form.
			UrlMDIChildWin.Show();

			}

		private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{

				FormArticles MDIChild = new FormArticles(this.toolStripStatusLabelMain.Text);
				MDIChild.MdiParent = this;
				MDIChild.WindowState = FormWindowState.Maximized;
				MDIChild.Show();
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Ajouter d'abord un URL!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void marquesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{

				FormMarques MDIChild = new FormMarques(this.toolStripStatusLabelMain.Text);
				MDIChild.MdiParent = this;
				MDIChild.Show();

				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Ajouter d'abord un URL!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void famillesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{

				FormFamilles MDIChild = new FormFamilles(this.toolStripStatusLabelMain.Text);
				MDIChild.MdiParent = this;
				MDIChild.Show();
				
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Ajouter d'abord un URL!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void sousFamillesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{
				
				FormSousFamilles MDIChild = new FormSousFamilles(this.toolStripStatusLabelMain.Text);
				MDIChild.MdiParent = this;
				MDIChild.Show();
				
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Ajouter d'abord un URL!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
			{
			this.Close();
			}

		private void clientToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{

				FormClients MDIChild = new FormClients(this.toolStripStatusLabelMain.Text);
				MDIChild.MdiParent = this;
				MDIChild.WindowState = FormWindowState.Maximized;
				MDIChild.Show();
				
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Ajouter d'abord un URL!";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}

			}

		private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
			{
			FormAPropos APropos = new FormAPropos();
			APropos.ShowDialog();
			}
		}
	}

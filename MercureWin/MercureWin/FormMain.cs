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
				FormArticles ArticlesMDIChild = new FormArticles(this.toolStripStatusLabelMain.Text);
				ArticlesMDIChild.MdiParent = this;
				ArticlesMDIChild.WindowState = FormWindowState.Maximized;
				ArticlesMDIChild.Show();
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Annuler cette opération?";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void marquesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{
				FormMarques ArticlesMDIChild = new FormMarques(this.toolStripStatusLabelMain.Text);
				ArticlesMDIChild.MdiParent = this;
				ArticlesMDIChild.Show();
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Annuler cette opération?";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void famillesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{
				FormFamilles ArticlesMDIChild = new FormFamilles(this.toolStripStatusLabelMain.Text);
				ArticlesMDIChild.MdiParent = this;
				ArticlesMDIChild.Show();
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Annuler cette opération?";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		private void sousFamillesToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (this.toolStripStatusLabelMain.Text != "")
				{
				FormSousFamilles ArticlesMDIChild = new FormSousFamilles(this.toolStripStatusLabelMain.Text);
				ArticlesMDIChild.MdiParent = this;
				ArticlesMDIChild.Show();
				}
			else
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Annuler cette opération?";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur URL");
				}
			}

		}
	}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace MercureWin
	{
	public partial class FormURL : Form
		{
		ToolStripStatusLabel MyToolSSLabel;
		public FormURL(ToolStripStatusLabel ToolSSLabel)
			{
			InitializeComponent();
			MyToolSSLabel = ToolSSLabel;
			}

		private void BtnCancelURL_Click(object sender, EventArgs e)
			{
			this.Close();
			}

		private void BtnOkURL_Click(object sender, EventArgs e)
			{
			if (!this.TxtBoxURL.Text.Contains("http://"))
				{
				this.TxtBoxURL.Text = "http://" + this.TxtBoxURL.Text.Trim();
				}
			if (!isValidURL(TxtBoxURL.Text))
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string Message = "URL invalide! Service Mercure non trouvé";
				// Displays the MessageBox.
				MessageBox.Show(Message, "Erreur Detectée URL", MessageBoxButtons.OK);
				}
			else
				{
				MyToolSSLabel.Text = this.TxtBoxURL.Text;
				this.Close();
				}
			}

		/// <summary>
		/// check URL est disponible
		/// </summary>
		/// <param name="source">URL</param>
		/// <returns></returns>
		private bool isValidURL(string URL)
			{
			try
				{
				var Request = WebRequest.Create(URL) as HttpWebRequest;
				Request.Method = "GET";
				using (var Response = (HttpWebResponse)Request.GetResponse())
					{
					return Response.StatusCode == HttpStatusCode.OK;
					}
				}
			catch
				{
				return false;
				}
			}
		}
	}

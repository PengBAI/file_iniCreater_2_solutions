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
			// check
			if (!isValidURL(TxtBoxURL.Text))
				{
				// Initializes the variables to pass to the MessageBox.Show method.
				string message = "You did not enter a URL. Cancel this operation?";
				string caption = "Error Detected in Input";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result;

				// Displays the MessageBox.

				result = MessageBox.Show(message, caption, buttons);

				if (result == System.Windows.Forms.DialogResult.Yes)
					{
					// todo if need
					}
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
		public static bool isValidURL(string Url)
			{
			return Uri.IsWellFormedUriString(Url, UriKind.RelativeOrAbsolute);
			}

		private void FormURL_Load(object sender, EventArgs e)
			{

			}

		}
	}

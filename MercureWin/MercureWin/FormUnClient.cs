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
			}
		}
	}

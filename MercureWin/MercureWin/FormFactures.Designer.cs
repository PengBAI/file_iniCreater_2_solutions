namespace MercureWin
	{
	partial class FormFactures
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			this.LstViewFactures = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtBoxRefFacture = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CbBoxClients = new System.Windows.Forms.ComboBox();
			this.BtnAjouterFacture = new System.Windows.Forms.Button();
			this.BtnSuppFacture = new System.Windows.Forms.Button();
			this.BtnGestion = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LabelRefFacture = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// LstViewFactures
			// 
			this.LstViewFactures.Location = new System.Drawing.Point(12, 64);
			this.LstViewFactures.Name = "LstViewFactures";
			this.LstViewFactures.Size = new System.Drawing.Size(1010, 536);
			this.LstViewFactures.TabIndex = 2;
			this.LstViewFactures.UseCompatibleStateImageBehavior = false;
			this.LstViewFactures.View = System.Windows.Forms.View.Details;
			this.LstViewFactures.SelectedIndexChanged += new System.EventHandler(this.LstViewFactures_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtBoxRefFacture);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.CbBoxClients);
			this.groupBox1.Controls.Add(this.BtnAjouterFacture);
			this.groupBox1.Location = new System.Drawing.Point(12, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(574, 51);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ajouter une nouvelle facture";
			// 
			// TxtBoxRefFacture
			// 
			this.TxtBoxRefFacture.Location = new System.Drawing.Point(85, 19);
			this.TxtBoxRefFacture.MaxLength = 10;
			this.TxtBoxRefFacture.Name = "TxtBoxRefFacture";
			this.TxtBoxRefFacture.Size = new System.Drawing.Size(128, 20);
			this.TxtBoxRefFacture.TabIndex = 6;
			this.TxtBoxRefFacture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxRefFacture_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "RéfFacture:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(248, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Client: ";
			// 
			// CbBoxClients
			// 
			this.CbBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbBoxClients.FormattingEnabled = true;
			this.CbBoxClients.Location = new System.Drawing.Point(293, 19);
			this.CbBoxClients.Name = "CbBoxClients";
			this.CbBoxClients.Size = new System.Drawing.Size(140, 21);
			this.CbBoxClients.TabIndex = 3;
			// 
			// BtnAjouterFacture
			// 
			this.BtnAjouterFacture.Location = new System.Drawing.Point(472, 13);
			this.BtnAjouterFacture.Name = "BtnAjouterFacture";
			this.BtnAjouterFacture.Size = new System.Drawing.Size(87, 31);
			this.BtnAjouterFacture.TabIndex = 2;
			this.BtnAjouterFacture.Text = "Ajouter";
			this.BtnAjouterFacture.UseVisualStyleBackColor = true;
			this.BtnAjouterFacture.Click += new System.EventHandler(this.BtnAjouterFacture_Click);
			// 
			// BtnSuppFacture
			// 
			this.BtnSuppFacture.Location = new System.Drawing.Point(884, 20);
			this.BtnSuppFacture.Name = "BtnSuppFacture";
			this.BtnSuppFacture.Size = new System.Drawing.Size(87, 31);
			this.BtnSuppFacture.TabIndex = 1;
			this.BtnSuppFacture.Text = "Supprimer";
			this.BtnSuppFacture.UseVisualStyleBackColor = true;
			this.BtnSuppFacture.Click += new System.EventHandler(this.BtnSuppFacture_Click);
			// 
			// BtnGestion
			// 
			this.BtnGestion.Location = new System.Drawing.Point(142, 14);
			this.BtnGestion.Name = "BtnGestion";
			this.BtnGestion.Size = new System.Drawing.Size(116, 31);
			this.BtnGestion.TabIndex = 6;
			this.BtnGestion.Text = "Détaille Facture";
			this.BtnGestion.UseVisualStyleBackColor = true;
			this.BtnGestion.Click += new System.EventHandler(this.BtnGestion_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LabelRefFacture);
			this.groupBox2.Controls.Add(this.BtnGestion);
			this.groupBox2.Location = new System.Drawing.Point(597, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(273, 51);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Facture";
			// 
			// LabelRefFacture
			// 
			this.LabelRefFacture.AutoSize = true;
			this.LabelRefFacture.Location = new System.Drawing.Point(14, 25);
			this.LabelRefFacture.Name = "LabelRefFacture";
			this.LabelRefFacture.Size = new System.Drawing.Size(30, 13);
			this.LabelRefFacture.TabIndex = 7;
			this.LabelRefFacture.Text = "Réf: ";
			// 
			// FormFactures
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 612);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.BtnSuppFacture);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LstViewFactures);
			this.Name = "FormFactures";
			this.Text = "Factures";
			this.Load += new System.EventHandler(this.FormFactures_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LstViewFactures;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnAjouterFacture;
		private System.Windows.Forms.Button BtnSuppFacture;
		private System.Windows.Forms.TextBox TxtBoxRefFacture;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CbBoxClients;
		private System.Windows.Forms.Button BtnGestion;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label LabelRefFacture;
		}
	}
namespace MercureWin
	{
	partial class FormUnClient
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
			this.BtnModifier = new System.Windows.Forms.Button();
			this.BtnAnnuler = new System.Windows.Forms.Button();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.TxtBoxCodePostal = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtBoxAdresse = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtBoxNom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtBoxPrenom = new System.Windows.Forms.TextBox();
			this.TxtBoxRaisonSocial = new System.Windows.Forms.TextBox();
			this.TxtBoxVille = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtBoxPays = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.LabelRefClient = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnModifier
			// 
			this.BtnModifier.Location = new System.Drawing.Point(495, 120);
			this.BtnModifier.Name = "BtnModifier";
			this.BtnModifier.Size = new System.Drawing.Size(101, 31);
			this.BtnModifier.TabIndex = 25;
			this.BtnModifier.Text = "Modifier";
			this.BtnModifier.UseVisualStyleBackColor = true;
			this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
			// 
			// BtnAnnuler
			// 
			this.BtnAnnuler.Location = new System.Drawing.Point(495, 163);
			this.BtnAnnuler.Name = "BtnAnnuler";
			this.BtnAnnuler.Size = new System.Drawing.Size(101, 31);
			this.BtnAnnuler.TabIndex = 24;
			this.BtnAnnuler.Text = "Annuler";
			this.BtnAnnuler.UseVisualStyleBackColor = true;
			this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
			// 
			// BtnAjouter
			// 
			this.BtnAjouter.Location = new System.Drawing.Point(350, 163);
			this.BtnAjouter.Name = "BtnAjouter";
			this.BtnAjouter.Size = new System.Drawing.Size(101, 31);
			this.BtnAjouter.TabIndex = 23;
			this.BtnAjouter.Text = "Ajouter";
			this.BtnAjouter.UseVisualStyleBackColor = true;
			this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
			// 
			// TxtBoxCodePostal
			// 
			this.TxtBoxCodePostal.Location = new System.Drawing.Point(122, 126);
			this.TxtBoxCodePostal.Name = "TxtBoxCodePostal";
			this.TxtBoxCodePostal.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxCodePostal.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "CodePostal:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(278, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Prénom:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Nom:";
			// 
			// TxtBoxAdresse
			// 
			this.TxtBoxAdresse.Location = new System.Drawing.Point(122, 87);
			this.TxtBoxAdresse.Name = "TxtBoxAdresse";
			this.TxtBoxAdresse.Size = new System.Drawing.Size(474, 20);
			this.TxtBoxAdresse.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Adresse:";
			// 
			// TxtBoxNom
			// 
			this.TxtBoxNom.Location = new System.Drawing.Point(122, 12);
			this.TxtBoxNom.MaxLength = 50;
			this.TxtBoxNom.Name = "TxtBoxNom";
			this.TxtBoxNom.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxNom.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "RaisonSocial:";
			// 
			// TxtBoxPrenom
			// 
			this.TxtBoxPrenom.Location = new System.Drawing.Point(330, 12);
			this.TxtBoxPrenom.Name = "TxtBoxPrenom";
			this.TxtBoxPrenom.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxPrenom.TabIndex = 17;
			// 
			// TxtBoxRaisonSocial
			// 
			this.TxtBoxRaisonSocial.Location = new System.Drawing.Point(122, 47);
			this.TxtBoxRaisonSocial.Name = "TxtBoxRaisonSocial";
			this.TxtBoxRaisonSocial.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxRaisonSocial.TabIndex = 17;
			// 
			// TxtBoxVille
			// 
			this.TxtBoxVille.Location = new System.Drawing.Point(330, 126);
			this.TxtBoxVille.Name = "TxtBoxVille";
			this.TxtBoxVille.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxVille.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(278, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "Ville:";
			// 
			// TxtBoxPays
			// 
			this.TxtBoxPays.Location = new System.Drawing.Point(122, 163);
			this.TxtBoxPays.Name = "TxtBoxPays";
			this.TxtBoxPays.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxPays.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(44, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 13);
			this.label7.TabIndex = 30;
			this.label7.Text = "Pays:";
			// 
			// LabelRefClient
			// 
			this.LabelRefClient.AutoSize = true;
			this.LabelRefClient.Location = new System.Drawing.Point(495, 15);
			this.LabelRefClient.Name = "LabelRefClient";
			this.LabelRefClient.Size = new System.Drawing.Size(45, 13);
			this.LabelRefClient.TabIndex = 32;
			this.LabelRefClient.Text = "refClient";
			// 
			// FormUnClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 205);
			this.Controls.Add(this.LabelRefClient);
			this.Controls.Add(this.TxtBoxPays);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TxtBoxVille);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TxtBoxRaisonSocial);
			this.Controls.Add(this.TxtBoxPrenom);
			this.Controls.Add(this.BtnModifier);
			this.Controls.Add(this.BtnAnnuler);
			this.Controls.Add(this.BtnAjouter);
			this.Controls.Add(this.TxtBoxCodePostal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtBoxAdresse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtBoxNom);
			this.Controls.Add(this.label1);
			this.Name = "FormUnClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormUnClient";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button BtnModifier;
		private System.Windows.Forms.Button BtnAnnuler;
		private System.Windows.Forms.Button BtnAjouter;
		private System.Windows.Forms.TextBox TxtBoxCodePostal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtBoxAdresse;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtBoxNom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtBoxPrenom;
		private System.Windows.Forms.TextBox TxtBoxRaisonSocial;
		private System.Windows.Forms.TextBox TxtBoxVille;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtBoxPays;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label LabelRefClient;
		}
	}
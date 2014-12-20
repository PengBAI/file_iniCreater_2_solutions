namespace MercureWin
	{
	partial class FormFamilles
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
			this.LsvFamilles = new System.Windows.Forms.ListView();
			this.DBAjouter = new System.Windows.Forms.GroupBox();
			this.TxtBoxNomFamille = new System.Windows.Forms.TextBox();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LabelRefFamille = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtBoxModifierNom = new System.Windows.Forms.TextBox();
			this.BtnModifier = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnSupprimer = new System.Windows.Forms.Button();
			this.DBAjouter.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LsvFamilles
			// 
			this.LsvFamilles.Location = new System.Drawing.Point(12, 12);
			this.LsvFamilles.Name = "LsvFamilles";
			this.LsvFamilles.Size = new System.Drawing.Size(239, 343);
			this.LsvFamilles.TabIndex = 1;
			this.LsvFamilles.UseCompatibleStateImageBehavior = false;
			this.LsvFamilles.View = System.Windows.Forms.View.Details;
			this.LsvFamilles.SelectedIndexChanged += new System.EventHandler(this.LsvFamilles_SelectedIndexChanged);
			// 
			// DBAjouter
			// 
			this.DBAjouter.Controls.Add(this.TxtBoxNomFamille);
			this.DBAjouter.Controls.Add(this.BtnAjouter);
			this.DBAjouter.Controls.Add(this.label1);
			this.DBAjouter.Location = new System.Drawing.Point(257, 12);
			this.DBAjouter.Name = "DBAjouter";
			this.DBAjouter.Size = new System.Drawing.Size(124, 121);
			this.DBAjouter.TabIndex = 3;
			this.DBAjouter.TabStop = false;
			this.DBAjouter.Text = "Nouvelle Famille";
			// 
			// TxtBoxNomFamille
			// 
			this.TxtBoxNomFamille.Location = new System.Drawing.Point(17, 43);
			this.TxtBoxNomFamille.Name = "TxtBoxNomFamille";
			this.TxtBoxNomFamille.Size = new System.Drawing.Size(87, 20);
			this.TxtBoxNomFamille.TabIndex = 1;
			// 
			// BtnAjouter
			// 
			this.BtnAjouter.Location = new System.Drawing.Point(17, 82);
			this.BtnAjouter.Name = "BtnAjouter";
			this.BtnAjouter.Size = new System.Drawing.Size(87, 23);
			this.BtnAjouter.TabIndex = 0;
			this.BtnAjouter.Text = "Ajouter";
			this.BtnAjouter.UseVisualStyleBackColor = true;
			this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom Famille:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LabelRefFamille);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.TxtBoxModifierNom);
			this.groupBox1.Controls.Add(this.BtnModifier);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(257, 156);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(124, 155);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modifier Famille";
			// 
			// LabelRefFamille
			// 
			this.LabelRefFamille.AutoSize = true;
			this.LabelRefFamille.Location = new System.Drawing.Point(85, 30);
			this.LabelRefFamille.Name = "LabelRefFamille";
			this.LabelRefFamille.Size = new System.Drawing.Size(19, 13);
			this.LabelRefFamille.TabIndex = 3;
			this.LabelRefFamille.Text = "ref";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Réf Famille:";
			// 
			// TxtBoxModifierNom
			// 
			this.TxtBoxModifierNom.Location = new System.Drawing.Point(17, 76);
			this.TxtBoxModifierNom.Name = "TxtBoxModifierNom";
			this.TxtBoxModifierNom.Size = new System.Drawing.Size(87, 20);
			this.TxtBoxModifierNom.TabIndex = 1;
			// 
			// BtnModifier
			// 
			this.BtnModifier.Location = new System.Drawing.Point(17, 114);
			this.BtnModifier.Name = "BtnModifier";
			this.BtnModifier.Size = new System.Drawing.Size(87, 23);
			this.BtnModifier.TabIndex = 0;
			this.BtnModifier.Text = "Modifier";
			this.BtnModifier.UseVisualStyleBackColor = true;
			this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nom Famille:";
			// 
			// BtnSupprimer
			// 
			this.BtnSupprimer.Location = new System.Drawing.Point(274, 332);
			this.BtnSupprimer.Name = "BtnSupprimer";
			this.BtnSupprimer.Size = new System.Drawing.Size(87, 23);
			this.BtnSupprimer.TabIndex = 2;
			this.BtnSupprimer.Text = "Supprimer";
			this.BtnSupprimer.UseVisualStyleBackColor = true;
			this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
			// 
			// FormFamilles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 367);
			this.Controls.Add(this.BtnSupprimer);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.DBAjouter);
			this.Controls.Add(this.LsvFamilles);
			this.Name = "FormFamilles";
			this.Text = "Familles";
			this.Load += new System.EventHandler(this.FormFamilles_Load);
			this.DBAjouter.ResumeLayout(false);
			this.DBAjouter.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LsvFamilles;
		private System.Windows.Forms.GroupBox DBAjouter;
		private System.Windows.Forms.TextBox TxtBoxNomFamille;
		private System.Windows.Forms.Button BtnAjouter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtBoxModifierNom;
		private System.Windows.Forms.Button BtnModifier;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnSupprimer;
		private System.Windows.Forms.Label LabelRefFamille;
		private System.Windows.Forms.Label label3;
		}
	}
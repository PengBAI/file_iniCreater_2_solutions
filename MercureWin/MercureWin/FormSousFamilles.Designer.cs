namespace MercureWin
	{
	partial class FormSousFamilles
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
			this.LsvSousFamilles = new System.Windows.Forms.ListView();
			this.DBAjouter = new System.Windows.Forms.GroupBox();
			this.CbBoxFamille = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtBoxNomSousFamille = new System.Windows.Forms.TextBox();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnSupprimer = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CbBoxModifier = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.LabelRefSousFamille = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtBoxModifierNom = new System.Windows.Forms.TextBox();
			this.BtnModifier = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.DBAjouter.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LsvSousFamilles
			// 
			this.LsvSousFamilles.Location = new System.Drawing.Point(12, 12);
			this.LsvSousFamilles.Name = "LsvSousFamilles";
			this.LsvSousFamilles.Size = new System.Drawing.Size(528, 436);
			this.LsvSousFamilles.TabIndex = 1;
			this.LsvSousFamilles.UseCompatibleStateImageBehavior = false;
			this.LsvSousFamilles.View = System.Windows.Forms.View.Details;
			this.LsvSousFamilles.SelectedIndexChanged += new System.EventHandler(this.LsvSousFamilles_SelectedIndexChanged);
			// 
			// DBAjouter
			// 
			this.DBAjouter.Controls.Add(this.CbBoxFamille);
			this.DBAjouter.Controls.Add(this.label2);
			this.DBAjouter.Controls.Add(this.TxtBoxNomSousFamille);
			this.DBAjouter.Controls.Add(this.BtnAjouter);
			this.DBAjouter.Controls.Add(this.label1);
			this.DBAjouter.Location = new System.Drawing.Point(546, 12);
			this.DBAjouter.Name = "DBAjouter";
			this.DBAjouter.Size = new System.Drawing.Size(156, 169);
			this.DBAjouter.TabIndex = 3;
			this.DBAjouter.TabStop = false;
			this.DBAjouter.Text = "Nouvelle SousFamille";
			// 
			// CbBoxFamille
			// 
			this.CbBoxFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbBoxFamille.FormattingEnabled = true;
			this.CbBoxFamille.Location = new System.Drawing.Point(17, 45);
			this.CbBoxFamille.Name = "CbBoxFamille";
			this.CbBoxFamille.Size = new System.Drawing.Size(121, 21);
			this.CbBoxFamille.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nom Famille:";
			// 
			// TxtBoxNomSousFamille
			// 
			this.TxtBoxNomSousFamille.Location = new System.Drawing.Point(17, 93);
			this.TxtBoxNomSousFamille.Name = "TxtBoxNomSousFamille";
			this.TxtBoxNomSousFamille.Size = new System.Drawing.Size(121, 20);
			this.TxtBoxNomSousFamille.TabIndex = 1;
			// 
			// BtnAjouter
			// 
			this.BtnAjouter.Location = new System.Drawing.Point(34, 129);
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
			this.label1.Location = new System.Drawing.Point(14, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom SousFamille:";
			// 
			// BtnSupprimer
			// 
			this.BtnSupprimer.Location = new System.Drawing.Point(580, 425);
			this.BtnSupprimer.Name = "BtnSupprimer";
			this.BtnSupprimer.Size = new System.Drawing.Size(87, 23);
			this.BtnSupprimer.TabIndex = 4;
			this.BtnSupprimer.Text = "Supprimer";
			this.BtnSupprimer.UseVisualStyleBackColor = true;
			this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CbBoxModifier);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.LabelRefSousFamille);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.TxtBoxModifierNom);
			this.groupBox1.Controls.Add(this.BtnModifier);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(546, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(156, 194);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modifier SousFamille";
			// 
			// CbBoxModifier
			// 
			this.CbBoxModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbBoxModifier.FormattingEnabled = true;
			this.CbBoxModifier.Location = new System.Drawing.Point(17, 74);
			this.CbBoxModifier.Name = "CbBoxModifier";
			this.CbBoxModifier.Size = new System.Drawing.Size(121, 21);
			this.CbBoxModifier.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Nom Famille:";
			// 
			// LabelRefSousFamille
			// 
			this.LabelRefSousFamille.AutoSize = true;
			this.LabelRefSousFamille.Location = new System.Drawing.Point(102, 31);
			this.LabelRefSousFamille.Name = "LabelRefSousFamille";
			this.LabelRefSousFamille.Size = new System.Drawing.Size(19, 13);
			this.LabelRefSousFamille.TabIndex = 3;
			this.LabelRefSousFamille.Text = "ref";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Réf SousFamille: ";
			// 
			// TxtBoxModifierNom
			// 
			this.TxtBoxModifierNom.Location = new System.Drawing.Point(17, 120);
			this.TxtBoxModifierNom.Name = "TxtBoxModifierNom";
			this.TxtBoxModifierNom.Size = new System.Drawing.Size(121, 20);
			this.TxtBoxModifierNom.TabIndex = 1;
			// 
			// BtnModifier
			// 
			this.BtnModifier.Location = new System.Drawing.Point(34, 155);
			this.BtnModifier.Name = "BtnModifier";
			this.BtnModifier.Size = new System.Drawing.Size(87, 23);
			this.BtnModifier.TabIndex = 0;
			this.BtnModifier.Text = "Modifier";
			this.BtnModifier.UseVisualStyleBackColor = true;
			this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nom SousFamille:";
			// 
			// FormSousFamilles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 460);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnSupprimer);
			this.Controls.Add(this.DBAjouter);
			this.Controls.Add(this.LsvSousFamilles);
			this.Name = "FormSousFamilles";
			this.Text = "SousFamilles";
			this.Load += new System.EventHandler(this.FormSousFamilles_Load);
			this.DBAjouter.ResumeLayout(false);
			this.DBAjouter.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LsvSousFamilles;
		private System.Windows.Forms.GroupBox DBAjouter;
		private System.Windows.Forms.TextBox TxtBoxNomSousFamille;
		private System.Windows.Forms.Button BtnAjouter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CbBoxFamille;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnSupprimer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox CbBoxModifier;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LabelRefSousFamille;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtBoxModifierNom;
		private System.Windows.Forms.Button BtnModifier;
		private System.Windows.Forms.Label label3;
		}
	}
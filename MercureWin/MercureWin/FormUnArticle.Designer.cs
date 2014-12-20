namespace MercureWin
	{
	partial class FormUnArticle
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
			this.label1 = new System.Windows.Forms.Label();
			this.TxtBoxRefArticle = new System.Windows.Forms.TextBox();
			this.TxtBoxDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CbBoxSousFamille = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CbBoxMarque = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtBoxPrix = new System.Windows.Forms.TextBox();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.BtnAnnuler = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.LabelRefArticle = new System.Windows.Forms.Label();
			this.BtnModifier = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "RéfArticle:";
			// 
			// TxtBoxRefArticle
			// 
			this.TxtBoxRefArticle.Location = new System.Drawing.Point(115, 27);
			this.TxtBoxRefArticle.MaxLength = 8;
			this.TxtBoxRefArticle.Name = "TxtBoxRefArticle";
			this.TxtBoxRefArticle.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxRefArticle.TabIndex = 1;
			// 
			// TxtBoxDescription
			// 
			this.TxtBoxDescription.Location = new System.Drawing.Point(115, 52);
			this.TxtBoxDescription.Name = "TxtBoxDescription";
			this.TxtBoxDescription.Size = new System.Drawing.Size(523, 20);
			this.TxtBoxDescription.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Déscription:";
			// 
			// CbBoxSousFamille
			// 
			this.CbBoxSousFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbBoxSousFamille.FormattingEnabled = true;
			this.CbBoxSousFamille.Location = new System.Drawing.Point(115, 79);
			this.CbBoxSousFamille.Name = "CbBoxSousFamille";
			this.CbBoxSousFamille.Size = new System.Drawing.Size(132, 21);
			this.CbBoxSousFamille.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "SousFamille:";
			// 
			// CbBoxMarque
			// 
			this.CbBoxMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbBoxMarque.FormattingEnabled = true;
			this.CbBoxMarque.Location = new System.Drawing.Point(115, 106);
			this.CbBoxMarque.Name = "CbBoxMarque";
			this.CbBoxMarque.Size = new System.Drawing.Size(132, 21);
			this.CbBoxMarque.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Marque:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Prix H.T:";
			// 
			// TxtBoxPrix
			// 
			this.TxtBoxPrix.Location = new System.Drawing.Point(115, 133);
			this.TxtBoxPrix.Name = "TxtBoxPrix";
			this.TxtBoxPrix.Size = new System.Drawing.Size(132, 20);
			this.TxtBoxPrix.TabIndex = 9;
			// 
			// BtnAjouter
			// 
			this.BtnAjouter.Location = new System.Drawing.Point(412, 151);
			this.BtnAjouter.Name = "BtnAjouter";
			this.BtnAjouter.Size = new System.Drawing.Size(101, 31);
			this.BtnAjouter.TabIndex = 10;
			this.BtnAjouter.Text = "Ajouter";
			this.BtnAjouter.UseVisualStyleBackColor = true;
			this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
			// 
			// BtnAnnuler
			// 
			this.BtnAnnuler.Location = new System.Drawing.Point(537, 151);
			this.BtnAnnuler.Name = "BtnAnnuler";
			this.BtnAnnuler.Size = new System.Drawing.Size(101, 31);
			this.BtnAnnuler.TabIndex = 11;
			this.BtnAnnuler.Text = "Annuler";
			this.BtnAnnuler.UseVisualStyleBackColor = true;
			this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(253, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Ex: 16,25";
			// 
			// LabelRefArticle
			// 
			this.LabelRefArticle.AutoSize = true;
			this.LabelRefArticle.Location = new System.Drawing.Point(253, 30);
			this.LabelRefArticle.Name = "LabelRefArticle";
			this.LabelRefArticle.Size = new System.Drawing.Size(111, 13);
			this.LabelRefArticle.TabIndex = 13;
			this.LabelRefArticle.Text = "8 caractères Maxmum";
			// 
			// BtnModifier
			// 
			this.BtnModifier.Location = new System.Drawing.Point(537, 103);
			this.BtnModifier.Name = "BtnModifier";
			this.BtnModifier.Size = new System.Drawing.Size(101, 31);
			this.BtnModifier.TabIndex = 14;
			this.BtnModifier.Text = "Modifier";
			this.BtnModifier.UseVisualStyleBackColor = true;
			this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
			// 
			// FormUnArticle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 195);
			this.Controls.Add(this.BtnModifier);
			this.Controls.Add(this.LabelRefArticle);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.BtnAnnuler);
			this.Controls.Add(this.BtnAjouter);
			this.Controls.Add(this.TxtBoxPrix);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CbBoxMarque);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CbBoxSousFamille);
			this.Controls.Add(this.TxtBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtBoxRefArticle);
			this.Controls.Add(this.label1);
			this.Name = "FormUnArticle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UnArticle";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtBoxRefArticle;
		private System.Windows.Forms.TextBox TxtBoxDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CbBoxSousFamille;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CbBoxMarque;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtBoxPrix;
		private System.Windows.Forms.Button BtnAjouter;
		private System.Windows.Forms.Button BtnAnnuler;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label LabelRefArticle;
		private System.Windows.Forms.Button BtnModifier;
		}
	}
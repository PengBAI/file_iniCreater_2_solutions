namespace MercureWin
	{
	partial class FormArticles
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
			this.LstViewArticles = new System.Windows.Forms.ListView();
			this.BtnSuppArticle = new System.Windows.Forms.Button();
			this.BtnAjouterArticle = new System.Windows.Forms.Button();
			this.BtnModifierArticle = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LstViewArticles
			// 
			this.LstViewArticles.Location = new System.Drawing.Point(12, 61);
			this.LstViewArticles.Name = "LstViewArticles";
			this.LstViewArticles.Size = new System.Drawing.Size(1010, 539);
			this.LstViewArticles.TabIndex = 0;
			this.LstViewArticles.UseCompatibleStateImageBehavior = false;
			// 
			// BtnSuppArticle
			// 
			this.BtnSuppArticle.Location = new System.Drawing.Point(274, 13);
			this.BtnSuppArticle.Name = "BtnSuppArticle";
			this.BtnSuppArticle.Size = new System.Drawing.Size(87, 31);
			this.BtnSuppArticle.TabIndex = 1;
			this.BtnSuppArticle.Text = "Supprimer";
			this.BtnSuppArticle.UseVisualStyleBackColor = true;
			this.BtnSuppArticle.Click += new System.EventHandler(this.BtnSuppArticle_Click);
			// 
			// BtnAjouterArticle
			// 
			this.BtnAjouterArticle.Location = new System.Drawing.Point(7, 13);
			this.BtnAjouterArticle.Name = "BtnAjouterArticle";
			this.BtnAjouterArticle.Size = new System.Drawing.Size(87, 31);
			this.BtnAjouterArticle.TabIndex = 2;
			this.BtnAjouterArticle.Text = "Ajouter";
			this.BtnAjouterArticle.UseVisualStyleBackColor = true;
			this.BtnAjouterArticle.Click += new System.EventHandler(this.BtnAjouterArticle_Click);
			// 
			// BtnModifierArticle
			// 
			this.BtnModifierArticle.Location = new System.Drawing.Point(141, 13);
			this.BtnModifierArticle.Name = "BtnModifierArticle";
			this.BtnModifierArticle.Size = new System.Drawing.Size(87, 31);
			this.BtnModifierArticle.TabIndex = 3;
			this.BtnModifierArticle.Text = "Modifier";
			this.BtnModifierArticle.UseVisualStyleBackColor = true;
			this.BtnModifierArticle.Click += new System.EventHandler(this.BtnModifierArticle_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnAjouterArticle);
			this.groupBox1.Controls.Add(this.BtnSuppArticle);
			this.groupBox1.Controls.Add(this.BtnModifierArticle);
			this.groupBox1.Location = new System.Drawing.Point(497, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 51);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// FormArticles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 612);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LstViewArticles);
			this.Name = "FormArticles";
			this.Text = "Articles";
			this.Load += new System.EventHandler(this.FormArticles_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LstViewArticles;
		private System.Windows.Forms.Button BtnSuppArticle;
		private System.Windows.Forms.Button BtnAjouterArticle;
		private System.Windows.Forms.Button BtnModifierArticle;
		private System.Windows.Forms.GroupBox groupBox1;
		}
	}
namespace MercureWin
	{
	partial class FormFactureArticles
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
			this.LstFactureArticles = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CbBoxArticles = new System.Windows.Forms.ComboBox();
			this.BtnAjouterFacture = new System.Windows.Forms.Button();
			this.BtnSupprimer = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LstFactureArticles
			// 
			this.LstFactureArticles.Location = new System.Drawing.Point(12, 68);
			this.LstFactureArticles.Name = "LstFactureArticles";
			this.LstFactureArticles.Size = new System.Drawing.Size(877, 405);
			this.LstFactureArticles.TabIndex = 0;
			this.LstFactureArticles.UseCompatibleStateImageBehavior = false;
			this.LstFactureArticles.View = System.Windows.Forms.View.Details;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtBoxQuantity);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.CbBoxArticles);
			this.groupBox1.Controls.Add(this.BtnAjouterFacture);
			this.groupBox1.Location = new System.Drawing.Point(12, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(598, 51);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ajouter un article";
			// 
			// TxtBoxQuantity
			// 
			this.TxtBoxQuantity.Location = new System.Drawing.Point(388, 19);
			this.TxtBoxQuantity.Name = "TxtBoxQuantity";
			this.TxtBoxQuantity.Size = new System.Drawing.Size(71, 20);
			this.TxtBoxQuantity.TabIndex = 7;
			this.TxtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantitiy_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(333, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Quantity:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Article:";
			// 
			// CbBoxArticles
			// 
			this.CbBoxArticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbBoxArticles.FormattingEnabled = true;
			this.CbBoxArticles.Location = new System.Drawing.Point(61, 19);
			this.CbBoxArticles.Name = "CbBoxArticles";
			this.CbBoxArticles.Size = new System.Drawing.Size(244, 21);
			this.CbBoxArticles.TabIndex = 3;
			// 
			// BtnAjouterFacture
			// 
			this.BtnAjouterFacture.Location = new System.Drawing.Point(495, 14);
			this.BtnAjouterFacture.Name = "BtnAjouterFacture";
			this.BtnAjouterFacture.Size = new System.Drawing.Size(87, 31);
			this.BtnAjouterFacture.TabIndex = 2;
			this.BtnAjouterFacture.Text = "Ajouter";
			this.BtnAjouterFacture.UseVisualStyleBackColor = true;
			this.BtnAjouterFacture.Click += new System.EventHandler(this.BtnAjouterFacture_Click);
			// 
			// BtnSupprimer
			// 
			this.BtnSupprimer.Location = new System.Drawing.Point(673, 25);
			this.BtnSupprimer.Name = "BtnSupprimer";
			this.BtnSupprimer.Size = new System.Drawing.Size(87, 31);
			this.BtnSupprimer.TabIndex = 8;
			this.BtnSupprimer.Text = "Supprimer";
			this.BtnSupprimer.UseVisualStyleBackColor = true;
			this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
			// 
			// FormFactureArticles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 494);
			this.Controls.Add(this.BtnSupprimer);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LstFactureArticles);
			this.Name = "FormFactureArticles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FactureArticles";
			this.Load += new System.EventHandler(this.FormFactureArticles_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LstFactureArticles;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CbBoxArticles;
		private System.Windows.Forms.Button BtnAjouterFacture;
		private System.Windows.Forms.TextBox TxtBoxQuantity;
		private System.Windows.Forms.Button BtnSupprimer;
		}
	}
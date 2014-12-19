namespace MercureWin
	{
	partial class FormMarques
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
			this.LsvMarques = new System.Windows.Forms.ListView();
			this.BtnSupprimer = new System.Windows.Forms.Button();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.DBAjouter = new System.Windows.Forms.GroupBox();
			this.TxtBoxNomMarque = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtBoxModifierNom = new System.Windows.Forms.TextBox();
			this.BtnModifier = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.DBAjouter.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LsvMarques
			// 
			this.LsvMarques.Location = new System.Drawing.Point(12, 12);
			this.LsvMarques.Name = "LsvMarques";
			this.LsvMarques.Size = new System.Drawing.Size(216, 292);
			this.LsvMarques.TabIndex = 0;
			this.LsvMarques.UseCompatibleStateImageBehavior = false;
			this.LsvMarques.View = System.Windows.Forms.View.Details;
			this.LsvMarques.SelectedIndexChanged += new System.EventHandler(this.LsvMarques_SelectedIndexChanged);
			// 
			// BtnSupprimer
			// 
			this.BtnSupprimer.Location = new System.Drawing.Point(251, 281);
			this.BtnSupprimer.Name = "BtnSupprimer";
			this.BtnSupprimer.Size = new System.Drawing.Size(87, 23);
			this.BtnSupprimer.TabIndex = 1;
			this.BtnSupprimer.Text = "Supprimer";
			this.BtnSupprimer.UseVisualStyleBackColor = true;
			this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
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
			// DBAjouter
			// 
			this.DBAjouter.Controls.Add(this.TxtBoxNomMarque);
			this.DBAjouter.Controls.Add(this.BtnAjouter);
			this.DBAjouter.Controls.Add(this.label1);
			this.DBAjouter.Location = new System.Drawing.Point(234, 12);
			this.DBAjouter.Name = "DBAjouter";
			this.DBAjouter.Size = new System.Drawing.Size(124, 121);
			this.DBAjouter.TabIndex = 2;
			this.DBAjouter.TabStop = false;
			this.DBAjouter.Text = "Nouvelle Marque";
			// 
			// TxtBoxNomMarque
			// 
			this.TxtBoxNomMarque.Location = new System.Drawing.Point(17, 43);
			this.TxtBoxNomMarque.Name = "TxtBoxNomMarque";
			this.TxtBoxNomMarque.Size = new System.Drawing.Size(87, 20);
			this.TxtBoxNomMarque.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom Marque:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtBoxModifierNom);
			this.groupBox1.Controls.Add(this.BtnModifier);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(234, 139);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(124, 121);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modifier Marque";
			// 
			// TxtBoxModifierNom
			// 
			this.TxtBoxModifierNom.Location = new System.Drawing.Point(17, 43);
			this.TxtBoxModifierNom.Name = "TxtBoxModifierNom";
			this.TxtBoxModifierNom.Size = new System.Drawing.Size(87, 20);
			this.TxtBoxModifierNom.TabIndex = 1;
			// 
			// BtnModifier
			// 
			this.BtnModifier.Location = new System.Drawing.Point(17, 82);
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
			this.label2.Location = new System.Drawing.Point(17, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nom Marque:";
			// 
			// FormMarques
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 316);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnSupprimer);
			this.Controls.Add(this.DBAjouter);
			this.Controls.Add(this.LsvMarques);
			this.Name = "FormMarques";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Marques";
			this.Load += new System.EventHandler(this.FormMarques_Load);
			this.DBAjouter.ResumeLayout(false);
			this.DBAjouter.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LsvMarques;
		private System.Windows.Forms.Button BtnAjouter;
		private System.Windows.Forms.Button BtnSupprimer;
		private System.Windows.Forms.GroupBox DBAjouter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtBoxNomMarque;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtBoxModifierNom;
		private System.Windows.Forms.Button BtnModifier;
		private System.Windows.Forms.Label label2;
		}
	}
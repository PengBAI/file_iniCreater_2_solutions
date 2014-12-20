namespace MercureWin
	{
	partial class FormClients
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
			this.LstViewClients = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnAjouterClient = new System.Windows.Forms.Button();
			this.BtnSuppClient = new System.Windows.Forms.Button();
			this.BtnModifierClient = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LstViewClients
			// 
			this.LstViewClients.Location = new System.Drawing.Point(12, 12);
			this.LstViewClients.Name = "LstViewClients";
			this.LstViewClients.Size = new System.Drawing.Size(970, 488);
			this.LstViewClients.TabIndex = 1;
			this.LstViewClients.UseCompatibleStateImageBehavior = false;
			this.LstViewClients.View = System.Windows.Forms.View.Details;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnAjouterClient);
			this.groupBox1.Controls.Add(this.BtnSuppClient);
			this.groupBox1.Controls.Add(this.BtnModifierClient);
			this.groupBox1.Location = new System.Drawing.Point(612, 506);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 51);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// BtnAjouterClient
			// 
			this.BtnAjouterClient.Location = new System.Drawing.Point(7, 13);
			this.BtnAjouterClient.Name = "BtnAjouterClient";
			this.BtnAjouterClient.Size = new System.Drawing.Size(87, 31);
			this.BtnAjouterClient.TabIndex = 2;
			this.BtnAjouterClient.Text = "Ajouter";
			this.BtnAjouterClient.UseVisualStyleBackColor = true;
			this.BtnAjouterClient.Click += new System.EventHandler(this.BtnAjouterClient_Click);
			// 
			// BtnSuppClient
			// 
			this.BtnSuppClient.Location = new System.Drawing.Point(274, 13);
			this.BtnSuppClient.Name = "BtnSuppClient";
			this.BtnSuppClient.Size = new System.Drawing.Size(87, 31);
			this.BtnSuppClient.TabIndex = 1;
			this.BtnSuppClient.Text = "Supprimer";
			this.BtnSuppClient.UseVisualStyleBackColor = true;
			// 
			// BtnModifierClient
			// 
			this.BtnModifierClient.Location = new System.Drawing.Point(141, 13);
			this.BtnModifierClient.Name = "BtnModifierClient";
			this.BtnModifierClient.Size = new System.Drawing.Size(87, 31);
			this.BtnModifierClient.TabIndex = 3;
			this.BtnModifierClient.Text = "Modifier";
			this.BtnModifierClient.UseVisualStyleBackColor = true;
			// 
			// FormClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 562);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LstViewClients);
			this.Name = "FormClients";
			this.Text = "Clients";
			this.Load += new System.EventHandler(this.FormClients_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LstViewClients;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnAjouterClient;
		private System.Windows.Forms.Button BtnSuppClient;
		private System.Windows.Forms.Button BtnModifierClient;
		}
	}
namespace MercureWin
	{
	partial class FormMain
		{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
			{
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.articlesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.marquesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.famillesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sousFamillesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStripMain.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.fichierToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.toolStripMenuItem1});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(1034, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStripMain";
			// 
			// windowsToolStripMenuItem
			// 
			this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editURLToolStripMenuItem,
            this.quitterToolStripMenuItem});
			this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
			this.windowsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.windowsToolStripMenuItem.Text = "Fichier";
			// 
			// editURLToolStripMenuItem
			// 
			this.editURLToolStripMenuItem.Name = "editURLToolStripMenuItem";
			this.editURLToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.editURLToolStripMenuItem.Text = "Edit URL";
			this.editURLToolStripMenuItem.Click += new System.EventHandler(this.editURLToolStripMenuItem_Click);
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem1,
            this.marquesToolStripMenuItem1,
            this.famillesToolStripMenuItem1,
            this.sousFamillesToolStripMenuItem1});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.fichierToolStripMenuItem.Text = "Edition";
			// 
			// articlesToolStripMenuItem1
			// 
			this.articlesToolStripMenuItem1.Name = "articlesToolStripMenuItem1";
			this.articlesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
			this.articlesToolStripMenuItem1.Text = "Articles";
			this.articlesToolStripMenuItem1.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
			// 
			// marquesToolStripMenuItem1
			// 
			this.marquesToolStripMenuItem1.Name = "marquesToolStripMenuItem1";
			this.marquesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
			this.marquesToolStripMenuItem1.Text = "Marques";
			this.marquesToolStripMenuItem1.Click += new System.EventHandler(this.marquesToolStripMenuItem_Click);
			// 
			// famillesToolStripMenuItem1
			// 
			this.famillesToolStripMenuItem1.Name = "famillesToolStripMenuItem1";
			this.famillesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
			this.famillesToolStripMenuItem1.Text = "Familles";
			this.famillesToolStripMenuItem1.Click += new System.EventHandler(this.famillesToolStripMenuItem_Click);
			// 
			// sousFamillesToolStripMenuItem1
			// 
			this.sousFamillesToolStripMenuItem1.Name = "sousFamillesToolStripMenuItem1";
			this.sousFamillesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
			this.sousFamillesToolStripMenuItem1.Text = "SousFamilles";
			this.sousFamillesToolStripMenuItem1.Click += new System.EventHandler(this.sousFamillesToolStripMenuItem_Click);
			// 
			// gestionToolStripMenuItem
			// 
			this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
			this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
			this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.gestionToolStripMenuItem.Text = "Gestion";
			// 
			// clientToolStripMenuItem
			// 
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.clientToolStripMenuItem.Text = "Clients";
			this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// aProposToolStripMenuItem
			// 
			this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
			this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.aProposToolStripMenuItem.Text = "A propos";
			this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
			this.statusStripMain.Location = new System.Drawing.Point(0, 639);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(1034, 22);
			this.statusStripMain.TabIndex = 2;
			this.statusStripMain.Text = "statusStripMain";
			// 
			// toolStripStatusLabelMain
			// 
			this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
			this.toolStripStatusLabelMain.Size = new System.Drawing.Size(139, 17);
			this.toolStripStatusLabelMain.Text = "toolStripStatusLabelMain";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 661);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.menuStripMain);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mercure";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editURLToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem marquesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem famillesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sousFamillesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
		}
	}


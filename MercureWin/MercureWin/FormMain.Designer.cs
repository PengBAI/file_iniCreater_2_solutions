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
			this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStripMain.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(984, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStripMain";
			// 
			// windowsToolStripMenuItem
			// 
			this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editURLToolStripMenuItem,
            this.articlesToolStripMenuItem});
			this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
			this.windowsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.windowsToolStripMenuItem.Text = "Edition";
			// 
			// editURLToolStripMenuItem
			// 
			this.editURLToolStripMenuItem.Name = "editURLToolStripMenuItem";
			this.editURLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editURLToolStripMenuItem.Text = "Edit URL";
			this.editURLToolStripMenuItem.Click += new System.EventHandler(this.editURLToolStripMenuItem_Click);
			// 
			// articlesToolStripMenuItem
			// 
			this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
			this.articlesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.articlesToolStripMenuItem.Text = "Articles";
			this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
			this.statusStripMain.Location = new System.Drawing.Point(0, 590);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(984, 22);
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
			this.ClientSize = new System.Drawing.Size(984, 612);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.menuStripMain);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.Text = "Mercure Client";
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
		private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
		}
	}


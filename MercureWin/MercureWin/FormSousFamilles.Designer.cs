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
			this.SuspendLayout();
			// 
			// LsvSousFamilles
			// 
			this.LsvSousFamilles.Location = new System.Drawing.Point(12, 12);
			this.LsvSousFamilles.Name = "LsvSousFamilles";
			this.LsvSousFamilles.Size = new System.Drawing.Size(528, 292);
			this.LsvSousFamilles.TabIndex = 1;
			this.LsvSousFamilles.UseCompatibleStateImageBehavior = false;
			this.LsvSousFamilles.View = System.Windows.Forms.View.Details;
			// 
			// FormSousFamilles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 316);
			this.Controls.Add(this.LsvSousFamilles);
			this.Name = "FormSousFamilles";
			this.Text = "SousFamilles";
			this.Load += new System.EventHandler(this.FormSousFamilles_Load);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView LsvSousFamilles;
		}
	}
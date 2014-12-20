namespace MercureWin
	{
	partial class FormURL
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
			this.TxtBoxURL = new System.Windows.Forms.TextBox();
			this.BtnOkURL = new System.Windows.Forms.Button();
			this.BtnCancelURL = new System.Windows.Forms.Button();
			this.LabelURL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtBoxURL
			// 
			this.TxtBoxURL.Location = new System.Drawing.Point(20, 65);
			this.TxtBoxURL.Name = "TxtBoxURL";
			this.TxtBoxURL.Size = new System.Drawing.Size(341, 20);
			this.TxtBoxURL.TabIndex = 0;
			this.TxtBoxURL.Text = "http://localhost:8001/Sources/Mercure.asmx";
			// 
			// BtnOkURL
			// 
			this.BtnOkURL.Location = new System.Drawing.Point(144, 110);
			this.BtnOkURL.Name = "BtnOkURL";
			this.BtnOkURL.Size = new System.Drawing.Size(75, 23);
			this.BtnOkURL.TabIndex = 1;
			this.BtnOkURL.Text = "OK";
			this.BtnOkURL.UseVisualStyleBackColor = true;
			this.BtnOkURL.Click += new System.EventHandler(this.BtnOkURL_Click);
			// 
			// BtnCancelURL
			// 
			this.BtnCancelURL.Location = new System.Drawing.Point(250, 110);
			this.BtnCancelURL.Name = "BtnCancelURL";
			this.BtnCancelURL.Size = new System.Drawing.Size(75, 23);
			this.BtnCancelURL.TabIndex = 2;
			this.BtnCancelURL.Text = "Cancel";
			this.BtnCancelURL.UseVisualStyleBackColor = true;
			this.BtnCancelURL.Click += new System.EventHandler(this.BtnCancelURL_Click);
			// 
			// LabelURL
			// 
			this.LabelURL.AutoSize = true;
			this.LabelURL.Location = new System.Drawing.Point(17, 37);
			this.LabelURL.Name = "LabelURL";
			this.LabelURL.Size = new System.Drawing.Size(83, 13);
			this.LabelURL.TabIndex = 3;
			this.LabelURL.Text = "Configurer URL:";
			// 
			// FormURL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 145);
			this.Controls.Add(this.LabelURL);
			this.Controls.Add(this.BtnCancelURL);
			this.Controls.Add(this.BtnOkURL);
			this.Controls.Add(this.TxtBoxURL);
			this.Name = "FormURL";
			this.Text = "Edit URL";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.TextBox TxtBoxURL;
		private System.Windows.Forms.Button BtnOkURL;
		private System.Windows.Forms.Button BtnCancelURL;
		private System.Windows.Forms.Label LabelURL;
		}
	}
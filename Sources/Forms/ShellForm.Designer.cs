namespace Thrak. Forms
	{
	partial class ShellForm
		{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose ( bool disposing )
			{
			if ( disposing && ( components != null ) )
				{
				components. Dispose ( );
				}
			base. Dispose ( disposing );
			}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent ( )
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellForm));
			this.ShellStatusBar = new System.Windows.Forms.StatusStrip();
			this.ShellStatusBarFillerLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ShellStatusBarInsertLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ShellStatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ShellStatusBar
			// 
			this.ShellStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShellStatusBarFillerLabel,
            this.ShellStatusBarInsertLabel});
			this.ShellStatusBar.Location = new System.Drawing.Point(0, 410);
			this.ShellStatusBar.Name = "ShellStatusBar";
			this.ShellStatusBar.Size = new System.Drawing.Size(962, 24);
			this.ShellStatusBar.TabIndex = 1;
			this.ShellStatusBar.Visible = false;
			// 
			// ShellStatusBarFillerLabel
			// 
			this.ShellStatusBarFillerLabel.Name = "ShellStatusBarFillerLabel";
			this.ShellStatusBarFillerLabel.Size = new System.Drawing.Size(882, 19);
			this.ShellStatusBarFillerLabel.Spring = true;
			// 
			// ShellStatusBarInsertLabel
			// 
			this.ShellStatusBarInsertLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.ShellStatusBarInsertLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.ShellStatusBarInsertLabel.Name = "ShellStatusBarInsertLabel";
			this.ShellStatusBarInsertLabel.Size = new System.Drawing.Size(34, 19);
			this.ShellStatusBarInsertLabel.Text = "OVR";
			// 
			// Console
			// 
			this.Console=new ConsoleTextBox();
			this.Console.BackColor = System.Drawing.Color.Black;
			this.Console.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Console.ForeColor = System.Drawing.Color.Green;
			this.Console.Location = new System.Drawing.Point(0, 0);
			this.Console.Name = "Console";
			this.Console.Size = new System.Drawing.Size(240, 146);
			this.Console.TabIndex = 0;
			this.Console.Text = "";
			this.Console.WordWrap = false;
			// 
			// ShellForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(962, 434);
			this.Controls.Add(this.ShellStatusBar);
			this.Controls.Add(this.Console);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ShellForm";
			this.PersistAppearance = true;
			this.Text = "ShellForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShellForm_FormClosing);
			this.Load += new System.EventHandler(this.ShellForm_Load);
			this.SizeChanged += new System.EventHandler(this.ShellForm_SizeChanged);
			this.ShellStatusBar.ResumeLayout(false);
			this.ShellStatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private ConsoleTextBox Console;
		private System.Windows.Forms.StatusStrip ShellStatusBar;
		private System.Windows.Forms.ToolStripStatusLabel ShellStatusBarFillerLabel;
		private System.Windows.Forms.ToolStripStatusLabel ShellStatusBarInsertLabel;





		}
	}

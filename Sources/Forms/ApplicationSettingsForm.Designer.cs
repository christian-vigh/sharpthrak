namespace Thrak. Forms
	{
	partial class ApplicationSettingsForm
		{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private global::System.ComponentModel.IContainer components = null;

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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(ApplicationSettingsForm));
			this.SearchLabel = new global::System.Windows.Forms.Label();
			this.SearchTextBox = new global::System.Windows.Forms.TextBox();
			this.SearchButtonCommand = new global::System.Windows.Forms.Button();
			this.SettingsTreeView = new global::System.Windows.Forms.TreeView();
			this.ContainerPanel = new global::System.Windows.Forms.Panel();
			this.OkButtonCommand = new global::System.Windows.Forms.Button();
			this.ApplyButtonCommand = new global::System.Windows.Forms.Button();
			this.CancelButtonCommand = new global::System.Windows.Forms.Button();
			this.SearchResultsListBox = new global::System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// SearchLabel
			// 
			this.SearchLabel.AutoSize = true;
			this.SearchLabel.Location = new global::System.Drawing.Point(12, 14);
			this.SearchLabel.Name = "SearchLabel";
			this.SearchLabel.Size = new global::System.Drawing.Size(47, 13);
			this.SearchLabel.TabIndex = 6;
			this.SearchLabel.Text = "&Search :";
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new global::System.Drawing.Point(15, 30);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new global::System.Drawing.Size(278, 20);
			this.SearchTextBox.TabIndex = 7;
			this.SearchTextBox.Enter += new global::System.EventHandler(this.SearchTextBox_Enter);
			// 
			// SearchButtonCommand
			// 
			this.SearchButtonCommand.Image = ((global::System.Drawing.Image)(resources.GetObject("SearchButtonCommand.Image")));
			this.SearchButtonCommand.Location = new global::System.Drawing.Point(299, 28);
			this.SearchButtonCommand.Name = "SearchButtonCommand";
			this.SearchButtonCommand.Size = new global::System.Drawing.Size(24, 24);
			this.SearchButtonCommand.TabIndex = 8;
			this.SearchButtonCommand.UseVisualStyleBackColor = true;
			// 
			// SettingsTreeView
			// 
			this.SettingsTreeView.Location = new global::System.Drawing.Point(15, 62);
			this.SettingsTreeView.Name = "SettingsTreeView";
			this.SettingsTreeView.Size = new global::System.Drawing.Size(308, 349);
			this.SettingsTreeView.TabIndex = 1;
			// 
			// ContainerPanel
			// 
			this.ContainerPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.ContainerPanel.Location = new global::System.Drawing.Point(340, 31);
			this.ContainerPanel.Name = "ContainerPanel";
			this.ContainerPanel.Size = new global::System.Drawing.Size(502, 380);
			this.ContainerPanel.TabIndex = 2;
			// 
			// OkButtonCommand
			// 
			this.OkButtonCommand.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.OkButtonCommand.Location = new global::System.Drawing.Point(340, 429);
			this.OkButtonCommand.Name = "OkButtonCommand";
			this.OkButtonCommand.Size = new global::System.Drawing.Size(100, 22);
			this.OkButtonCommand.TabIndex = 3;
			this.OkButtonCommand.Text = "&OK";
			this.OkButtonCommand.UseVisualStyleBackColor = true;
			// 
			// ApplyButtonCommand
			// 
			this.ApplyButtonCommand.Location = new global::System.Drawing.Point(742, 429);
			this.ApplyButtonCommand.Name = "ApplyButtonCommand";
			this.ApplyButtonCommand.Size = new global::System.Drawing.Size(100, 22);
			this.ApplyButtonCommand.TabIndex = 5;
			this.ApplyButtonCommand.Text = "&Apply";
			this.ApplyButtonCommand.UseVisualStyleBackColor = true;
			// 
			// CancelButtonCommand
			// 
			this.CancelButtonCommand.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelButtonCommand.Location = new global::System.Drawing.Point(455, 429);
			this.CancelButtonCommand.Name = "CancelButtonCommand";
			this.CancelButtonCommand.Size = new global::System.Drawing.Size(100, 22);
			this.CancelButtonCommand.TabIndex = 4;
			this.CancelButtonCommand.Text = "&Cancel";
			this.CancelButtonCommand.UseVisualStyleBackColor = true;
			// 
			// SearchResultsListBox
			// 
			this.SearchResultsListBox.FormattingEnabled = true;
			this.SearchResultsListBox.Location = new global::System.Drawing.Point(15, 62);
			this.SearchResultsListBox.Name = "SearchResultsListBox";
			this.SearchResultsListBox.Size = new global::System.Drawing.Size(308, 355);
			this.SearchResultsListBox.TabIndex = 9;
			// 
			// ApplicationSettingsForm
			// 
			this.AcceptButton = this.OkButtonCommand;
			this.AutoScaleDimensions = new global::System.Drawing.SizeF(6F, 13F);
			this.CancelButton = this.CancelButtonCommand;
			this.ClientSize = new global::System.Drawing.Size(855, 462);
			this.Controls.Add(this.SearchResultsListBox);
			this.Controls.Add(this.CancelButtonCommand);
			this.Controls.Add(this.ApplyButtonCommand);
			this.Controls.Add(this.OkButtonCommand);
			this.Controls.Add(this.ContainerPanel);
			this.Controls.Add(this.SettingsTreeView);
			this.Controls.Add(this.SearchButtonCommand);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SearchLabel);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ApplicationSettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new global::System.EventHandler(this.ApplicationSettingsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		protected global::System.Windows.Forms.Label SearchLabel;
		protected global::System.Windows.Forms.TextBox SearchTextBox;
		private global::System.Windows.Forms.Button SearchButtonCommand;
		protected global::System.Windows.Forms.TreeView SettingsTreeView;
		protected global::System.Windows.Forms.Panel ContainerPanel;
		protected global::System.Windows.Forms.Button OkButtonCommand;
		protected global::System.Windows.Forms.Button ApplyButtonCommand;
		protected global::System.Windows.Forms.Button CancelButtonCommand;
		private global::System.Windows.Forms.ListBox SearchResultsListBox;
		}
	}

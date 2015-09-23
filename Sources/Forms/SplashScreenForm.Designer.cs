namespace Thrak. Forms
	{
	partial class SplashScreenForm
		{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.ProgressBar p_ProgressBar;

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
			this.p_ProgressBar = new global::System.Windows.Forms.ProgressBar();
			this.p_MessageLabel = new global::System.Windows.Forms.Label();
			this.p_VersionLabel = new global::System.Windows.Forms.Label();
			this.p_ApplicationNameLabel = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// p_ProgressBar
			// 
			this.p_ProgressBar.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.p_ProgressBar.Location = new global::System.Drawing.Point(0, 342);
			this.p_ProgressBar.MarqueeAnimationSpeed = 20;
			this.p_ProgressBar.Name = "p_ProgressBar";
			this.p_ProgressBar.Size = new global::System.Drawing.Size(480, 18);
			this.p_ProgressBar.Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
			this.p_ProgressBar.TabIndex = 0;
			// 
			// p_MessageLabel
			// 
			this.p_MessageLabel.AutoSize = true;
			this.p_MessageLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.p_MessageLabel.Location = new global::System.Drawing.Point(29, 309);
			this.p_MessageLabel.Name = "p_MessageLabel";
			this.p_MessageLabel.Size = new global::System.Drawing.Size(70, 13);
			this.p_MessageLabel.TabIndex = 1;
			this.p_MessageLabel.Text = "Message text";
			// 
			// p_VersionLabel
			// 
			this.p_VersionLabel.AutoSize = true;
			this.p_VersionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.p_VersionLabel.Location = new global::System.Drawing.Point(29, 283);
			this.p_VersionLabel.Name = "p_VersionLabel";
			this.p_VersionLabel.Size = new global::System.Drawing.Size(62, 13);
			this.p_VersionLabel.TabIndex = 2;
			this.p_VersionLabel.Text = "Version text";
			// 
			// p_ApplicationNameLabel
			// 
			this.p_ApplicationNameLabel.AutoSize = true;
			this.p_ApplicationNameLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.p_ApplicationNameLabel.Location = new global::System.Drawing.Point(29, 253);
			this.p_ApplicationNameLabel.Name = "p_ApplicationNameLabel";
			this.p_ApplicationNameLabel.Size = new global::System.Drawing.Size(88, 13);
			this.p_ApplicationNameLabel.TabIndex = 3;
			this.p_ApplicationNameLabel.Text = "Application name";
			// 
			// SplashScreenForm
			// 
			this.AutoScaleDimensions = new global::System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new global::System.Drawing.Size(480, 360);
			this.ControlBox = false;
			this.Controls.Add(this.p_ApplicationNameLabel);
			this.Controls.Add(this.p_VersionLabel);
			this.Controls.Add(this.p_MessageLabel);
			this.Controls.Add(this.p_ProgressBar);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashScreenForm";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		protected global::System.Windows.Forms.Label p_MessageLabel;
		protected global::System.Windows.Forms.Label p_VersionLabel;
		protected global::System.Windows.Forms.Label p_ApplicationNameLabel;

		}
	}

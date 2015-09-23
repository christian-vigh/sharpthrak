namespace Thrak. Forms
	{
	partial class HistoryForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
			this.OkButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.HistoryGrid = new System.Windows.Forms.DataGridView();
			this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmptyHistoryLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.HistoryGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(633, 343);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(113, 23);
			this.OkButton.TabIndex = 0;
			this.OkButton.Text = "*** OKBUTTON";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new System.Drawing.Point(501, 343);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(113, 23);
			this.CloseButton.TabIndex = 1;
			this.CloseButton.Text = "*** CANCEL";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// HistoryGrid
			// 
			this.HistoryGrid.AllowUserToAddRows = false;
			this.HistoryGrid.AllowUserToDeleteRows = false;
			this.HistoryGrid.AllowUserToOrderColumns = true;
			this.HistoryGrid.AllowUserToResizeColumns = false;
			this.HistoryGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.HistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.HistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.HistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.CommandColumn});
			this.HistoryGrid.Location = new System.Drawing.Point(12, 17);
			this.HistoryGrid.MultiSelect = false;
			this.HistoryGrid.Name = "HistoryGrid";
			this.HistoryGrid.Size = new System.Drawing.Size(734, 313);
			this.HistoryGrid.TabIndex = 2;
			// 
			// DateColumn
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.DateColumn.Frozen = true;
			this.DateColumn.HeaderText = "*** DATE";
			this.DateColumn.Name = "DateColumn";
			this.DateColumn.ReadOnly = true;
			this.DateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DateColumn.Width = 140;
			// 
			// CommandColumn
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommandColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.CommandColumn.Frozen = true;
			this.CommandColumn.HeaderText = "*** COMMAND";
			this.CommandColumn.Name = "CommandColumn";
			this.CommandColumn.ReadOnly = true;
			this.CommandColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.CommandColumn.Width = 95;
			// 
			// EmptyHistoryLabel
			// 
			this.EmptyHistoryLabel.BackColor = System.Drawing.SystemColors.Control;
			this.EmptyHistoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.EmptyHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmptyHistoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.EmptyHistoryLabel.Location = new System.Drawing.Point(99, 147);
			this.EmptyHistoryLabel.Name = "EmptyHistoryLabel";
			this.EmptyHistoryLabel.Size = new System.Drawing.Size(557, 55);
			this.EmptyHistoryLabel.TabIndex = 3;
			this.EmptyHistoryLabel.Text = "label1";
			this.EmptyHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HistoryForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(758, 378);
			this.Controls.Add(this.EmptyHistoryLabel);
			this.Controls.Add(this.HistoryGrid);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.OkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HistoryForm";
			this.Text = "*** HISTORY";
			this.Load += new System.EventHandler(this.HistoryForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HistoryForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.HistoryGrid)).EndInit();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.DataGridView HistoryGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommandColumn;
		private System.Windows.Forms.Label EmptyHistoryLabel;
		}
	}

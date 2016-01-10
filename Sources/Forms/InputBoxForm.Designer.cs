namespace Thrak. Forms
{
	partial class InputBoxForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System. ComponentModel. IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components. Dispose ( );
			}
			base. Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.MessagePanel = new System.Windows.Forms.Panel();
			this.MessageLabelPanel = new System.Windows.Forms.Panel();
			this.MessageLabel = new System.Windows.Forms.Label();
			this.MessageInputPanel = new System.Windows.Forms.Panel();
			this.MessageInputTextbox = new System.Windows.Forms.TextBox();
			this.BottomPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.MessagePanel.SuspendLayout();
			this.MessageLabelPanel.SuspendLayout();
			this.MessageInputPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BottomPanel
			// 
			this.BottomPanel.Controls.Add(this.ButtonPanel);
			this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomPanel.Location = new System.Drawing.Point(0, 54);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(376, 40);
			this.BottomPanel.TabIndex = 0;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Controls.Add(this.CancelButton);
			this.ButtonPanel.Controls.Add(this.OkButton);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonPanel.Location = new System.Drawing.Point(176, 0);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(200, 40);
			this.ButtonPanel.TabIndex = 0;
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(114, 10);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 2;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(34, 10);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "Ok";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// MessagePanel
			// 
			this.MessagePanel.Controls.Add(this.MessageLabelPanel);
			this.MessagePanel.Controls.Add(this.MessageInputPanel);
			this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessagePanel.Location = new System.Drawing.Point(0, 0);
			this.MessagePanel.Name = "MessagePanel";
			this.MessagePanel.Size = new System.Drawing.Size(376, 54);
			this.MessagePanel.TabIndex = 1;
			// 
			// MessageLabelPanel
			// 
			this.MessageLabelPanel.Controls.Add(this.MessageLabel);
			this.MessageLabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageLabelPanel.Location = new System.Drawing.Point(0, 0);
			this.MessageLabelPanel.Margin = new System.Windows.Forms.Padding(0);
			this.MessageLabelPanel.Name = "MessageLabelPanel";
			this.MessageLabelPanel.Size = new System.Drawing.Size(376, 26);
			this.MessageLabelPanel.TabIndex = 1;
			// 
			// MessageLabel
			// 
			this.MessageLabel.AutoSize = true;
			this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageLabel.Location = new System.Drawing.Point(0, 0);
			this.MessageLabel.Margin = new System.Windows.Forms.Padding(0);
			this.MessageLabel.MaximumSize = new System.Drawing.Size(0, 480);
			this.MessageLabel.Name = "MessageLabel";
			this.MessageLabel.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);
			this.MessageLabel.Size = new System.Drawing.Size(76, 21);
			this.MessageLabel.TabIndex = 2;
			this.MessageLabel.Text = "Input value :";
			// 
			// MessageInputPanel
			// 
			this.MessageInputPanel.Controls.Add(this.MessageInputTextbox);
			this.MessageInputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MessageInputPanel.Location = new System.Drawing.Point(0, 26);
			this.MessageInputPanel.Name = "MessageInputPanel";
			this.MessageInputPanel.Size = new System.Drawing.Size(376, 28);
			this.MessageInputPanel.TabIndex = 0;
			// 
			// MessageInputTextbox
			// 
			this.MessageInputTextbox.Location = new System.Drawing.Point(12, 4);
			this.MessageInputTextbox.Name = "MessageInputTextbox";
			this.MessageInputTextbox.Size = new System.Drawing.Size(352, 20);
			this.MessageInputTextbox.TabIndex = 0;
			// 
			// InputBoxForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 94);
			this.Controls.Add(this.MessagePanel);
			this.Controls.Add(this.BottomPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputBoxForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input";
			this.Shown += new System.EventHandler(this.InputBoxForm_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxForm_KeyDown);
			this.BottomPanel.ResumeLayout(false);
			this.ButtonPanel.ResumeLayout(false);
			this.MessagePanel.ResumeLayout(false);
			this.MessageLabelPanel.ResumeLayout(false);
			this.MessageLabelPanel.PerformLayout();
			this.MessageInputPanel.ResumeLayout(false);
			this.MessageInputPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System. Windows. Forms. Panel MessagePanel;
		internal System. Windows. Forms. Panel BottomPanel;
		internal System. Windows. Forms. Panel ButtonPanel;
		internal System. Windows. Forms. Button CancelButton;
		internal System. Windows. Forms. Button OkButton;
		internal System. Windows. Forms. Panel MessageLabelPanel;
		internal System. Windows. Forms. Panel MessageInputPanel;
		internal System. Windows. Forms. TextBox MessageInputTextbox;
		internal System. Windows. Forms. Label MessageLabel;
	}
}
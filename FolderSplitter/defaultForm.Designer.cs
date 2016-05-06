namespace FolderSplitter
{
	partial class DefaultForm
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
			this.defalultPanel = new System.Windows.Forms.Panel();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.startButton = new System.Windows.Forms.Button();
			this.openFolderButton = new System.Windows.Forms.Button();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.defalultPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// defalultPanel
			// 
			this.defalultPanel.Controls.Add(this.progressBar);
			this.defalultPanel.Controls.Add(this.startButton);
			this.defalultPanel.Controls.Add(this.openFolderButton);
			this.defalultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defalultPanel.Location = new System.Drawing.Point(0, 0);
			this.defalultPanel.Name = "defalultPanel";
			this.defalultPanel.Size = new System.Drawing.Size(284, 61);
			this.defalultPanel.TabIndex = 0;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(3, 34);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(278, 23);
			this.progressBar.TabIndex = 3;
			// 
			// startButton
			// 
			this.startButton.Enabled = false;
			this.startButton.Location = new System.Drawing.Point(206, 3);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 25);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// openFolderButton
			// 
			this.openFolderButton.Image = global::FolderSplitter.Properties.Resources.folder_explore;
			this.openFolderButton.Location = new System.Drawing.Point(3, 3);
			this.openFolderButton.Name = "openFolderButton";
			this.openFolderButton.Size = new System.Drawing.Size(25, 25);
			this.openFolderButton.TabIndex = 0;
			this.openFolderButton.UseVisualStyleBackColor = true;
			this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
			// 
			// DefaultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 61);
			this.Controls.Add(this.defalultPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DefaultForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FolderSplitter";
			this.defalultPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel defalultPanel;
		private System.Windows.Forms.Button openFolderButton;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button startButton;
	}
}


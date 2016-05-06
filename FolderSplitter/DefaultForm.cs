using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FolderSplitter
{
	public partial class DefaultForm : Form
	{
		public IList<string> Files;
		public string SourceDirectory;
		public int QuantityOfFiles = 100;
		private BackgroundWorker _moveFilesBackgroundWorker;

		public DefaultForm()
		{
			InitializeComponent();
		}

		private void openFolderButton_Click(object sender, EventArgs e)
		{
			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				startButton.Enabled = true;
				SourceDirectory = folderDialog.SelectedPath;
				Files = Directory.GetFiles(SourceDirectory);
			}
			else
			{
				startButton.Enabled = false;
			}
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			var movedFiles = 0;
			var numOfDirectories = (int)Math.Ceiling((double)Files.Count / QuantityOfFiles);
			CreateSubDirectories(numOfDirectories);

			ProgressBarBackgroundWorker(progressBar, OnComplete);
			_moveFilesBackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
			{
				progressBar.BeginInvoke(new MethodInvoker(() => progressBar.Visible = true));
				try
				{
					for (var i = 0; i < numOfDirectories; i++)
					{
						var portionOfFiles = Files.OrderBy(f => f).Skip(i * QuantityOfFiles).Take(QuantityOfFiles);
						foreach (var file in portionOfFiles)
						{
							File.Move(file, Path.Combine(SourceDirectory, (i + 1).ToString(), Path.GetFileName(file)));
							movedFiles++;
							var progress = (double)movedFiles / Files.Count * 100;
							_moveFilesBackgroundWorker.ReportProgress((int)Math.Truncate(progress));
						}
					}
				}
				catch (Exception ex) { }
			}));
		}

		private void OnComplete()
		{
			Application.Exit();
		}

		private void CreateSubDirectories(int quantity)
		{
			for (var i = 1; i <= quantity; i++)
				Directory.CreateDirectory(Path.Combine(SourceDirectory, i.ToString()));
		}

		private void ProgressBarBackgroundWorker(ProgressBar progressBar, Action callBack)
		{
			_moveFilesBackgroundWorker = new BackgroundWorker();
			_moveFilesBackgroundWorker.WorkerReportsProgress = true;
			_moveFilesBackgroundWorker.DoWork += (sender, e) => ((MethodInvoker)e.Argument).Invoke();
			_moveFilesBackgroundWorker.ProgressChanged += (sender, e) =>
			{
				progressBar.Style = ProgressBarStyle.Continuous;
				progressBar.Value = e.ProgressPercentage;
			};
			_moveFilesBackgroundWorker.RunWorkerCompleted += (sender, e) =>
			{
				callBack();
			};
		}
	}
}
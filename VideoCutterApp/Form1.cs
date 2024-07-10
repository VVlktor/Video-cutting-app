using System.Diagnostics;

namespace VideoCutterApp
{
	public partial class Form1 : Form
	{
		private double StartPointTime;
		private double EndPointTime;
		private string filePath;

		public Form1()
		{
			InitializeComponent();
		}

		private void OpenNewFile(object sender, EventArgs e)
		{
			if (FileSearch.ShowDialog() != DialogResult.OK)
				return;
			MyPlayer.URL = FileSearch.FileName;
			filePath=FileSearch.FileName;
			SetStartPoint.Enabled = true;
			SetEndPoint.Enabled = true;
			SelectFileLabel.Visible = false;
		}

		private void SetPoint(object sender, EventArgs e)
		{
			double totalSeconds = MyPlayer.Ctlcontrols.currentPosition;
			string time = TimePattern(totalSeconds);
			SwapPointsButton.Enabled = false;
			if (((Button)sender).Name == "SetStartPoint")
			{
				StartPointTime = totalSeconds;
				StartPointLabel.Text = time;
			}
			else
			{
				EndPointTime = totalSeconds;
				EndPointLabel.Text = time;
			}
			if (StartPointTime > EndPointTime && EndPointTime!=0)
				SwapPointsButton.Enabled = true;
		}

		private void SwapPoints(object sender, EventArgs e)
		{
			SwapPointsButton.Enabled = false;
			double p = StartPointTime;
			StartPointTime = EndPointTime;
			EndPointTime = p;
			StartPointLabel.Text = TimePattern(StartPointTime);
			EndPointLabel.Text = TimePattern(EndPointTime);
		}

		private string TimePattern(double totalSeconds)
		{
			return $"{((int)(totalSeconds / 3600)).ToString("D2")}:{((int)((totalSeconds % 3600) / 60)).ToString("D2")}:{((int)(totalSeconds % 60)).ToString("D2")}.{Math.Round(totalSeconds-(int)totalSeconds,3)*1000}";
		}

		private void GoToPoint(object sender, EventArgs e)
		{
			if (((Label)sender).Name == "PunktStartowy")
				MyPlayer.Ctlcontrols.currentPosition = StartPointTime;
			else
				MyPlayer.Ctlcontrols.currentPosition = EndPointTime;
		}

		private void ResetClicked(object sender, EventArgs e)
		{
			StartPointLabel.Text = "Punkt startowy";
			EndPointLabel.Text = "Punkt koncowy";
			StartPointTime = default;
			EndPointTime = default;
		}

		private void ExportFIle(object sender, EventArgs e)
		{
			if (CheckConditions())
				return;

			if (folderBrowser.ShowDialog() != DialogResult.OK)
				return;

			string pathToSave=folderBrowser.SelectedPath+@"\"+ProjectNameInput.Text+".mp4";
			string InfoArguments = @$"-i ""{filePath}"" -ss {TimePattern(StartPointTime)} -to {TimePattern(EndPointTime)}{(MuteAudioBox.Checked ? " -an" : "")} -f mp4 ""{pathToSave}""";
			try
			{
				PleaseWaitLabel.Visible = true;
				using (Process process = new Process())
				{
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg", "ffmpeg.exe");
					process.StartInfo.Arguments = InfoArguments;
					process.Start();
					process.WaitForExit();
				}
				PleaseWaitLabel.Visible= false;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
			}
		}

		private bool CheckConditions()
		{
			if (filePath is null)
			{
				MessageBox.Show("Nie rozpoczêto edycji pliku!", "B³¹d", MessageBoxButtons.OK);
				return true;
			}
			if (StartPointTime > EndPointTime)
			{
				MessageBox.Show("Wide³ki czasowe nie s¹ zgodne!", "B³¹d", MessageBoxButtons.OK);
				return true;
			}
			if (ProjectNameInput.Text == "")
			{
				MessageBox.Show("Nie nadano nazwy projektowi!", "B³¹d", MessageBoxButtons.OK);
				return true;
			}
			if (EndPointTime == 0)
				EndPointTime = MyPlayer.currentMedia.duration;

			return false;
		}
	}
}

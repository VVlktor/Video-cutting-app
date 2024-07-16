using System.Diagnostics;
using VideoCutterApp.Custom_Controls;

namespace VideoCutterApp
{
	public partial class Form1 : Form
	{
		private string filePath;
		private PointOnTimeline StartPointStamp;
		private PointOnTimeline EndPointStamp;

		public Form1()
		{
			InitializeComponent();
			SetTimeStamps();
		}

		private void SetTimeStamps()
		{
			FileFormatSelector.SelectedIndex = 1;
			StartPointStamp = new() { Location = new(30, 470) };
			EndPointStamp = new() { Location = new(30, 470) };
			StartPointStamp.Click += TimeStampClicked;
			EndPointStamp.Click += TimeStampClicked;
			Controls.Add(StartPointStamp);
			StartPointStamp.BringToFront();
			Controls.Add(EndPointStamp);
			EndPointStamp.BringToFront();
		}

		public void TimeStampClicked(object sender, EventArgs e)
		{
			MyPlayer.Ctlcontrols.currentPosition=((PointOnTimeline)sender).TimeStamp;
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
			double proc = (totalSeconds * 100) / MyPlayer.currentMedia.duration;
			int locatX = (int)((((int)Math.Floor((Size.Width - 60) * proc / 100)) + 30) * 0.96);
			if (((Button)sender).Name == "SetStartPoint")
			{
				StartPointLabel.Text = time;
				StartPointStamp.TimeStamp = totalSeconds;
				StartPointStamp.Location = new(locatX, 470);
			}
			else
			{
				EndPointLabel.Text = time;
				EndPointStamp.TimeStamp=totalSeconds;
				EndPointStamp.Location = new(locatX, 470);
			}
			if (StartPointStamp.TimeStamp > EndPointStamp.TimeStamp && EndPointStamp.TimeStamp!=0)
				SwapPointsButton.Enabled = true;
		}

		private void SwapPoints(object sender, EventArgs e)
		{
			int loc = EndPointStamp.Location.X;
			EndPointStamp.Location = new(StartPointStamp.Location.X, 470);
			StartPointStamp.Location = new(loc, 470);
			SwapTwoVariables<double>(ref StartPointStamp.TimeStamp, ref EndPointStamp.TimeStamp);
			SwapPointsButton.Enabled = false;
			StartPointLabel.Text = TimePattern(StartPointStamp.TimeStamp);
			EndPointLabel.Text = TimePattern(EndPointStamp.TimeStamp);
		}

		private void SwapTwoVariables<T>(ref T first, ref T second)
		{
			T o = first;
			first = second; 
			second = o;
		}

		private string TimePattern(double totalSeconds)
		{
			return $"{((int)(totalSeconds / 3600)).ToString("D2")}:{((int)((totalSeconds % 3600) / 60)).ToString("D2")}:{((int)(totalSeconds % 60)).ToString("D2")}.{Math.Round(totalSeconds-(int)totalSeconds,3)*1000}";
		}

		private void GoToPoint(object sender, EventArgs e)
		{
			if (((Label)sender).Name == "PunktStartowy")
				MyPlayer.Ctlcontrols.currentPosition = StartPointStamp.TimeStamp;
			else
				MyPlayer.Ctlcontrols.currentPosition = EndPointStamp.TimeStamp;
		}

		private void ResetClicked(object sender, EventArgs e)
		{
			StartPointLabel.Text = "Punkt startowy";
			EndPointLabel.Text = "Punkt koncowy";
			StartPointStamp.TimeStamp = 0;
			EndPointStamp.TimeStamp = 0;
			ProjectNameInput.Text = "";
			MuteAudioBox.Checked = false;
			FileFormatSelector.SelectedIndex = 1;
		}

		private void ExportFIle(object sender, EventArgs e)
		{
			if (CheckConditions())
				return;

			if (folderBrowser.ShowDialog() != DialogResult.OK)
				return;

			string pathToSave=folderBrowser.SelectedPath+@"\"+ProjectNameInput.Text+$".{FileFormatSelector.Text}";
			string InfoArguments = @$"-i ""{filePath}"" -ss {TimePattern(StartPointStamp.TimeStamp)} -to {TimePattern(EndPointStamp.TimeStamp)}{(MuteAudioBox.Checked ? " -an" : "")} -f {FileFormatSelector.Text} ""{pathToSave}""";
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
			if (StartPointStamp.TimeStamp > EndPointStamp.TimeStamp)
			{
				MessageBox.Show("Wide³ki czasowe nie s¹ zgodne!", "B³¹d", MessageBoxButtons.OK);
				return true;
			}
			if (ProjectNameInput.Text == "")
			{
				MessageBox.Show("Nie nadano nazwy projektowi!", "B³¹d", MessageBoxButtons.OK);
				return true;
			}
			if(!FileFormatSelector.Items.Contains(FileFormatSelector.Text)){
				MessageBox.Show("Nieznany format pliku!", "B³¹d", MessageBoxButtons.OK);
				return true;
			}
			if (EndPointStamp.TimeStamp == 0)
				EndPointStamp.TimeStamp = MyPlayer.currentMedia.duration;

			return false;
		}
	}
}

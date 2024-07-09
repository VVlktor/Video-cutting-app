using System.Diagnostics;

namespace VideoCutterApp
{
	public partial class Form1 : Form
	{
		public double StartPointTime;
		public double EndPointTime;
		public string filePath;

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
				PunktStartowy.Text = time;
			}
			else
			{
				EndPointTime = totalSeconds;
				PunktKoncowy.Text = time;
			}
			if (StartPointTime > EndPointTime)
				SwapPointsButton.Enabled = true;
		}

		private void SwapPoints(object sender, EventArgs e)
		{
			SwapPointsButton.Enabled = false;
			double p = StartPointTime;
			StartPointTime = EndPointTime;
			EndPointTime = p;
			PunktStartowy.Text = TimePattern(StartPointTime);
			PunktKoncowy.Text = TimePattern(EndPointTime);
		}

		public string TimePattern(double totalSeconds)
		{
			return $"{((int)(totalSeconds / 3600)).ToString("D2")}:{((int)((totalSeconds % 3600) / 60)).ToString("D2")}:{((int)(totalSeconds % 60)).ToString("D2")}";
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
			PunktStartowy.Text = "Punkt startowy";
			PunktKoncowy.Text = "Punkt koncowy";
			StartPointTime = default;
			EndPointTime = default;
		}

		private void ExportFIle(object sender, EventArgs e)
		{
			if (filePath is null)
				
				return;
			if (StartPointTime > EndPointTime)

				return;
			if (folderBrowser.ShowDialog() != DialogResult.OK)
				return;
			label1.Text = folderBrowser.SelectedPath;

		}

	}
}

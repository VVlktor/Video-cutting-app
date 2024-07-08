using System.Diagnostics;

namespace VideoCutterApp
{
	public partial class Form1 : Form
	{
		public double StartPointTime;
		public double EndPointTime;

		public Form1()
		{
			InitializeComponent();
		}

		private void OpenNewFile(object sender, EventArgs e)
		{
			if (FileSearch.ShowDialog() != DialogResult.OK)
				return;
			MyPlayer.URL = FileSearch.FileName;
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
	}
}

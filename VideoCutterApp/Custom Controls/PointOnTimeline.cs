namespace VideoCutterApp.Custom_Controls
{
	public partial class PointOnTimeline : Button
	{
		public double TimeStamp;

		public PointOnTimeline()
		{
			InitializeComponent();
			TimeStamp = 0;
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			Size = new() { Width = 15, Height = 15 };
			Text = "";
			BackColor = Color.DeepSkyBlue;
			base.OnPaint(pe);
		}
	}
}

using System.Diagnostics;

namespace VideoCutterApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SearchForFile(object sender, EventArgs e)
		{
			if(FileSearch.ShowDialog() == DialogResult.OK)
				MyPlayer.URL = FileSearch.FileName;
		}
	}
}

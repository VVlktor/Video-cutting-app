namespace VideoCutterApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			MyPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			FileSearch = new OpenFileDialog();
			menuStrip1 = new MenuStrip();
			plikToolStripMenuItem = new ToolStripMenuItem();
			otwórzToolStripMenuItem = new ToolStripMenuItem();
			wyeksportujToolStripMenuItem = new ToolStripMenuItem();
			edycjaToolStripMenuItem = new ToolStripMenuItem();
			usunToolStripMenuItem = new ToolStripMenuItem();
			StartPointLabel = new Label();
			EndPointLabel = new Label();
			SetStartPoint = new Button();
			SetEndPoint = new Button();
			SelectFileLabel = new Label();
			SwapPointsButton = new Button();
			folderBrowser = new FolderBrowserDialog();
			ProjectNameInput = new TextBox();
			label2 = new Label();
			PleaseWaitLabel = new Label();
			MuteAudioBox = new CheckBox();
			((System.ComponentModel.ISupportInitialize)MyPlayer).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// MyPlayer
			// 
			MyPlayer.Enabled = true;
			MyPlayer.Location = new Point(0, 31);
			MyPlayer.Name = "MyPlayer";
			MyPlayer.OcxState = (AxHost.State)resources.GetObject("MyPlayer.OcxState");
			MyPlayer.Size = new Size(800, 492);
			MyPlayer.TabIndex = 2;
			// 
			// FileSearch
			// 
			FileSearch.FileName = "openFileDialog1";
			FileSearch.Filter = "MP4 Files (*.mp4)|*.mp4";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(798, 28);
			menuStrip1.TabIndex = 4;
			menuStrip1.Text = "menuStrip1";
			// 
			// plikToolStripMenuItem
			// 
			plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otwórzToolStripMenuItem, wyeksportujToolStripMenuItem });
			plikToolStripMenuItem.Name = "plikToolStripMenuItem";
			plikToolStripMenuItem.Size = new Size(46, 24);
			plikToolStripMenuItem.Text = "Plik";
			// 
			// otwórzToolStripMenuItem
			// 
			otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
			otwórzToolStripMenuItem.Size = new Size(177, 26);
			otwórzToolStripMenuItem.Text = "Otwórz plik...";
			otwórzToolStripMenuItem.Click += OpenNewFile;
			// 
			// wyeksportujToolStripMenuItem
			// 
			wyeksportujToolStripMenuItem.Name = "wyeksportujToolStripMenuItem";
			wyeksportujToolStripMenuItem.Size = new Size(177, 26);
			wyeksportujToolStripMenuItem.Text = "Wyeksportuj";
			wyeksportujToolStripMenuItem.Click += ExportFIle;
			// 
			// edycjaToolStripMenuItem
			// 
			edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usunToolStripMenuItem });
			edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
			edycjaToolStripMenuItem.Size = new Size(66, 24);
			edycjaToolStripMenuItem.Text = "Edycja";
			// 
			// usunToolStripMenuItem
			// 
			usunToolStripMenuItem.Name = "usunToolStripMenuItem";
			usunToolStripMenuItem.Size = new Size(140, 26);
			usunToolStripMenuItem.Text = "Resetuj";
			usunToolStripMenuItem.Click += ResetClicked;
			// 
			// StartPointLabel
			// 
			StartPointLabel.AutoSize = true;
			StartPointLabel.Font = new Font("Segoe UI", 12F);
			StartPointLabel.Location = new Point(22, 592);
			StartPointLabel.Name = "StartPointLabel";
			StartPointLabel.Size = new Size(142, 28);
			StartPointLabel.TabIndex = 5;
			StartPointLabel.Text = "Punkt startowy";
			StartPointLabel.Click += GoToPoint;
			// 
			// EndPointLabel
			// 
			EndPointLabel.AutoSize = true;
			EndPointLabel.Font = new Font("Segoe UI", 12F);
			EndPointLabel.Location = new Point(210, 592);
			EndPointLabel.Name = "EndPointLabel";
			EndPointLabel.Size = new Size(145, 28);
			EndPointLabel.TabIndex = 6;
			EndPointLabel.Text = "Punkt koncowy";
			EndPointLabel.Click += GoToPoint;
			// 
			// SetStartPoint
			// 
			SetStartPoint.Enabled = false;
			SetStartPoint.Location = new Point(22, 541);
			SetStartPoint.Name = "SetStartPoint";
			SetStartPoint.Size = new Size(142, 48);
			SetStartPoint.TabIndex = 7;
			SetStartPoint.Text = "Ustaw punkt startowy";
			SetStartPoint.UseVisualStyleBackColor = true;
			SetStartPoint.Click += SetPoint;
			// 
			// SetEndPoint
			// 
			SetEndPoint.Enabled = false;
			SetEndPoint.Location = new Point(210, 541);
			SetEndPoint.Name = "SetEndPoint";
			SetEndPoint.Size = new Size(145, 48);
			SetEndPoint.TabIndex = 8;
			SetEndPoint.Text = "Ustaw punkt koncowy";
			SetEndPoint.UseVisualStyleBackColor = true;
			SetEndPoint.Click += SetPoint;
			// 
			// SelectFileLabel
			// 
			SelectFileLabel.AutoSize = true;
			SelectFileLabel.BackColor = Color.Black;
			SelectFileLabel.Font = new Font("Segoe UI", 40F);
			SelectFileLabel.ForeColor = SystemColors.ControlLightLight;
			SelectFileLabel.Location = new Point(210, 212);
			SelectFileLabel.Name = "SelectFileLabel";
			SelectFileLabel.Size = new Size(398, 89);
			SelectFileLabel.TabIndex = 9;
			SelectFileLabel.Text = "Wybierz plik";
			SelectFileLabel.Click += OpenNewFile;
			// 
			// SwapPointsButton
			// 
			SwapPointsButton.Enabled = false;
			SwapPointsButton.Font = new Font("Segoe UI", 12F);
			SwapPointsButton.Location = new Point(22, 632);
			SwapPointsButton.Name = "SwapPointsButton";
			SwapPointsButton.Size = new Size(333, 54);
			SwapPointsButton.TabIndex = 10;
			SwapPointsButton.Text = "Zamien punkty miejscami";
			SwapPointsButton.UseVisualStyleBackColor = true;
			SwapPointsButton.Click += SwapPoints;
			// 
			// ProjectNameInput
			// 
			ProjectNameInput.Location = new Point(398, 562);
			ProjectNameInput.Name = "ProjectNameInput";
			ProjectNameInput.Size = new Size(388, 27);
			ProjectNameInput.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(398, 539);
			label2.Name = "label2";
			label2.Size = new Size(113, 20);
			label2.TabIndex = 12;
			label2.Text = "Nazwa projektu";
			// 
			// PleaseWaitLabel
			// 
			PleaseWaitLabel.AutoSize = true;
			PleaseWaitLabel.BackColor = Color.Transparent;
			PleaseWaitLabel.Font = new Font("Segoe UI", 40F);
			PleaseWaitLabel.Location = new Point(166, 212);
			PleaseWaitLabel.Name = "PleaseWaitLabel";
			PleaseWaitLabel.Size = new Size(488, 89);
			PleaseWaitLabel.TabIndex = 13;
			PleaseWaitLabel.Text = "Prosze czekac...";
			PleaseWaitLabel.Visible = false;
			// 
			// MuteAudioBox
			// 
			MuteAudioBox.AutoSize = true;
			MuteAudioBox.Font = new Font("Segoe UI", 12F);
			MuteAudioBox.Location = new Point(398, 611);
			MuteAudioBox.Name = "MuteAudioBox";
			MuteAudioBox.Size = new Size(149, 32);
			MuteAudioBox.TabIndex = 14;
			MuteAudioBox.Text = "Wycisz audio";
			MuteAudioBox.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(798, 698);
			Controls.Add(MuteAudioBox);
			Controls.Add(PleaseWaitLabel);
			Controls.Add(label2);
			Controls.Add(ProjectNameInput);
			Controls.Add(SwapPointsButton);
			Controls.Add(SelectFileLabel);
			Controls.Add(SetEndPoint);
			Controls.Add(SetStartPoint);
			Controls.Add(EndPointLabel);
			Controls.Add(StartPointLabel);
			Controls.Add(MyPlayer);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Edytor video";
			((System.ComponentModel.ISupportInitialize)MyPlayer).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private AxWMPLib.AxWindowsMediaPlayer MyPlayer;
		private OpenFileDialog FileSearch;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem plikToolStripMenuItem;
		private ToolStripMenuItem otwórzToolStripMenuItem;
		private Label StartPointLabel;
		private Label EndPointLabel;
		private Button SetStartPoint;
		private Button SetEndPoint;
		private Label SelectFileLabel;
		private Button SwapPointsButton;
		private ToolStripMenuItem wyeksportujToolStripMenuItem;
		private ToolStripMenuItem edycjaToolStripMenuItem;
		private ToolStripMenuItem usunToolStripMenuItem;
		private FolderBrowserDialog folderBrowser;
		private TextBox ProjectNameInput;
		private Label label2;
		private Label PleaseWaitLabel;
		private CheckBox MuteAudioBox;
	}
}

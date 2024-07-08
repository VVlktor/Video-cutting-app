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
			label1 = new Label();
			MyPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			FileSearch = new OpenFileDialog();
			menuStrip1 = new MenuStrip();
			plikToolStripMenuItem = new ToolStripMenuItem();
			otwórzToolStripMenuItem = new ToolStripMenuItem();
			zapiszToolStripMenuItem = new ToolStripMenuItem();
			usunToolStripMenuItem = new ToolStripMenuItem();
			PunktStartowy = new Label();
			PunktKoncowy = new Label();
			SetStartPoint = new Button();
			SetEndPoint = new Button();
			SelectFileLabel = new Label();
			SwapPointsButton = new Button();
			((System.ComponentModel.ISupportInitialize)MyPlayer).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(535, 572);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 1;
			label1.Text = "label1";
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
			menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(798, 28);
			menuStrip1.TabIndex = 4;
			menuStrip1.Text = "menuStrip1";
			// 
			// plikToolStripMenuItem
			// 
			plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otwórzToolStripMenuItem, zapiszToolStripMenuItem, usunToolStripMenuItem });
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
			// zapiszToolStripMenuItem
			// 
			zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
			zapiszToolStripMenuItem.Size = new Size(177, 26);
			zapiszToolStripMenuItem.Text = "Wyeksportuj";
			// 
			// usunToolStripMenuItem
			// 
			usunToolStripMenuItem.Name = "usunToolStripMenuItem";
			usunToolStripMenuItem.Size = new Size(177, 26);
			usunToolStripMenuItem.Text = "Usun";
			// 
			// PunktStartowy
			// 
			PunktStartowy.AutoSize = true;
			PunktStartowy.Font = new Font("Segoe UI", 12F);
			PunktStartowy.Location = new Point(22, 592);
			PunktStartowy.Name = "PunktStartowy";
			PunktStartowy.Size = new Size(142, 28);
			PunktStartowy.TabIndex = 5;
			PunktStartowy.Text = "Punkt startowy";
			// 
			// PunktKoncowy
			// 
			PunktKoncowy.AutoSize = true;
			PunktKoncowy.Font = new Font("Segoe UI", 12F);
			PunktKoncowy.Location = new Point(210, 592);
			PunktKoncowy.Name = "PunktKoncowy";
			PunktKoncowy.Size = new Size(145, 28);
			PunktKoncowy.TabIndex = 6;
			PunktKoncowy.Text = "Punkt koncowy";
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(798, 698);
			Controls.Add(SwapPointsButton);
			Controls.Add(SelectFileLabel);
			Controls.Add(SetEndPoint);
			Controls.Add(SetStartPoint);
			Controls.Add(PunktKoncowy);
			Controls.Add(PunktStartowy);
			Controls.Add(MyPlayer);
			Controls.Add(label1);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)MyPlayer).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private AxWMPLib.AxWindowsMediaPlayer MyPlayer;
		private OpenFileDialog FileSearch;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem plikToolStripMenuItem;
		private ToolStripMenuItem otwórzToolStripMenuItem;
		private ToolStripMenuItem zapiszToolStripMenuItem;
		private ToolStripMenuItem usunToolStripMenuItem;
		private Label PunktStartowy;
		private Label PunktKoncowy;
		private Button SetStartPoint;
		private Button SetEndPoint;
		private Label SelectFileLabel;
		private Button SwapPointsButton;
	}
}

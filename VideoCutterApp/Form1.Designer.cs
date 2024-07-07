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
			ButtonOpenFileDialog = new Button();
			menuStrip1 = new MenuStrip();
			plikToolStripMenuItem = new ToolStripMenuItem();
			otwórzToolStripMenuItem = new ToolStripMenuItem();
			zapiszToolStripMenuItem = new ToolStripMenuItem();
			usunToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)MyPlayer).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(227, 622);
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
			// ButtonOpenFileDialog
			// 
			ButtonOpenFileDialog.Location = new Point(32, 618);
			ButtonOpenFileDialog.Name = "ButtonOpenFileDialog";
			ButtonOpenFileDialog.Size = new Size(94, 29);
			ButtonOpenFileDialog.TabIndex = 3;
			ButtonOpenFileDialog.Text = "button2";
			ButtonOpenFileDialog.UseVisualStyleBackColor = true;
			ButtonOpenFileDialog.Click += SearchForFile;
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
			otwórzToolStripMenuItem.Size = new Size(140, 26);
			otwórzToolStripMenuItem.Text = "Otwórz";
			// 
			// zapiszToolStripMenuItem
			// 
			zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
			zapiszToolStripMenuItem.Size = new Size(140, 26);
			zapiszToolStripMenuItem.Text = "Zapisz";
			// 
			// usunToolStripMenuItem
			// 
			usunToolStripMenuItem.Name = "usunToolStripMenuItem";
			usunToolStripMenuItem.Size = new Size(140, 26);
			usunToolStripMenuItem.Text = "Usun";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(798, 698);
			Controls.Add(ButtonOpenFileDialog);
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
		private Button ButtonOpenFileDialog;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem plikToolStripMenuItem;
		private ToolStripMenuItem otwórzToolStripMenuItem;
		private ToolStripMenuItem zapiszToolStripMenuItem;
		private ToolStripMenuItem usunToolStripMenuItem;
	}
}

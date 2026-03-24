namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRandomColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RotateSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.rotateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ScaleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.scaleXTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.scaleYTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.applyNameSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.groupSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.UngroupSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawElipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.rgbRedTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.rgbGreenTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.rgbBlueTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.rgbAlphaTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.applyColorFromRGB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorPalleteSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.drawTriangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1942, 54);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Monocraft", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(111, 50);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(239, 48);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateToolStripMenuItem,
            this.setRandomColorToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Monocraft", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(111, 50);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(562, 48);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // setRandomColorToolStripMenuItem
            // 
            this.setRandomColorToolStripMenuItem.Name = "setRandomColorToolStripMenuItem";
            this.setRandomColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.setRandomColorToolStripMenuItem.Size = new System.Drawing.Size(562, 48);
            this.setRandomColorToolStripMenuItem.Text = "Set Random Color";
            this.setRandomColorToolStripMenuItem.Click += new System.EventHandler(this.setRandomColorToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Font = new System.Drawing.Font("Monocraft", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(129, 50);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Monocraft", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(111, 50);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(311, 48);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 1091);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.statusBar.Size = new System.Drawing.Size(1942, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 11);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
            // 
            // RotateSpeedButton
            // 
            this.RotateSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.RotateSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RotateSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateSpeedButton.Name = "RotateSpeedButton";
            this.RotateSpeedButton.Size = new System.Drawing.Size(156, 50);
            this.RotateSpeedButton.Text = "Rotate";
            this.RotateSpeedButton.ToolTipText = "rotate";
            this.RotateSpeedButton.Click += new System.EventHandler(this.RotateSpeedButton_Click);
            // 
            // rotateTextBox
            // 
            this.rotateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rotateTextBox.Name = "rotateTextBox";
            this.rotateTextBox.Size = new System.Drawing.Size(100, 56);
            this.rotateTextBox.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 56);
            // 
            // ScaleSpeedButton
            // 
            this.ScaleSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.ScaleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ScaleSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScaleSpeedButton.Name = "ScaleSpeedButton";
            this.ScaleSpeedButton.Size = new System.Drawing.Size(134, 50);
            this.ScaleSpeedButton.Text = "Scale";
            this.ScaleSpeedButton.Click += new System.EventHandler(this.ScaleSpeedButton_Click);
            // 
            // scaleXTextBox
            // 
            this.scaleXTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scaleXTextBox.Name = "scaleXTextBox";
            this.scaleXTextBox.Size = new System.Drawing.Size(100, 56);
            // 
            // speedMenu
            // 
            this.speedMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.RotateSpeedButton,
            this.rotateTextBox,
            this.toolStripSeparator4,
            this.ScaleSpeedButton,
            this.scaleXTextBox,
            this.scaleYTextBox,
            this.toolStripSeparator5,
            this.applyNameSpeedButton,
            this.nameTextBox,
            this.nameLabel});
            this.speedMenu.Location = new System.Drawing.Point(334, 54);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.speedMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.speedMenu.Size = new System.Drawing.Size(1608, 56);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "scale";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedMenu_ItemClicked);
            // 
            // scaleYTextBox
            // 
            this.scaleYTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scaleYTextBox.Name = "scaleYTextBox";
            this.scaleYTextBox.Size = new System.Drawing.Size(100, 56);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 56);
            // 
            // applyNameSpeedButton
            // 
            this.applyNameSpeedButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.applyNameSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.applyNameSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.applyNameSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyNameSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("applyNameSpeedButton.Image")));
            this.applyNameSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applyNameSpeedButton.Name = "applyNameSpeedButton";
            this.applyNameSpeedButton.Size = new System.Drawing.Size(244, 50);
            this.applyNameSpeedButton.Text = "Apply Name";
            this.applyNameSpeedButton.Click += new System.EventHandler(this.applyNameSpeedButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nameTextBox.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 56);
            this.nameTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nameLabel.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(118, 50);
            this.nameLabel.Text = "Name:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.groupSpeedButton,
            this.UngroupSpeedButton,
            this.drawRectangleSpeedButton,
            this.drawElipseSpeedButton,
            this.drawTriangleSpeedButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 54);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(334, 1037);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pickUpSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(329, 50);
            this.pickUpSpeedButton.Text = "Select";
            // 
            // groupSpeedButton
            // 
            this.groupSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.groupSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.groupSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSpeedButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("groupSpeedButton.Image")));
            this.groupSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupSpeedButton.Name = "groupSpeedButton";
            this.groupSpeedButton.Size = new System.Drawing.Size(329, 50);
            this.groupSpeedButton.Text = "Group";
            this.groupSpeedButton.Click += new System.EventHandler(this.groupSpeedButton_Click);
            // 
            // UngroupSpeedButton
            // 
            this.UngroupSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.UngroupSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UngroupSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UngroupSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("UngroupSpeedButton.Image")));
            this.UngroupSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupSpeedButton.Name = "UngroupSpeedButton";
            this.UngroupSpeedButton.Size = new System.Drawing.Size(329, 50);
            this.UngroupSpeedButton.Text = "Ungroup";
            this.UngroupSpeedButton.Click += new System.EventHandler(this.UngroupSpeedButton_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.drawRectangleSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(329, 50);
            this.drawRectangleSpeedButton.Text = "Draw Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.drawRectangleSpeedButton_Click);
            // 
            // drawElipseSpeedButton
            // 
            this.drawElipseSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.drawElipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.drawElipseSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawElipseSpeedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.drawElipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawElipseSpeedButton.Name = "drawElipseSpeedButton";
            this.drawElipseSpeedButton.Size = new System.Drawing.Size(329, 50);
            this.drawElipseSpeedButton.Text = "Draw Ellipse";
            this.drawElipseSpeedButton.Click += new System.EventHandler(this.drawElipseSpeedButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.rgbRedTextBox,
            this.rgbGreenTextBox,
            this.rgbBlueTextBox,
            this.rgbAlphaTextBox,
            this.applyColorFromRGB,
            this.toolStripSeparator1,
            this.ColorPalleteSpeedButton});
            this.toolStrip2.Location = new System.Drawing.Point(334, 110);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1608, 56);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(118, 50);
            this.toolStripLabel2.Text = "RGBa:";
            // 
            // rgbRedTextBox
            // 
            this.rgbRedTextBox.BackColor = System.Drawing.Color.Red;
            this.rgbRedTextBox.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbRedTextBox.ForeColor = System.Drawing.Color.White;
            this.rgbRedTextBox.Name = "rgbRedTextBox";
            this.rgbRedTextBox.Size = new System.Drawing.Size(100, 56);
            this.rgbRedTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rgbGreenTextBox
            // 
            this.rgbGreenTextBox.BackColor = System.Drawing.Color.Lime;
            this.rgbGreenTextBox.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbGreenTextBox.ForeColor = System.Drawing.Color.White;
            this.rgbGreenTextBox.Name = "rgbGreenTextBox";
            this.rgbGreenTextBox.Size = new System.Drawing.Size(100, 56);
            this.rgbGreenTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rgbBlueTextBox
            // 
            this.rgbBlueTextBox.BackColor = System.Drawing.Color.Blue;
            this.rgbBlueTextBox.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbBlueTextBox.ForeColor = System.Drawing.Color.White;
            this.rgbBlueTextBox.Name = "rgbBlueTextBox";
            this.rgbBlueTextBox.Size = new System.Drawing.Size(100, 56);
            this.rgbBlueTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rgbAlphaTextBox
            // 
            this.rgbAlphaTextBox.Font = new System.Drawing.Font("Monocraft", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbAlphaTextBox.ForeColor = System.Drawing.Color.Black;
            this.rgbAlphaTextBox.Name = "rgbAlphaTextBox";
            this.rgbAlphaTextBox.Size = new System.Drawing.Size(100, 56);
            // 
            // applyColorFromRGB
            // 
            this.applyColorFromRGB.BackColor = System.Drawing.Color.LightCoral;
            this.applyColorFromRGB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.applyColorFromRGB.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyColorFromRGB.Image = ((System.Drawing.Image)(resources.GetObject("applyColorFromRGB.Image")));
            this.applyColorFromRGB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applyColorFromRGB.Name = "applyColorFromRGB";
            this.applyColorFromRGB.Size = new System.Drawing.Size(266, 50);
            this.applyColorFromRGB.Text = "Apply Color";
            this.applyColorFromRGB.Click += new System.EventHandler(this.applyColorFromRGB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // ColorPalleteSpeedButton
            // 
            this.ColorPalleteSpeedButton.BackColor = System.Drawing.Color.LightCoral;
            this.ColorPalleteSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorPalleteSpeedButton.Font = new System.Drawing.Font("Monocraft", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorPalleteSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorPalleteSpeedButton.Name = "ColorPalleteSpeedButton";
            this.ColorPalleteSpeedButton.Size = new System.Drawing.Size(310, 50);
            this.ColorPalleteSpeedButton.Text = "Color Pallete";
            this.ColorPalleteSpeedButton.Click += new System.EventHandler(this.ColorPalleteSpeedButton_Click);
            // 
            // viewPort
            // 
            this.viewPort.BackColor = System.Drawing.Color.LavenderBlush;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 54);
            this.viewPort.Margin = new System.Windows.Forms.Padding(16);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1942, 1037);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // drawTriangleSpeedButton
            // 
            this.drawTriangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.drawTriangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleSpeedButton.Image")));
            this.drawTriangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleSpeedButton.Name = "drawTriangleSpeedButton";
            this.drawTriangleSpeedButton.Size = new System.Drawing.Size(329, 41);
            this.drawTriangleSpeedButton.Text = "Draw Triangle";
            this.drawTriangleSpeedButton.Click += new System.EventHandler(this.drawTriangleSpeedButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1942, 1113);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton RotateSpeedButton;
        private System.Windows.Forms.ToolStripTextBox rotateTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ScaleSpeedButton;
        private System.Windows.Forms.ToolStripTextBox scaleXTextBox;
        private System.Windows.Forms.ToolStrip speedMenu;
        private System.Windows.Forms.ToolStripTextBox scaleYTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
        private System.Windows.Forms.ToolStripButton drawElipseSpeedButton;
        private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
        private System.Windows.Forms.ToolStripButton groupSpeedButton;
        private System.Windows.Forms.ToolStripLabel nameLabel;
        private System.Windows.Forms.ToolStripTextBox nameTextBox;
        private System.Windows.Forms.ToolStripButton applyNameSpeedButton;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRandomColorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox rgbRedTextBox;
        private System.Windows.Forms.ToolStripTextBox rgbGreenTextBox;
        private System.Windows.Forms.ToolStripTextBox rgbBlueTextBox;
        private System.Windows.Forms.ToolStripTextBox rgbAlphaTextBox;
        private System.Windows.Forms.ToolStripButton applyColorFromRGB;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ColorPalleteSpeedButton;
        private System.Windows.Forms.ToolStripButton UngroupSpeedButton;
        private System.Windows.Forms.ToolStripButton drawTriangleSpeedButton;
    }
}

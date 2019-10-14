namespace _1753081_Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ViewIcons = new System.Windows.Forms.ToolStripButton();
            this.ViewLists = new System.Windows.Forms.ToolStripButton();
            this.ViewDetails = new System.Windows.Forms.ToolStripButton();
            this.driveLeft = new System.Windows.Forms.ComboBox();
            this.driveRight = new System.Windows.Forms.ComboBox();
            this.addressLeft = new System.Windows.Forms.TextBox();
            this.addressRight = new System.Windows.Forms.TextBox();
            this.listLeft = new System.Windows.Forms.ListView();
            this.NameLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listRight = new System.Windows.Forms.ListView();
            this.NameRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseClick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.newFolderToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Enabled = false;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Enabled = false;
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.ViewIcons,
            this.ViewLists,
            this.ViewDetails});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.RefreshButton.Size = new System.Drawing.Size(31, 29);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ViewIcons
            // 
            this.ViewIcons.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewIcons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewIcons.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ViewIcons.Image = ((System.Drawing.Image)(resources.GetObject("ViewIcons.Image")));
            this.ViewIcons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewIcons.Margin = new System.Windows.Forms.Padding(5, 1, 10, 2);
            this.ViewIcons.Name = "ViewIcons";
            this.ViewIcons.Size = new System.Drawing.Size(29, 29);
            this.ViewIcons.Text = "View Icons";
            this.ViewIcons.Click += new System.EventHandler(this.ViewIcons_Click);
            // 
            // ViewLists
            // 
            this.ViewLists.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewLists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewLists.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ViewLists.Image = ((System.Drawing.Image)(resources.GetObject("ViewLists.Image")));
            this.ViewLists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewLists.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.ViewLists.Name = "ViewLists";
            this.ViewLists.Size = new System.Drawing.Size(29, 29);
            this.ViewLists.Text = "View Lists";
            this.ViewLists.Click += new System.EventHandler(this.ViewLists_Click);
            // 
            // ViewDetails
            // 
            this.ViewDetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewDetails.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ViewDetails.Image = ((System.Drawing.Image)(resources.GetObject("ViewDetails.Image")));
            this.ViewDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewDetails.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(29, 29);
            this.ViewDetails.Text = "View Details";
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // driveLeft
            // 
            this.driveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveLeft.FormattingEnabled = true;
            this.driveLeft.Location = new System.Drawing.Point(0, 63);
            this.driveLeft.Name = "driveLeft";
            this.driveLeft.Size = new System.Drawing.Size(60, 23);
            this.driveLeft.TabIndex = 2;
            this.driveLeft.SelectedIndexChanged += new System.EventHandler(this.driveLeft_SelectedIndexChanged);
            this.driveLeft.Click += new System.EventHandler(this.Form1_Click);
            this.driveLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftSelect);
            // 
            // driveRight
            // 
            this.driveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveRight.FormattingEnabled = true;
            this.driveRight.Location = new System.Drawing.Point(425, 63);
            this.driveRight.Name = "driveRight";
            this.driveRight.Size = new System.Drawing.Size(60, 23);
            this.driveRight.TabIndex = 5;
            this.driveRight.SelectedIndexChanged += new System.EventHandler(this.driveRight_SelectedIndexChanged);
            this.driveRight.Click += new System.EventHandler(this.Form1_Click);
            this.driveRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightSelect);
            // 
            // addressLeft
            // 
            this.addressLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLeft.Location = new System.Drawing.Point(66, 64);
            this.addressLeft.Name = "addressLeft";
            this.addressLeft.Size = new System.Drawing.Size(354, 21);
            this.addressLeft.TabIndex = 6;
            this.addressLeft.Click += new System.EventHandler(this.Form1_Click);
            this.addressLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftSelect);
            this.addressLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressLeft_KeyPress);
            // 
            // addressRight
            // 
            this.addressRight.BackColor = System.Drawing.Color.White;
            this.addressRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressRight.Location = new System.Drawing.Point(490, 64);
            this.addressRight.Name = "addressRight";
            this.addressRight.Size = new System.Drawing.Size(354, 21);
            this.addressRight.TabIndex = 7;
            this.addressRight.Click += new System.EventHandler(this.Form1_Click);
            this.addressRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightSelect);
            this.addressRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressRight_KeyPress);
            // 
            // listLeft
            // 
            this.listLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameLeft,
            this.DateLeft,
            this.SizeLeft});
            this.listLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.listLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLeft.FullRowSelect = true;
            this.listLeft.LargeImageList = this.imageList2;
            this.listLeft.Location = new System.Drawing.Point(0, 92);
            this.listLeft.Name = "listLeft";
            this.listLeft.Size = new System.Drawing.Size(420, 456);
            this.listLeft.SmallImageList = this.imageList1;
            this.listLeft.TabIndex = 8;
            this.listLeft.UseCompatibleStateImageBehavior = false;
            this.listLeft.Click += new System.EventHandler(this.Form1_Click);
            this.listLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftSelect);
            this.listLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listLeft_MouseDoubleClick);
            // 
            // NameLeft
            // 
            this.NameLeft.Text = "Name";
            this.NameLeft.Width = 200;
            // 
            // DateLeft
            // 
            this.DateLeft.Text = "Date Modified";
            this.DateLeft.Width = 150;
            // 
            // SizeLeft
            // 
            this.SizeLeft.Text = "Size";
            this.SizeLeft.Width = 80;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Back.png");
            this.imageList2.Images.SetKeyName(1, "Folder.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "Back.png");
            this.imageList1.Images.SetKeyName(1, "Folder.png");
            // 
            // listRight
            // 
            this.listRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameRight,
            this.DateRight,
            this.SizeRight});
            this.listRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRight.FullRowSelect = true;
            this.listRight.LargeImageList = this.imageList2;
            this.listRight.Location = new System.Drawing.Point(425, 92);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(420, 456);
            this.listRight.SmallImageList = this.imageList1;
            this.listRight.TabIndex = 9;
            this.listRight.UseCompatibleStateImageBehavior = false;
            this.listRight.Click += new System.EventHandler(this.Form1_Click);
            this.listRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightSelect);
            this.listRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRight_MouseDoubleClick);
            // 
            // NameRight
            // 
            this.NameRight.Text = "Name";
            this.NameRight.Width = 200;
            // 
            // DateRight
            // 
            this.DateRight.Text = "Date";
            this.DateRight.Width = 150;
            // 
            // SizeRight
            // 
            this.SizeRight.Text = "Size";
            this.SizeRight.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.newFolderToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 202);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.Form1_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Enabled = false;
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Enabled = false;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Enabled = false;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // newFolderToolStripMenuItem1
            // 
            this.newFolderToolStripMenuItem1.Enabled = false;
            this.newFolderToolStripMenuItem1.Name = "newFolderToolStripMenuItem1";
            this.newFolderToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newFolderToolStripMenuItem1.Text = "New Folder";
            this.newFolderToolStripMenuItem1.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Enabled = false;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Enabled = false;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 551);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listRight);
            this.Controls.Add(this.listLeft);
            this.Controls.Add(this.addressRight);
            this.Controls.Add(this.addressLeft);
            this.Controls.Add(this.driveRight);
            this.Controls.Add(this.driveLeft);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Project 1 - Total Commander";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox driveLeft;
        private System.Windows.Forms.ComboBox driveRight;
        private System.Windows.Forms.TextBox addressLeft;
        private System.Windows.Forms.TextBox addressRight;
        private System.Windows.Forms.ListView listLeft;
        private System.Windows.Forms.ListView listRight;
        private System.Windows.Forms.ColumnHeader NameLeft;
        private System.Windows.Forms.ColumnHeader SizeLeft;
        private System.Windows.Forms.ColumnHeader DateLeft;
        private System.Windows.Forms.ColumnHeader NameRight;
        private System.Windows.Forms.ColumnHeader DateRight;
        private System.Windows.Forms.ColumnHeader SizeRight;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ViewIcons;
        private System.Windows.Forms.ToolStripButton ViewLists;
        private System.Windows.Forms.ToolStripButton ViewDetails;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}


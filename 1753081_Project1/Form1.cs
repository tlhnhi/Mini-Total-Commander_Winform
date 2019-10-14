using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _1753081_Project1
{
    public partial class Form1 : Form
    {
        bool LeftSelected = true;

        enum ViewStyle
        {
            details,
            icons,
            lists,
        };
        ViewStyle ViewStyleLeft, ViewStyleRight;

        public Form1()
        {
            InitializeComponent();
        }

        private void viewListLeft()
        {
            switch (ViewStyleLeft)
            {
                case (ViewStyle.details): listLeft.View = View.Details; break;
                case (ViewStyle.icons): listLeft.View = View.LargeIcon; break;
                case (ViewStyle.lists): listLeft.View = View.List; break;
            }
        }
        private void viewListRight()
        {
            switch (ViewStyleRight)
            {
                case (ViewStyle.details): listRight.View = View.Details; break;
                case (ViewStyle.icons): listRight.View = View.LargeIcon; break;
                case (ViewStyle.lists): listRight.View = View.List; break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo dr in DriveInfo.GetDrives())
            {
                driveLeft.Items.Add(dr);
                driveRight.Items.Add(dr);
            }
        }

        private void LeftSelect(object sender, MouseEventArgs e)
        {
            LeftSelected = true;
            listRight.SelectedItems.Clear();
            if (listLeft.SelectedItems.Count == 0)
                moveToolStripMenuItem.Enabled = false;
            else moveToolStripMenuItem.Enabled = true;
        }
        private void RightSelect(object sender, MouseEventArgs e)
        {
            LeftSelected = false;
            listLeft.SelectedItems.Clear();
            if (listRight.SelectedItems.Count == 0)
                moveToolStripMenuItem.Enabled = false;
            else moveToolStripMenuItem.Enabled = true;
        }

        private void driveLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            listLeft.Items.Clear();
            newFolderToolStripMenuItem.Enabled = true;
            try
            {
                addressLeft.Text = driveLeft.SelectedItem.ToString();
                DriveInfo drive = (DriveInfo)driveLeft.SelectedItem;
                foreach (DirectoryInfo diInfo in drive.RootDirectory.GetDirectories())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = diInfo.Name;
                    item.ImageIndex = 1;
                    item.SubItems.Add(diInfo.LastWriteTime.ToString());
                    listLeft.Items.Add(item);
                }
                foreach (FileInfo fi in drive.RootDirectory.GetFiles())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.SubItems.Add(fi.LastWriteTime.ToString());
                    item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                    string ext = fi.Extension;
                    if (!imageList1.Images.Keys.Contains(ext))
                    {
                        imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                    }
                    int index = imageList1.Images.Keys.IndexOf(ext);
                    item.ImageIndex = index;

                    listLeft.Items.Add(item);
                }
                viewListLeft();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void driveRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            listRight.Items.Clear();
            newFolderToolStripMenuItem.Enabled = true;
            try
            {
                addressRight.Text = driveRight.SelectedItem.ToString();
                DriveInfo drive = (DriveInfo)driveRight.SelectedItem;
                foreach (DirectoryInfo diInfo in drive.RootDirectory.GetDirectories())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = diInfo.Name;
                    item.ImageIndex = 1;
                    item.SubItems.Add(diInfo.LastWriteTime.ToString());
                    listRight.Items.Add(item);
                }
                foreach (FileInfo fi in drive.RootDirectory.GetFiles())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.SubItems.Add(fi.LastWriteTime.ToString());
                    item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                    string ext = fi.Extension;
                    if (!imageList1.Images.Keys.Contains(ext))
                    {
                        imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                    }
                    int index = imageList1.Images.Keys.IndexOf(ext);
                    item.ImageIndex = index;

                    listRight.Items.Add(item);
                }
                viewListRight();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listLeft.SelectedItems.Count < 1) return;
                DirectoryInfo dir;
                if (listLeft.SelectedItems[0].Text == " ..")
                {
                    dir = new DirectoryInfo(addressLeft.Text);
                    dir = dir.Parent;
                    addressLeft.Text = dir.FullName;
                }
                else
                {
                    addressLeft.Text = addressLeft.Text + listLeft.SelectedItems[0].Text;
                    dir = new DirectoryInfo(addressLeft.Text);
                    addressLeft.Text = dir.FullName;
                }
                listLeft.Items.Clear();

                if (dir.Name != dir.Root.Name)
                {
                    ListViewItem itemBack = new ListViewItem();
                    itemBack.Text = " ..";
                    itemBack.ImageIndex = 0;
                    listLeft.Items.Add(itemBack);
                    addressLeft.Text += @"\";
                }

                foreach (DirectoryInfo diInfo in dir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = diInfo.Name;
                    item.ImageIndex = 1;
                    item.SubItems.Add(diInfo.LastWriteTime.ToString());
                    listLeft.Items.Add(item);
                }
                foreach (FileInfo fi in dir.GetFiles())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.SubItems.Add(fi.LastWriteTime.ToString());
                    item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                    string ext = fi.Extension;
                    if (!imageList1.Images.Keys.Contains(ext))
                    {
                        imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                    }
                    int index = imageList1.Images.Keys.IndexOf(ext);
                    item.ImageIndex = index;

                    listLeft.Items.Add(item);
                }
                viewListLeft();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listRight.SelectedItems.Count < 1) return;
                DirectoryInfo dir;
                if (listRight.SelectedItems[0].Text == " ..")
                {
                    dir = new DirectoryInfo(addressRight.Text);
                    dir = dir.Parent;
                    addressRight.Text = dir.FullName;
                }
                else
                {
                    addressRight.Text = addressRight.Text + listRight.SelectedItems[0].Text;
                    dir = new DirectoryInfo(addressRight.Text);
                    addressRight.Text = dir.FullName;
                }
                listRight.Items.Clear();

                if (dir.Name != dir.Root.Name)
                {
                    ListViewItem itemBack = new ListViewItem();
                    itemBack.Text = " ..";
                    itemBack.ImageIndex = 0;
                    listRight.Items.Add(itemBack);
                    addressRight.Text += @"\";
                }

                foreach (DirectoryInfo diInfo in dir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = diInfo.Name;
                    item.ImageIndex = 1;
                    item.SubItems.Add(diInfo.LastWriteTime.ToString());
                    listRight.Items.Add(item);
                }
                foreach (FileInfo fi in dir.GetFiles())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.SubItems.Add(fi.LastWriteTime.ToString());
                    item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                    string ext = fi.Extension;
                    if (!imageList1.Images.Keys.Contains(ext))
                    {
                        imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                    }
                    int index = imageList1.Images.Keys.IndexOf(ext);
                    item.ImageIndex = index;

                    listRight.Items.Add(item);
                }
                viewListRight();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addressLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(addressLeft.Text);
                    driveLeft.SelectedIndex = driveLeft.FindString(dir.Root.ToString());
                    driveLeft_SelectedIndexChanged(sender, e);

                    listLeft.Items.Clear();

                    if (dir.Name != dir.Root.Name)
                    {
                        ListViewItem itemBack = new ListViewItem();
                        itemBack.Text = " ..";
                        itemBack.ImageIndex = 0;
                        listLeft.Items.Add(itemBack);
                    }

                    foreach (DirectoryInfo diInfo in dir.GetDirectories())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = diInfo.Name;
                        item.ImageIndex = 1;
                        item.SubItems.Add(diInfo.LastWriteTime.ToString());
                        listLeft.Items.Add(item);
                    }
                    foreach (FileInfo fi in dir.GetFiles())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = fi.Name;
                        item.SubItems.Add(fi.LastWriteTime.ToString());
                        item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                        string ext = fi.Extension;
                        if (!imageList1.Images.Keys.Contains(ext))
                        {
                            imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                            imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        }
                        int index = imageList1.Images.Keys.IndexOf(ext);
                        item.ImageIndex = index;

                        listLeft.Items.Add(item);
                    }
                    viewListLeft();
                    addressLeft.Text = dir.FullName;
                    if (addressLeft.Text[addressLeft.Text.Length - 1] != '\\')
                        addressLeft.Text += @"\";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void addressRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(addressRight.Text);
                    driveRight.SelectedIndex = driveRight.FindString(dir.Root.ToString());
                    driveRight_SelectedIndexChanged(sender, e);

                    listRight.Items.Clear();

                    if (dir.Name != dir.Root.Name)
                    {
                        ListViewItem itemBack = new ListViewItem();
                        itemBack.Text = " ..";
                        itemBack.ImageIndex = 0;
                        listRight.Items.Add(itemBack);
                    }

                    foreach (DirectoryInfo diInfo in dir.GetDirectories())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = diInfo.Name;
                        item.ImageIndex = 1;
                        item.SubItems.Add(diInfo.LastWriteTime.ToString());
                        listRight.Items.Add(item);
                    }
                    foreach (FileInfo fi in dir.GetFiles())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = fi.Name;
                        item.SubItems.Add(fi.LastWriteTime.ToString());
                        item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                        string ext = fi.Extension;
                        if (!imageList1.Images.Keys.Contains(ext))
                        {
                            imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                            imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        }
                        int index = imageList1.Images.Keys.IndexOf(ext);
                        item.ImageIndex = index;

                        listRight.Items.Add(item);
                    }
                    viewListRight();
                    addressRight.Text = dir.FullName;
                    if (addressRight.Text[addressRight.Text.Length - 1] != '\\')
                        addressRight.Text += @"\";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            if (LeftSelected)
            {
                ViewStyleLeft = ViewStyle.details;
                viewListLeft();
            }
            else
            {
                ViewStyleRight = ViewStyle.details;
                viewListRight();
            }
        }

        private void ViewLists_Click(object sender, EventArgs e)
        {
            if (LeftSelected)
            {
                ViewStyleLeft = ViewStyle.lists;
                viewListLeft();
            }
            else
            {
                ViewStyleRight = ViewStyle.lists;
                viewListRight();
            }
        }

        private void ViewIcons_Click(object sender, EventArgs e)
        {
            if (LeftSelected)
            {
                ViewStyleLeft = ViewStyle.icons;
                viewListLeft();
            }
            else
            {
                ViewStyleRight = ViewStyle.icons;
                viewListRight();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir;
                if (addressLeft.Text.Length != 0)
                {
                    dir = new DirectoryInfo(addressLeft.Text);
                    listLeft.Items.Clear();

                    if (dir.Name != dir.Root.Name)
                    {
                        ListViewItem itemBack = new ListViewItem();
                        itemBack.Text = " ..";
                        itemBack.ImageIndex = 0;
                        listLeft.Items.Add(itemBack);
                    }

                    foreach (DirectoryInfo diInfo in dir.GetDirectories())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = diInfo.Name;
                        item.ImageIndex = 1;
                        item.SubItems.Add(diInfo.LastWriteTime.ToString());
                        listLeft.Items.Add(item);
                    }
                    foreach (FileInfo fi in dir.GetFiles())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = fi.Name;
                        item.SubItems.Add(fi.LastWriteTime.ToString());
                        item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                        string ext = fi.Extension;
                        if (!imageList1.Images.Keys.Contains(ext))
                        {
                            imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                            imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        }
                        int index = imageList1.Images.Keys.IndexOf(ext);
                        item.ImageIndex = index;

                        listLeft.Items.Add(item);
                    }
                    viewListLeft();
                }

                if (addressRight.Text.Length != 0)
                {
                    dir = new DirectoryInfo(addressRight.Text);
                    listRight.Items.Clear();

                    if (dir.Name != dir.Root.Name)
                    {
                        ListViewItem itemBack = new ListViewItem();
                        itemBack.Text = " ..";
                        itemBack.ImageIndex = 0;
                        listRight.Items.Add(itemBack);
                    }

                    foreach (DirectoryInfo diInfo in dir.GetDirectories())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = diInfo.Name;
                        item.ImageIndex = 1;
                        item.SubItems.Add(diInfo.LastWriteTime.ToString());
                        listRight.Items.Add(item);
                    }
                    foreach (FileInfo fi in dir.GetFiles())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = fi.Name;
                        item.SubItems.Add(fi.LastWriteTime.ToString());
                        item.SubItems.Add((fi.Length / 1024).ToString() + "KB");

                        string ext = fi.Extension;
                        if (!imageList1.Images.Keys.Contains(ext))
                        {
                            imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                            imageList2.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                        }
                        int index = imageList1.Images.Keys.IndexOf(ext);
                        item.ImageIndex = index;

                        listRight.Items.Add(item);
                    }
                    viewListRight();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 2;
            if (LeftSelected)
            {
                ListViewItem item = new ListViewItem();
                bool exist = Directory.Exists(addressLeft.Text + "New folder");
                if (!exist)
                {
                    Directory.CreateDirectory(addressLeft.Text + "New folder");
                    item.Text = "New folder";
                }
                else
                {
                    exist = Directory.Exists(addressLeft.Text + "New folder (" + i + ")");
                    while (exist)
                    {
                        i++;
                        exist = Directory.Exists(addressLeft.Text + "New folder (" + i + ")");
                    }
                    Directory.CreateDirectory(addressLeft.Text + "New folder (" + i + ")");
                    item.Text = "New folder (" + i + ")";
                }
                item.ImageIndex = 1;
                listLeft.Items.Add(item);
                listLeft.SelectedItems.Clear();
                listLeft.SelectedIndices.Add(listLeft.Items.Count - 1);
                viewListLeft();
            }
            else
            {
                ListViewItem item = new ListViewItem();
                bool exist = Directory.Exists(addressRight.Text + "New folder");
                if (!exist)
                {
                    Directory.CreateDirectory(addressRight.Text + "New folder");
                    item.Text = "New folder";
                }
                else
                {
                    exist = Directory.Exists(addressRight.Text + "New folder (" + i + ")");
                    while (exist)
                    {
                        i++;
                        exist = Directory.Exists(addressRight.Text + "New folder (" + i + ")");
                    }
                    Directory.CreateDirectory(addressRight.Text + "New folder (" + i + ")");
                    item.Text = "New folder (" + i + ")";
                }
                item.ImageIndex = 1;
                listRight.Items.Add(item);
                listRight.SelectedItems.Clear();
                listRight.SelectedIndices.Add(listRight.Items.Count - 1);
                viewListRight();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath;

                if (LeftSelected)
                {
                    foreach (ListViewItem item in listLeft.SelectedItems)
                    {
                        filePath = addressLeft.Text + item.Text;
                        if (!File.Exists(filePath))
                        {
                            MessageBox.Show("Cannot find the file '" + filePath + "'!");
                            continue;
                        }
                        ViewFile formView = new ViewFile(filePath);
                        formView.Text = "[View] " + item.Text;
                        formView.ShowDialog();
                    }
                }
                else
                {
                    foreach (ListViewItem item in listRight.SelectedItems)
                    {
                        filePath = addressRight.Text + item.Text;
                        if (!File.Exists(filePath))
                        {
                            MessageBox.Show("Cannot find the file '" + filePath + "'!");
                            continue;
                        }
                        ViewFile formView = new ViewFile(filePath);
                        formView.Text = "[View] " + item.Text;
                        formView.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listLeft.SelectedItems.Count == 0 && listRight.SelectedItems.Count == 0)
            {
                viewToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                moveToolStripMenuItem.Enabled = false;
                newFolderToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = false;

                viewToolStripMenuItem1.Enabled = false;
                editToolStripMenuItem1.Enabled = false;
                copyToolStripMenuItem1.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                newFolderToolStripMenuItem1.Enabled = true;
                deleteToolStripMenuItem1.Enabled = false;
                renameToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                moveToolStripMenuItem.Enabled = true;
                newFolderToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = true;

                copyToolStripMenuItem1.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                newFolderToolStripMenuItem1.Enabled = false;
                deleteToolStripMenuItem1.Enabled = true;
                renameToolStripMenuItem.Enabled = true;

                viewToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                viewToolStripMenuItem1.Enabled = false;
                editToolStripMenuItem1.Enabled = false;
                if (LeftSelected)
                    foreach (ListViewItem item in listLeft.SelectedItems)
                        if (File.Exists(addressLeft.Text + item.Text))
                        {
                            viewToolStripMenuItem.Enabled = true;
                            editToolStripMenuItem.Enabled = true;
                            viewToolStripMenuItem1.Enabled = true;
                            editToolStripMenuItem1.Enabled = true;
                            break;
                        }
                        else { }
                else foreach (ListViewItem item in listRight.SelectedItems)
                        if (File.Exists(addressRight.Text + item.Text))
                        {
                            viewToolStripMenuItem.Enabled = true;
                            editToolStripMenuItem.Enabled = true;
                            viewToolStripMenuItem1.Enabled = true;
                            editToolStripMenuItem1.Enabled = true;
                            break;
                        }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LeftSelected)
                {
                    foreach (ListViewItem item in listLeft.SelectedItems)
                        if (Directory.Exists(addressLeft.Text + item.Text))
                        {
                            DirectoryInfo dir = new DirectoryInfo(addressLeft.Text + item.Text);
                            if (MessageBox.Show("Do you want to delete folder '" + dir.FullName + "'?",
                                "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                if (dir.GetDirectories().Length != 0)
                                    if (MessageBox.Show("The folder '" + dir.FullName + "' has content. Continue?",
                                        "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.No)
                                    {
                                        listLeft.SelectedIndices.Remove(item.Index);
                                        continue;
                                    }
                                Directory.Delete(addressLeft.Text + item.Text, true);
                            }
                            else listLeft.SelectedIndices.Remove(item.Index);
                        }
                        else
                        {
                            if (File.Exists(addressLeft.Text + item.Text))
                                if (MessageBox.Show("Do you want to delete file '" + addressLeft.Text + item.Text + "'? ",
                                    "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    File.Delete(addressLeft.Text + item.Text);
                                else listLeft.SelectedIndices.Remove(item.Index);

                        }
                    for (int i = listLeft.Items.Count - 1; i >= 0; i--)
                        if (listLeft.Items[i].Selected) listLeft.Items[i].Remove();
                    viewListLeft();
                }
                else
                {
                    foreach (ListViewItem item in listRight.SelectedItems)
                        if (Directory.Exists(addressRight.Text + item.Text))
                        {
                            DirectoryInfo dir = new DirectoryInfo(addressRight.Text + item.Text);
                            if (MessageBox.Show("Do you want to delete folder '" + dir.FullName + "'?",
                                "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                if (dir.GetDirectories().Length != 0)
                                    if (MessageBox.Show("The folder '" + dir.FullName + "' has content. Continue?",
                                        "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.No)
                                    {
                                        listRight.SelectedIndices.Remove(item.Index);
                                        continue;
                                    }
                                Directory.Delete(addressRight.Text + item.Text, true);
                            }
                            else listRight.SelectedIndices.Remove(item.Index);
                        }
                        else
                        {
                            if (File.Exists(addressRight.Text + item.Text))
                                if (MessageBox.Show("Do you want to delete file '" + addressRight.Text + item.Text + "'? ",
                                    "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    File.Delete(addressRight.Text + item.Text);
                                else listRight.SelectedIndices.Remove(item.Index);

                        }
                    for (int i = listRight.Items.Count - 1; i >= 0; i--)
                        if (listRight.Items[i].Selected) listRight.Items[i].Remove();
                    viewListRight();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Help.pdf");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LeftSelected)
                {
                    foreach (ListViewItem item in listLeft.SelectedItems)
                    {
                        if (File.Exists(addressLeft.Text + item.Text))
                            System.Diagnostics.Process.Start("notepad.exe", addressLeft.Text + item.Text);
                        else
                            MessageBox.Show("Cannot open file '" + addressLeft.Text + item.Text + "'!");
                    }
                }
                else
                {
                    foreach (ListViewItem item in listRight.SelectedItems)
                    {
                        if (File.Exists(addressRight.Text + item.Text))
                            System.Diagnostics.Process.Start("notepad.exe", addressRight.Text + item.Text);
                        else
                            MessageBox.Show("Cannot open file '" + addressRight.Text + item.Text + "'!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyAll(DirectoryInfo source, DirectoryInfo destination)
        {
            Directory.CreateDirectory(destination.FullName);

            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                DirectoryInfo desSubDir = destination.CreateSubdirectory(dir.Name);
                copyAll(dir, desSubDir);
            }
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(destination.FullName, fi.Name), true);
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool OverwriteAll = false, SkipAll = false;
            DialogResult OoSResult = DialogResult.No;
            if (LeftSelected)
                foreach (ListViewItem item in listLeft.SelectedItems)
                {
                    try
                    {
                        bool exist = Directory.Exists(addressLeft.Text + item.Text);
                        if (exist)
                        {
                            DirectoryInfo dir = new DirectoryInfo(addressLeft.Text + item.Text);
                            DirectoryInfo[] subdirs = dir.GetDirectories();
                            if (subdirs.Length != 0)
                            {
                                if (MessageBox.Show("Do you want to copy this folder and all its sub-folders/files?", "Copy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    bool flag = false;
                                    if (Directory.Exists(addressRight.Text + item.Text))
                                    {
                                        if (!OverwriteAll && !SkipAll)
                                        {
                                            flag = true;
                                            Duplicated OoSMessBox = new Duplicated("'" + item.Text +
                                                "' already exists in '" + addressRight.Text + "'.");
                                            OoSResult = OoSMessBox.ShowDialog();
                                        }
                                        switch (OoSResult)
                                        {
                                            case DialogResult.Yes: Directory.Delete(addressRight.Text + item.Text, true); break;
                                            case DialogResult.No: continue;
                                            case DialogResult.OK:
                                                Directory.Delete(addressRight.Text + item.Text, true);
                                                OverwriteAll = true; break;
                                            case DialogResult.Cancel: SkipAll = true; continue;
                                        }
                                    }
                                    DirectoryInfo source = new DirectoryInfo(addressLeft.Text + item.Text),
                                    destination = new DirectoryInfo(addressRight.Text + item.Text);
                                    copyAll(source, destination);
                                    if (!flag) listRight.Items.Add((ListViewItem)item.Clone());
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Do you want to copy this folder?", "Copy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    bool flag = false;
                                    if (File.Exists(addressRight.Text + item.Text))
                                    {
                                        if (!OverwriteAll && !SkipAll)
                                        {
                                            flag = true;
                                            Duplicated OoSMessBox = new Duplicated("'" + item.Text +
                                                "' already exists in '" + addressRight.Text + "'.");
                                            OoSResult = OoSMessBox.ShowDialog();
                                        }
                                        switch (OoSResult)
                                        {
                                            case DialogResult.Yes: Directory.Delete(addressRight.Text + item.Text, true); break;
                                            case DialogResult.No: continue;
                                            case DialogResult.OK:
                                                Directory.Delete(addressRight.Text + item.Text, true);
                                                OverwriteAll = true; break;
                                            case DialogResult.Cancel: SkipAll = true; continue;
                                        }
                                    }
                                    Directory.CreateDirectory(addressRight.Text + item.Text);
                                    if (!flag) listRight.Items.Add((ListViewItem)item.Clone());
                                }
                            }
                        }
                        else
                        {
                            exist = File.Exists(addressLeft.Text + item.Text);
                            if (exist)
                            {
                                if (MessageBox.Show("Do you want to copy this file?", "Copy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    bool flag = false;
                                    if (File.Exists(addressRight.Text + item.Text))
                                    {
                                        if (!OverwriteAll && !SkipAll)
                                        {
                                            flag = true;
                                            Duplicated OoSMessBox = new Duplicated("'" + item.Text +
                                                "' already exists in '" + addressRight.Text + "'.");
                                            OoSResult = OoSMessBox.ShowDialog();
                                        }
                                        switch (OoSResult)
                                        {
                                            case DialogResult.Yes: File.Delete(addressRight.Text + item.Text); break;
                                            case DialogResult.No: continue;
                                            case DialogResult.OK:
                                                File.Delete(addressRight.Text + item.Text);
                                                OverwriteAll = true; break;
                                            case DialogResult.Cancel: SkipAll = true; continue;
                                        }
                                    }
                                    File.Copy(addressLeft.Text + item.Text, addressRight.Text + item.Text);
                                    if (!flag) listRight.Items.Add((ListViewItem)item.Clone());
                                }
                            }
                        }
                        viewListRight();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            else
            {
                foreach (ListViewItem item in listRight.SelectedItems)
                {
                    try
                    {
                        bool exist = Directory.Exists(addressRight.Text + item.Text);
                        if (exist)
                        {

                            DirectoryInfo dir = new DirectoryInfo(addressRight.Text + item.Text);
                            DirectoryInfo[] subdirs = dir.GetDirectories();
                            if (subdirs.Length != 0)
                            {
                                if (MessageBox.Show("Do you want to copy this folder and all its sub-folders/files?", "Copy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    bool flag = false;
                                    if (Directory.Exists(addressLeft.Text + item.Text))
                                    {
                                        if (!OverwriteAll && !SkipAll)
                                        {
                                            flag = true;
                                            Duplicated OoSMessBox = new Duplicated("'" + item.Text +
                                                "' already exists in '" + addressLeft.Text + "'.");
                                            OoSResult = OoSMessBox.ShowDialog();
                                        }
                                        switch (OoSResult)
                                        {
                                            case DialogResult.Yes: Directory.Delete(addressLeft.Text + item.Text, true); break;
                                            case DialogResult.No: continue;
                                            case DialogResult.OK:
                                                Directory.Delete(addressLeft.Text + item.Text, true);
                                                OverwriteAll = true; break;
                                            case DialogResult.Cancel: SkipAll = true; continue;
                                        }
                                    }
                                    DirectoryInfo source = new DirectoryInfo(addressRight.Text + item.Text),
                                    destination = new DirectoryInfo(addressLeft.Text + item.Text);
                                    copyAll(source, destination);
                                    if (!flag) listLeft.Items.Add((ListViewItem)item.Clone());
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Do you want to copy this folder?", "Copy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    bool flag = false;
                                    if (Directory.Exists(addressLeft.Text + item.Text))
                                    {
                                        if (!OverwriteAll && !SkipAll)
                                        {
                                            flag = true;
                                            Duplicated OoSMessBox = new Duplicated("'" + item.Text +
                                                "' already exists in '" + addressLeft.Text + "'.");
                                            OoSResult = OoSMessBox.ShowDialog();
                                        }
                                        switch (OoSResult)
                                        {
                                            case DialogResult.Yes: Directory.Delete(addressLeft.Text + item.Text, true); break;
                                            case DialogResult.No: continue;
                                            case DialogResult.OK:
                                                Directory.Delete(addressLeft.Text + item.Text, true);
                                                OverwriteAll = true; break;
                                            case DialogResult.Cancel: SkipAll = true; continue;
                                        }
                                    }
                                    Directory.CreateDirectory(addressLeft.Text + item.Text);
                                    if (!flag) listLeft.Items.Add((ListViewItem)item.Clone());
                                }
                            }
                        }
                        else
                        {
                            exist = File.Exists(addressRight.Text + item.Text);
                            if (exist)
                            {
                                if (MessageBox.Show("Do you want to copy this file?", "Copy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    bool flag = false;
                                    if (File.Exists(addressLeft.Text + item.Text))
                                    {
                                        if (!OverwriteAll && !SkipAll)
                                        {
                                            flag = true;
                                            Duplicated OoSMessBox = new Duplicated("'" + item.Text +
                                                "' already exists in '" + addressLeft.Text + "'.");
                                            OoSResult = OoSMessBox.ShowDialog();
                                        }
                                        switch (OoSResult)
                                        {
                                            case DialogResult.Yes: File.Delete(addressLeft.Text + item.Text); break;
                                            case DialogResult.No: continue;
                                            case DialogResult.OK:
                                                File.Delete(addressLeft.Text + item.Text);
                                                OverwriteAll = true; break;
                                            case DialogResult.Cancel: SkipAll = true; continue;
                                        }
                                    }
                                    File.Copy(addressRight.Text + item.Text, addressLeft.Text + item.Text);
                                    if (!flag) listLeft.Items.Add((ListViewItem)item.Clone());
                                }
                            }
                        }
                        viewListLeft();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (listLeft.SelectedItems.Count == 0 && listRight.SelectedItems.Count == 0)
            {
                viewToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                moveToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                newFolderToolStripMenuItem.Enabled = true;

                viewToolStripMenuItem1.Enabled = false;
                editToolStripMenuItem1.Enabled = false;
                copyToolStripMenuItem1.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                newFolderToolStripMenuItem1.Enabled = true;
                deleteToolStripMenuItem1.Enabled = false;
                renameToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                moveToolStripMenuItem.Enabled = true;
                newFolderToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = true;

                copyToolStripMenuItem1.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                newFolderToolStripMenuItem1.Enabled = false;
                deleteToolStripMenuItem1.Enabled = true;
                renameToolStripMenuItem.Enabled = true;

                viewToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                viewToolStripMenuItem1.Enabled = false;
                editToolStripMenuItem1.Enabled = false;
                if (LeftSelected)
                    foreach (ListViewItem item in listLeft.SelectedItems)
                        if (File.Exists(addressLeft.Text + item.Text))
                        {
                            viewToolStripMenuItem.Enabled = true;
                            editToolStripMenuItem.Enabled = true;
                            viewToolStripMenuItem1.Enabled = true;
                            editToolStripMenuItem1.Enabled = true;
                            break;
                        }
                        else { }
                else foreach (ListViewItem item in listRight.SelectedItems)
                        if (File.Exists(addressRight.Text + item.Text))
                        {
                            viewToolStripMenuItem.Enabled = true;
                            editToolStripMenuItem.Enabled = true;
                            viewToolStripMenuItem1.Enabled = true;
                            editToolStripMenuItem1.Enabled = true;
                            break;
                        }
            }
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = "";
                bool OverwriteAll = false, SkipAll = false;
                DialogResult duplicatedSolve = DialogResult.No;
                if (LeftSelected)
                {
                    if (listLeft.SelectedItems.Count < 2)
                        mess = "Do you want to move '" + listLeft.SelectedItems[0].Text + "' from '" +
                                   addressLeft.Text + "' to '" + addressRight.Text + "'?";
                    else mess = "Do you want to move " + listLeft.SelectedItems.Count + " items from '" +
                                   addressLeft.Text + "' to '" + addressRight.Text + "'?";
                    if (MessageBox.Show(mess, "Confirm Move", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    foreach (ListViewItem item in listLeft.SelectedItems)
                    {
                        if (Directory.Exists(addressLeft.Text + item.Text))
                        {
                            if (Directory.Exists(addressRight.Text + item.Text))
                            {
                                if (!OverwriteAll && !SkipAll)
                                {
                                    Duplicated dupMessBox = new Duplicated("'" + item.Text +
                                        "' already exists in '" + addressRight.Text + "'.");
                                    duplicatedSolve = dupMessBox.ShowDialog();
                                }
                                switch (duplicatedSolve)
                                {
                                    case DialogResult.Yes: Directory.Delete(addressRight.Text + item.Text, true); break;
                                    case DialogResult.No: continue;
                                    case DialogResult.OK:
                                        Directory.Delete(addressRight.Text + item.Text, true);
                                        OverwriteAll = true; break;
                                    case DialogResult.Cancel: SkipAll = true; continue;
                                }
                            }
                            Directory.Move(addressLeft.Text + item.Text, addressRight.Text + item.Text);
                        }
                        else if (File.Exists(addressLeft.Text + item.Text))
                        {
                            if (File.Exists(addressRight.Text + item.Text))
                            {
                                if (!OverwriteAll && !SkipAll)
                                {
                                    Duplicated dupMessBox = new Duplicated("'" + item.Text +
                                        "' already exists in '" + addressRight.Text + "'.");
                                    duplicatedSolve = dupMessBox.ShowDialog();
                                }
                                switch (duplicatedSolve)
                                {
                                    case DialogResult.Yes: File.Delete(addressRight.Text + item.Text); break;
                                    case DialogResult.No: continue;
                                    case DialogResult.OK:
                                        File.Delete(addressRight.Text + item.Text);
                                        OverwriteAll = true; break;
                                    case DialogResult.Cancel: SkipAll = true; continue;
                                }
                            }
                            File.Move(addressLeft.Text + item.Text, addressRight.Text + item.Text);
                        }
                    }
                }
                else
                {
                    if (listRight.SelectedItems.Count < 2)
                        mess = "Do you want to move '" + listRight.SelectedItems[0].Text + "' from '" +
                                   addressRight.Text + "' to '" + addressLeft.Text + "'?";
                    else mess = "Do you want to move " + listRight.SelectedItems.Count + " files from '" +
                                   addressRight.Text + "' to '" + addressLeft.Text + "'?";
                    if (MessageBox.Show(mess, "Confirm Move", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    foreach (ListViewItem item in listRight.SelectedItems)
                    {
                        if (Directory.Exists(addressRight.Text + item.Text))
                        {
                            if (Directory.Exists(addressLeft.Text + item.Text))
                            {
                                if (!OverwriteAll && !SkipAll)
                                {
                                    Duplicated dupMessBox = new Duplicated("'" + item.Text +
                                        "' already exists in '" + addressLeft.Text + "'.");
                                    duplicatedSolve = dupMessBox.ShowDialog();
                                }
                                switch (duplicatedSolve)
                                {
                                    case DialogResult.Yes: Directory.Delete(addressLeft.Text + item.Text, true); break;
                                    case DialogResult.No: continue;
                                    case DialogResult.OK:
                                        Directory.Delete(addressLeft.Text + item.Text, true);
                                        OverwriteAll = true; break;
                                    case DialogResult.Cancel: SkipAll = true; continue;
                                }
                            }
                            Directory.Move(addressRight.Text + item.Text, addressLeft.Text + item.Text);
                        }
                        else if (File.Exists(addressRight.Text + item.Text))
                        {
                            if (File.Exists(addressLeft.Text + item.Text))
                            {
                                if (!OverwriteAll && !SkipAll)
                                {
                                    Duplicated dupMessBox = new Duplicated("'" + item.Text +
                                        "' already exists in '" + addressLeft.Text + "'.");
                                    duplicatedSolve = dupMessBox.ShowDialog();
                                }
                                switch (duplicatedSolve)
                                {
                                    case DialogResult.Yes: File.Delete(addressLeft.Text + item.Text); break;
                                    case DialogResult.No: continue;
                                    case DialogResult.OK:
                                        File.Delete(addressLeft.Text + item.Text);
                                        OverwriteAll = true; break;
                                    case DialogResult.Cancel: SkipAll = true; continue;
                                }
                            }
                            File.Move(addressRight.Text + item.Text, addressLeft.Text + item.Text);
                        }
                    }
                }
                RefreshButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

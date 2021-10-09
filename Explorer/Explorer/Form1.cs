using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class Form1 : Form
    {
        //private static readonly string defaultPath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyComputer);
        private List<string> Logs { get; set; } = new List<string>();
        public string previousFolderPath { get; set; }
        public string newFolderPath { get; set; }
        public Form1()
        {
            InitializeComponent();
            string[] root = Directory.GetLogicalDrives();//@"D:\";
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(@"icon.jpg"));
            leftTV.ImageList = imageList;
            leftTV.ImageIndex = 0;

            foreach (var item in root)
            {   
                leftTV.Nodes.Add(item);
            }
        }

        private void leftTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var selectedPath = leftTV.SelectedNode.FullPath;
                //fileDIrectoryLabel.Text = selectedPath;
                var folders = Directory.GetDirectories(selectedPath)
                                    .Select(Path.GetFileName)
                                    .ToList();

                foreach (var item in folders)
                {
                    leftTV.SelectedNode.Nodes.Add(new TreeNode(item));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void RefreshList(string selectedPath)
        {
            filesLV.Items.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(leftTV.SelectedNode.FullPath);
            var files = Directory.GetFiles(selectedPath)
                                .Select(Path.GetFileName)
                                .ToList();
            var folders = Directory.GetDirectories(selectedPath)
                                .Select(Path.GetFileName)
                                .ToList();
            var imageList = new ImageList();

            imageList.Images.Add(Image.FromFile(@"file.png"));
            imageList.Images.Add(Image.FromFile(@"icon.jpg"));
            imageList.ImageSize = new Size(32, 32);
            filesLV.View = View.LargeIcon;
            filesLV.LargeImageList = imageList;

            foreach (var item in folders)
            {
                var lvItem = new ListViewItem(item);
                lvItem.ImageIndex = 1;
                filesLV.Items.Add(lvItem);
            }

            foreach (var item in files)
            {
                var lvItem = new ListViewItem(item);
                lvItem.ImageIndex = 0;
                filesLV.Items.Add(lvItem);
            }
        }
        private void leftTV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {               
                var selectedPath = leftTV.SelectedNode.FullPath;
                Logs.Add(selectedPath);
                previousFolderPath = selectedPath;
                RefreshList(selectedPath);
                fileDIrectoryLabel.Text = selectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filesLV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Delete && filesLV.SelectedItems.Count > 0)
                {
                    for (var i = 0; i < filesLV.SelectedItems.Count; i++)
                    {
                        var selectedPath = leftTV.SelectedNode.FullPath + "\\" + filesLV.SelectedItems[i].Text;
                        if(File.Exists(selectedPath))
                        {
                            FileInfo fileInfo = new FileInfo(selectedPath);
                            File.SetAttributes(fileInfo.FullName, FileAttributes.Normal);
                            File.Delete(selectedPath);
                        }
                        else
                        {
                            Directory.Delete(selectedPath);
                        }
                    }
                    RefreshList(leftTV.SelectedNode.FullPath);
                }
                else if(e.KeyCode == Keys.Back && Logs.Count > 1)
                {
                    Logs.RemoveAt(Logs.Count - 1);
                    fileDIrectoryLabel.Text = Logs[Logs.Count - 1];
                    RefreshList(Logs[Logs.Count - 1]);
                }
                               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(filesLV.SelectedItems.Count == 1)
                {
                    var selectedPath = leftTV.SelectedNode.FullPath;
                    fileDIrectoryLabel.Text = previousFolderPath + "\\" +filesLV.SelectedItems[0].Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filesLV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(filesLV.SelectedItems.Count > 0)
                {                   
                    var selectedPath = leftTV.SelectedNode.FullPath + "\\" + filesLV.SelectedItems[0].Text;
                    if(File.Exists(selectedPath))
                    {
                        var thread = new Thread(() => { Process.Start(selectedPath); });
                        thread.Start();
                    }
                    else
                    {
                        previousFolderPath += ("\\" + filesLV.SelectedItems[0].Text);
                        Logs.Add(previousFolderPath);
                        RefreshList(previousFolderPath);                       
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

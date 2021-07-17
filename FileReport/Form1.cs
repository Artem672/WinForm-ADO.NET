using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileReport
{
    public partial class Form1 : Form
    {
        private List<FileInfo> files { get; set; } = new();

        private static readonly string desktopP = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
        private readonly DirectoryInfo dirInfo = new(desktopP);
        public Form1()
        {
            InitializeComponent();            
            files = dirInfo.GetFiles().ToList<FileInfo>();
            RefreshDataSource();
            Size.Text = files[0].Length.ToString();
        }
        private void RefreshDataSource()
        {
            files = dirInfo.GetFiles().ToList<FileInfo>();
            desktopFiles.DataSource = null;
            desktopFiles.DataSource = files;
            desktopFiles.DisplayMember = "Name"; 
            desktopFiles.ValueMember = "Length";
        }

        private void desctopFiles_SelectedIndexChanged(object sender, EventArgs e)
        {         
            if(desktopFiles.SelectedIndex == -1)
            {
                return;
            }
            Text = desktopFiles.SelectedItem.ToString();
            textBox1.Text = files[desktopFiles.SelectedIndex].Name;
            Extencion.Text = files[desktopFiles.SelectedIndex].Extension;
            Size.Text = desktopFiles.SelectedValue.ToString();
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(FileName.Text))
            {
                string pathComb = Path.Combine(desktopP, FileName.Text);
                using (FileStream file = File.Create(pathComb)) 
                {
                    files.Add(new FileInfo(file.Name));
                }
            }
            else
            {
                errorProvider1.SetError(FileName, "Can't be empty!");
            }
            
            RefreshDataSource();
        }

        private void FileName_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}

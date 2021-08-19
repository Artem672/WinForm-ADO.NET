using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveDialog.FileName) == ".txt")
                {
                    richTextBox1.SaveFile(saveDialog.FileName, RichTextBoxStreamType.UnicodePlainText);
                }
                else
                {
                    richTextBox1.SaveFile(saveDialog.FileName);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openDialog.Filter = "All files|*.*|Text documents|*.txt|RTF|*.rtf";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openDialog.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength == 0)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

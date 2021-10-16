using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private Process[] Processes { get; set; }
        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void startProcessButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(processNameTB.Text))
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Process.Start(fileDialog.FileName);
                    return;
                }
            }

            Process.Start(processNameTB.Text);
        }
        private void SetupDataGridView()
        {
            processesDGW.ColumnCount = 5;
            processesDGW.Columns[0].Name = "Id";
            processesDGW.Columns[1].Name = "Name";
            processesDGW.Columns[2].Name = "Start time";
            processesDGW.Columns[3].Name = "Processor time";
            processesDGW.Columns[4].Name = "Total threads";

            processesDGW.SelectAll();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            UpdateProcesses();
        }

        private void stopByIdButton_Click(object sender, EventArgs e)
        {
            Processes[processesDGW.CurrentCell.RowIndex].Kill();
        }

        private void UpdateProcesses()
        {
            processesDGW.Rows.Clear();
            Processes = Process.GetProcesses().OrderBy(p => p.ProcessName).ToArray();

            for (var i = 0; i < Processes.Length; i++)
            {
                string[] row = { Processes[i].Id.ToString(), Processes[i].ProcessName/*, Processes[i].StartTime.ToString(), Processes[i].TotalProcessorTime.ToString(), Processes[i].Threads.Count.ToString() */};//Access denied
                processesDGW.Rows.Add(row);
            }
        }

        private void stopByNameButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = processesDGW.CurrentCell.RowIndex;
            for (var i = 0; i < processesDGW.Rows.Count - 1; i++) 
            {
                if(Processes[i].ProcessName == processesDGW.Rows[selectedIndex].Cells[1].Value.ToString())
                {
                    Processes[i].Kill();
                }
            }
        }
    }
}

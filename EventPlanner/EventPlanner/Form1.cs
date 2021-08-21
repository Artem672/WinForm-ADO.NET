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

namespace EventPlanner
{
    public partial class Form1 : Form
    {
        private List<Event> events { get; set; } = new List<Event>();

        private SaveFile saveFile { get; set; } = new SaveFile();
        public Form1()
        {
            InitializeComponent();

            RefreshDataSource();
            priorityCB.SelectedIndex = 1;
            eventDTPicker.Value = DateTime.Now.AddDays(1);
            eventsListBox.DataSource = events;
        }

        private void clearEventButton_Click(object sender, EventArgs e)
        {
            events.Clear();
            RefreshDataSource();
            RefreshFields();
        }
        private void RefreshDataSource()
        {
            eventsListBox.DataSource = null;
            eventsListBox.DataSource = events;
            eventsListBox.DisplayMember = "Name";
        }
        private void addEventButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(eventNameTB.Text) || eventDTPicker.Value < DateTime.Now)
            {
                MessageBox.Show("Name value empty or invalid time value!");
            }
            else
            {
                events.Add(new Event()
                {
                    Name = eventNameTB.Text,
                    Place = eventPlaceTB.Text,
                    Date = eventDTPicker.Value,
                    Priority = priorityCB.SelectedIndex
                });

                RefreshDataSource();
                RefreshFields();
            }
        }

        private void RefreshFields()
        {
            eventNameTB.Text = String.Empty;
            eventPlaceTB.Text = String.Empty;
            eventDTPicker.Value = DateTime.Now.AddDays(1);
            priorityCB.SelectedIndex = 1;
        }

        private void eventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsListBox.SelectedIndex == -1)
            {
                return;
            }

            eventNameTB.Text = eventsListBox.SelectedItem.ToString();
            eventPlaceTB.Text = events[eventsListBox.SelectedIndex].Place;
            eventDTPicker.Value = events[eventsListBox.SelectedIndex].Date;
            priorityCB.SelectedIndex = events[eventsListBox.SelectedIndex].Priority;
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            RefreshFields();
        }

        private void saveJsonButton_Click(object sender, EventArgs e)
        {
            var saveF = new FolderBrowserDialog();
            if(saveF.ShowDialog() == DialogResult.OK)
            {         
                saveFile.SerializeJson(events, saveF.SelectedPath);
            }           
        }

        private void saveXMLButton_Click(object sender, EventArgs e)
        {
            var saveF = new FolderBrowserDialog();
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                saveFile.SerializeXML(events,saveF.SelectedPath);
            }           
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Text documents|*.json;*.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                switch(Path.GetExtension(openFile.FileName))
                {
                    case ".json":
                        {
                            events = saveFile.DeserializeJson(openFile.FileName);
                            RefreshFields();
                            RefreshDataSource();
                            break;
                        }
                    case ".xml":
                        {
                            events = saveFile.DeserializeXML(openFile.FileName);
                            RefreshFields();
                            RefreshDataSource();
                            break;
                        }
                }
            }
        }
    }
}

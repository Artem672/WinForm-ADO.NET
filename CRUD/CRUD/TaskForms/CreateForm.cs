using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRUD.TaskForms
{
    public partial class CreateForm : Form
    {
        private Form1 GetForm { get; set; }
        private List<Task> tasks { get; set; }
        public CreateForm(Form1 form)
        {
            InitializeComponent();
            GetForm = form;
            tasks = new List<Task>();
            RefreshDataSource();
        }
        private void RefreshDataSource()
        {
            taskLB.DataSource = null;
            taskLB.DataSource = tasks;
            taskLB.DisplayMember = "Title";
            taskLB.ValueMember = "Priority";
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            var position = GetForm.application.Positions.Where(c => c.Title == positionTB.Text);
            if (position.Count() > 0)
            {
                var employee = new Employee
                {
                    Name = nameTB.Text,
                    Surname = surnameTB.Text,
                    Age = Convert.ToInt32(ageNUD.Value),
                    Salary = Convert.ToInt32(salaryNUP.Value),
                    Position = position.FirstOrDefault(),
                    Tasks = tasks
                };

                GetForm.application.Employees.Add(employee);
                GetForm.application.SaveChanges();
                this.Close();
                MessageBox.Show("Employee was added!");
            }
            else
            {
                MessageBox.Show("Position invalid value!");
            }

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(taskTB.Text))
            {
                //I unsuccessfully tried to avoid similar tasks
                var task = GetForm.application.Tasks
                    .Where(t => t.Title == taskTB.Text && t.Id == priorityNUP.Value)
                    .Select(t => t).FirstOrDefault();

                if (task is null)
                {
                    tasks.Add(new Task
                    {
                        Title = taskTB.Text,
                        Priority = Convert.ToInt32(priorityNUP.Value)
                    });
                }
                else
                {
                    tasks.Add(task);
                }
                RefreshDataSource();
            }
        }
    }
}

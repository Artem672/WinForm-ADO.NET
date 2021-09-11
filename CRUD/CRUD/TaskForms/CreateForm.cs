using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CRUD.TaskForms
{
    public partial class CreateForm : Form
    {
        private Form1 GetForm { get; set; }
        private List<Task> tasks { get; set; }
        private Employee GetEmployee { get; set; } = new Employee();
        public CreateForm(Form1 form)
        {
            InitializeComponent();
            GetForm = form;
            tasks = new List<Task>();            
            RefreshDataSource();
        }
        private void RefreshDataSource()
        {
            positionCB.Items.Clear();
            GetForm.application.Positions.ToList().ForEach(p => positionCB.Items.Add(p.Title));
            taskLB.DataSource = null;
            taskLB.DataSource = GetEmployee.Tasks;
            taskLB.DisplayMember = "Title";
            taskLB.ValueMember = "Priority";
        }
        private void createButton_Click(object sender, EventArgs e)
        {

            if (positionCB.SelectedIndex != -1 || GetEmployee.Position != null)
            {
                GetEmployee.Name = nameTB.Text;
                GetEmployee.Surname = surnameTB.Text;
                GetEmployee.Age = Convert.ToInt32(ageNUD.Value);
                GetEmployee.Salary = Convert.ToInt32(salaryNUP.Value);

                GetForm.application.Entry(GetEmployee).State = EntityState.Added;
                GetForm.application.SaveChanges();
                MessageBox.Show("Employee was added!");
                this.Close();
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
                var task = GetForm.application.Tasks
                    .Where(t => t.Title == taskTB.Text && t.Id == priorityNUP.Value)
                    .Select(t => t).FirstOrDefault();

                if (task is null)
                {
                    GetEmployee.Tasks.Add(new Task
                    {
                        Title = taskTB.Text,
                        Priority = Convert.ToInt32(priorityNUP.Value)
                    });
                }
                else
                {
                    GetEmployee.Tasks.Add(task);
                }
                RefreshDataSource();
            }
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            if (positionCB.SelectedIndex == -1 && !string.IsNullOrEmpty(positionCB.Text) && !GetForm.application.Positions.ToList().Exists(p => p.Title == positionCB.Text))
            {
                Position position = new Position { Title = positionCB.Text };
                GetForm.application.Entry(position).State = EntityState.Added;
                GetForm.application.SaveChanges();
                MessageBox.Show("Position was added!");
                RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Invalid code!");
            }
        }

        private void positionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmployee.Position = GetForm.application.Positions.FirstOrDefault(c => c.Title == positionCB.SelectedItem.ToString());
        }
    }
}

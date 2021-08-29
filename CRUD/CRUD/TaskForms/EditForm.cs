using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CRUD.TaskForms
{
    public partial class EditForm : Form
    {
        private Form1 GetForm { get; set; }
        private List<Task> tasks { get; set; } 
        public EditForm(Form1 form)
        {
            InitializeComponent();
            GetForm = form;
            GetForm.application.Employees.ToList()
                .ForEach(x => idCB.Items.Add(x.Id));
            tasks = new List<Task>();
            RefreshDataSource();
        }
        private void DefaultFields()
        {
            nameTB.Text = string.Empty;
            surnameTB.Text = string.Empty;
            ageTB.Text = string.Empty;
            salaryTB.Text = string.Empty;
            positionTB.Text = string.Empty; ;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //DefaultFields();
            if (idCB.SelectedItem == null)
            {
                MessageBox.Show("You need to choose something!");
                return;
            }
            var employeeId = Convert.ToInt32(idCB.SelectedItem.ToString());
            var employee = GetForm.application.Employees
                .Include(x => x.Position).Include(x => x.Tasks).Where(x => x.Id == employeeId).FirstOrDefault();

            nameTB.Text = employee.Name.ToString();
            surnameTB.Text = employee.Surname.ToString();
            ageTB.Text = employee.Age.ToString();
            salaryTB.Text = employee.Salary.ToString();
            positionTB.Text = employee.Position != null ? employee.Position.Title.ToString() : string.Empty;
            tasks = employee.Tasks.ToList();
            RefreshDataSource();
        }

        private void removeTaskButton_Click(object sender, EventArgs e)
        {
            if(titleLB.SelectedIndex == -1)
            {
                MessageBox.Show("Item is not selected!");
                return;
            }

            tasks.RemoveAt(titleLB.SelectedIndex);
            RefreshDataSource();
        }
        private void RefreshDataSource()
        {
            titleLB.DataSource = null;
            priorityLB.DataSource = null;
            titleLB.DataSource = tasks;
            priorityLB.DataSource = tasks;
            titleLB.DisplayMember = "Title";
            priorityLB.DisplayMember = "Priority";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (idCB.SelectedItem == null)
            {
                MessageBox.Show("You need to choose something!");
                return;
            }
            var employeeId = Convert.ToInt32(idCB.SelectedItem.ToString());
            var employee = GetForm.application.Employees
                .Include(x => x.Position)
                .Include(x => x.Tasks)
                .Where(x => x.Id == employeeId).FirstOrDefault();
            
            employee.Name = nameTB.Text;
            employee.Surname = surnameTB.Text;
            employee.Age = !string.IsNullOrEmpty(ageTB.Text) ? Convert.ToInt32(ageTB.Text) : employee.Age;
            employee.Salary = !string.IsNullOrEmpty(salaryTB.Text) ? Convert.ToDouble(salaryTB.Text) : employee.Salary; 
            employee.Position = GetForm.application.Positions.Where(p => p.Title == positionTB.Text).FirstOrDefault();
            employee.Tasks = tasks;

            GetForm.application.SaveChanges();
            MessageBox.Show("User was updated!");
            //DefaultFields();
        }
    }
}

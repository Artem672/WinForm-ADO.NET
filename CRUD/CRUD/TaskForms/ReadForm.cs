using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CRUD.TaskForms
{
    public partial class ReadForm : Form
    {
        private Form1 GetForm { get; set; }
        public ReadForm(Form1 form)
        {
            InitializeComponent();
            GetForm = form;
            GetForm.application.Employees.ToList()
                .ForEach(x => idCB.Items.Add(x.Id));//If i remove the employee , his id becomes empty so i need to check all of them
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            DefaultFields();
            if (idCB.SelectedItem == null)
            {
                MessageBox.Show("You need to choose something!");
                return;
            }
            var employeeId = Convert.ToInt32(idCB.SelectedItem.ToString());
            var employee = GetForm.application.Employees
                .Include(x => x.Position)
                .Include(x => x.Tasks)
                .Where(x => x.Id == employeeId)
                .FirstOrDefault();

            nameTB.Text = employee.Name.ToString();
            surnameTB.Text = employee.Surname.ToString();
            ageTB.Text = employee.Age.ToString();
            salaryTB.Text = employee.Salary.ToString();
            positionTB.Text = employee.Position != null ? employee.Position.Title.ToString() : string.Empty;
            if (employee.Tasks.Count > 0)
            {
                foreach (var i in employee.Tasks)
                {
                    titleLB.Items.Add(i.Title);
                    priorityLB.Items.Add(i.Priority);
                }
            }
        }
        private void DefaultFields()
        {
            titleLB.Items.Clear();
            priorityLB.Items.Clear();
            nameTB.Text = string.Empty;
            surnameTB.Text = string.Empty;
            ageTB.Text = string.Empty;
            salaryTB.Text = string.Empty;
            positionTB.Text = string.Empty; ;
        }
    }
}

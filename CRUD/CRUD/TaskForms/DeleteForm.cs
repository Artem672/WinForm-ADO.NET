using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.TaskForms
{
    public partial class DeleteForm : Form
    {
        private Form1 GetForm { get; set; }
        public DeleteForm(Form1 form)
        {
            InitializeComponent();
            GetForm = form;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var employeeName = deleteTB.Text;
            if (!string.IsNullOrEmpty(employeeName))
            {
                var deleteEmp = GetForm.application.Employees.Where(c => c.Name == employeeName);
                if(deleteEmp.Count() > 0)
                {
                    GetForm.application.Employees.Remove(deleteEmp.FirstOrDefault());
                    GetForm.application.SaveChanges();
                }
                else
                {
                    MessageBox.Show("There isn't any employees!");
                }               
            }
            else
            {
                MessageBox.Show("You need enter employee name!");
            }
        }
    }
}

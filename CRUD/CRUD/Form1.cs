using CRUD.TaskForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        internal ApplicationContext application { get; set; }
        public Form1()
        {
            InitializeComponent();
            application = new ApplicationContext();
        }

        private void readEmployeeButton_Click(object sender, EventArgs e)
        {
            var readForm = new ReadForm(this);
            readForm.ShowDialog();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteForm(this);
            deleteForm.ShowDialog();
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateForm(this);
            createForm.ShowDialog();
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(this);
            editForm.ShowDialog();
        }
    }
}

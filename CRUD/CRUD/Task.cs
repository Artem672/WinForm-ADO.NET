using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Task
    {
        public Task()
        {
            Employees = new List<Employee>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? Priority { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

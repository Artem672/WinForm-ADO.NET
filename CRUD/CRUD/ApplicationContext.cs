using System;
using System.Data.Entity;
using System.Linq;

namespace CRUD
{
    public class ApplicationContext : DbContext
    {
        
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}
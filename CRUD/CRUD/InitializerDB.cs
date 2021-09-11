using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CRUD
{
    class InitializerDB : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var positions = new List<Position>
            {
                new Position{Title = "Director"},
                new Position{Title = "Assistant"},
                new Position{Title = "Student"}
            };
            var employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Artem",
                    Surname = "Synytsia",
                    Age = 19,
                    Salary = 2500,
                    Position = positions.FirstOrDefault(p => p.Title == "Director")
                },
                new Employee
                {
                    Name = "Nazar",
                    Surname = "Shavaryn",
                    Age = 20,
                    Salary = 500,
                    Position = positions.FirstOrDefault(p => p.Title == "Assistant")
                }
            };
            var tasks = new List<Task>
            {
                new Task{Title = "Cleaning",Priority = 1,Employees = employees},
                new Task{Title = "Preparing",Priority = 3},
                new Task{Title = "Homework",Priority = 2,Employees = employees},
                new Task{Title = "Attack",Priority = 4},
            };
            context.Positions.AddRange(positions);
            context.Tasks.AddRange(tasks);
            context.Employees.AddRange(employees);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}

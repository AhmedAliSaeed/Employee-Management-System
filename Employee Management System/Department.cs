using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Department
    {
        private string Name, Head;
        private List<Employee> Employees;

        Employee employee;
        public Department(string name, string head)
        {
            Name = name;
            Head = head;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            //if(employee.Department == Name)
            //{
                if (Employees.Contains(employee))
                    Console.WriteLine($"{employee.Name} is already exists in this department\n");
                else
                {
                    Employees.Add(employee);
                    Console.WriteLine($"{employee.Name} added Successfully\n");
                }
            //}
            /*else
                Console.WriteLine($"Can not add {employee.Name} to {Name} department because his role doesn't match!");*/
        }

        public void RemoveEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
                Console.WriteLine($"{employee.Name} is already doesn't exist in this department\n");
            else
            {
                Employees.Remove(employee);
                Console.WriteLine($"{employee.Name} removed Successfully\n");
            }
            
        }

        public void SwitchDepartment(Employee employee, Department newDepartment)
        {
            if (!Employees.Contains(employee))
            {
                Console.WriteLine($"Employee {employee.Name} is not in {Name}, so cannot be switched.\n");
                return;
            }

            Employees.Remove(employee);
            Console.WriteLine($"Employee {employee.Name} removed from {Name}.");

            newDepartment.AddEmployee(employee);
            Console.WriteLine($"Employee {employee.Name} transferred to {newDepartment.Name}.\n");
        }

        public void Display()
        {
            Console.WriteLine($"Department: {Name}");
            Console.WriteLine($"Department Head: {Head}");
            Console.WriteLine("Employees:");
            if (Employees.Count > 0)
            {
                foreach (var employee in Employees)
                {
                    Console.WriteLine($"   {employee} ");
                }
            }
            else
                Console.WriteLine("  No employees yet.");

            Console.WriteLine();
        }
    }
}
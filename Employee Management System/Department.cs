using System;
using System.Collections.Generic;
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
            if(Employees.Contains(employee))
                Console.WriteLine($"Employee is already exists in this department");
            else
            {
                Employees.Add(employee);
                Console.WriteLine("Employee added Successfully");
            }
        }

        public void RemoveEmployee()
        {
            if (!(Employees.Contains(employee)))
                Console.WriteLine($"Employee is already doesn't exist in this department");
            else
            {
                Employees.Remove(employee);
                Console.WriteLine("Employee removed Successfully");
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Employee
    {
       public int Id { set ; get ;} 
       public string Name  { set ; get ;} 
        public int Age  { set ; get ;}
        public double Salary  { set ; get ;} 
        public string Department { set ; get ;}
         public DateTime EmploymentDate { get; set;}
        
    public Employee( int id, string name, int age, double salary, string department, DateTime employmentDate)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
        Department = department;
        EmploymentDate = employmentDate;
     }

         public void Promote(double salaryIncrement)
        {
            Salary += salaryIncrement;
            Console.WriteLine($"{Name} has been promoted with a salary increment {salaryIncrement}");

         }  
        
         public void Transfer(string newDepartment)
        {
            Department = newDepartment;
            Console.WriteLine($"{Name} has been transferred to {newDepartment} department");
        }
        
       public void Terminate()
        {
            Console.WriteLine($"{Name} has been terminated from the company");
        }

        public override string ToString()
    {
        return $"Employee {{ Name = {Name}, Id = {Id}, Age = {Age}, Salary = {Salary}, Department ={Department},EmploymentDate ={EmploymentDate} }}";
    }
           
    }
}

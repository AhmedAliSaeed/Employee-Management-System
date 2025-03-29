using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Employee
    {
<<<<<<< HEAD
=======
     
		private int id;
		private string name;
		private int age;
		private double salary;
		private string department;
		private DateTime employmentDate;
		public int Id
		{
			set
			{
				if (value <= 0) throw new Exception("invalid Id");
				this.id = value;
			}
				get { return this.id; }
		}
		public string Name 
		{
			set
			{
				if (value.Length < 3) throw new Exception(" Name is invalid ");
				this.name = value;
			}
			get { return  this.name; }
		}
		public int Age
		{
			set
			{
				if (value <= 0) throw new Exception("Age is invalid");
				this.age = value;
			}
			get { return this.age; } 
		}
		public double Salary
		{ set 
			{
				if (value <= 0) throw new Exception("Salary is invalid");
				this.salary = value;
			}
			get{ return this.salary; }
		}
		public string Department 
		{ set 
			{
				if (value.Length <= 1) throw new Exception("Department is invalid");
				this.department = value;
			}
			get{ return this.department; } 
		}
		public DateTime EmploymentDate { get; private set; }

		public List<int> PerformanceRatings { get; private set; } = new List<int>();

		public bool isTerminated { get; private set; } = false;

		public Employee(int id, string name, int age, double salary, string department, DateTime employmentDate)
		{
			Id = id;
			Name = name;
			Age = age;
			Salary = salary;
			Department = department;
			EmploymentDate = employmentDate;
		}

		public void Terminate()
		{
			isTerminated = true;
		}

		public void AddPerformanceRating(int rating)
		{
			PerformanceRatings.Add(rating);
		}

		public void Promote(double salaryIncrement)
		{
			double averageRating = PerformanceRatings.Count > 0 ? PerformanceRatings.Average() : 0;
			int years = DateTime.Now.Year - EmploymentDate.Year;
			if (averageRating > 8.0 && years >= 2)
			{
				Salary *= 1.1;
				Console.WriteLine($"Employee {Name} has been promoted, new salary is {Salary}");
			}
			else
			{
				Console.WriteLine($"Employee {Name} is not eligible for promotion");
			}
			
		}

		public void Transfer(string newDepartment)
		{
			if (isTerminated)
			{
				Console.WriteLine($"Employee {Name} is terminated and cannot be transferred");
			}
			else
			{
				Department = newDepartment;
				Console.WriteLine($"Emplyee {Name} has been transferred to Department {Department}");
			}
		}

		

		public override string ToString()
		{
			return $"Employee {{ Id = {Id},Name = {Name}, Age = {Age}, Salary = {Salary}, Department = {Department},EmploymentDate = {EmploymentDate.ToShortDateString()} Terminated= {isTerminated} }}";
		}

	}

}
>>>>>>> origin/Mostafamahmoud36-patch-1
           
    }
}

namespace Employee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"mostafa",25, 30000,"hr", DateTime.Now);
            Console.WriteLine(emp.ToString());

            Employee emp1 = new Employee(2,"omer mohamed", 22 , 50000,"it", DateTime.Now);
            Console.WriteLine(emp1.ToString());
        }
    }
}

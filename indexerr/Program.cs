using System;
namespace indexerr
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Anish Ghimire", "Project Manger", 100000);
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);
       


            Console.ReadLine();
        }
    }
}
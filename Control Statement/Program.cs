using System;

namespace Control_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
         ineligible:
            Console.WriteLine("Your are not elligible to vote");

        Console.WriteLine("Enter your age:  \n");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age < 18){
            goto ineligible;
        }else{
            Console.WriteLine("You are eligible to vote");
        }

        }
    }
}

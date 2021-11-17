using System;

namespace Hybrid_Inheritance
{


    class Principal {
        public void rule(){
            Console.WriteLine("Rule maker");
        }
    }

    class Teacher:Principal {
        public void teach(){
            Console.WriteLine("Teacher teach student");
        }
    }

    class Student:Principal{
        public void follow(){
            Console.WriteLine("Follow the rule of principle");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Student ob = new Student();
            ob.follow();
            ob.rule();
        }
    }
}

using System;

namespace SingleInheritance
{


    class Person {
        public void mssg(){
            Console.WriteLine("Super class");
        }
    }

    class Student:Person {
        public void std(){
            Console.WriteLine("Derived Class");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Student ob = new Student();
            ob.mssg();
            ob.std();

        }
    }
}

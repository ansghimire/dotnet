using System;

namespace alloperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operator
            Console.WriteLine("===========Arithmetic Operator==========");
            int a = 10;
            int b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);

            //    Assignment Operator
            Console.WriteLine("============Assignment Operator==========");
            a += 5;
            Console.WriteLine(a);
            a -= 5;
            Console.WriteLine(a);


            // Relational Operator
            Console.WriteLine("=======Relational Operator==========");
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);


            // Logical Operator
            Console.WriteLine("==========Logical Operator========");
            bool x = true;
            bool y = false;
            Console.WriteLine(x && y);
            Console.WriteLine(x || y);
            Console.WriteLine(!(x && y));

          // Bitwise Operator
          Console.WriteLine("=========Bitwise Operator=======");
          int ab = 60;
          int bc = 30;
          int c = 0;

          c = ab & bc;
          Console.WriteLine("Value of c is {0}", c);

          c = ab << 2;
          Console.WriteLine("Value of c is {0}", c);


        // MISC OPERATOR
        Console.WriteLine("===========Misc Operator===========");
        c = sizeof(int);
        Console.WriteLine("Size of int {0}",c);
    



        }
    }
}

using System;

namespace MethodOverloadingDemo
{

    class ArithmeticDemo{
        public void sum (int a, int b){
            Console.WriteLine("The sum of {0}, {1} = {2}",a,b,(a+b));
        }

        public void sum(float a, float b){
             Console.WriteLine("The sum of {0}, {1} = {2}",a,b,(a+b));
        }

        public void diff(int a, int b){
             Console.WriteLine("The difference of {0}, {1} = {2}",a,b,(a-b));
        }

        public void diff(int a, int b, int c){
             Console.WriteLine("The difference of {0}, {1}, {2} = {3}",a,b,c,(a-b-c));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticDemo ob = new ArithmeticDemo();
            ob.sum(13,17);
            ob.sum(13.5f,16.5f);
            ob.diff(33,22);
            ob.diff(44,10,4);

        }
    }
}

using System;

namespace OutParameter1
{
    class Program
    {
        public void show(out int a, out int b){
            int square = 5;
            a = square;
            b = square;
            a *= a;
            b *= b;


        }
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            Program pr = new Program();
            Console.WriteLine("Value before passing \n val1 = " + val1+" \n val2 = "+val2); 
            pr.show(out val1, out val2);
            Console.WriteLine("Value after passing \n val1 = " + val1+" \n val2 = "+val2); 
        }
    }
}

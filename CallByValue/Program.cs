using System;

namespace CallByValue
{
    class Program
    {
        public void show(int val){
        val *= val;
        Console.WriteLine("Value inside the show function "+val);

        }



        static void Main(string[] args)
        {
            int val = 50;
            Program pr = new Program();
            Console.WriteLine("Value before calling the function "+val);  
            pr.show(val);
            Console.WriteLine("Value after calling the function"+val);

        }
    }
}

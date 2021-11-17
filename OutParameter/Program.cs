using System;

namespace OutParameter
{
    class Program
    {

        public void show(out int val){
            int square = 5;
            val = square;
            val *= val;
        }


        static void Main(string[] args)
        {
            int val = 50;
            Program pr = new Program();
            Console.WriteLine("Value before passing out variable "+val);
            
            pr.show(out val);
            Console.WriteLine("Value after recieving the out variable "+val);
    }
}
}
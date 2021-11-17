using System;

namespace Function
{
    class Program
    {
        public string show(string message)
        {
            return $"Hello {message}";
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            Console.WriteLine(pr.show("Anish"));

        }
    }
}

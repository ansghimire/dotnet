using System;

namespace DelegateDemo
{
// For nonstatic method Delegate is placed before the function name
public delegate void DelegateSum(int x, int y);
// for static method Delegate is placed after the function name
public delegate string MessageDelegate(string name);


class OperationDemo {
    public void Sum(int x, int y){
        Console.WriteLine("The sum of two value is {0}", (x+y));
    }

    public static string Message(string  name){
        return "Hi"+name;

    }
}


    class Program
    {
        static void Main(string[] args)
        {
            OperationDemo ob = new OperationDemo();
            DelegateSum add = new DelegateSum(ob.Sum);
            MessageDelegate mssg = new MessageDelegate(OperationDemo.Message);

            add(100, 15); // add.Invoke(100,15);
            string output = mssg(" Anish");

           Console.WriteLine(output);
        }
    }
}

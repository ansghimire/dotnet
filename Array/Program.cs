using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] arr = {10,20,30,40,50};
           
        //    // traversing array
        //    for(int i =0; i<arr.Length; i++){
        //        Console.WriteLine(arr[i]);
        //    }

           foreach(int i in arr){
               Console.WriteLine(i);
           }
        }
    }
}

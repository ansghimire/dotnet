using System;

namespace ArrayToFunction
{
    class Program
    {
        static void printArray(int[] arr){
            int temp = 0;
            for(int i = 0; i<arr.Length; i++){
                for(int j = i+1; j<arr.Length; j++){
                    if(arr[i] > arr[j]){
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            foreach(int i in arr){
                Console.WriteLine(i);
            }         
   
        
            

        }
        static void Main(string[] args)
        {
            int [] arr1 = {5,2,3,4,1};
            int [] arr2 = {30,20,10,50,40};
            printArray(arr1);
            printArray(arr2);
        }
    }
}

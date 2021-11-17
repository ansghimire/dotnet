using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = {
                        new int[3]{1,3,4},
                        new int[4]{4,7,9,12},
                        new int[5]{5,10,15,17,11}

                    };

            // for(int i=0; i< arr.GetLength(0); i++){
            //     for(int j=0; j < arr[i].GetLength(0); j++){

            //         Console.WriteLine(arr[i][j]+ "    ");

            //     }
            // } 


            for (int i = 0; i < arr.GetLength(0); i++)
            {
               foreach(int val in arr[i]){
                   Console.WriteLine(val);
               }
            }

        }
    }
}

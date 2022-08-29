using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = { 5, 1, 4, 10, 70 };
                int a = arr.Length;
                int z = 4;
                int result = Search(arr, 0, a - 1, z);



                if (result == -1)
                    Console.WriteLine("Number not Found");
                else
                    Console.WriteLine("Number Found at : " + result);
            }


            int Search(int[] arr, int left, int right, int z)
            {
                if (right >= left)
                {
                    int mid = left + (right - left) / 2;

                    if (arr[mid] == z)
                        return mid;





                    if (arr[mid] > z)
                        return Search(arr, left, mid - 1, z);



                    return Search(arr, mid + 1, right, z);
                }



                return 0;
            }

            Console.ReadLine();

        }



    }
}
     

    
    

    

    

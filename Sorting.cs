using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17
{
    public class Sorting
    {
        public void Display()
        {

            int[] arr = { };
            int size;
            Console.WriteLine("Enter size of the array");
            size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];

            for (int k = 0; k < size; k++)
            {
                int number = k + 1;
                Console.WriteLine("Enter element number: " + number);
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Given Array :");
            foreach (int ele in arr)
            {
                Console.WriteLine(ele);
            }
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - j - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array :");
            foreach (int ele in arr)
            {
                Console.WriteLine(ele);
            }
        }
    }
}



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

            int[] arr1 = {};
            int size;
            Console.WriteLine("Enter size of the array");
            size = Convert.ToInt32(Console.ReadLine());
            arr1 = new int[size];

            for (int k = 0; k < size; k++)
            {
                int number = k + 1;
                Console.WriteLine("Enter element number: "+number);
                arr1[k] = Convert.ToInt32(Console.ReadLine());
            }
            
            int  i, j, val, flag;

            Console.WriteLine("Initial Array");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            for (i = 1; i < size; i++)
            {
                val = arr1[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr1[j])
                    {
                        arr1[j + 1] = arr1[j];
                        j--;
                        arr1[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            Console.WriteLine("Sorted Array: ");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }
    }
}

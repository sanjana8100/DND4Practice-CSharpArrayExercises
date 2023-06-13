using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program16
    {
        public void FindSecondLargestElementOfArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int maximum1 = 0;
            int maximum2 = 0;

            for (int index = 0; index < length; index++)
            {
                if (array[index] > maximum1)
                {
                    maximum1 = array[index];
                }
            }

            for (int index = 0; index < length; index++)
            {
                if (array[index] != maximum1)
                {
                    if (array[index] > maximum2)
                    {
                        maximum2 = array[index];
                    }
                }
            }
            Console.WriteLine($"The second largest element in the Array is: {maximum2}");
        }
    }
}

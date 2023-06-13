using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program17
    {
        public void FindSecondSmallestElementOfArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int minimum1 = array[0];
            int minimum2 = array[0];

            for (int index = 0; index < length; index++)
            {
                if (array[index] < minimum1)
                {
                    minimum1 = array[index];
                }
            }

            for (int index = 0; index < length; index++)
            {
                if (array[index] != minimum1)
                {
                    if (array[index] < minimum2)
                    {
                        minimum2 = array[index];
                    }
                }
            }
            Console.WriteLine($"The second smallest element in the Array is: {minimum2}");
        }
    }
}

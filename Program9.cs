using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program9
    {
        public void FindMinimumAndMaximumOfArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int minimum = array[0];
            int maximum = array[0];

            for (int index = 1; index < length; index++)
            {

                if (array[index] < minimum)
                {
                    minimum = array[index];
                }
                if (array[index] > maximum)
                {
                    maximum = array[index];
                }
            }
            Console.WriteLine($"Minimum element is {minimum}");
            Console.WriteLine($"Minimum element is {maximum}");
        }
    }
}

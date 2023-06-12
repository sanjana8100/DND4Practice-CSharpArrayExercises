using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program3
    {
        public void SumOfElementsInArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int index = 0; index < length; index++)
            {
                sum += array[index];
            }
            Console.WriteLine($"The Sum of all the elements in the Array is: {sum}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program2
    {
        public void StoreAndPrintArrayInReverse()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Elements in the Array in Reverse Order: ");
            for (int index = length-1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

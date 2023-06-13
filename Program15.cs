using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program15
    {
        public void DeleteElementFromArray()
        {
            Console.WriteLine("Please enter the number of elements in Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of Array 1: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Elements in the Array are: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the position where you want to delete the element: ");
            int position = Convert.ToInt32(Console.ReadLine());

            for (int index = position; index < array.Length ; index++)
            {
                array[index-1] = array[index];
            }

            Array.Resize(ref (array), array.Length - 1);

            Console.WriteLine("The Elements in the Array after deleting element: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

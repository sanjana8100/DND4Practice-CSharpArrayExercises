using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program13
    {
        public void InsertElementToSortedArray()
        {
            Console.WriteLine("Please enter the number of elements in Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of Array 1: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            for (int index = 0; index < length - 1; index++)
            {
                for (int index2 = index + 1; index2 < length; index2++)
                {
                    if (array[index] > array[index2])
                    {
                        int temp = array[index2];
                        array[index2] = array[index];
                        array[index] = temp;
                    }
                }
            }
            Console.WriteLine("The Array in Ascending Order after sorting: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the element you want to insert: ");
            int element = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref(array), array.Length+1);
            array[array.Length-1] = element;

            for (int index = 0; index < array.Length - 1; index++)
            {
                for (int index2 = index + 1; index2 < array.Length; index2++)
                {
                    if (array[index] > array[index2])
                    {
                        int temp = array[index2];
                        array[index2] = array[index];
                        array[index] = temp;
                    }
                }
            }
            Console.WriteLine("The Array in Ascending Order after insertng new element: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

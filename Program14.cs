using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program14
    {
        public void InsertElementToArray()
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

            Console.WriteLine("Enter the element you want to insert: ");
            int element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the position where you want to insert the element: ");
            int position = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref (array), array.Length + 1);

            for (int index = array.Length-1; index > position- 1; index--)
            {
                array[index] = array[index - 1];
            }
            array[position - 1] = element;

            Console.WriteLine("The Elements in the Array after insertng new element: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

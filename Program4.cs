using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program4
    {
        public void CopyArrayToAnotherArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int[] newArray = new int[length];
            for (int index = 0; index < array.Length; index++)
            {
                newArray[index] = array[index];
            }
                
            Console.WriteLine("The Elements in the Array are: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The Elements copied to the New Array are: ");
            for (int index = 0; index < newArray.Length; index++)
            {
                Console.Write(newArray[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

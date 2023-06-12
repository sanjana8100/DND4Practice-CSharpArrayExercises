using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program1
    {
        public void StoreAndPrintArray()
        {
            int[] array = new int[10]; 
            Console.WriteLine("Please enter the 10 elements of the Array: ");
            for (int index =0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Elements in the Array are: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

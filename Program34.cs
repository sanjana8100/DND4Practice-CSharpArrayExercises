using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program34
    {
        public static void PrintMissingElementsInArrayBetween10And20()
        {
            int[] array = new int[10];

            Console.WriteLine($"Please enter 10 elements of the Array between 10 and 20: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"The Missing Elements in the Array between 10 and 20 are: {165 - array.Sum()}");
            Console.WriteLine();
        }
    }
}

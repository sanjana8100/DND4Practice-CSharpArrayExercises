using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program10
    {
        public void FindOddEvenElementsInArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int[] oddArray = new int[length];
            int[] evenArray = new int[length];
           
            int oddCount = 0, evenCount = 0;
            for (int index = 0; index < length; index++)
            {
                if (array[index] % 2 != 0)
                {
                    oddArray[oddCount] = array[index];
                    oddCount++;
                }
                else
                {
                    evenArray[evenCount] = array[index];
                    evenCount++;
                }
            }

            Console.WriteLine("The Even Elements are: ");
            for (int index = 0; index < evenCount; index++)
            {
                Console.Write(evenArray[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Odd Elements are: ");
            for (int index = 0; index < oddCount; index++)
            {
                Console.Write(oddArray[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

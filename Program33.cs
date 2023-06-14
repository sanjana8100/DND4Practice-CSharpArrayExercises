using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program33
    {
        public static void RemoveDuplicateElementsInArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            int[] countArray = new int[length];
            int count = 1, visited = -1;

            int[] newArray = new int[length];
            int newLength = 0;

            for (int index1 = 0; index1 < length; index1++)
            {
                count = 1;
                if (countArray[index1] != visited)
                {
                    for (int index2 = index1 + 1; index2 < countArray.Length; index2++)
                    {
                        if (array[index1] == array[index2])
                        {
                            countArray[index2] = visited;
                            count++;
                        }
                    }
                    countArray[index1] = count;
                    newArray[newLength++] = array[index1];
                }
            }

            Array.Resize(ref newArray, newLength);

            Console.WriteLine($"The new Array without Duplicate Elements is: ");
            for (int index = 0; index < newArray.Length; index++)
            {
                Console.WriteLine(newArray[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

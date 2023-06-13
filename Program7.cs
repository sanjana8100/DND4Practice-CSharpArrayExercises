using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program7
    {
        public void MergeTwoArraysInAscendingOrder()
        {
            Console.WriteLine("Please enter the number of elements in Array 1: ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[length1];

            Console.WriteLine($"Please enter {length1} elements of Array 1: ");
            for (int index = 0; index < array1.Length; index++)
            {
                array1[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter the number of elements in Array 2: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[length2];

            Console.WriteLine($"Please enter {length2} elements of Array 2: ");
            for (int index = 0; index < array2.Length; index++)
            {
                array2[index] = Convert.ToInt32(Console.ReadLine());
            }

            int newLength = length1 + length2;
            int[] newArray = new int[newLength];
            int index1;
            for (index1 = 0; index1 < length1; index1++)
            {
                newArray[index1] = array1[index1];
            }
            for (int index2 = 0; index2 < length2; index2++)
            {
                newArray[index1] = array2[index2];
                index1++;
            }

            for (int index = 0; index < newLength - 1; index++)
            {
                for (int index2 = index + 1; index2 < newLength; index2++)
                {
                    if (newArray[index] > newArray[index2])
                    {
                        int temp = newArray[index2];
                        newArray[index2] = newArray[index];
                        newArray[index] = temp;
                    }
                }
            }
            Console.WriteLine("The Merged Array in Ascending Order: ");
            for (int index = 0; index < newArray.Length; index++)
            {
                Console.Write(newArray[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDPractice_CSharpArrayExercises
{
    internal class Program35
    {
        public static void SumOfTwoLowestNegativeElementsInArray()
        {
            Console.WriteLine("Please enter the number of elements in the Array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Please enter {length} elements of the Array: ");
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

            Console.WriteLine($"Sum of two lowest negative numbers of the said array of integers: {array.Where(x => x < 0).OrderBy(x => x).Take(2).Sum()}");
            Console.WriteLine();
        }
    }
}

﻿namespace _02.Multidimensional_Arrays_Lecture
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] arr = new int[dim[0], dim[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }
            }
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

﻿using System;

namespace ConsoleApp4
{
    class Program51
    {
        static void MaxMinNumber()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($" max");
            Console.WriteLine($" min");
        }
        static void SummArray()
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            Random rnd = new Random();
            int[] array3 = new int[10];
            int[] array4 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);

            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(10, 100);

            }
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] * array2[i];
                Console.Write($" {array3[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                array4[i] = array[i] + array2[i];
                Console.Write($" {array4[i]}");
            }

        }
        public static void SameElements()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        array[i] = 0;
                        array[j] = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }





        }
        public static void ArrayLeson2()
        {
            int[] array = new int[10];
            int[] array1 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
                array1[i] = new Random().Next(1, 10);
            }
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" {array1[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int d = i + 1; d < array.Length; d++)
                {
                    if (array[i] == array[d])
                    {
                        array[d] = 0;
                    }
                }
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array[i] == array1[j])
                    {
                        Console.Write(" " + $"{array1[j]}");
                        array[i] = 0;
                    }
                }
            }
        }
    }
}



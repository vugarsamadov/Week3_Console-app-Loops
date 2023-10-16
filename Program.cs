﻿using System;
using System.Data;
using System.Runtime.InteropServices;

namespace October16
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] array = {0,1,1,1,0,9,8};

            #region Task1 Birinci Usul
            // Sinifde yazdigim

            int[] countsArray = new int[array.Length];

            /*
            Contains indexes of the array. Indexes of duplicate elements marked with -1 so that we can skip them
            during printing.
            */
            int[] indexes = new int[array.Length];

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        countsArray[i] += 1;
                }
            }


            for (int i = 0; i < indexes.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                        indexes[i] = -1;
                }
            }

            foreach (var i in indexes)
            {
                if (i > 0)
                    Console.WriteLine(array[i] + " -> " + countsArray[i]);
            }

            //--
            #endregion
            #region Task1 Ikinci usul

            //int maxElement = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (maxElement < array[i])
            //    {
            //        maxElement = array[i];
            //    }
            //}
            //int[] countsArray = new int[maxElement + 1];

            //foreach (var i in array)
            //{
            //    countsArray[i] += 1;
            //}

            //for (int i = 0; i < countsArray.Length; i++)
            //{
            //    if (countsArray[i] > 0)
            //        Console.WriteLine(i + " -> " + countsArray[i] + " dene");
            //}
            #endregion


            // 2
            #region Task2
            //int[] array;
            //do
            //{
            //    Console.Write("Enter array length: ");
            //    int arrayLength = Convert.ToInt32(Console.ReadLine()); // 5
            //    array = new int[arrayLength];

            //    if (arrayLength == 0)
            //        break;

            //    string command;
            //    bool commandCheck;
            //    int counter = 0;
            //    do
            //    {
            //        Console.Write("Enter (Yes,yes, Y,y) to add new item: ");
            //        command = Console.ReadLine();
            //        commandCheck = command == "Yes" || command == "yes" || command == "y" || command == "Y";
            //        if (!commandCheck)
            //            break;
            //        Console.Write("Enter a number: ");
            //        array[counter++] = Convert.ToInt32(Console.ReadLine());

            //    } while (counter<arrayLength);

            //} while (false);

            //Console.WriteLine();
            //Console.Write("Provided Array: ");
            //foreach (var i in array)
            //{
            //    Console.Write(i+" ");
            //}
            #endregion








        }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iteration with integer array
            //int[] testScores = { 98, 99, 85. 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++ )
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            // Interation with a string
            //string[] names = { "Shen", "Erik", "Daniel", "Jesse" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();


            // Iteration with a list
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //    Console.ReadLine();
            //}

            // Iteration with a string
            //    List<string> names = new List<string>() { "Shen", "Jesse", "Erik", "Adam" };

            //    foreach (string names in names)
            //    {
            //        if (names == "Jesse")
            //        {
            //            Console.WriteLine(names);
            //        }
            //    }
            //    Console.ReadLine();


            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}

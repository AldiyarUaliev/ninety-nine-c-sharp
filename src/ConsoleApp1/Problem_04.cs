﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Get the number of elements in a list
{
    public class Problem_04
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 4: Get  number of elements in a list.");
            Console.WriteLine("//////////////////////////////////////////////////////// ");
            Console.Write("Input a list of comma separated integers to form a list: ");

            try
            {
                var input = Console.ReadLine();

                int n = Convert.ToInt32(input);

                List<int> listOfNumbers = new List<int>();

                for (int i = 1; i <= n; i++)
                {
                    listOfNumbers.Add(i);
                }

                Console.WriteLine("The number of elements in this list is " + listOfNumbers.Count() + ".");
                Console.WriteLine(Environment.NewLine);
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
                Execute(null);
            }
        }
    }
}

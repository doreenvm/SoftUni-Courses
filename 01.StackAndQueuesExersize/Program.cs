using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperation
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackNumber = new Stack<int>(numbers);

            int numberToPush = int.Parse(input[0]);
            int numberToPop = int.Parse(input[1]); 
            int numberToLookFor = int.Parse(input[2]);


            if (numberToPop <= stackNumber.Count)
            {
                for (int i = 0; i < numberToPop; i++)
                {
                    stackNumber.Pop();
                }
            }

            if (stackNumber.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else if(stackNumber.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stackNumber.Min());
            }
            
        }
    }
}

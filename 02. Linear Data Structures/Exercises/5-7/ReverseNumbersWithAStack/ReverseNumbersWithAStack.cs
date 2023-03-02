using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseNumbersWithAStack
{
    class ReverseNumbersWithAStack
    {
        static void Main()
        {
            int[] numbersInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbersOutput = new Stack<int>();

            for (int i = 0; i < numbersInput.Length; i++)
            {
                numbersOutput.Push(numbersInput[i]);
            }

            while(numbersOutput.Count > 0)
            {
                Console.WriteLine(numbersOutput.Pop());
            }
        }
    }
}

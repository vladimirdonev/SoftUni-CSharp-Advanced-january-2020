using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    var leftindex = stack.Pop();
                    var word = expression.Substring(leftindex, i - leftindex + 1);
                    Console.WriteLine(word);
                }
            }

        }
    }
}

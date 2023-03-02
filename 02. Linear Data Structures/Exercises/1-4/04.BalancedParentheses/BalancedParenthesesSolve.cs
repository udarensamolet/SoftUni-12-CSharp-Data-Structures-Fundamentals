namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            Stack<char> parenthesis = new Stack<char>();
            bool result = false;
            for (int i = 0; i < parentheses.Length; i++)
            {
                char currentChar = parentheses[i];
                switch (currentChar)
                {
                    case '{':
                    case '[':
                    case '(':
                        parenthesis.Push(currentChar);
                        break;
                    case '}':
                    case ']':
                    case ')':

                        if (parenthesis.Count > 0)
                        {
                            char correctChar = GettingCorrectRightParentheses(currentChar);
                            char lastInputChar = parenthesis.Peek();
                            if (correctChar == lastInputChar)
                            {
                                parenthesis.Pop();
                                result = true;
                            }
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                        break;
                }
            }

            if (parenthesis.Count == 0 && result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static char GettingCorrectRightParentheses(char right)
        {
            char left = ' ';
            switch (right)
            {
                case '}':
                    left = '{';
                    break;
                case ']':
                    left = '[';
                    break;
                case ')':
                    left = '(';
                    break;
            }
            return left;
        }
    }
}

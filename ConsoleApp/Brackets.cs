using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Brackets
    {
        public static bool AreBracketsBalanced(string expr)
        {
            // chars allowed based on the requirements (< , >).
            char[] allowedChars = "<>".ToCharArray();

            int i = -1;
            char[] stack = new char[expr.Length];

            // return True if no brackets in the string.
            if (!allowedChars.Any(c => expr.Contains(c)))
            {
                return true;
            }

            foreach (char ch in expr)
            {
                // process only allowed chars and ignore the rest. 
                if (allowedChars.Any(c => c.Equals(ch)))
                {
                    if (ch == '<')
                    {
                        stack[++i] = ch;
                    }
                    else
                    {
                        if (i >= 0 && (stack[i] == '<' && ch == '>'))
                        {
                            i--;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return i == -1;
        }
    }
}

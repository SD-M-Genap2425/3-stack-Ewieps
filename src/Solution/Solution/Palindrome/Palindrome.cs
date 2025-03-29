using System;

    namespace Solution.Palindrome;

        public static class PalindromeChecker
        {
            public static bool CekPalindrom(string inp)
            {
                string normal = new string(inp.ToLower().Where(char.IsLetterOrDigit).ToArray());

                Stack<char> stack = new Stack<char>();

                foreach(char i in normal)
                {
                    stack.Push(i);
                }

                foreach (char i in normal)
                {
                    if (stack.Pop() != i) return false;
                }
                return true;
            }  
        }
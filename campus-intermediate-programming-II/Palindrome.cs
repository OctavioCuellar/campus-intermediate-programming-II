using System;

namespace campus_intermediate_programming_II
{
    public class Palindrome
    {
        public static bool IsPalindrome(string phrase)
        {
            Stack<string> stack = new Stack<string>();

            foreach (char c in phrase)
            {
                stack.Push(c.ToString());
            }
            string? palindromedPhrase = null;
            while (stack.Count > 0)
            {
                palindromedPhrase += stack.Peek(); stack.Pop();
            }

            if (phrase.ToLower().Replace(" ", "").Equals(palindromedPhrase.ToLower().Replace(" ", ""))) return true;
            return false;

        }
    }
}

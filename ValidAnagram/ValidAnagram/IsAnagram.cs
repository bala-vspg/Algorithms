using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    //Given two strings s and t, write a function to determine if t is an anagram of s.

    //    For example,
    //    s = "anagram", t = "nagaram", return true.
    //s = "rat", t = "car", return false.
    //Follow up:What if the inputs contain unicode characters? How would you adapt your solution to such case?
    //This solution is for unicode. If only lowercase, we can go with arrayIndex way with 26 as array size.
    public class IsAnagram
    {
        private void IsValid(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                throw new ArgumentException();
             }
        }

        private void CharCounter(string s1,out Dictionary<char,int> chars)
        {
           chars =new Dictionary<char, int>();
            foreach (var c in s1)
            {
                if (chars.ContainsKey(c))
                    chars[c]++;
                else
                    chars.Add(c, 1);
            }

        }

        public bool IsValidAnagram(string s1, string s2)
        {
            IsValid(s1, s2);
            if (s1.Length != s2.Length)
                return false;
            else
            {
                Dictionary<char, int> chars;
                CharCounter(s1, out chars);
                foreach (var c in s2)
                {
                    if (chars.ContainsKey(c) && chars[c] >= 0)
                        chars[c]--;
                    else
                        return false;
                }
                return true;
            }
        }
    }
}

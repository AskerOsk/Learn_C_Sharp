﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class1
    {
        /* 
    * You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.

   Return the number of consistent strings in the array words.



   Example 1:

   Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
   Output: 2
   Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'.
   Example 2:

   Input: allowed = "abc", words = ["a","b","c","ab","ac","bc","abc"]
   Output: 7
   Explanation: All strings are consistent.
   Example 3:

   Input: allowed = "cad", words = ["cc","acd","b","ba","bac","bad","ac","d"]
   Output: 4
   Explanation: Strings "cc", "acd", "ac", and "d" are consistent.
   */

        public class Solution
        {
            public int CountConsistentStrings(string allowed, string[] words)
            {

                HashSet<char> allowedSet = new HashSet<char>(allowed);

                int count = 0;
                foreach (string word in words)
                {
                    bool dd = true;

                    foreach (char c in word)
                    {
                        if (!allowedSet.Contains(c))
                        {
                            dd = false;
                            break;
                        }
                    }
                    if (dd)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

    }
}

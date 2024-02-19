using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubstring.Manager
{
    public class FindLongestSubstringManager
    {

        public List<int> GetLongestSubstring(string input)
        {
            var numbersStr = input.Split(' ');
            var numbers = new List<int>();
            var longestSubstring = new List<int>();


            foreach (var numStr in numbersStr)
            {
                if (int.TryParse(numStr, out int num))
                {
                    numbers.Add(num);
                }
            }

            if (numbers.Any())
            {
                var currentSubstring = new List<int> { numbers[0] };
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                        currentSubstring.Add(numbers[i + 1]);
                    else if (currentSubstring.Count > longestSubstring.Count)
                    {
                        longestSubstring = currentSubstring;
                        currentSubstring = new List<int> { numbers[i + 1] };
                    }
                    else
                    {
                        currentSubstring = new List<int> { numbers[i + 1] };
                    }
                }

                return longestSubstring.Any() ? longestSubstring : currentSubstring;
            }

            return new List<int>();
        }
    }
}

using LongestIncreasingSubstring.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestIncreasingSubstring
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your list of numbers: ");
            var userInput = Console.ReadLine();

            while (userInput == null || userInput == string.Empty || Regex.Replace(userInput, @"\s+", "") == string.Empty)
            {
                Console.WriteLine("Please enter a valid list of numbers: ");
                userInput = Console.ReadLine();
            }

            var findLongestSubstringManager = new FindLongestSubstringManager();
            var longestIncreasingSubsequence = findLongestSubstringManager.GetLongestSubstring(userInput);

            // Print the result
            if (!longestIncreasingSubsequence.Any())
                Console.WriteLine("Your input didn't include any valid numbers.");
            else
            {
                Console.WriteLine("Longest increasing subsequence:");
                Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
            }
        }
    }
}

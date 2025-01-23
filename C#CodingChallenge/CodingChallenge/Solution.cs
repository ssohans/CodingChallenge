
using System.Text;

namespace CodingChallenge
{
    /// <summary>
    /// A static class containing solutions to coding challenges.
    /// </summary>
    public static class Solution
    {

        /// <summary>
        /// List of charecter mapped in each key
        /// </summary>
        private static Dictionary<string, string> keyAlpha = new()
        {
            { "2", "abc" },
            { "3", "def" },
            { "4", "ghi" },
            { "5", "jkl" },
            { "6", "mno" },
            { "7", "pqrs" },
            { "8", "tuv" },
            { "9", "wxyz" }
        };

        /// <summary>
        /// This method convert pressed old-style phone keypad string to text
        /// <example>
        /// For example:
        /// <code>
        /// var sms = Solution.OldPhonePad("222");
        /// </code>
        /// results in <c>sms</c>'s having the value "C".
        /// </example>
        /// </summary>
        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                return string.Empty;
            }

            StringBuilder result = new();

            for(var index = 0; index<input.Length; index++)
            {
                var ch = input[index];
                if (keyAlpha.ContainsKey(ch.ToString()))
                {
                    var count = 0;
                    var pointer = index;
                    while (pointer<input.Length && ch == input[pointer])
                    {
                        count++;    
                        pointer++;
                    }

                    var position = (count % keyAlpha[ch.ToString()].Length - 1);

                    if (position >= 0)
                    {
                        result.Append(keyAlpha[ch.ToString()][position]);
                    }
                    else
                    {
                        result.Append(keyAlpha[ch.ToString()].Last());
                    }

                    index = pointer-1;
                }
                else if (input[index] == '#')
                {
                    break;
                }
                else if (input[index] == '*' && result.Length > 0)
                {
                    result.Length--;
                }
                else if (input[index] == ' ')
                {
                    continue;
                }
                else
                {
                    return "Error: Unwanted input";
                }
            }

            // Method intentionally left empty.
            return result.ToString().ToUpper();
        }
    }
}
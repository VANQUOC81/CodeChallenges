using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class RomanToInteger : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 13;

        public string Execute(string input)
        {
            var input2 = "MCMXCIV";

            return RomanToInt(input2).ToString();
        }

        public string GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanToInt = new Dictionary<char, int>() {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };

            int result = 0;

            // iterate through the roman numeral string from right to left
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i < s.Length - 1 && romanToInt[s[i]] < romanToInt[s[i + 1]])
                {
                    // if the current roman numeral is smaller than the previous one,
                    // subtract it from the result instead of adding
                    result -= romanToInt[s[i]];
                }
                else
                {
                    // add the value of the current roman numeral to the result
                    result += romanToInt[s[i]];
                }
            }

            return result;
        }
    }
}

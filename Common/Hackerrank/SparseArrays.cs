using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank
{
    public class SparseArrays : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

        public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

        public string Execute()
        {
            List<string> strings = new List<string>
            {
                "aba",
                "baba",
                "aba",
                "xzxb"
            };

            List<string> stringsToLookFor = new List<string>
            {
                "aba",
                "xzxb",
                "ab"
            };

            return string.Join(",", MatchingStrings(strings, stringsToLookFor));
        }

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY of matches of stringsToLookFor.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY stringsToLookFor
         */
        public static List<int> MatchingStrings(List<string> strings, List<string> stringsToLookFor)
        {
            var result = new List<int>();

            foreach (var item in stringsToLookFor)
            {
                var matchResult = strings.Where(x => x == item);

                result.Add(matchResult.Count());
            }

            return result;
        }

        public void GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }
    }
}

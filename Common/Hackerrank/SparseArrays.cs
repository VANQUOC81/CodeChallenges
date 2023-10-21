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
            int stringsCount = Convert.ToInt32("4");

            List<string> strings = new List<string>();
            strings.Add("aba");
            strings.Add("baba");
            strings.Add("aba");
            strings.Add("xzxb");

            int queriesCount = Convert.ToInt32("3");

            List<string> queries = new List<string>();
            queries.Add("aba");
            queries.Add("xzxb");
            queries.Add("ab");

            List<int> result = MatchingStrings(strings, queries);
            Console.Write(string.Join(",", result));

            return string.Join(",", result);
        }

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         */
        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();

            foreach (var item in queries)
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

using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank
{
    public class TimeConversion : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

        public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

        public string Execute(string input)
        {
            // Calling function and return
            return ConvertTime("07:05:45PM");
        }

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string ConvertTime(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

        public string GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }
    }
}

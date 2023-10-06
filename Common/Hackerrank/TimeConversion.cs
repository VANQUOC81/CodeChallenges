using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank
{
    public class TimeConversion : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

        public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

        public string Execute()
        {
            const string s = "07:05:45PM";

            return  ConvertTime(s);
        }

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string ConvertTime(string s)
        {
            // solution
            var t = DateTime.Parse(s);

            return t.ToString("HH:mm:ss");
        }

        public void GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }
    }
}

using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class Pangram : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    /*
     * Complete the 'GetPangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public string Execute(string input)
    {
        string s = "We promptly judged antique ivory buckles for the prize";

        return GetPangrams(s);
    }

    public static string GetPangrams(string s)
    {
        string noSpaces = s.Replace(" ", string.Empty).ToLowerInvariant();
        var listChars = noSpaces.Distinct().ToList();

        var abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLowerInvariant().ToList();
        var abcCount = abc.Count;

        int count = 0;
        foreach (char c in listChars)
        {
            if (abc.Contains(c))
            {
                count++;
            }
        }

        if (count.Equals(abcCount))
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }
    }

    public string GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

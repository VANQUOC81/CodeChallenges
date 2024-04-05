using System.Globalization;
using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class RoundingDirectionNearestLargerInteger : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Snippets;

    public int CodeChallengeNumber => throw new NotImplementedException("Snippets doesn't have numbers");

    /*
        rounding where positive numbers are rounded up to the nearest larger integer and 
        negative numbers are rounded down to the nearest larger integer
     */

    public string Execute()
    {
        decimal value = -1.5M;

        return RoundToNearestLargerInteger(value).ToString(CultureInfo.InvariantCulture);
    }

    public static decimal RoundToNearestLargerInteger(decimal value)
    {
        // Check if the value is negative
        if (value < 0)
        {
            // For negative numbers, round down to the nearest integer
            return Math.Ceiling(value);
        }
        else
        {
            // For positive numbers, round up to the nearest integer
            return Math.Round(value, MidpointRounding.AwayFromZero);
        }
    }

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

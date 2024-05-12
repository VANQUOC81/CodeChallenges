using System.Globalization;
using Common.Enums;
using Common.Interfaces;

namespace Common.Snippets;

public class RoundingDirectionNearestLargerInteger : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Snippets;

    public int CodeChallengeNumber => 1;

    /*
        rounding where positive numbers are rounded up to the nearest larger integer and 
        negative numbers are rounded down to the nearest larger integer
     */

    public string Execute(string input)
    {
        decimal value = -1.5M;

        return RoundToNearestLargerInteger(value).ToString(CultureInfo.InvariantCulture);
    }

    public static decimal RoundToNearestLargerInteger(decimal value)
    {
        // Check if the value is negative
        if (value < 0)
        {
            // Check if the absolute value is a midpoint (e.g., -4.5)
            if (Math.Abs(value) - Math.Floor(Math.Abs(value)) == 0.5m)
            {
                // If it's a midpoint, round up to the nearest larger integer
                return Math.Floor(value);
            }
            else
            {
                // Otherwise, round down to the nearest integer
                return Math.Ceiling(value);
            }
        }
        else
        {
            // For positive numbers, round up to the nearest integer
            return Math.Round(value, MidpointRounding.AwayFromZero);
        }
    }

    public string GetInputValuesCommands()
    {
        bool showCommand = true;
        string input = string.Empty;
        while (showCommand)
        {
            // show command prompts.
            Console.WriteLine("Please provide input values for the challenge:");

            input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input) || input.Length == 0)
            {
                Console.WriteLine($"Input values cannot be empty. Please try again.");

                continue;
            }
            else
            {
                showCommand = false;
            }
        }

        return input;
    }
}

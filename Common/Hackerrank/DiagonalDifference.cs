using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class DiagonalDifference : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute(List<string> input)
    {
        // Sample how a input may look like for this challenge
        // input = new List<string>{ "11, 2, 4", "4, 5, 6", "10, 8, -12"};
        List<List<int>> intList = new List<List<int>>();

        foreach (var inputValues in input)
        {
            List<int> tempList = inputValues.Split(',')
                                    .Select(int.Parse)
                                    .ToList();
            intList.Add(tempList);
        }

        // Calling function and return
        return GetDiagonalDifference(intList).ToString();
    }

    /*
     * Complete the 'GetDiagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int GetDiagonalDifference(List<List<int>> arr)
    {
        int primarySum = 0;
        int secondarySum = 0;

        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            primarySum += arr[i][i];
            secondarySum += arr[i][n - i - 1];
        }

        return Math.Abs(primarySum - secondarySum);
    }

    public List<string> GetInputValuesCommands()
    {
        var inputList = new List<string>();
        bool showCommand = true;

        while (showCommand)
        {
            // show command prompts.
            Console.WriteLine("Please provide (more) input values for the challenge like e.g. '11, 2, 4':");

            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input) || input.Length == 0)
            {
                Console.WriteLine($"Input values cannot be empty. Please try again.");

                continue;
            }
            else
            {
                inputList.Add(input);
            add_more_input_question:
                Console.WriteLine("Do you want to add more input?");

                input = Console.ReadLine() ?? string.Empty;

                if (input.ToLower().Equals("no") || input.ToLower().Equals("yes"))
                {
                    if (input.ToLower().Equals("yes"))
                    {
                        continue;
                    }
                    else
                    {
                        showCommand = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please say yes or no");
                    goto add_more_input_question;
                }
            }
        }

        return inputList;
    }
}

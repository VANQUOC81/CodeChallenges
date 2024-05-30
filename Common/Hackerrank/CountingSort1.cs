using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class CountingSort1 : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute(List<string> input)
    {
        // Sample input
        //List<int> inputList = new() { 63, 25, 73, 1, 98, 73, 56, 84 /* add your elements here */ };
        List<int> inputList = input.Select(int.Parse).ToList();

        // Calling counting sort function and return
        return string.Join(",", CountingSort(inputList));
    }

    /*
     * Complete the 'CountingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> CountingSort(List<int> arr)
    {
        // Create a frequency array with 100 elements initialized to 0
        int[] frequency = new int[100];

        // Count occurrences of each value in the input list
        foreach (int num in arr)
        {
            frequency[num]++;
        }

        // Convert the frequency array to a list and return it
        List<int> result = new List<int>(frequency);
        return result;
    }

    public List<string> GetInputValuesCommands()
    {
        var inputList = new List<string>();
        bool showCommand = true;

        while (showCommand)
        {
            // show command prompts.
            Console.WriteLine("Please provide (more) input values for the challenge:");

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

using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class CountingSort1 : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute()
    {
        // Sample input
        List<int> inputList = new() { 63, 25, 73, 1, 98, 73, 56, 84 /* add your elements here */ };

        // Calling counting sort function
        List<int> result = CountingSort(inputList);

        return string.Join(",", result);
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

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

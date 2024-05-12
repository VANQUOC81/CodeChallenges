using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class DiagonalDifference : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute(string input)
    {
        // Sample input
        List<List<int>> inputList = new()
        {
            new List<int>() { 11, 2, 4 },
            new List<int>() { 4, 5, 6 },
            new List<int>() { 10, 8, -12 }
        };

        // Calling function and return
        return GetDiagonalDifference(inputList).ToString();
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

    public string GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class DiagonalDifference : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute()
    {
        // Sample input
        List<List<int>> inputList = new()
        {
            new List<int>() { 11, 2, 4 },
            new List<int>() { 4, 5, 6 },
            new List<int>() { 10, 8, -12 }
        };

        // Calling function
        var result = GetDiagonalDifference(inputList);

        return result.ToString();
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

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

// class Result
// {

//     /*
//      * Complete the 'diagonalDifference' function below.
//      *
//      * The function is expected to return an INTEGER.
//      * The function accepts 2D_INTEGER_ARRAY arr as parameter.
//      */

//     public static int diagonalDifference(List<List<int>> arr)
//     {
//         int sumLeftToRight = 0;
//         int sumRightToLeft = 0;

//         int count = 0;
//         int countEnd = arr.First().Count - 1;

//         foreach (var row in arr)
//         {

//             sumLeftToRight += row.ElementAt(count);
//             sumRightToLeft += row.ElementAt(countEnd);

//             count++;
//             countEnd--;

//         }

//         int absoluteDiff = Math.Abs(sumLeftToRight - sumRightToLeft);

//         return absoluteDiff;
//     }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         // int n = Convert.ToInt32(Console.ReadLine().Trim());

//         List<List<int>> arr = new List<List<int>>();
//         arr.Add(new List<int> { 1, 2, 3 });
//         arr.Add(new List<int> { 4, 5, 6 });
//         arr.Add(new List<int> { 9, 8, 9 });


//         // for (int i = 0; i < n; i++)
//         // {
//         //     arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//         // }

//         int result = Result.diagonalDifference(arr);

//         // textWriter.WriteLine(result);

//         // textWriter.Flush();
//         // textWriter.Close();
//     }
// }
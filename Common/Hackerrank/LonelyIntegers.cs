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
//      * Complete the 'lonelyinteger' function below.
//      *
//      * The function is expected to return an INTEGER.
//      * The function accepts INTEGER_ARRAY a as parameter.
//      */

//     public static int lonelyinteger(List<int> a)
//     {
//         int unique = 0;

//         foreach (var i in a)
//         {
//                 int count = 0;
//                 foreach (var j in a)
//                 {
//                     if(i == j)
//                     {
//                         count++;
//                     }
//                 }

//                 if(count == 1)
//                 {
//                     unique = i;
//                     break;
//                 }
//         }

//         return unique;
//     }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         // int n = Convert.ToInt32(Console.ReadLine().Trim());

//         //  List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//         List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };

//         int result = Result.lonelyinteger(a);
//         Console.WriteLine(result);
//         // textWriter.WriteLine(result);

//         // textWriter.Flush();
//         // textWriter.Close();
//     }
// }

using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class LonelyInteger : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException();

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public string Execute()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 3, 2, 1 };

        return Lonelyinteger(numbers).ToString();
    }

    public static int Lonelyinteger(List<int> a)
    {
        int unique = 0;

        foreach (var i in a)
        {
            int count = 0;
            foreach (var j in a)
            {
                if (i == j)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                unique = i;
                break;
            }
        }

        return unique;
    }

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

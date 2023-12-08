using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class FlippingBits : ICodeChallenge
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

        // Calling function and return
        return GetFlippingBits(inputList).ToString();
    }

/*
     * Complete the 'GetFlippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long GetFlippingBits(long n)
    {

    }

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

// using System.Security.Cryptography;
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
//      * Complete the 'flippingBits' function below.
//      *
//      * The function is expected to return a LONG_INTEGER.
//      * The function accepts LONG_INTEGER n as parameter.
//      */

//     public static long flippingBits(long n)
//     {
//         // good website which explains bits and bytes
//         // https://www.beterrekenen.nl/website/index.php?pag=259#:~:text=Er%20is%20een%20handige%20manier,je%20hebt%20het%20binaire%20getal.

//         // move to left from index 0 of a byte and toggle 0 to 1 or 1 to 0.
//         //var flipped = n ^= (1 << 0);
//         // The ~ operator inverts each bits i.e. changes 1 to 0 and 0 to 1.
//         //var flipped = ~n;
//         UInt32 casted = (UInt32)n;
//         return ~casted;

//     }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         int q = Convert.ToInt32(1);

//         for (int qItr = 0; qItr < q; qItr++)
//         {
//             long n = Convert.ToInt64(3);

//             // Console.WriteLine(Convert.ToString(n, toBase: 2));

//             Console.WriteLine($"before decimal value : {n}");
//             Console.WriteLine($"before binary value : {Convert.ToString(n, toBase: 2)}");

//             long result = Result.flippingBits(n);

//             // textWriter.WriteLine(result);
//             Console.WriteLine($"after decimal value : {result}");
//             Console.WriteLine($"after binary value : {Convert.ToString(result, toBase: 2)}");
//         }

//         // textWriter.Flush();
//         // textWriter.Close();
//     }
// }

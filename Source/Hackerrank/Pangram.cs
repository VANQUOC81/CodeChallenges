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
//      * Complete the 'pangrams' function below.
//      *
//      * The function is expected to return a STRING.
//      * The function accepts STRING s as parameter.
//      */

//     public static string pangrams(string s)
//     {
//         string noSpaces = s.Replace(" ", string.Empty).ToLowerInvariant();
//         var listChars = noSpaces.Distinct().ToList();

//         var abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLowerInvariant().ToList();
//         var abcCount = abc.Count;

//         int count = 0;
//         foreach (char c in listChars)
//         {
//             if (abc.Contains(c))
//             {
//                 count++;
//             }
//         }

//         if (count.Equals(abcCount))
//         {
//             return "pangram";
//         }
//         else
//         {
//             return "not pangram";
//         }
//     }
// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         // ?TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         string s = "We promptly judged antique ivory buckles for the prize";

//         string result = Result.pangrams(s);

//         Console.WriteLine(result);

//         // textWriter.WriteLine(result);

//         // textWriter.Flush();
//         // textWriter.Close();
//     }
// }

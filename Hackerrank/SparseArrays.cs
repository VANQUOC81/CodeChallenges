// using System.Runtime.CompilerServices;
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
//      * Complete the 'matchingStrings' function below.
//      *
//      * The function is expected to return an INTEGER_ARRAY.
//      * The function accepts following parameters:
//      *  1. STRING_ARRAY strings
//      *  2. STRING_ARRAY queries
//      */

//     public static List<int> matchingStrings(List<string> strings, List<string> queries)
//     {
//         var result = new List<int>();

//         foreach (var item in queries)
//         {
//             var matchResult = strings.Where(x => x == item);
            
//             result.Add(matchResult.Count());
//         }

//         return result;
//     }

//     class Solution
//     {
//         public static void Main(string[] args)
//         {
//             // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//             int stringsCount = Convert.ToInt32("4");

//             List<string> strings = new List<string>();
//             strings.Add("aba");
//             strings.Add("baba");
//             strings.Add("aba");
//             strings.Add("xzxb");

//             // for (int i = 0; i < stringsCount; i++)
//             // {
//             //     string stringsItem = Console.ReadLine();
//             //     strings.Add(stringsItem);
//             // }

//             int queriesCount = Convert.ToInt32("3");

//             List<string> queries = new List<string>();
//             queries.Add("aba");
//             queries.Add("xzxb");
//             queries.Add("ab");

//             // for (int i = 0; i < queriesCount; i++)
//             // {
//             //     string queriesItem = Console.ReadLine();
//             //     queries.Add(queriesItem);
//             // }

//             List<int> res = Result.matchingStrings(strings, queries);
//             Console.Write(string.Join(",", res));
//             //     textWriter.WriteLine(String.Join("\n", res));

//             //     textWriter.Flush();
//             //     textWriter.Close();
//         }
//     }
// }

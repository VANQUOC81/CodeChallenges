﻿using Common.Interfaces;
using Common.Enums;
using System.Reflection;
using Source.Factories;

namespace Source
{
    public static class Program
    {
        public static void Main()
        {
            // show options
            (string challengeSource, int number) = ShowConsoleCommands();

            if (number != 0)
            {
                var codeChallenge = ServiceProviderFactory.GetRequiredService<ICodeChallenge>()
                .First(x => x.CodeChallengeSource == GetCodeChallengeSourceEnum(challengeSource) && x.CodeChallengeNumber == number);

                // get input values Why do you have this here?
                List<string> input = codeChallenge.GetInputValuesCommands();

                // TODO pass in input to execute challenge
                var result = codeChallenge.Execute(input);

                // display result
                Console.WriteLine($"result: {result}");
            }
        }

        private static (string challengeSource, int codeChallengeNumber) ShowConsoleCommands()
        {
            var challengeSources = new string[] { "LeetCode", "Hackerrank", "Snippets" };
            bool showCommand = true;
            int number = default;
            string source = string.Empty;
            string challengeSource= string.Empty;
            while (showCommand)
            {
                // show command prompts.
                Console.WriteLine("Type in the challenge source:");

                source = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(source) || !challengeSources.Select(x => x.ToLower()).Contains(source.ToLower()))
                {
                    Console.WriteLine($"Invalid input: {source}");

                    continue;
                }

                challengeSource = challengeSources.Where(c => c.ToLower() == source.ToLower()).Single();

                string folderPath = $@"{Directory.GetCurrentDirectory()}\..\Common\{challengeSource}";
                string[] files = Directory.GetFiles(folderPath, "*.cs");

                Console.WriteLine($"List of {challengeSource} Code Challenges:");
                Console.WriteLine();
                foreach (string file in files)
                {
                    // get filename without extension
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    var CodeChallengeNumber = GetCodeChallengeNumber(fileName, challengeSource);
                    if (CodeChallengeNumber == null) continue;
                    Console.WriteLine($"{fileName}: {CodeChallengeNumber}");
                }

                Console.WriteLine();
                Console.WriteLine("Type in the number of the challenge:");

                string? input = Console.ReadLine();

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine($"Invalid input. Could not parse: {input}");
                }
                else
                {
                    showCommand = false;
                }
            }

            return (challengeSource, number);
        }

        private static object? GetCodeChallengeNumber(string fileName, string source)
        {
            // load the desired assembly
            Assembly externalAssembly = Assembly.LoadFrom("../Common/obj/Debug/net7.0/common.dll");

            Type? type = externalAssembly.GetType($"Common.{source}.{fileName}");
            if (type == null) return null;
            object? instance = Activator.CreateInstance(type);

            PropertyInfo? propertyInfo = type.GetProperty("CodeChallengeNumber");

            return propertyInfo?.GetValue(instance);
        }

        private static CodeChallengeSource GetCodeChallengeSourceEnum(string source)
        {
            return (source.ToLower() ?? string.Empty) switch
            {
                "snippets" => CodeChallengeSource.Snippets,
                "leetcode" => CodeChallengeSource.LeetCode,
                "hankerrank" => CodeChallengeSource.Hankerrank,
                _ => throw new ArgumentException("source isn't supported yet."),
            };
        }
    }
}

using Common.Interfaces;
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
            int number = ShowConsoleCommands();
            if (number != 0)
            {
                var codeChallenge = ServiceProviderFactory.GetRequiredService<ICodeChallenge>().
                
                // TODO return tuple with CodeChallengeSource
                First(x => x.CodeChallengeSource == CodeChallengeSource.Snippets && x.CodeChallengeNumber == number);

                // get input values Why do you have this here?
                codeChallenge.GetInputValuesCommands();

                // execute challenge
                var result = codeChallenge.Execute();

                // display result
                Console.WriteLine($"result: {result}");
            }
        }

        private static (string? source, int codeChallengeNumber) ShowConsoleCommands()
        {
            var challengeSources = new string []{"LeetCode", "Hackerrank", "Snippets"}; 
            bool showCommand = true;
            int number = default;
            string? source = default;
            while (showCommand)
            {
                // show command prompts.
                Console.WriteLine("Type in the challenge source:");

                source = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(source) || !challengeSources.Contains(source))
                {
                    Console.WriteLine($"Invalid input: {source}");

                    continue;
                }

                string folderPath = $@"{Directory.GetCurrentDirectory()}\..\Common\{source}";
                string[] files = Directory.GetFiles(folderPath, "*.cs");

                Console.WriteLine($"List of {source} Code Challenges:");
                Console.WriteLine();
                foreach (string file in files)
                {
                    // get filename without extension
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    var CodeChallengeNumber = GetCodeChallengeNumber(fileName, source);
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

            return (source, number);
        }

        private static object? GetCodeChallengeNumber(string fileName, string? source)
        {
            // load the desired assembly
            Assembly externalAssembly = Assembly.LoadFrom("../Common/obj/Debug/net7.0/common.dll");

            Type? type = externalAssembly.GetType($"Common.{source}.{fileName}");
            if (type == null) return null;
            object? instance = Activator.CreateInstance(type);

            PropertyInfo? propertyInfo = type.GetProperty("CodeChallengeNumber");

            return propertyInfo?.GetValue(instance);
        }
    }
}

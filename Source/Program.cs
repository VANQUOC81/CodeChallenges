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
                var result = ServiceProviderFactory.GetRequiredService<ICodeChallenge>().
                First(x => x.CodeChallengeSource == CodeChallengeSource.LeetCode && x.CodeChallengeNumber == number).Execute();

                Console.WriteLine(result);
            }
        }

        private static int ShowConsoleCommands()
        {
            bool showCommand = true;
            int number = default;
            while (showCommand)
            {
                // show command prompts.
                string folderPath = $@"{Directory.GetCurrentDirectory()}\..\Common\LeetCode";
                string[] files = Directory.GetFiles(folderPath, "*.cs");

                Console.WriteLine("List of LeetCode Code Challenges:");
                Console.WriteLine();
                foreach (string file in files)
                {
                    // get filename without extension
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    var CodeChallengeNumber = GetCodeChallengeNumber(fileName);
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

            return number;
        }

        private static object? GetCodeChallengeNumber(string fileName)
        {
            // load the desired assembly
            Assembly externalAssembly = Assembly.LoadFrom("../Common/obj/Debug/net7.0/common.dll");

            Type? type = externalAssembly.GetType($"Common.LeetCode.{fileName}");
            if (type == null) return null;
            object? instance = Activator.CreateInstance(type);

            PropertyInfo? propertyInfo = type.GetProperty("CodeChallengeNumber");

            return propertyInfo?.GetValue(instance);
        }
    }
}

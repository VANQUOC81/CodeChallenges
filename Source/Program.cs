using Common.Interfaces;
using Common.Enums;
using Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;

namespace Source
{
    public class Program
    {
        public static void Main()
        {
            int number = ShowConsoleCommands();
            if (number != 0)
            {
                // configure and register services in container
                ServiceProvider serviceProvider = new ServiceCollection()
                 .AddMyAppServices()
                 .BuildServiceProvider();

                // get services and scope only the dependencies registered for this container
                using var scope = serviceProvider.CreateScope();

                var requiredServices = scope.ServiceProvider.GetServices<ICodeChallenge>()
                .First(x => x.CodeChallengeSource == CodeChallengeSource.LeetCode && x.CodeChallengeNumber == number);

                var result = requiredServices.Execute();

                var concatResult = string.Empty;

                // display results in console
                foreach (var innerresult in result)
                {
                    concatResult = string.Join(", ", innerresult);
                    Console.WriteLine(concatResult);
                }
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

                    // load the desired assembly
                    Assembly externalAssembly = Assembly.LoadFrom("../Common/obj/Debug/net6.0/common.dll");

                    Type type = externalAssembly.GetType($"Common.LeetCode.{fileName}");
                    if (type == null) continue;
                    object instance = Activator.CreateInstance(type);

                    PropertyInfo propertyInfo = type.GetProperty("CodeChallengeNumber");
                    propertyInfo.GetValue(instance);

                    Console.WriteLine($"{fileName}: {propertyInfo.GetValue(instance)}");
                }

                Console.WriteLine();
                Console.WriteLine("Type in the number of the challenge:");

                string input = Console.ReadLine();

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
    }
}
using Common.Interfaces;
using Common.Enums;
using Common;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        // configure and register services in container
        ServiceProvider serviceProvider = new ServiceCollection()
        .AddMyAppServices()
        .BuildServiceProvider();

        // get services and scope only the dependencies registered for this container
        using (var scope = serviceProvider.CreateScope())
        {
            var requiredServices = scope.ServiceProvider.GetServices<ICodeChallenge>()
            .First(x => x.CodeChallengeSource == CodeChallengeSource.LeetCode && x.GetType().Name == "MinimumOperationsToMakeTheArrayIncreasing");

            var result = requiredServices.Execute();

            var concatResult = "";

            foreach (var innerresult in result)
            {
                concatResult = string.Join(", ", innerresult);
                Console.WriteLine(concatResult);
            }
        }
    }
}
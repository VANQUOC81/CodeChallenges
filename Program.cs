// XX. description
using CodeChallenges.Interfaces;
using Hackerrank;
using LeetCode;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        // configure and register services in container
        var services = new ServiceCollection();
        services.AddSingleton<ICodeChallenge, TimeConversion>();
        services.AddSingleton<ICodeChallenge, IntersectionofTwoArrayII>();
        var serviceProvider = services.BuildServiceProvider();

        // get services
        var requiredServices = serviceProvider.GetServices<ICodeChallenge>()
        .First(x => x.CodeChallengeSource == Enums.CodeChallengeSource.LeetCode && x.GetType().Name == "IntersectionofTwoArrayII");

        var result = requiredServices.Execute();

        Console.WriteLine(result);
    }
}
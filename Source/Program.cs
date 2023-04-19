using Source.Interfaces;
using Source.Hackerrank;
using Source.LeetCode;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        // configure and register services in container
        var services = new ServiceCollection();
        services.AddSingleton<ICodeChallenge, TimeConversion>();
        services.AddSingleton<ICodeChallenge, IntersectionofTwoArrayII>();
        services.AddSingleton<ICodeChallenge, FindTheTownJudge>();
        services.AddSingleton<ICodeChallenge, MinimumOperationsToMakeTheArrayIncreasing>();
        var serviceProvider = services.BuildServiceProvider();

        // get services
        var requiredServices = serviceProvider.GetServices<ICodeChallenge>()
        .First(x => x.CodeChallengeSource == Source.Enums.CodeChallengeSource.LeetCode && x.GetType().Name == "MinimumOperationsToMakeTheArrayIncreasing");

        var result = requiredServices.Execute();

            var concatResult = "";

            foreach (var innerresult in result)
            {
                concatResult = string.Join(", ", innerresult);
                Console.WriteLine(concatResult);
            }
    }
}
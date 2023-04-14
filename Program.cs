// XX. description
using CodeChallenges.Interfaces;
using Hackerrank;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        // configure and register services in container
        var services = new ServiceCollection();
        services.AddSingleton<ICodeChallenge, TimeConversion>();
        var serviceProvider = services.BuildServiceProvider();

        // get services
        var requiredServices = serviceProvider.GetServices<ICodeChallenge>()
        .First(x => x.CodeChallengeSource == Enums.CodeChallengeSource.Hankerrank && x.GetType().Name == "TimeConversion");

        var result = requiredServices.Execute();

        Console.WriteLine(result);
    }
}
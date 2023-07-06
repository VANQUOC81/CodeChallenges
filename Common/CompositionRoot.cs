using Microsoft.Extensions.DependencyInjection;
using Common.Hackerrank;
using Common.Interfaces;
using Common.LeetCode;

namespace Common;

public static class CompositionRoot
{
    public static IServiceCollection AddMyAppServices(this IServiceCollection services)
    {
        // register dependencies
        services.AddSingleton<ICodeChallenge, BestTimetoBuyandSellStockII>();
        services.AddSingleton<ICodeChallenge, TimeConversion>();
        services.AddSingleton<ICodeChallenge, IntersectionofTwoArrayII>();
        services.AddSingleton<ICodeChallenge, FindTheTownJudge>();
        services.AddSingleton<ICodeChallenge, MinimumOperationsToMakeTheArrayIncreasing>();
        services.AddSingleton<ICodeChallenge, ThreeSum>();
        services.AddSingleton<ICodeChallenge, RangeSumofBST>();
        services.AddSingleton<ICodeChallenge, RomanToInteger>();

        return services;
    }
}

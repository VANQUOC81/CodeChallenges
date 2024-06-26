﻿using Microsoft.Extensions.DependencyInjection;
using Common.Hackerrank;
using Common.Interfaces;
using Common.LeetCode;
using Common.Snippets;

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
        services.AddSingleton<ICodeChallenge, Pangram>();
        services.AddSingleton<ICodeChallenge, ThreeSum>();
        services.AddSingleton<ICodeChallenge, RangeSumofBST>();
        services.AddSingleton<ICodeChallenge, RoundingDirectionNearestLargerInteger>();
        services.AddSingleton<ICodeChallenge, RemoveDuplicatesfromSortedArray>();
        services.AddSingleton<ICodeChallenge, RomanToInteger>();
        services.AddSingleton<ICodeChallenge, RotateArray>();
        services.AddSingleton<ICodeChallenge, SparseArrays>();
        
        return services;
    }
}

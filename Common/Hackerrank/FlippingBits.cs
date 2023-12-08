using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class FlippingBits : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute()
    {
        // Sample input
        long input = 2147483647; // Example input value

        // Calling function and return
        return GetFlippingBits(input).ToString();
    }

    /*
         * Complete the 'GetFlippingBits' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

    public static long GetFlippingBits(long n)
    {
        long maxInt = (1L << 32) - 1; // Maximum value for 32-bit unsigned integer

        // XOR operation with maxUInt (all bits set to 1 for 32-bit) flips all bits
        return n ^ maxInt;
    }

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

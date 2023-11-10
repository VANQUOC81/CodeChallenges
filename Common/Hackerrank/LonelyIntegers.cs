using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class LonelyInteger : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException();

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public string Execute()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 3, 2, 1 };

        return Lonelyinteger(numbers).ToString();
    }

    public static int Lonelyinteger(List<int> a)
    {
        int unique = 0;

        foreach (var i in a)
        {
            int count = 0;
            foreach (var j in a)
            {
                if (i == j)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                unique = i;
                break;
            }
        }

        return unique;
    }

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

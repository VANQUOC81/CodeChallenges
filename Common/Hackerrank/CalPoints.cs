using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class CalPoints : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute()
    {
        string[] ops = { "1", "+", "2" };

        return GetCalPoints(ops).ToString();
    }

    public int GetCalPoints(string[] ops)
    {
        var opsList = new List<string>();
        var sum = 0;

        foreach (var item in ops)
        {
            if (item.Equals("+"))
            {
                var index = int.Parse(opsList[opsList.Count - 1]) + int.Parse(opsList[opsList.Count - 2]);
                opsList.Add(index.ToString());

                sum = CalculateSum(opsList);
            }
            else if (item.Equals("D"))
            {
                var index = int.Parse(opsList[opsList.Count - 1]) * 2;
                opsList.Add(index.ToString());

                sum = CalculateSum(opsList);
            }
            else if (item.Equals("C"))
            {
                opsList.RemoveAt(opsList.Count - 1);

                sum = CalculateSum(opsList);
            }
            else
            {
                //An integer was added
                opsList.Add(item);

                sum = CalculateSum(opsList);
            }
        }

        return sum;
    }
    private int CalculateSum(List<string> opsList)
    {
        int sum = 0;

        foreach (var val in opsList)
        {
            sum += int.Parse(val);
        }

        return sum;
    }

    public void GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class CalPoints : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute(string input)
    {
        string[] ops = {"5", "-2", "4", "C", "D", "9", "+", "+"};

        return GetCalPoints(ops).ToString();
    }

    public int GetCalPoints(string[] ops)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string op in ops)
        {
            if (int.TryParse(op, out int num))
            {
                stack.Push(num);
            }
            else if (op == "+")
            {
                int last = stack.Pop();
                int secondLast = stack.Peek();
                stack.Push(last);
                stack.Push(last + secondLast);
            }
            else if (op == "D")
            {
                stack.Push(2 * stack.Peek());
            }
            else if (op == "C")
            {
                stack.Pop();
            }
        }

        int sum = 0;
        while (stack.Count > 0)
        {
            sum += stack.Pop();
        }

        return sum;
    }

    string IInputValues.GetInputValuesCommands()
    {
        throw new NotImplementedException();
    }
}

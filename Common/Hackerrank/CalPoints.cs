using Common.Enums;
using Common.Interfaces;

namespace Common.Hackerrank;

public class CalPoints : ICodeChallenge
{
    public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.Hankerrank;

    public int CodeChallengeNumber => throw new NotImplementedException("Hankerrank doesn't have numbers");

    public string Execute(List<string> input)
    {
         // test case
        //string[] ops = {"5", "-2", "4", "C", "D", "9", "+", "+"};

        return GetCalPoints(input.ToArray()).ToString();
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

    public List<string> GetInputValuesCommands()
    {
         var inputList = new List<string>();
            bool showCommand = true;

            while (showCommand)
            {
                // show command prompts.
                Console.WriteLine("Please provide (more) input values for the challenge:");

                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input) || input.Length == 0)
                {
                    Console.WriteLine($"Input values cannot be empty. Please try again.");

                    continue;
                }
                else
                {
                    inputList.Add(input);
                add_more_input_question:
                    Console.WriteLine("Do you want to add more input?");

                    input = Console.ReadLine() ?? string.Empty;

                    if (input.ToLower().Equals("no") || input.ToLower().Equals("yes"))
                    {
                        if (input.ToLower().Equals("yes"))
                        {
                            continue;
                        }
                        else
                        {
                            showCommand = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please say yes or no");
                        goto add_more_input_question;
                    }
                }
            }

            return inputList;
    }
}

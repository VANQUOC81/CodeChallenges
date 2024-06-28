using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class MinimumOperationsToMakeTheArrayIncreasing : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 1827;

        public string Execute(List<string> input)
        {
            // test case
            //var input2 = new int[] { 1, 1, 1 };

            return MinOperations(input.Select(int.Parse).ToArray()).ToString();
        }

        public int MinOperations(int[] nums)
        {
            int count = 0;

            // loop through array starting from index 1
            for (int i = 1; i < nums.Length; i++)
            {
                // check if current element is less than or equal to previous element
                if (nums[i] <= nums[i - 1])
                {
                    // calculate the difference between previous element and current element
                    // add 1 to the difference to make current element strictly greater than previous element
                    count += nums[i - 1] - nums[i] + 1;

                    // update current element to be strictly greater than previous element
                    nums[i] = nums[i - 1] + 1;
                }
            }

            // return the minimum number of operations needed to make nums strictly increasing
            return count;
        }

        public List<string> GetInputValuesCommands()
        {
            var inputList = new List<string>();
            bool showCommand = true;

            while (showCommand)
            {
                // show command prompts.
                Console.WriteLine("Please provide (more) input values for the challenge like e.g. '11':");

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
}

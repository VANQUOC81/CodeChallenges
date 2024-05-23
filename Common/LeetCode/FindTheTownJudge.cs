using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class FindTheTownJudge : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 997;

        public string Execute(List<string> input)
        {
            var N = input[0];
            var input2 = input[1];

            string[] components = input2.Split(',');
            var myList = new List<int[]>();

            var size = components.Length;

            int[][] trust = new int[1][];
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                string[] result = components[i].Split(' ');
                myList.Insert(i, new int[] { int.Parse(result[0]), int.Parse(result[1]) });
            }
            trust = myList.Select(a => a.ToArray()).ToArray();

            return findJudge(int.Parse(N), trust).ToString();
        }

        public int findJudge(int N, int[][] trust)
        {
            // initialize trustCounts array with n+1 elements (indices 1 to n)
            var trustCounts = new int[N + 1];

            // iterate through each trust pair in the trust array
            foreach (var pair in trust)
            {
                int firstPerson = pair[0];
                int secondPerson = pair[1];

                // decrement trust for the first person
                trustCounts[firstPerson]--;

                // increment trust for the second person
                trustCounts[secondPerson]++;
            }

            // loop through all people in the town
            for (int i = 1; i <= N; i++)
            {
                // check if trust count for person i is n-1
                // (indicating that they are trusted by everyone except themselves)
                if (trustCounts[i] == N - 1)
                {
                    // i is identified as the town judge
                    return i;
                }
            }

            // Return -1 if the town judge doesn't exist or can't be identified
            return -1;
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
}

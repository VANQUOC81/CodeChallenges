using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class RotateArray : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 189;

        public int k = 0;
        
        public int[] nums = new int[] {};

        public string Execute()
        {
            return string.Join(",", Rotate(nums, k));
        }

        public int[] Rotate(int[] nums, int k)
        {
            if (k == 0 || nums == null || nums.Length < 2)
            {
                return new int[] { };
            }

            // takes care of overflow
            k = k % nums.Length;

            int[] temp = new int[k];

            // Save k elements from the end of the array
            for (int i = 0; i < k; i++)
            {
                temp[i] = nums[nums.Length - k + i];
            }

            // Shift all elements k positions to the right starting from the end of the array
            for (int i = nums.Length - 1; i > k - 1; i--)
            {
                nums[i] = nums[i - k];
            }

            // Copy those saved elements back to the front of the array
            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];
            }

            return nums;
        }

        public void GetInputValuesCommands()
        {
            bool showCommand = true;
            while (showCommand)
            {
                // show command prompts.
                Console.WriteLine("Provide an array integers, seperated by ',':");
                string? inputArray = Console.ReadLine();

                if (inputArray is not null)
                {
                    nums = inputArray.Split(',').Select(s => s.Trim())         // Remove spaces
                            .Where(s => !string.IsNullOrWhiteSpace(s)) // Exclude empty strings
                            .Select(int.Parse).ToArray();
                }
                else
                {
                    continue;
                }

                Console.WriteLine("Provide k array rotation steps to the right, where k is non-negative:");
                string? inputSteps = Console.ReadLine();

                if (int.TryParse(inputSteps, out k) && k > 0)
                {
                    showCommand = false; 
                }
                else
                {
                    Console.WriteLine($"Invalid {nameof(inputSteps)}: {inputSteps}");
                    continue;
                }
            }
        }

        string IInputValues.GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }
    }
}

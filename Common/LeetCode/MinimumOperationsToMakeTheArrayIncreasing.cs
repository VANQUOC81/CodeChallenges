using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class MinimumOperationsToMakeTheArrayIncreasing : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 1827;

        public string Execute()
        {
            // test case
            var input = new int[] { 1, 1, 1 };

            return MinOperations(input).ToString();
        }

        public void GetInputValuesCommands()
        {
            throw new NotImplementedException();
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
    }
}

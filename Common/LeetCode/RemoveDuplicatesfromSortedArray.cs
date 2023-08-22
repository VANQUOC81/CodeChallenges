using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class RemoveDuplicatesfromSortedArray : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 26;

        public string Execute()
        {
            // using in-place algorithm updates the passed in nums variable in Main scope.
            var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //var nums = new[] { 1, 1, 2 };

            return RemoveDuplicates(nums).ToString();
        }

        public int RemoveDuplicates(int[] nums)
        {
            var uniqueNumsToSwap = nums.Distinct().ToArray();

            for (int j = 0; j < nums.Count(); j++)
            {
                if (j + 1 > uniqueNumsToSwap.Count())
                {
                    break;
                }

                // replacement array value
                nums[j] = uniqueNumsToSwap[j];

                //         // swap current with next using temp variable (allowed with in-place algo)                   
                //         var temp = nums[j];
                //         nums[j] = nums[j + 1];
                //         nums[j + 1] = temp;   
            }

            return uniqueNumsToSwap.Count();
        }
    }
}
using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class ThreeSum : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 15;

        public string Execute(string input)
        {
            var stringArray = input.Split(",");

            int[] intArray = Array.ConvertAll(stringArray, int.Parse);

            var result = threeSum(intArray);

            var concat = "";

            foreach (var innerresult in result)
            {
                concat += string.Join(", ", innerresult);
            }

            return concat;
        }

        public IList<IList<int>> threeSum(int[] nums)
        {
            Array.Sort(nums); // sort the array
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue; // skip duplicates

                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++;
                        right--;

                        // skip duplicates
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }

        (string input1, string input2, string input3, string input4) IInputValues.GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }
    }
}

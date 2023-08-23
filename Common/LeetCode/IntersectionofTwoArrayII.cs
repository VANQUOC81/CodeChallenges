using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class IntersectionofTwoArrayII : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 350;

        public string Execute()
        {
            var result = Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });

            return string.Join(",", result);
        }

        public void GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in nums1)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            List<int> intersection = new List<int>();
            foreach (int num in nums2)
            {
                if (dict.ContainsKey(num) && dict[num] > 0)
                {
                    intersection.Add(num);
                    dict[num]--;
                }
            }
            return intersection.ToArray();
        }
    }
}
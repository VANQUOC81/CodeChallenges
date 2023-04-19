// // 26. Remove Duplicates from Sorted Array
// // non-decreasing means that the values could stay the same - they don't decrease but they could increase or stay the same. The values 1, 1, 1, 2 are in nondecreasing order but 1, 2, 3, 4 are increasing.
// // in-place means modifying the array without using another array to copy. Temp variable is allowed. An in-place algorithm updates its input sequence only through replacement or swapping of elements.
// public class Solution
// {
//     public int RemoveDuplicates(int[] nums)
//     {
//         var uniqueNumsToSwap = nums.Distinct().ToArray();

//         for (int j = 0; j < nums.Count(); j++)
//         {
//             if (j + 1 > uniqueNumsToSwap.Count())
//             {
//                 break;
//             }
//             // replacement array value
//             nums[j] = uniqueNumsToSwap[j];

//             //         // swap current with next using temp variable (allowed with in-place algo)                   
//             //         var temp = nums[j];
//             //         nums[j] = nums[j + 1];
//             //         nums[j + 1] = temp;   
//         }

//         return uniqueNumsToSwap.Count();
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // using in-place algorithm updates the passed in nums variable in Main scope.
//         //var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
//         var nums = new[] { 1, 1, 2 };
//         var expectedNums = new[] { 1, 2 };
//         //var expectedNums = new[] { 0, 1, 2, 3, 4 };

//         var sol = new Solution();
//         var k = sol.RemoveDuplicates(nums);

//         if (k != expectedNums.Count())
//         {
//             Console.WriteLine("length expectedNums does not match");
//         }

//         for (int i = 0; i < k; i++)
//         {
//             if (nums[i] == expectedNums[i])
//             {
//                 continue;
//             }
//             else
//             {
//                 Console.Write("nums does not correspond with expectedNums");
//             };
//         }


//     }
// }
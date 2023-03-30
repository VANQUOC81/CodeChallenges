// // https://csharpexamples.com/c-binary-search-tree-implementation/
// // 938. Range Sum of BST
// // Definition for a binary tree node.

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

// public class Solution
// {
//     // implementation performance is poor use Queue next time for traversal. 
//     // See details Memory LeetCode of other submissions.  
//     public int RangeSumBST(TreeNode root, int low, int high)
//     {
//         int sum = default;
//         List<int> valuesTreeNode = TraversePreOrder(root, new List<int>());
//         valuesTreeNode.Sort();

//         if (valuesTreeNode.Contains(low) && valuesTreeNode.Contains(high))
//         {
//             var lowIndex = valuesTreeNode.IndexOf(low);
//             var highIndex = valuesTreeNode.IndexOf(high);
//             // increase +1 to include end index of the range
//             var stepCount = (highIndex - lowIndex) + 1;
//             List<int> rangeList = valuesTreeNode.GetRange(lowIndex, stepCount);

//             sum = rangeList.Sum();
//         }
//         else
//         {
//             throw new ArgumentException("low or high does not exists");
//         }

//         return sum;
//     }

//     // Recursive traverse function
//     // Visit the root
//     // Traverse the left subtree
//     // Traverse the right subtree
//     public List<int> TraversePreOrder(TreeNode parent, List<int> valuesTreeNode)
//     {
//         if (parent != null)
//         {
//             valuesTreeNode.Add(parent.val);
//             Console.Write(parent.val + " ");
//             // sequential so first do left tree node
//             TraversePreOrder(parent.left, valuesTreeNode);
//             // then right tree node
//             TraversePreOrder(parent.right, valuesTreeNode);
//         }

//         return valuesTreeNode;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Example 1 success
//         var node7 = new TreeNode(7);
//         var node3 = new TreeNode(3);
//         var node5 = new TreeNode(5, node3, node7);
//         var node18 = new TreeNode(18);
//         var node15 = new TreeNode(15, null, node18);

//         // root node
//         var node10 = new TreeNode(10, node5, node15);

//         // Example 2 faalt
//         // var node6 = new TreeNode(6);
//         // var node7 = new TreeNode(7, node6, null);
//         // var node1 = new TreeNode(1);
//         // var node3 = new TreeNode(3, node1, null);
//         // var node5 = new TreeNode(5, node3, node7);
//         // var node18 = new TreeNode(18);
//         // var node13 = new TreeNode(13);
//         // var node15 = new TreeNode(15, node13, node18);

//         // // root node
//         // var node10 = new TreeNode(10, node5, node15);

//         var sol = new Solution();
//         var result = sol.RangeSumBST(node10, 7, 15);
//         //var result = sol.RangeSumBST(node10, 6, 10);

//         Console.Write(result);
//     }
// }





using Common.Interfaces;
using Common.Enums;

namespace Common.LeetCode
{
    public class RangeSumofBST : ICodeChallenge
    {
        public CodeChallengeSource CodeChallengeSource => CodeChallengeSource.LeetCode;

        public int CodeChallengeNumber => 938;

        public string Execute()
        {
            // Arrange
            var node7 = new TreeNode(7);
            var node3 = new TreeNode(3);
            var node5 = new TreeNode(5, node3, node7);
            var node18 = new TreeNode(18);
            var node15 = new TreeNode(15, null!, node18);

            // root node
            var node10 = new TreeNode(10, node5, node15);

            int result = RangeSumBST(node10, 7, 15);

            // local method
            static string displayIntResultAsOneLine(int i)
            {
                string concatResult = string.Empty;

                foreach (var item in i.ToString())
                {
                    concatResult += item;
                }

                return concatResult;
            }

            return displayIntResultAsOneLine(result);
        }

        public void GetInputValuesCommands()
        {
            throw new NotImplementedException();
        }

        // implementation performance is poor use Queue next time for traversal. 
        // See details Memory LeetCode of other submissions.  
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            List<int> valuesTreeNode = TraversePreOrder(root, new List<int>());
            valuesTreeNode.Sort();

            if (valuesTreeNode.Contains(low) && valuesTreeNode.Contains(high))
            {
                var lowIndex = valuesTreeNode.IndexOf(low);
                var highIndex = valuesTreeNode.IndexOf(high);
                // increase +1 to include end index of the range
                var stepCount = (highIndex - lowIndex) + 1;
                List<int> rangeList = valuesTreeNode.GetRange(lowIndex, stepCount);

                return rangeList.Sum();
            }
            else
            {
                throw new ArgumentException("low or high does not exists");
            }
        }

        // Recursive traverse function
        // Visit the root
        // Traverse the left subtree
        // Traverse the right subtree
        public List<int> TraversePreOrder(TreeNode parent, List<int> valuesTreeNode)
        {
            if (parent != null)
            {
                valuesTreeNode.Add(parent.val);
                Console.Write(parent.val + " ");
                // sequential so first do left tree node
                TraversePreOrder(parent.left, valuesTreeNode);
                // then right tree node
                TraversePreOrder(parent.right, valuesTreeNode);
            }

            return valuesTreeNode;
        }

        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
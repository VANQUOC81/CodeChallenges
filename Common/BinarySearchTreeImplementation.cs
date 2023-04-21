// /**
// * By Van Quoc Nguyen 2022/12/05
// **/

// namespace InterviewPrep
// {
//     public class BinaryTreeTest
//     {
//         static void TestBinaryTree(int[] values)
//         {
//             BinaryTree bt = new BinaryTree(values);
//             Console.WriteLine(" Depth: " + bt.GetTreeDepth());

//             bt.TraverseInOrder();
//             bt.TraversePreOrder();
//             bt.TraversePostOrder();

//             if (values.Length >= 2)
//             {
//                 Console.WriteLine(" Removing value { " + values[1] + " }");
//                 bt.Remove(values[1]);
//                 bt.TraverseInOrder();
//                 bt.TraversePreOrder();
//                 bt.TraversePostOrder();
//             }

//             Console.WriteLine("\n");
//         }

//         public static void Main(string[] args)
//         {
//             int[] arr1 = { 1, 2, 7, 3, 10, 5, 8, 8, 9 };
//             int[] arr2 = { 1, 3, 6, 2, 7, 5, 4, 8, 9 };
//             int[] arr3 = { -10, 10, -20, 0, 17, 19, 4, 8, 9, -30, -5 };

//             TestBinaryTree(arr1);
//             TestBinaryTree(arr2);
//             TestBinaryTree(arr3);

//             Console.ReadLine();
//         }
//     }

//     class Node
//     {
//         public Node LeftNode { get; set; }
//         public Node RightNode { get; set; }
//         public int Data { get; set; }
//     }

//     class BinaryTree
//     {
//         public BinaryTree()
//         {

//         }

//         public BinaryTree(int[] values)
//         {
//             Console.WriteLine("BinaryTree { " + string.Join(",", values) + " }");

//             foreach (int i in values)
//             {
//                 Add(i);
//             }
//         }

//         public Node Root { get; set; }

//         public bool Add(int value)
//         {
//             Node before = null, after = this.Root;

//             while (after != null)
//             {
//                 before = after;
//                 if (value == after.Data) //Is new node in right tree?
//                 {
//                     after = after.RightNode;
//                 }
//                 else
//                 {
//                     //Exist same value
//                     return false;
//                 }
//             }

//             Node newNode = new Node();
//             newNode.Data = value;

//             if (this.Root == null)//Tree ise empty
//                 this.Root = newNode;
//             else
//             {
//                 if (value < before.Data)
//             {
//                     before.LeftNode = newNode;
//             }
//                 else
//                 {
//                     before.RightNode = newNode;
//                 }
//             }

//             return true;
//         }

//         public Node Find(int value)
//         {
//             return this.Find(value, this.Root);
//         }

//         public void Remove(int value)
//         {
//             Remove(this.Root, value);
//         }

//         private Node Remove(Node parent, int key)
//         {
//             if (parent == null)
//             {
//                 return parent;
//             }

//             if (key == parent.Data)
//             {
//                 parent.RightNode = Remove(parent.RightNode, key);
//             }

//             // if value is same as parent’s value, then this is the node to be deleted
//             else
//             {
//                 // node with only one child or no child
//                 if (parent.LeftNode == null)
//                 {
//                     return parent.RightNode;
//                 }
//                 else if (parent.RightNode == null)
//                 {
//                     return parent.LeftNode;
//                 }

//                 // node with two children: Get the inorder successor (smallest in the right subtree)
//                 parent.Data = MinValue(parent.RightNode);

//                 // Delete the inorder successor
//                 parent.RightNode = Remove(parent.RightNode, parent.Data);
//             }

//             return parent;
//         }

//         private int MinValue(Node node)
//         {
//             int minv = node.Data;

//             while (node.LeftNode != null)
//             {
//                 minv = node.LeftNode.Data;
//                 node = node.LeftNode;
//             }

//             return minv;
//         }

//         private Node Find(int value, Node parent)
//         {
//             if (parent != null)
//             {
//                 if (value == parent.Data) 
//                 {
//                     return parent;
//                 }
//                 if (value < parent.Data)
//                 {
//                     return Find(value, parent.LeftNode);
//                 }
//                 else
//                 {
//                     return Find(value, parent.RightNode);
//                 }
//             }

//             return null;
//         }

//         public int GetTreeDepth()
//         {
//             return this.GetTreeDepth(this.Root);
//         }

//         private int GetTreeDepth(Node parent)
//         {
//             return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
//         }

//         public void TraversePreOrder()
//         {
//             Console.Write(" Traverse Pre Order: \t");
//             TraversePreOrder(this.Root);
//             Console.WriteLine();
//         }
//         public void TraversePreOrder(Node parent)
//         {
//             if (parent != null)
//             {
//                 Console.Write(parent.Data + " ");
//                 TraversePreOrder(parent.LeftNode);
//                 TraversePreOrder(parent.RightNode);
//             }
//         }

//         public void TraverseInOrder()
//         {
//             Console.Write(" Traverse In Order: \t");
//             TraverseInOrder(this.Root);
//             Console.WriteLine();
//         }
//         public void TraverseInOrder(Node parent)
//         {
//             if (parent != null)
//             {
//                 TraverseInOrder(parent.LeftNode);
//                 Console.Write(parent.Data + " ");
//                 TraverseInOrder(parent.RightNode);
//             }
//         }

//         public void TraversePostOrder()
//         {
//             Console.Write(" Traverse Post Order: \t");
//             TraversePostOrder(this.Root);
//             Console.WriteLine();

//         }
//         public void TraversePostOrder(Node parent)
//         {
//             if (parent != null)
//             {
//                 TraversePostOrder(parent.LeftNode);
//                 TraversePostOrder(parent.RightNode);
//                 Console.Write(parent.Data + " ");
//             }
//         }
//     }

// }
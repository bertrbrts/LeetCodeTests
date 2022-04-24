using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class BinaryTreeZigZag
    {
        public static IList<IList<int>> Execute(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            List<IList<int>> results = new();

            // add the root element with a delimiter to kick of the BFS loop
            LinkedList<TreeNode> node_queue = new();
            TreeNode? nullNode = null;

            node_queue.AddLast(root);
            node_queue.AddLast(nullNode);

            LinkedList<int> level_list = new();
            bool is_order_left = true;

            while (node_queue.Count > 0)
            {
                TreeNode currentNode = node_queue.First();
                node_queue.Remove(currentNode);
                if (currentNode != null)
                {
                    if (is_order_left)
                        level_list.AddLast(currentNode.val);
                    else
                        level_list.AddFirst(currentNode.val);

                    if (currentNode.left != null)
                        node_queue.AddLast(currentNode.left);

                    if (currentNode.right != null)
                        node_queue.AddLast(currentNode.right);
                }
                else
                {
                    results.Add(level_list.ToList());
                    level_list = new LinkedList<int>();

                    if (node_queue.Count > 0)
                    {
                        node_queue.AddLast(nullNode);
                    }


                    is_order_left = !is_order_left;
                }
            }

            return results;
        }
    }
}
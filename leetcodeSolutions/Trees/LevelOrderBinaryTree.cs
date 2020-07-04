using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class LevelOrderBinaryTree
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> list = Bfs(root);
            return list.Reverse().ToList();
        }

        private IList<IList<int>> Bfs(TreeNode root)
        {
            IList<IList<int>> output = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if(root != null)
            {
                queue.Enqueue(root);
                while(queue.Count > 0)
                {
                    IList<int> currentLevel = new List<int>();
                    int numberOfLevelElements = queue.Count();

                    for(int i=0; i< numberOfLevelElements; i++)
                    {
                        TreeNode current = queue.Dequeue();
                        currentLevel.Add(current.val);
                        if(current.left != null)
                        {
                            queue.Enqueue(current.left);
                        }
                        if(current.right != null)
                        {
                            queue.Enqueue(current.right);
                        }
                    }
                    output.Add(currentLevel);
                }
            }

            return output;
        }
    }
}

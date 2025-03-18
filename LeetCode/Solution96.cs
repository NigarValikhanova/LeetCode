using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution96
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();
            return GenerateTreesHelper(1, n);
        }

        private List<TreeNode> GenerateTreesHelper(int start, int end)
        {
            List<TreeNode> allTrees = new List<TreeNode>();
            if (start > end)
            {
                allTrees.Add(null);
                return allTrees;
            }

            for (int i = start; i <= end; i++)
            {
                List<TreeNode> leftTrees = GenerateTreesHelper(start, i - 1);
                List<TreeNode> rightTrees = GenerateTreesHelper(i + 1, end);

                foreach (var left in leftTrees)
                {
                    foreach (var right in rightTrees)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = left;
                        root.right = right;
                        allTrees.Add(root);
                    }
                }
            }
            return allTrees;
        }

        public int NumTrees(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    dp[i] += dp[j - 1] * dp[i - j];
                }
            }

            return dp[n];
        }
    }
}

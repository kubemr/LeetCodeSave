using LeetCodeSave.BinaryTreeDFS;

namespace LeetCodeSave.BinaryTreeBFS;

public class MaximumLevelSumofaBinaryTree //40
{
    public int MaxLevelSum(TreeNode root) {
        if (root == null) return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int level = 1;
        int maxLevel = 1;
        int maxSum = int.MinValue;

        while (queue.Count > 0) {
            int size = queue.Count;
            int levelSum = 0;

            for (int i = 0; i < size; i++) {
                TreeNode node = queue.Dequeue();
                levelSum += node.val;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            if (levelSum > maxSum) {
                maxSum = levelSum;
                maxLevel = level;
            }

            level++;
        }

        return maxLevel;
    }
}
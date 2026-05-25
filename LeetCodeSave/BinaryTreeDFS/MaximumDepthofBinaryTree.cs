namespace LeetCodeSave.BinaryTreeDFS;

public class MaximumDepthofBinaryTree
{
    //33 Maximum Depth of Binary Tree
    public int MaxDepth(TreeNode root) {
        if (root == null) {return 0;}
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
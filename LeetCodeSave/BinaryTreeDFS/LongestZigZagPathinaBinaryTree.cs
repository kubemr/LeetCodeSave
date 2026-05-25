namespace LeetCodeSave.BinaryTreeDFS;

//37
public class LongestZigZagPathinaBinaryTree
{
    public int LongestZigZag(TreeNode root) {
        return Math.Max(DFs(root.left, true, 0), DFs(root.right, false, 0));
    }

    int DFs(TreeNode node, bool isLeft, int count) {
        if (node == null) {
            return count;
        }

        if (isLeft) {
            return Math.Max(DFs(node.left, true, 0), DFs(node.right, false, count+1));
        }
        return Math.Max(DFs(node.left, true, count+1), DFs(node.right, false, 0));
    }
}
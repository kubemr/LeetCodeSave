namespace LeetCodeSave.BinaryTreeDFS;

//35 
public class CountGoodNodesinBinaryTree
{
    int count = 0;
    public int GoodNodes(TreeNode root) {
        DFS(root,root.val);
        return count;
    }

    private void DFS(TreeNode root, int max){
        if(root == null) return;
        if(root.val>=max) count++;

        DFS(root.left, Math.Max(max, root.val));
        DFS(root.right, Math.Max(max, root.val));
    }
}
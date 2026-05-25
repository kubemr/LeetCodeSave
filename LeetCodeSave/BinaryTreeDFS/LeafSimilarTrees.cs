namespace LeetCodeSave.BinaryTreeDFS;

public class LeafSimilarTrees
{
    //34 Leaf-Similar Trees
    public void Inorder(TreeNode root, List<int> v) {
        if (root != null) {
            Inorder(root.left, v);
            if (root.left == null && root.right == null) {
                v.Add(root.val);
            }
            Inorder(root.right, v);
        }
    }

    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> v1 = new List<int>();
        List<int> v2 = new List<int>();
        Inorder(root1, v1);
        Inorder(root2, v2);
        return Enumerable.SequenceEqual(v1, v2);
    }
}
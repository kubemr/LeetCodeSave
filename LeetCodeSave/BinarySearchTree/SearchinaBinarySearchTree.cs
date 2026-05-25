using LeetCodeSave.BinaryTreeDFS;

namespace LeetCodeSave.BinarySearchTree;

public class SearchinaBinarySearchTree //41
{
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null || root.val == val)
        {
            return root;
        }
        
        if(root.val > val)
        {
            return SearchBST(root.left, val);
        }
        else
        {
            return SearchBST(root.right, val);
        }
    }
}
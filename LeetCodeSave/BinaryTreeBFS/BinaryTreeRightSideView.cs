using LeetCodeSave.BinaryTreeDFS;

namespace LeetCodeSave.BinaryTreeBFS;

public class BinaryTreeRightSideView //39
{
    public IList<int> RightSideView(TreeNode root) 
    {
        List<int>result= new List<int>();
        Traverse(root,0,result);
        return result;
    }
    private void Traverse(TreeNode node, int level, List<int> result){
        
        if (node is null) return ;
        if(result.Count==level) result.Add(node.val);
        
        Traverse(node.right,level+1,result);
        Traverse(node.left,level+1,result);
    }
}
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null) return result;
        return AddTreeNodeValues(root, result);
    }
    
    public List<int> AddTreeNodeValues(TreeNode root, List<int> result){
        result.Add(root.val);
        if(root.left != null) AddTreeNodeValues(root.left, result);
        if(root.right != null) AddTreeNodeValues(root.right, result);
        return result;
    }
}

/*

1. Create a List<int> variable and initilize it to return with all the tree node values
2. Return null if the root is null
3. Assumption:  Each tree node will have only one of its two branches filled
    a. Check to see which child node has a value; add the value and keep traveling
    b. Travel down the tree until both child tree nodes are null
*/
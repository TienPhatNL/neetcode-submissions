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
    public int KthSmallest(TreeNode root, int k) {
        int result = 0, count = 0;
        InOrderTrav(root, ref count, ref result, k);
        return result;
    }

    public void InOrderTrav(TreeNode root, ref int count, ref int result, int k){
        if(root == null) return;

        InOrderTrav(root.left, ref count, ref result, k);


        count++;
        if(count == k){
            result = root.val;
            return;
        }
        
        InOrderTrav(root.right, ref count, ref result, k);
    }
}

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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        if(root == null) return result;
        var order = new Queue<TreeNode>();
        order.Enqueue(root);

        while(order.Count > 0){
            var size = order.Count;
            var level = new List<int>();

            for(int i = 0; i < size; i++){
                var node = order.Dequeue();
                if(node == null) break;
                level.Add(node.val);
                if(node.left != null) order.Enqueue(node.left);
                if(node.right != null) order.Enqueue(node.right);
            }
            result.Add(level);
        }
        return result;
    }
}

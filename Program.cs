namespace Assignment_7._3__Search_in_a_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] root = { 4, 2, 7, 1, 3 };    
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left=null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right; 
        }
    }

    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
                while (root != null && val != root.val)
                    root = val < root.val ? root.left : root.right;
                return root;
    
        }
    }
}

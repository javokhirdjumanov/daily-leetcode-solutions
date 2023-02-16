namespace DailyLeetcode.Trees.Easies;
public class PostorderTraversal
{
    public static IList<int> PostorderTraversals(TreeNode root)
    {
        return PostorderTraversalTree(root, new List<int>());
    }
    private static IList<int> PostorderTraversalTree(TreeNode root, IList<int> list)
    {
        if (root == null)
        {
            return list;
        }

        list = PostorderTraversalTree(root.right, list);
        list = PostorderTraversalTree(root.left, list);
        list.Add(root.val);

        return list;
    }
}
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

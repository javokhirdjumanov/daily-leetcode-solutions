
namespace DailyLeetcode.Trees.Easies;
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
public static class InorderTraversalTree
{
    public static void View()
    {
        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        //TreeNode root = new TreeNode(1);
        //root.right = new TreeNode(2);
        //root.right.left = new TreeNode(3);

        foreach (var item in InorderTraversalTrees(root, new List<int>()))
        {
            Console.Write(item + " ");
        }
    }
    private static IList<int> InorderTraversalTrees(TreeNode root, IList<int> list)
    {
        if (root == null)
        {
            return list;
        }

        list = InorderTraversalTrees(root.left, list);
        list.Add(root.val);
        list = InorderTraversalTrees(root.right, list);

        return list;
    }
}
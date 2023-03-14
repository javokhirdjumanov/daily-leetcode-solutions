using DailyLeetcode.Trees.Easies;

namespace DailyLeetcode.Trees.Mediums;
public class SumNumbers
{
    private static int result = 0;
    public static int SumNumber(TreeNode root)
    {
        SummaOfThreeNodeVal(root, 0);
        return result;
    }
    public static void SummaOfThreeNodeVal(TreeNode root, int summa)
    {
        summa = summa * 10 + root.val;
        if (root.left is not null)
        {
            SummaOfThreeNodeVal(root.left, summa);
        }
        if (root.right is not null)
        {
            SummaOfThreeNodeVal(root.right, summa);
        }
        if (root.right is null && root.left is null)
        {
            result += summa;
            return;
        }
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

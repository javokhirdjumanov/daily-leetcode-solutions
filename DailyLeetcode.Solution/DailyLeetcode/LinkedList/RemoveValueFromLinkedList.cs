namespace DailyLeetcode.LinkedList;
public class RemoveValueFromLinkedList
{
    public static void Main()
    {
        ListNode lists = new ListNode();

        lists = FilledList(lists, 7);

        Console.Write("Remove Value : ");
        int val = int.Parse(Console.ReadLine());

        lists = RemoveValue(lists, val);

        PrintList(lists);
    }
    private static ListNode FilledList(ListNode lists, int currentNumber)
    {
        Console.WriteLine("Add to list : ");
        for (int i = 0; i < currentNumber; i++)
        {
            Console.Write("-> "); int j = int.Parse(Console.ReadLine());
            lists.next = new ListNode(j);
            lists = lists.next;
        }

        return lists;
    }
    private static ListNode RemoveValue(ListNode head, int val)
    {
        ListNode node = head.next;

        while (node.next != null)
        {
            if (node.next.val == val)
                node.next = node.next.next;
            else
                node = node.next;
        }
        ListNode temp = head.next;

        return temp;
    }
    private static void PrintList(ListNode lists)
    {
        Console.Write("Result : ");
        while (lists != null)
        {
            Console.Write(lists.val + " ");
            lists = lists.next;
        }
    }
}
public class ListNode
{
    public ListNode next;
    public int val;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.next = next;
        this.val = val;
    }
}

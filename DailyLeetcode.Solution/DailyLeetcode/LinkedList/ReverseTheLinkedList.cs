namespace DailyLeetcode.LinkedList;
public class ReverseTheLinkedList
{

    public static void Main()
    {
        ListNode lists = new ListNode();

        FilledLinkedList(lists, 4);

        lists = ReverseLinkedList(lists);

        PrintLinkedList(lists);
    }
    private static void FilledLinkedList(ListNode lists, int currentNumber)
    {
        Random random = new Random();
        for (int i = 0; i < currentNumber; i++)
        {
            int r = random.Next(1, 10);
            lists.next = new ListNode(r);
            lists = lists.next;
        }
    }
    private static ListNode ReverseLinkedList(ListNode head)
    {
        Stack<ListNode> stack = new Stack<ListNode>();

        ListNode node = head;

        while (node != null)
        {
            stack.Push(node);
            node = node.next;
        }

        head = stack.Pop();
        node = head;

        while (stack.Count > 0)
        {
            node.next = stack.Pop();
            node = node.next;
        }
        node.next = null;

        return head;
    }
    private static void PrintLinkedList(ListNode lists)
    {
        Console.Write("Result : ");
        while (lists.next != null)
        {
            Console.Write(lists.value + " ");
            lists = lists.next;
        }
    }
}
public class ListNode
{
    public ListNode next { get; set; }
    public int value { get; set; }
    public ListNode(int value = 0, ListNode next = null)
    {
        this.value = value;
        this.next = next;
    }
}

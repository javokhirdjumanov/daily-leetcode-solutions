namespace DailyLeetcode.LinkedList.Easies;
public class ListNode
{
    public ListNode next;
    public int value;

    public ListNode(ListNode next = null, int value = 0)
    {
        this.next = next;
        this.value = value;
    }
}
public class DeleteNodeOfLinked_List
{
    private static void Main()
    {
        ListNode lists = new ListNode();

        FillUpLinkedList(lists, 4);

        DeleteNode(lists);

        PrintDeleteNode(lists);
    }
    private static void FillUpLinkedList(ListNode lists, int borderNumber)
    {
        for (int i = 0; i < borderNumber; i++)
        {
            lists.next = new ListNode(lists);
            lists = lists.next;
        }
    }
    private static void DeleteNode(ListNode head)
    {
        head.value = head.next.value;
        head.next = head.next.next;
    }
    private static void PrintDeleteNode(ListNode lists)
    {
        while (lists != null)
        {
            Console.Write(lists.value + " ");
            lists = lists.next;
        }
    }
}


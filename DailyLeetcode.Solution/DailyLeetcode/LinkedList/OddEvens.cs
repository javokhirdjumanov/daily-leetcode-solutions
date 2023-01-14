namespace DailyLeetcode.LinkedList;
public class ListNode
{
    public ListNode(ListNode next = null, int value = 0)
    {
        this.value = value;
        this.next = next;
    }

    public int value { get; set; }
    public ListNode next { get; set; }
}
public class OddEvens
{
    public static ListNode OddEvenList(ListNode head)
    {
        Queue<ListNode> queue = new Queue<ListNode>();
        ListNode slow = head, fast = head.next;

        if (head == null)
            return head;

        AddSlowToQueue(slow, queue);
        AddFastToQueue(fast, queue);

        return AddResultLinkedListWith(queue);
    }
    private static void AddSlowToQueue(ListNode slow, Queue<ListNode> queue)
    {
        while (slow != null)
        {
            queue.Enqueue(slow);

            if (slow.next == null)
                break;
            else
                slow = slow.next.next;
        }
    }
    private static void AddFastToQueue(ListNode fast, Queue<ListNode> queue)
    {
        while (fast != null)
        {
            queue.Enqueue(fast);
            if (fast.next == null)
                break;
            else
                fast = fast.next.next;
        }
    }
    private static ListNode AddResultLinkedListWith(Queue<ListNode> queue)
    {
        ListNode result = new ListNode();
        ListNode node = result;

        while (queue.Count > 0)
        {
            node.next = new ListNode(queue.Dequeue().value);
            node = node.next;
        }

        return result;
    }
}

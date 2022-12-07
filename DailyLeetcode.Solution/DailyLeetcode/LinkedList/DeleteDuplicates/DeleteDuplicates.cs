namespace DailyLeetcode.LinkedList.DeleteDuplicates;
public class DeleteDuplicates
{
    private static void MainView()
    {
        Console.Write("List Limit Number : ");
        int listNumber = int.Parse(Console.ReadLine());

        ListNode node = new ListNode();
        var listNode = FillUpLinkedList(node, listNumber);

        var result = DeleteDuplicatess(listNode.next);

        PrintLinkedList(result);
    }
    private static ListNode FillUpLinkedList(ListNode listOfChars, int limitNumber)
    {
        Random random = new Random();
        ListNode temp = listOfChars;

        Console.WriteLine("Enter the Linked List Valuies");
        for (int iterator = 0; iterator < limitNumber; iterator++)
        {
            Console.Write(">>> ");
            int randomValue = random.Next(0, 10);

            temp.next = new ListNode(randomValue);
            temp = temp.next;
        }

        return listOfChars;
    }
    private static ListNode DeleteDuplicatess(ListNode head)
    {
        if (head == null)
            return null;

        var duplicates = AddHashSetWithNode(head);
        
        ListNode result = new ListNode();
        ListNode other = result;

        foreach (var item in duplicates)
        {
            other.next = new ListNode(item);
            other = other.next;
        }
        
        return result.next;
    }
    private static HashSet<int> AddHashSetWithNode(ListNode head)
    {
        HashSet<int> duplicates = new HashSet<int>();
        ListNode slow = head;

        while (slow is not null)
        {
            duplicates.Add(slow.val);

            if (slow.next is not null)
                slow = slow.next;
            else
                break; 
        }

        return duplicates;
    }
    private static void PrintLinkedList(ListNode result)
    {
        while (result is not null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

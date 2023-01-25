using System.Collections.Generic;

namespace DailyLeetcode.LinkedList.Easies;
public class ListNode
{
    public ListNode next;
    public int value;

    public ListNode(int value = 0, ListNode next = null)
    {
        this.next = next;
        this.value = value;
    }
}

public class MiddleOfLinkedList
{
    private static void Main()
    {
        ListNode list = new ListNode();
        FillUpLinkedList(list, 5);

        list = MiddleNode(list.next);

        PrintMiddleNode(list);
    }
    private static void FillUpLinkedList(ListNode list, int borderNumber)
    {
        for (int i = 0; i < borderNumber; i++)
        {
            Random random = new Random();
            int r = random.Next(1, 10);
            list.next = new ListNode(r);
            list = list.next;
        }
    }
    private static ListNode MiddleNode(ListNode head)
    {
        ListNode forCounter = head;
        int counter = 0;
        while (forCounter != null)
        {
            counter++;
            forCounter = forCounter.next;
        }
        int half = counter / 2;
        while (half > 0)
        {
            head = head.next;
            half--;
        }

        return head;
    }
    private static void PrintMiddleNode(ListNode list)
    {
        Console.Write("Result -> ");
        while (list != null)
        {
            Console.Write(list.value + " ");
            list = list.next;
        }
    }
}


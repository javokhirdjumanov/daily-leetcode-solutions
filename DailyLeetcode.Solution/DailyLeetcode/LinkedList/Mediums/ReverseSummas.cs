
using System.Text;

namespace DailyLeetcode.LinkedList.Mediums;
class Program
{
    public static void MainViewer()
    {
        ListNode list1 = new ListNode();
        ListNode list2 = new ListNode();
        ListNode newlist = new ListNode();

        FillUpLinkedList1(list1, 3);

        FillUpLinkedList2(list2, 3);

        int SumLeft = Summa(list1.next, list2.next);

        ListNode newList = NewLinkedList(newlist, SumLeft);

        while (newlist.next != null)
        {
            Console.Write(newlist.next.value + " ");

            newlist = newlist.next;
        }
    }
    private static void FillUpLinkedList1(ListNode listOfChars, int counter)
    {
        Random random = new Random();
        ListNode temp = listOfChars;
        for (int iterator = 0; iterator < counter; iterator++)
        {
            int r = random.Next(1, 10);

            temp.next = new ListNode(r);
            temp = temp.next;
        }
        Console.Write("Linked List One : ");
        while (listOfChars.next != null)
        {
            Console.Write(listOfChars.next.value + " ");
            listOfChars = listOfChars.next;
        }
        Console.WriteLine();
    }
    private static void FillUpLinkedList2(ListNode listOfChars, int counter)
    {
        Random random = new Random();
        ListNode temp = listOfChars;

        for (int iterator = 0; iterator < counter; iterator++)
        {
            int r = random.Next(1, 10);

            temp.next = new ListNode(r);
            temp = temp.next;
        }
        Console.Write("Linked List Two : ");

        while (listOfChars.next != null)
        {
            Console.Write(listOfChars.next.value + " ");
            listOfChars = listOfChars.next;
        }

        Console.WriteLine();
    }
    private static int Summa(ListNode list1, ListNode list2)
    {
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();

        ListNode node1 = list1;
        ListNode node2 = list2;

        while (node1 != null)
        {
            sb1.Append(node1.value.ToString());
            node1 = node1.next;
        }
        while (node2 != null)
        {
            sb2.Append(node2.value.ToString());
            node2 = node2.next;
        }
        int SumLeft = int.Parse(sb1.ToString()) + int.Parse(sb2.ToString());

        return SumLeft;
    }
    private static ListNode NewLinkedList(ListNode newlist, int SumLeft)
    {
        ListNode listNode = newlist;
        while (SumLeft > 0)
        {
            listNode.next = new ListNode(SumLeft % 10);

            listNode = listNode.next;

            SumLeft /= 10;
        }

        return newlist;
    }
}
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

namespace DailyLeetcode.LinkedList.Mediums;
public class PalindromOftheLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListNode list = new ListNode();

            FilledLinkedList(list, 4);

            Console.WriteLine(IsPalindrom(list.next));
        }
        private static void FilledLinkedList(ListNode list, int borderNumber)
        {
            Random random = new Random();
            for (int i = 0; i < borderNumber; i++)
            {
                int r = random.Next(1, 10);
                list.next = new ListNode(r);
                list = list.next;
            }
        }
        private static bool IsPalindrom(ListNode head)
        {
            Stack<int> stack = new Stack<int>();

            ListNode forCounter = head;
            int counter = 0;

            while (forCounter != null)
            {
                counter++;
                forCounter = forCounter.next;
            }

            ListNode temp = head;
            int halp = counter / 2;

            while (halp > 0)
            {
                stack.Push(temp.val);
                temp = temp.next;
                halp--;
            }

            if (counter % 2 == 1)
                stack.Push(temp.val);

            while (temp != null)
            {
                if (stack.Pop() != temp.val)
                    return false;
                else
                    temp = temp.next;
            }

            return true;
        }
    }
}

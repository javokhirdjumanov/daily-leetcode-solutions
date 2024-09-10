using System.Numerics;

namespace DailyLeetcode.LinkedList.Mediums
{
    public class _2807_InsertGreatestCommonDivisorsInLinkedList
    {
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode slow = head, fast = head.next;

            while (fast is not null)
            {
                ListNode temp = fast;
                slow.next = EKUB(slow.val, fast.val);
                slow.next.next = temp;

                slow = fast;
                fast = fast.next;
            }

            return head;
        }
        private ListNode EKUB(int a, int b)
        {
            return new ListNode((int)BigInteger.GreatestCommonDivisor(a, b));
        }
    }
}

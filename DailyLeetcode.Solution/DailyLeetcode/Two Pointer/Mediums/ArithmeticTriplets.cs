namespace DailyLeetcode.Two_Pointer.ArithmeticTriplets;
public sealed class ArithmeticTriplets
{
    public static int ArithmeticTripletss(int[] nums, int diff)
    {
        int checkCount = 0, resultCount = 0;
        int last = nums.Length - 1, middle = nums.Length - 1, front = nums.Length - 2;

        while (middle > 0)
        {
            if (nums[middle] - nums[front] == diff)
            {
                checkCount++;
                if (checkCount == 2)
                {
                    last--;
                    middle = last;
                    front = middle - 1;

                    resultCount++;
                    checkCount = 0;
                }
                else
                {
                    middle = front;
                    front = middle - 1;
                }
            }
            else if (front == 0)
            {
                last--;
                middle = last;
                front = middle - 1;

                checkCount = 0;
            }
            else
                front--;
        }

        return resultCount;
    }
}

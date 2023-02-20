namespace DailyLeetcode.Arrays.Easies;
internal class ValidMountainArray
{
    public static bool ValidMountainArrays(int[] arr)
    {
        if (arr.Length < 3) return false;

        if (arr.Max() == arr[0] || arr.Max() == arr[arr.Length - 1]) return false;

        bool mountain = true;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i] && mountain) 
                mountain = false;

            if (!mountain)
            {
                if (arr[i] >= arr[i - 1])  return false;
            }

            if (arr[i - 1] == arr[i])  return false;
        }

        return true;
    }
}

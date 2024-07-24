public static class AddUpToSum
{
    public static bool CanSumToLargest(int[] arr)
    {
        if (arr.Length < 2)
        {
            return false;
        }
        Array.Sort(arr);
        int max = arr[^1];

        int[] numbers = arr.Take(arr.Length - 1).ToArray(); // take out the max

        return numbers.Sum() > max;
    }
}

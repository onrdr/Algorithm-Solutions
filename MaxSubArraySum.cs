namespace UsefulAlgorithms;

public static class MaxSubArraySum
{
    public static int Find(int[] arr)
    { 
        int maxSum = arr[0];
        int currentSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            currentSum = Math.Max(arr[i], currentSum + arr[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
namespace UseFulAlgorithms;

public static class FindMissingNumber
{
    public static int From1toN(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        foreach (int num in nums) 
            actualSum += num; 

        return expectedSum - actualSum;
    }

    public static int FromNtoM(int[] nums)
    {
        int max = nums[0], min = nums[0], expectedSum, actualSum = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
                max = nums[i];

            if (nums[i] < min)
                min = nums[i];
        }

        expectedSum = (max + min) * (max - min + 1) / 2;

        foreach (int num in nums)
            actualSum += num;

        return expectedSum - actualSum;
    }
}
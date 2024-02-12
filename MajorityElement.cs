namespace UsefulAlgorithms;

public class MajorityElement
{
    public static int Run(int[] nums)
    {
        int count = 0, majorityElement = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
                majorityElement = nums[i];
            
            if (majorityElement == nums[i])
                count++;            

            else count -= 1;
        }

        return majorityElement;
    }

    public static int Run2(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }

    public static void RunTestCases()
    {
        Console.WriteLine(Run2(new[] { 2, 2, 1, 2, 1, 2, 3, 2, 2, 3 }));
        Console.WriteLine(Run2(new[] { 3, 2, 3 }));
        Console.WriteLine(Run2(new[] { 3, 2, 3, 6, 6, 5, 5, 6, 6, 6, 6, 6 }));
    }
}

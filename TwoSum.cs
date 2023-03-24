namespace UsefulAlgorithms;
 
public static class TwoSum
{
    public static int[] Find(int[] arr, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int num1 = arr[i];

            for (int j = i + 1; j < arr.Length; j++)
            {
                int num2 = arr[j];

                if (num1 + num2 == target)
                {
                    result[0] = i;
                    result[1] = j;

                    return result;
                }
            }
        }

        return result;
    }
}

/*
    The method searches for a pair of numbers in the input array 
    whose sum is equal to the target value, and returns an array 
    of two integers that represent the indices of the two numbers 
    in the input array.
 */
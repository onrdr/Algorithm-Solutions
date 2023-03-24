namespace UsefulAlgorithms;

public static class BinarySearch
{
    public static int Run(int[] arr, int target)
    {
        var list = arr.ToList();
        list.Sort();

        int left = 0, right = list.Count - 1;

        while (left <= right)
        {
            int middle = left + right / 2;

            if (target > list[middle])
                left = middle + 1;

            else if (target < list[middle])
                right = middle - 1;

            else
                return middle;
        }

        return -1;
    }
}
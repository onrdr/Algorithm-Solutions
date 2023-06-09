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

    public static int Run2(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
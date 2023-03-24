namespace UsefulAlgorithms;

public static class FibonacciAlgorithms
{
    public static int FindSumOfTheFirstNSequence(int n)
    {
        if (n <= 0)
            return 0;

        if (n == 1)
            return 1;

        int first = 0, second = 1, sum = first + second;

        for (int i = 2; i < n; i++)
        {
            int next = first + second;
            first = second;
            second = next;
            sum += next;
        }
        return sum;
    }

    public static List<int> GenerateFirstNSequence(int n)
    {
        List<int> result = new();
        int a = 0, b = 1, c;

        for (int i = 0; i < n; i++)
        {
            result.Add(a);
            c = a + b;
            a = b;
            b = c;
        }

        return result;
    }

    public static int FindNthFibonacciNumber(int n)
    {
        if (n <= 0)
            return 0;

        if (n == 1)
            return 0;

        return FindNthFibonacciNumber(n - 1) + FindNthFibonacciNumber(n - 2);
    }
}
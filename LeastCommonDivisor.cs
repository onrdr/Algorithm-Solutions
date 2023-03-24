namespace UsefulAlgorithms;

public static class LeastCommonDivisor
{
    public static int FindLCS(string first, string second, int n, int m)
    {
        // n = first.Length and  m = second.Length

        if (n == 0 || m == 0)
            return 0;

        if (first[n - 1] == second[m - 1])
            return 1 + FindLCS(first, second, n - 1, m - 1);

        else
            return Math.Max(
                            FindLCS(first, second, n, m - 1),
                            FindLCS(first, second, n - 1, m)
                            );
    }
}
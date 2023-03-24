namespace UsefulAlgorithms;

public static class ReverseBinaryEquivalentNumber
{
    public static int Find(int number)
    {
        // 1. Convert the number to its binary equivalent,
        // 2. Reverse the binary equivalent and convert it back to an integer
        var binaryRep = string.Empty;

        while (number > 0)
        {
            binaryRep += number % 2;
            number /= 2;
        }

        int result = 0;
        int base1 = 1;
        int len = binaryRep.Length;

        for (int i = 0; i < len; i++)
        {
            if (binaryRep[i] == '1')
                result += base1;

            base1 *= 2;
        }

        return result;
    }
}
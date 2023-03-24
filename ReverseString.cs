namespace UseFulAlgorithms;

public static class ReverseString
{
    public static string FindReverse(string input)
    {
        int length = input.Length;
        char[] charArray = new char[length];

        for (int i = 0; i < length; i++)
            charArray[i] = input[length - i - 1];

        return new string(charArray);
    }
}
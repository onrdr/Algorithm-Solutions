using System.Text;

namespace UsefulAlgorithms;

public static class AddLargeNumbers
{
    public static string AddLargeNumbersModified(string num1, string num2)
    {
        StringBuilder result = new();
        long carry = 0;
        int len1 = num1.Length - 1;
        int len2 = num2.Length - 1;

        while (len1 >= 0 || len2 >= 0 || carry != 0)
        {
            long digit1 = len1 >= 0 ? num1[len1] - '0' : 0;
            long digit2 = len2 >= 0 ? num2[len2] - '0' : 0;

            long sum = digit1 + digit2 + carry;
            carry = sum / 10;
            result.Insert(0, sum % 10);

            len1--;
            len2--;
        }

        return result.ToString();
    }
}
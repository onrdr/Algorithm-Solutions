namespace UsefulAlgorithms;

public static class IsPalindrome
{
    public static bool Find(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left++] != word[right--])
                return false;
        }

        return true;
    }
}
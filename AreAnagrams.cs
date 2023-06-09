public static class AreAnagrams
{
    public static bool Run(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        int[] charCount = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            var s1Char = s1[i];
            var s2Char = s2[i];

            var sub1 = s1Char - 'a';
            var sub2 = s2Char - 'a';

            charCount[sub1]++;
            charCount[sub2]--;

            // charCount[s1[i] - 'a']++;
            // charCount[s2[i] - 'a']--;
        }

        foreach (int count in charCount)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}



public static class ReverseEachWord
{
    public static string Run(string input)
    {
        // input: Welcome to Csharp corner, output: emocleW ot prahsC renroc

        string[] wordArr = input.Split(' ');

        char[] charArr = new char[input.Length];

        int charCounter = 0;

        foreach (var word in wordArr)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                charArr[charCounter++] = word[i];
            }

            if (charCounter != input.Length)
            {
                charArr[charCounter++] = ' ';
            }
        }

        var result = new string(charArr);

        return result;
    }
}



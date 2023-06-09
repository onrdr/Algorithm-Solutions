

public static class ReverseOrderOfWords
{
    public static void Run(string str)
    {
        // Welcome to Csharp corner, output: corner Csharp to Welcome

        string[] arr = str.Split(' ');

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}



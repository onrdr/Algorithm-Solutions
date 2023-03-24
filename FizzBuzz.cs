namespace UsefulAlgorithms;

public static class FizzBuzz
{
    public static void Run(int num1, int num2, int N)
    {
        for (int i = 1; i <= N; i++)
        {
            if (i % num1 == 0 && i % num2 == 0)
                Console.WriteLine("FizzBuzz");

            else if (i % num1 == 0)
                Console.WriteLine("Fizz");

            else if (i % num2 == 0)
                Console.WriteLine("Buzz");

            else
                Console.WriteLine(i);
        }
    }
}
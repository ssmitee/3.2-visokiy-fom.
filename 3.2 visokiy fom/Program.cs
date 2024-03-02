using System;

class Fibonacci
{
    static void Main()
    {
        const int position = 20;
        long fib0 = 0;
        long fib1 = 1;
        long fibN = 0;

        for (int i = 2; i <= position; i++)
        {
            fibN = fib0 + fib1;
            fib0 = fib1;
            fib1 = fibN;
        }

        Console.WriteLine($"20-е число Фибоначчи: {fibN}");
    }
}
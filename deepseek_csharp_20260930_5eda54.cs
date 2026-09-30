using System;

class Program
{
    static void Main()
    {
        int A = 1, B = 5;
        int C = 3, D = 7;

        PrintIntersection(A, B, C, D);
    }

    static void PrintIntersection(int A, int B, int C, int D)
    {
        int start = Math.Max(A, C);
        int end = Math.Min(B, D);

        if (start <= end)
            Console.WriteLine($"[{start}, {end}]");
        else
            Console.WriteLine("Пересечения нет");
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte první hodnotu (first): ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Zadejte poslední hodnotu (last): ");
        int last = int.Parse(Console.ReadLine());

        Console.Write("Zadejte krok (step): ");
        int step = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Výstup:");

        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }
}
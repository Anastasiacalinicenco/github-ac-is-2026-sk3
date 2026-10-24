using System;

class Program
{
    static void Main()
    {
        // Nadstavba: Bezpečné načítání čísel a kontrola platnosti kroku
        int first = NactiCislo("Zadejte první hodnotu (first): ");
        int last = NactiCislo("Zadejte poslední hodnotu (last): ");
        int step = NactiCislo("Zadejte krok (step): ");

        // Ochrana proti nekonečnému cyklu (krok musí být větší než 0)
        if (step <= 0)
        {
            Console.WriteLine("Chyba: Krok musí být větší než 0!");
            return;
        }

        Console.WriteLine("\nVýstup:");
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }

    // Pomocná metoda pro validaci vstupu proti nečíselným hodnotám
    static int NactiCislo(string vyzva)
    {
        int cislo;
        Console.Write(vyzva);
        while (!int.TryParse(Console.ReadLine(), out cislo))
        {
            Console.Write("Neplatné číslo! Zadejte hodnotu znovu: ");
        }
        return cislo;
    }
}

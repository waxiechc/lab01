using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть рядок: ");
        string input = Console.ReadLine();

        Console.Write("Введiть першу букву: ");
        char letter1 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Введiть другу букву: ");
        char letter2 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count1 = 0, count2 = 0;

        foreach (char c in input)
        {
            if (c == letter1)
                count1++;
            if (c == letter2)
                count2++;
        }

        if (count1 > count2)
            Console.WriteLine($"Буква '{letter1}' зустрiчається частiше.");
        else if (count2 > count1)
            Console.WriteLine($"Буква '{letter2}' зустрiчається частiше.");
        else
            Console.WriteLine("Обидвi букви зустрiчаються однакову кiлькiсть раз.");
    }
}
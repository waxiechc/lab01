using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть основний рядок (S): ");
        string S = Console.ReadLine();

        Console.Write("Введіть рядок, перед яким буде вставка (S1): ");
        string S1 = Console.ReadLine();

        Console.Write("Введіть рядок для вставки (S2): ");
        string S2 = Console.ReadLine();

        string result = S.Replace(S1, S2 + S1);

        Console.WriteLine("Результат: " + result);
    }
}
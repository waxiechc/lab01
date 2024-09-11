using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть речення: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length - 1; i += 2)
        {
            string temp = words[i];
            words[i] = words[i + 1];
            words[i + 1] = temp;
        }

        string result = string.Join(" ", words);
        Console.WriteLine("Результат: " + result);
    }
}
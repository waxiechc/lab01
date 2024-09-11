using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Введіть речення: ");
        string sentence = Console.ReadLine();

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (!string.IsNullOrEmpty(words[i]))
            {
                words[i] = textInfo.ToTitleCase(words[i]);
            }
        }

        string result = string.Join(" ", words);
        Console.WriteLine("Результат: " + result);
    }
}
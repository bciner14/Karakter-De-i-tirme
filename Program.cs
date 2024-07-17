using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();
        
        string result = SwapFirstAndLastCharacters(input);
        
        Console.WriteLine(result);
    }

    static string SwapFirstAndLastCharacters(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                words[i] = SwapFirstAndLast(words[i]);
            }
        }
        return string.Join(" ", words);
    }

    static string SwapFirstAndLast(string word)
    {
        if (word.Length <= 1)
        {
            return word;
        }

        char firstChar = word[0];
        char lastChar = word[word.Length - 1];

        return lastChar + word.Substring(1, word.Length - 2) + firstChar;
    }
}

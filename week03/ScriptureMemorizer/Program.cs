// Enhancement Comment:
// I have exceeded the core requirements by adding a scripture library that loads dynamically from a text file.
// The file 'scriptures.txt' contains scripture entries. The program reads this file at runtime, allowing for easy expansion without modifying code. This supports better memorization variety and user flexibility.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found. Please check scriptures.txt");
            return;
        }

        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            selectedScripture.Display();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords(3);

            if (selectedScripture.AllWordsHidden())
            {
                selectedScripture.Display();
                Console.WriteLine("All words are now hidden. Well done!");
                break;
            }
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();

        if (!File.Exists(filePath))
            return scriptures;

        foreach (var line in File.ReadAllLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split('|');
            if (parts.Length < 4) continue;

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            string versePart = parts[2];
            string text = parts[3];

            Reference reference;
            if (versePart.Contains("-"))
            {
                var range = versePart.Split('-');
                int verseStart = int.Parse(range[0]);
                int verseEnd = int.Parse(range[1]);
                reference = new Reference(book, chapter, verseStart, verseEnd);
            }
            else
            {
                int verse = int.Parse(versePart);
                reference = new Reference(book, chapter, verse);
            }

            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}


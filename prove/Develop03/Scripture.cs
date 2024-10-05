using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        string[] splitText = text.Split(' ');

        foreach (string word in splitText)
        {
            words.Add(new Word(word));
        }
    }

    // Display the scripture with hidden words
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(reference.GetReferenceString());

        foreach (Word word in words)
        {
            Console.Write(word.GetDisplayWord() + " ");
        }
        Console.WriteLine();
    }

    // Hide a few random words
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(count, words.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(words.Count);
            words[randomIndex].Hide();
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

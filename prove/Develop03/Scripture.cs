using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsHidden = 0;
        while (wordsHidden < count)
        {
            int index = random.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(reference.GetDisplayText());
        sb.Append(" - ");

        foreach (Word word in words)
        {
            sb.Append(word.GetDisplayText());
            sb.Append(" ");
        }

        return sb.ToString().Trim();
    }

    public bool AreAllWordsHidden()
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
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
       _reference = reference;

        _words = new List<Word>();

       string[] splitScripture = text.Split(" ");

       foreach (string wordString in splitScripture)
       {
        Word word = new Word(wordString);

        _words.Add(word);
       }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        int notHiddenCount = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                notHiddenCount += 1;
            }
        }

        if (numberToHide <= notHiddenCount)
        {
            for (int i = 0; i < numberToHide; i++)
            {
                int randomNum = rand.Next(0, _words.Count);

                while (_words[randomNum].IsHidden())
                {
                    randomNum = rand.Next(0, _words.Count);
                }

                 _words[randomNum].Hide();
            }
        }
        else
        {
            for (int i = 0; i < notHiddenCount; i++)
            {
                int randomNum = rand.Next(0, _words.Count);

                while (_words[randomNum].IsHidden())
                {
                    randomNum = rand.Next(0, _words.Count);
                }

                 _words[randomNum].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string verse = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            verse = $"{verse} {word.GetDisplayText()}";
        }
        return  verse;
    }

    public bool IsCompletlyHidden()
    {
        bool allFalse = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                allFalse = false;
                break;
            }
        }
        if (allFalse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
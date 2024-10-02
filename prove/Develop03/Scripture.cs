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

    }

    public string GetDisplayText()
    {
        return  "";
    }

    public bool IsCompletlyHidden()
    {
        return false;
    }
}
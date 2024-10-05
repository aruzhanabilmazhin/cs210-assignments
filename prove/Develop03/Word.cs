public class Word
{
    private string word;
    private bool isHidden;

    public Word(string word)
    {
        this.word = word;
        this.isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        isHidden = true;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return isHidden;
    }

    // Get the display value of the word (show as "____" if hidden)
    public string GetDisplayWord()
    {
        return isHidden ? "____" : word;
    }
}

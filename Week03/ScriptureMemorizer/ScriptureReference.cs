public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public ScriptureReference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        _book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        _chapter = int.Parse(chapterVerse[0]);

        string[] verses = chapterVerse[1].Split('-');
        _startVerse = int.Parse(verses[0]);
        _endVerse = verses.Length > 1 ? int.Parse(verses[1]) : (int?)null;
    }

    public override string ToString()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_chapter}:{_startVerse}";
    }
}

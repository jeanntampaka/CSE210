using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(Random random, int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        if (!visibleWords.Any()) return;

        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    public string GetDisplayText()
    {
        return $"{_reference}\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}

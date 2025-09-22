using System.IO;
using System;
using System.Collections.Generic;

public class Scripture
{
    private References _reference;
    private string[] _words;

    public Scripture(References reference, string[] words)
    {
        _reference = reference;
        _words = words;
    }
   

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;
        if (hidden < count)
        {
            int index = rand.Next(_words.Length);
            
            if (_words[index] != "____")
            {
                _words[index] = "____";
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetReference()} " + string.Join(" ", _words);
    }
    
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (word != "____")
                return false;
        }
        return true;
    }   
}
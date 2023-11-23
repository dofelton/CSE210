using System;
using System.Runtime.Intrinsics.Arm;
class Words
{
public List<string> _text = new List<string>();
public List<bool> _hidden = new List<bool>();
public Words(string scripture)
{
  _text = CreateWordList(scripture);
  int size = _text.Count();
  _hidden = Enumerable.Repeat(false, size).ToList();
  
}
public List<string> CreateWordList(string scripture)
{
  _text = scripture.Split(" ").ToList();
  
  return _text;
}

public void HideWords(List<string> text)
    {
        Random rnd = new Random();
        int num = rnd.Next(0, _text.Count());
        _text[num] = "____";
        _hidden[num] = true;
    }
    
public bool CompletelyHidden()
{
  return !(_hidden.Contains(false));
}
}
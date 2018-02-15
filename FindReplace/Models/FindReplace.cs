using System;

namespace FindReplace.Models
{
  public class FindAndReplace
  {
    private string _text;
    private string _find;
    private string _replace;
    private string _result;

    public FindAndReplace(string text, string find, string replace)
    {
      _text = text;
      _find = find;
      _replace = replace;
    }

    public string GetText()
    {
      return _text;
    }

    public string GetFind()
    {
      return _find;
    }

    public string GetReplace()
    {
      return _replace;
    }

    public string GetResult()
    {
      return _result;
    }

    public int GetIndex(int start)
    {
      string text = _text.Substring(start, _text.Length - start).ToLower();
      return text.IndexOf(_find.ToLower()) + start;
    }

    public void ReplaceAll()
    {
      string newText = "";
      int lastIndex = 0;
      while (true)
      {
        int index = GetIndex(lastIndex);
        if(index < lastIndex)
        {
          break;
        }
        newText += _text.Substring(lastIndex, index - lastIndex) + _replace;
        lastIndex = index + _find.Length;
      }
      newText += _text.Substring(lastIndex, _text.Length - lastIndex);
      _result = newText;
    }
  }
}

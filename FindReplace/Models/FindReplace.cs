using System;

namespace FindReplace.Models
{
  public class FindReplace
  {
    private string _text;
    private string _find;
    private string _replace;

    public FindReplace(string text, string find, string replace)
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

    public int GetIndex()
    {
      return _text.IndexOf(_find);
    }

    public string ReplaceAll()
    {
      // while (true)
      // {
      //   int index = _text.
      // }

      return _text;
    }
  }
}

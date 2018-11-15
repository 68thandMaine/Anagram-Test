using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramGame
  {

    private string _word;
    // private static List<words> _listOfMaybeAnagrams = new List<words>{};

    public AnagramGame (string word)
    {
      _word = word;
      // _listOfMaybeAnagrams.Add(this);
    }

    public string stringCapture()
    {
      return "";
    }

    // public static List<words> GetAll()
    // {
    //   return _listOfMaybeAnagrams;
    // }

  }
}

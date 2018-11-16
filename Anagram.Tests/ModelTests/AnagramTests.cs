using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramGameTests
  {
    [TestMethod]
    public void StringCapture_CaptureInputWord_True()
    {
      List<string> comparisonWords = new List<string>{"bear", "dog"};
      AnagramGame inputWord = new AnagramGame("word", comparisonWords);
      string result = inputWord.StringCapture();
      Assert.AreEqual("word", result);
    }

    [TestMethod]

    public void GetPossibleAnagrams_CapturesAnagramWords_True()
    {
      List<string> comparisonWords = new List<string>{"bear", "dog"};
      AnagramGame inputWordToList = new AnagramGame("bear", comparisonWords);
      var result = inputWordToList.GetPossibleAnagrams();
      Console.WriteLine("This is second test result: " + result);
      CollectionAssert.AreEqual(comparisonWords, result);
    }

  }
}

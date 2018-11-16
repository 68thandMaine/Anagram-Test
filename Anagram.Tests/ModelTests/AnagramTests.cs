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
      List<string> comparisonWords = new List<string> {"word"};
      AnagramGame inputWord = new AnagramGame("junk", comparisonWords);
      string result = inputWord.stringCapture();
      Assert.AreEqual("word", result);
    }

    // [TestMethod]
    // public bool isLetterEqual_CompareInputEquality_True()
    // {
    //   List<string> comparisonWords = new List<string> {"a"};
    //   AnagramGame inputWord = new AnagramGame("a", comparisonWords);
    //
    //   string result = inputWord.isLetterEqual()
    //
    //   Assert.AreEqual
    // }
    // // [TestMethod]
    // public void GetPossibleAnagrams_CapturesAnagramWords_True()
    // {
    //   List<string> comparisonWords = new List<string>{"bear", "dog"};
    //   AnagramGame inputWordToList = new AnagramGame("bear", comparisonWords);
    //   var result = inputWordToList.GetPossibleAnagrams();
    //   Console.WriteLine("This is second test result: " + result);
    //   CollectionAssert.AreEqual(comparisonWords, result);
    // }

  }
}

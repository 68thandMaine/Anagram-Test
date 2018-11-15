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
    public void stringCapture_CaptureInputWord_True()
    {
      AnagramGame inputWord = new AnagramGame("word");

      string result = inputWord.stringCapture();

      Assert.AreEqual("word", result);
    }

  }
}

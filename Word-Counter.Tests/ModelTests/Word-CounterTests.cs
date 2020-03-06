using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCountTests
  {
    [TestMethod]
    public void WordCount_AcceptInput_True()
    {
      // Arrange
      WordCount testWord = new WordCount("Jef", "My name Jef");
      // Assert
      Assert.AreEqual(typeof(WordCount), testWord.GetType());
    }
    
    [TestMethod]
    public void BreakDown_SeperateEachWord_ArrayOfWords()
    {
      string inputSentence = "My name Jef";
      string[] sentenceArray = {"My", "name", "Jef"};
      Assert.AreEqual(WordCount.BreakDown(inputSentence), sentenceArray);
    }
  }
}
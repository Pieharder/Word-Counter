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
      WordCount testWord = new WordCount();
      // Act
      testWord.Count("magic", "magic the Gathering");
      // Assert
      Assert.AreEqual(typeof(WordCount), testWord.GetType());
    }

  }
}
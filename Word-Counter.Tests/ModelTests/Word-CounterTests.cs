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
    
    // [TestMethod]
    // public void Count_LowerCaseAllInput_LowerCaseString()
    // {
    //   // Arrange
    //   WordCount testWord = new WordCount();
    //   // Act
    //   testWord
    //   // Assert
    //   Assert.AreEqual(typeof(WordCount), testWord.GetType());
    // }

    // [TestMethod]
    // public void Count_CountOccurences_Number()
    // {
    //   // Arrange
    //   WordCount testWord = new WordCount();
    //   // Act
    //   testWord.Count("Jef", "My name Jef");
    //   // Assert
    //   Assert.AreEqual(typeof(WordCount), testWord.GetType());
    // }
  }
}
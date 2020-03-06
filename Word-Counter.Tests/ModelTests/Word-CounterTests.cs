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
      WordCount testWord = new WordCount("Jef", "My name Jef");
      Assert.AreEqual(typeof(WordCount), testWord.GetType());
    }
    
    [TestMethod]
    public void BreakDown_SeperateEachWord_ArrayOfWords()
    {
      string inputSentence = "My name Jef";
      string[] sentenceArray = {"My", "name", "Jef"};
      CollectionAssert.AreEqual(WordCount.BreakDown(inputSentence), sentenceArray);
    }

    [TestMethod]
    public void LowerCase_AllWordsLowerCase_ArrayOfLowerCaseWords()
    {
      string[] sentenceArray = {"My", "name", "Jef"};
      string[] lowerCaseSentenceArray = {"my", "name", "jef"};
      CollectionAssert.AreEqual(WordCount.LowerCase(sentenceArray), lowerCaseSentenceArray);
    }

    [TestMethod]
    public void WordCount_CountAllInstancesOfAWord_Number()
    {
      string inputWord = "jef";
      string[] lowerCaseSentenceArray = {"my", "name", "jef"};
      Assert.AreEqual(WordCount.WordCounter(inputWord, lowerCaseSentenceArray), 1);
    }
  }
}
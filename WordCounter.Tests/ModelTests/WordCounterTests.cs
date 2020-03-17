using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

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
    public void WordCounting_CountAllInstancesOfAWord_Number()
    {
      WordCount testWord = new WordCount("Jef", "My name Jef");
      Assert.AreEqual(testWord.WordCounting(), 1);
    }

        [TestMethod]
    public void WordCounting_OnlyCountCompleteWords_Number()
    {
      WordCount testWord = new WordCount("Jef", "My name Jeffrey but I go by Jef");
      Assert.AreEqual(testWord.WordCounting(), 1);
    }
  }
}
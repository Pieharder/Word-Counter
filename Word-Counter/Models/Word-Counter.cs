using System;

namespace WordCounter.Models
{
  public class WordCount
  {
    public string Word { get; set; }
    public string Sentence { get; set; }

    public WordCount(string inputWord, string inputSentence)
    {
      inputWord = Word;
      inputSentence = Sentence;
    }

    public static string[] BreakDown(string inputSentence)
    {
      return inputSentence.Split(" ");
    }

    public static string[] LowerCase(string[] sentenceArray)
    {
      for(int i = 0; i < sentenceArray.Length; i++)
      {
        sentenceArray[i] = sentenceArray[i].ToLower();
      }
      return sentenceArray;
    }
  }

}
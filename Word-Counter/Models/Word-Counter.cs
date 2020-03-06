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
  }

}
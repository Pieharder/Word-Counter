using System;

namespace WordCounter.Models
{
  public class WordCount
  {
    public string Word { get; set; }
    public string Sentence { get; set; }

    public void Count(string inputWord, string inputSentence)
    {
      inputWord = Word;
      inputSentence = Sentence;
    }
  }

}
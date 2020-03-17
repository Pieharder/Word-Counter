using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a sentence:");
      string userInputSentence = Console.ReadLine();
      Console.WriteLine("Input a word from that sentence to count:");
      string userInputWord = Console.ReadLine();
      WordCount newWordCount = new WordCount(userInputWord, userInputSentence);
      int count = newWordCount.WordCounting();
      Console.WriteLine("Your word appears " + count + " times in this sentence.");
    }
  }

}
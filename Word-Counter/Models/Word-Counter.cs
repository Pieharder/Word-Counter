namespace WordCounter.Models
{
  public class WordCount
  {
    public string Word { get; set; }
    public string Sentence { get; set; }

    public WordCount(string inputWord, string inputSentence)
    {
      Word = inputWord;
      Sentence = inputSentence;
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

    public static int WordCounter(string inputWord, string[] lowerCaseSentenceArray)
    {
      int wordUsed = 0;
      for(int i = 0; i < lowerCaseSentenceArray.Length; i++)
      {
        if(lowerCaseSentenceArray[i] == "jef")
        {
          wordUsed++;
        }
      }
      return wordUsed;
    }
  }

}
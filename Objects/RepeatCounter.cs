using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {
    public int CountRepeats(string sentence, string word)
    {
      int counter = 0;
      char[] delimiter = new char[]{' ', ',', ':', ';', '.', '!', '?'};
      string[] sentenceArr = sentence.Split(delimiter);
      string[] wordArr = word.Split(delimiter);

      for (int i = 0; i < 1; i++)
      {
        for (int s = 0; s < sentenceArr.Length; s++)
        {
          if(wordArr[i].ToLower() == sentenceArr[s].ToLower())
          {
            counter++;
          }
          else
          {
            continue;
          }
        }
      }
      return counter;
    }
  }
}

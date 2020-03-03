using System.Collections.Generic;
using System;


namespace Anagram.Models
{
  public class AnagramFinder
  {
    public string Word { get; set; }
    private static List<AnagramFinder> _instances = new List<AnagramFinder> {};
    public AnagramFinder(string word)
    {
      Word = word;
      // _instances.Add(this);
    }
    public static void AddWordList(AnagramFinder matchingObj)
    {
      _instances.Add(matchingObj);
    }
    public static List<AnagramFinder> GetAll()
    {
      return _instances;
    }
  }
}
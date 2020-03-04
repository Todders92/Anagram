using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Program
{
  public class Anagram
  {
    public static void Main()
    {
      Console.WriteLine("enter a word to find the anagrams of it");
      string word = Console.ReadLine();
      Console.WriteLine("enter words you thinkn may be anagrams of your inputted word");
      string compareWord = Console.ReadLine();
      AnagramFinder anagramFinder = new AnagramFinder(word);
      Console.WriteLine(anagramFinder.Word);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class ItemTests
  {

    [TestMethod]
    public void AnagramFinder_TakesInUserinput_String()
    {
      AnagramFinder anagramFinder = new AnagramFinder("golden girl");
      Assert.AreEqual(typeof(AnagramFinder), anagramFinder.GetType());
    }

    [TestMethod]
      public void AddWordsList_ReturnsWords_String()
      {
        //Arrange
        
        AnagramFinder anagramFinder = new AnagramFinder("cat");
        List<AnagramFinder> finalResult = new List<AnagramFinder> {anagramFinder};

        //Act
        AnagramFinder.AddWordList(anagramFinder);
        List<AnagramFinder> result = AnagramFinder.GetAll();

        //Assert
        CollectionAssert.AreEqual(finalResult, result);

      }
  }
}
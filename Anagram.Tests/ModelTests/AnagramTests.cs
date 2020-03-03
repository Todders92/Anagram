using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class ItemTests
  {

    [TestMethod]
    public void FormInput_TakesInUserinput_String()
    {
      AnagramFinder anagramFinder = new AnagramFinder("dog");
      Assert.AreEqual(typeof(AnagramFinder), anagramFinder.GetType());
    }

  }
}
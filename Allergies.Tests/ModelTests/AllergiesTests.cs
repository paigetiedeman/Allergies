using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergyScore
  {
    [TestMethod]
    public void AllergyOutput_128_Cats()
    {
      AllergyScore allergyScore = new AllergyScore();
      Assert.AreEqual("cats", allergyScore.AllergyOutput(128));
    }

    // [TestMethod]
    // public void Palindrome_IsEpicodusAPalindrome_False()
    // {
    //   PalindromeTest palindrome = new PalindromeTest();
    //   Assert.AreEqual(false, palindrome.IsAPalindrome("epicodus"));
    // }

    // [TestMethod]
    // public void Palindrome_IsCapitalizedMomAPalindrome_True()
    // {
    //   PalindromeTest palindrome = new PalindromeTest();
    //   Assert.AreEqual(true, palindrome.IsAPalindrome("Mom"));
    // }
  }
}
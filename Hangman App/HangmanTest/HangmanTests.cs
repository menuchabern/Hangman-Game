using HangmanSystem;
using NUnit.Framework.Internal.Execution;

namespace HangmanTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetWord()
        {
            ChosenWord word = new();
            word.AmntOfLetters = 7;
            string guessingword = "";
            guessingword = word.ChooseNewWord();
            string msg = $"the word is {guessingword}, the the amount of letters in the word({guessingword.Length.ToString()}) should equal 7";
            Assert.IsTrue(guessingword != "" && guessingword.Length == 7, msg);
            TestContext.WriteLine(msg);
        }
    }
}
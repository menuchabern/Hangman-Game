using HangmanSystem;
using Microsoft.VisualBasic;
using NUnit.Framework.Internal.Execution;
using static HangmanSystem.ChosenWord;

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

        [Test]
        public void CheckIfHasLetter()
        {
            ChosenWord word = new();
            word.AmntOfLetters = 5;
            string guessingword = word.ChooseNewWord();
            string letter = guessingword[4].ToString();
            word.CheckWordIfLetter(letter);
            string msg = $"the word has {guessingword.Length} = {word.TextBoxesLst.Count} letters. and the letter {letter} was chosen and {guessingword} should contain a {letter}";
            Assert.IsTrue(word.TextBoxesLst[4] == letter && word.TextBoxesLst.Count == guessingword.Length, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void CheckIfDoesntHaveLetter()
        {
            ChosenWord word = new();
            word.AmntOfLetters = 5;
            string guessingword = word.ChooseNewWord();
            string letter = "q";
            bool b = guessingword.Contains("q");
            Assume.That(b == false, $"the word did contain a q, can't run test. the word was {guessingword}");
            word.CheckWordIfLetter(letter);
            string msg = $"the letter {letter} was chosen and {guessingword} does not contain a {letter}";
            Assert.IsFalse(guessingword.Contains(letter), msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void CheckForWin()
        {
            ChosenWord word = new();
            word.AmntOfLetters = 3;
            string guessingword = word.ChooseNewWord();
            string letter1 = guessingword[0].ToString();
            word.CheckWordIfLetter(letter1);
            string letter2 = guessingword[1].ToString();
            word.CheckWordIfLetter(letter2);
            string letter3 = guessingword[2].ToString();
            word.CheckWordIfLetter(letter3);
            word.CheckForWin();
            string msg = $"the word was {guessingword} and {letter1}, {letter2} and {letter3} were guessed so the game status is {word.GameMessage}";
            Assert.IsTrue(word.GameMessage == "You Won!", msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void CheckForLose()
        {
            ChosenWord word = new();
            word.NumOfTries = 12;
            word.picturenum = 14;
            word.AmntOfLetters = 3;
            string guessingword = word.ChooseNewWord();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int timestried = 0;
            foreach (char letter in alphabet)
            {
                if (word.GameMessage == "")
                {
                    word.CheckWordIfLetter(letter.ToString());
                    if (guessingword.Contains(letter.ToString()) == false) { timestried++; }
                }
            }
            string basicmsg = $"num of tries = {timestried}, word = {guessingword}, Message = {word.GameMessage}";
            Assume.That(word.GameMessage.StartsWith("You Lost"), "Didnt lose. try running test again." + basicmsg);
            Assert.IsTrue(word.GameMessage.StartsWith("You Lost"), basicmsg);
            TestContext.WriteLine("Tried " + timestried + " and lost." + basicmsg);
        }
    }
}
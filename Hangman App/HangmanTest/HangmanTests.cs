using gnuciDictionary;
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
            Game game = new();
            int amntletters = 5;
            string guessingword = game.StartGame(amntletters);
            string letter = guessingword[4].ToString();
            game.CheckWordIfLetter(letter);
            string msg = $"the word has {guessingword.Length} = {game.TextBoxesLst.Count} letters. and the letter {letter} was chosen and {guessingword} should contain a {letter}";
            Assert.IsTrue(game.TextBoxesLst[4] == letter && game.TextBoxesLst.Count == guessingword.Length, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void CheckIfDoesntHaveLetter()
        {
            Game game = new();
            int amntletters = 5;
            string guessingword = game.StartGame(amntletters);
            string letter = "q";
            bool b = guessingword.Contains("q");
            Assume.That(b == false, $"the word did contain a q, can't run test. the word was {guessingword}");
            game.CheckWordIfLetter(letter);
            string msg = $"the letter {letter} was chosen and {guessingword} does not contain a {letter}";
            Assert.IsFalse(guessingword.Contains(letter), msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void CheckForWin()
        {
            Game game = new();
            int amntletters = 3;
            string guessingword = game.StartGame(amntletters);
            string letter1 = guessingword[0].ToString();
            game.CheckWordIfLetter(letter1);
            string letter2 = guessingword[1].ToString();
            game.CheckWordIfLetter(letter2);
            string letter3 = guessingword[2].ToString();
            game.CheckWordIfLetter(letter3);
            game.CheckForWin();
            string msg = $"the word was {guessingword} and {letter1}, {letter2} and {letter3} were guessed so the game status is {game.GameMessage}";
            Assert.IsTrue(game.GameMessage == "You Won!", msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void CheckForLose()
        {
            int amntletters = 3;
            Game game = new();
            string guessingword = game.StartGame(amntletters);
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int timestried = 0;
            foreach (char letter in alphabet)
            {
                if (game.GameMessage == "")
                {
                    game.CheckWordIfLetter(letter.ToString());
                    if (guessingword.Contains(letter.ToString()) == false) { timestried++; }
                    game.CheckForWin();
                    game.CheckForLose();
                }
            }
            string basicmsg = $"num of tries = {timestried}, word = {guessingword}, Message = {game.GameMessage}";
            Assume.That(game.GameMessage.StartsWith("You Lost"), "Didnt lose. try running test again." + basicmsg);
            Assert.IsTrue(game.GameMessage.StartsWith("You Lost"), basicmsg);
            TestContext.WriteLine("Tried " + timestried + " and lost." + basicmsg);
        }
    }
}
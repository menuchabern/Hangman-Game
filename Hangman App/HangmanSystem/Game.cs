using static HangmanSystem.ChosenWord;

namespace HangmanSystem
{
    public class Game
    {
        ChosenWord chosenword = new();
        public void StartGame(int amntofletters)
        {
            chosenword.ChooseNewWord();
            chosenword.AmntOfLetters = amntofletters;
            chosenword.NumOfTries = 12;
            chosenword.picturenum = 14;
        }

        public void EndGame()
        {
            chosenword.TextBoxesLst.Clear();
            chosenword.AmntOfLetters = 0;
            chosenword.NumOfTries = 0;
        }

        public void CheckForWin()
        {
            if (chosenword.TextBoxesLst.All(t => t != ""))
            {
                chosenword.GameStatus = GameStatusEnum.Won;
                Game game = new();
                game.EndGame();
            }
        }

        internal void CheckForLose()
        {
            if (chosenword.picturenum == 1 &&
                chosenword.NumOfTries == 0)
            {
                chosenword.GameStatus = GameStatusEnum.Lost;
                EndGame();
            }
        }
    }
}
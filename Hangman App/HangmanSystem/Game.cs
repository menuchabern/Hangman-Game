using System.ComponentModel;
using static HangmanSystem.ChosenWord;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace HangmanSystem
{
    public class Game : INotifyPropertyChanged
    {
        ChosenWord chosenword = new();

        public event PropertyChangedEventHandler? PropertyChanged;
        public enum GameStatusEnum { Playing, Won, Lost };
        private int _numoftries;
        private GameStatusEnum _gamestatus;
        public BindingList<String> ActiveTxtBoxesLst { get; set; } = new();
        public string PictureLocationWinForms { get { return AppDomain.CurrentDomain.BaseDirectory + @"pics\" + picturenum + ".png"; } }
        public string GameMessage
        {
            get
            {
                chosenword.InvokePropertyChanged();
                switch (GameStatus)
                {
                    case GameStatusEnum.Won:
                        return "You Won!";
                    case GameStatusEnum.Lost:
                        return "You Lost!" + Environment.NewLine + "the word was " + chosenword.GuessingWord;
                    default:
                        return "";
                }
            }
        }
        public int NumOfTries
        {
            get => _numoftries;
            set
            {
                _numoftries = value;
                chosenword.InvokePropertyChanged();
                chosenword.InvokePropertyChanged("picturenum");
            }
        }

        public string NumOfTriesDescription { get { chosenword.InvokePropertyChanged(); return NumOfTries.ToString() + " Tries Left"; } }
        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            set
            {
                _gamestatus = value;
                chosenword.InvokePropertyChanged();
                chosenword.InvokePropertyChanged("GameMessage");
            }
        }
        public int picturenum
        {
            get
            {
                chosenword.InvokePropertyChanged();
                chosenword.InvokePropertyChanged("PictureLocationWinForms");
                return NumOfTries + 1;
            }

        }

        public string StartGame(int amntofletters)
        {
            chosenword.AmntOfLetters = amntofletters;
            ActiveTxtBoxesLst = chosenword.ActiveTextBoxes;
            NumOfTries = 12;
            return chosenword.ChooseNewWord();
        }

        public void CheckWordIfLetter(string letter)
        {
            if (chosenword.GuessingWord.Contains(letter.ToLower()))
            {
                for (int i = 0; i < chosenword.GuessingWord.Length; i++)
                {
                    if (chosenword.GuessingWord[i].ToString().ToLower() == letter.ToString())
                    {
                        chosenword.ActiveTextBoxes[i] = letter;
                    }
                }
                CheckForWin();
            }
            else
            {
                NumOfTries--;
            }
            CheckForLose();
        }


        public void EndGame()
        {
            chosenword.ActiveTextBoxes.Clear();
            chosenword.AmntOfLetters = 0;
            NumOfTries = 0;
        }

        public void CheckForWin()
        {
            if (chosenword.ActiveTextBoxes.All(t => t != ""))
            {
                GameStatus = GameStatusEnum.Won;
                Game game = new();
                game.EndGame();
            }
        }

        public void CheckForLose()
        {
            if (picturenum == 1 && NumOfTries == 0)
            {
                GameStatus = GameStatusEnum.Lost;
                EndGame();
            }
        }
    }
}
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class Game : INotifyPropertyChanged
    {
        ChosenWord chosenword = new();

        public event PropertyChangedEventHandler? PropertyChanged;
        private enum GameStatusEnum { Playing, Won, Lost };
        private int _numoftries = 12;
        private GameStatusEnum _gamestatus;
        private List<Letters> _letterboxes = new();
        public List<Letters> LetterBoxes
        {
            get => _letterboxes;
            set
            {
                _letterboxes = value;
                InvokePropertyChanged();
            }
        }
        public string PictureLocationWinForms { get => AppDomain.CurrentDomain.BaseDirectory + @"pics\" + (NumOfTries + 1) + ".png"; }
        public string GameMessage
        {
            get
            {
                switch (GameStatus)
                {
                    case GameStatusEnum.Won:
                        return "You Won!";
                    case GameStatusEnum.Lost:
                        return "You Lost!" + Environment.NewLine + "the word was " + chosenword.GuessingWord.ToUpper();
                    default:
                        return "";
                }
            }
        }

        public int PicNumMaui { get => NumOfTries + 1; }

        private int NumOfTries
        {
            get => _numoftries;
            set
            {
                _numoftries = value;
                InvokePropertyChanged();
                InvokePropertyChanged("NumOfTriesDescription");
                InvokePropertyChanged("PictureLocationWinForms");
                InvokePropertyChanged("PicNumMaui");

            }
        }

        public string NumOfTriesDescription
        {
            get => NumOfTries.ToString() + " Tries Left";
        }

        private GameStatusEnum GameStatus
        {
            get => _gamestatus;
            set
            {
                _gamestatus = value;
                InvokePropertyChanged();
                InvokePropertyChanged("GameMessage");
            }
        }

        public string StartGame(int amntofletters)
        {
            LetterBoxes.Clear();
            chosenword.AmntOfLetters = amntofletters;
            for (int i = 0; i < amntofletters; i++)
            {
                Letters letter = new();
                LetterBoxes.Add(letter);
                letter.BackColorWinForms = letter.ActiveColor;
                InvokePropertyChanged("LetterBoxes");
            }
            NumOfTries = 12;
            GameStatus = GameStatusEnum.Playing;
            return chosenword.ChooseNewWord();
        }

        public void CheckWordIfLetter(string letter)
        {
            if (chosenword.GuessingWord.Contains(letter.ToLower()))
            {
                for (int i = 0; i < chosenword.GuessingWord.Length; i++)
                {
                    if (chosenword.GuessingWord[i].ToString().ToLower() == letter.ToLower())
                    {
                        LetterBoxes[i].Text = letter;
                    }
                }
                CheckForWin();
            }
            else
            {
                NumOfTries--;
                CheckForLose();
            }
        }

        //private void EndGame()
        //{
        //    chosenword.AmntOfLetters = 0;
        //}

        private void CheckForWin()
        {
            if (LetterBoxes.All(t => t.Text != ""))
            {
                GameStatus = GameStatusEnum.Won;
                //EndGame();
            }
        }

        private void CheckForLose()
        {
            if (NumOfTries == 0)
            {
                GameStatus = GameStatusEnum.Lost;
                //EndGame();
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
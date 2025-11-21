using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace HangmanSystem
{
    public class Game : INotifyPropertyChanged
    {
        ChosenWord chosenword = new();

        public event PropertyChangedEventHandler? PropertyChanged;
        public enum GameStatusEnum { Playing, Won, Lost };
        private int _numoftries = 12;
        private GameStatusEnum _gamestatus;
        private List<Letters> _letterboxes = new();
        public List<Letters> letterboxes
        {
            get => _letterboxes;
            set
            {
                for (int i = 0; i < chosenword.AmntOfLetters; i++)
                {
                    Letters letter = new();
                    letterboxes.Add(letter);
                }
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

        public int NumOfTries
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

        public GameStatusEnum GameStatus
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
            chosenword.AmntOfLetters = amntofletters;
            for (int i = 0; i < amntofletters; i++)
            {
                Letters letter = new();
                letterboxes.Add(letter);
                letter.BackColorWinForms = letter.ActiveColor;
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
                        letterboxes[i].Text = letter;
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

        public void EndGame()
        {
            letterboxes.Clear();
            chosenword.AmntOfLetters = 0;
        }

        public void CheckForWin()
        {
            if (letterboxes.All(t => t.Text != ""))
            {
                GameStatus = GameStatusEnum.Won;
                EndGame();
            }
        }

        public void CheckForLose()
        {
            if (NumOfTries == 0)
            {
                GameStatus = GameStatusEnum.Lost;
                EndGame();
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
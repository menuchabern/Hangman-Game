using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class Game : INotifyPropertyChanged
    {
        ChosenWord chosenword = new();

        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? ScoreChanged;

        private enum GameStatusEnum { Playing, Won, Lost, None };
        private int _numoftries = 12;
        private GameStatusEnum _gamestatus;
        private List<Letters> _letterboxes = new();
        private static int numofgames;
        private int _gamenumber;
        private List<bool> _abcbuttonsenabled = Enumerable.Repeat(false, 26).ToList();
        private string _amnofletters = "";
        public Game()
        {
            numofgames++;
            GameNumber = numofgames;
            GameStatus = GameStatusEnum.None;
        }
        private int GameNumber
        {
            get => _gamenumber; set
            {
                _gamenumber = value;
                InvokePropertyChanged();
            }
        }
        public List<bool> ABCButtonsEnabled
        {
            get => _abcbuttonsenabled;
            set
            {
                _abcbuttonsenabled = value;
            }
        }

        public void SetABCButtonEnabled(int index, bool value)
        {
            _abcbuttonsenabled[index] = value;
            InvokePropertyChanged(nameof(ABCButtonsEnabled));
        }

        public List<Letters> LetterBoxes
        {
            get => _letterboxes;
            set
            {
                _letterboxes = value;
                InvokePropertyChanged();
            }
        }

        public string AmntOfLetters
        {
            get => _amnofletters;
            set { _amnofletters = value; InvokePropertyChanged(); }
        }

        private static int scorewin = 0;
        private static int scorelose = 0;
        public static string ScoreDescription { get => scorewin.ToString() + " Games Won, " + scorelose + " Games Lost"; }
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
        public string GameStartDescription
        {
            get
            {
                string s = "Start";
                if (GameStatus == GameStatusEnum.Playing) { s = "Restart"; }
                return s + " Game " + GameNumber;
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
                InvokePropertyChanged("GameStartDescription");
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
            for (int i = 0; i < ABCButtonsEnabled.Count; i++)
            {
                SetABCButtonEnabled(i, true);
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

        private void CheckForWin()
        {
            if (LetterBoxes.All(t => t.Text != ""))
            {
                GameStatus = GameStatusEnum.Won;
                scorewin++;
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }

        private void CheckForLose()
        {
            if (NumOfTries == 0)
            {
                GameStatus = GameStatusEnum.Lost;
                scorelose++;
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
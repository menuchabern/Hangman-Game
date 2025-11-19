using Common.Extensions;
using gnuciDictionary;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace HangmanSystem
{
    public class ChosenWord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private List<Word> GnuicWordsLst = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        private List<String> WordLst = new();
        public List<String> TextBoxesLst { get; private set; } = new();
        public enum GameStatusEnum { Playing, Won, Lost };
        private int _numoftries;
        private GameStatusEnum _gamestatus;
        private int _picturenum;
        public ChosenWord()
        {
            WordLst = GnuicWordsLst.Select(w => w.Value.ToString()).ToList();
        }
        public int NumOfTries
        {
            get => _numoftries;
            set
            {
                _numoftries = value;
                InvokePropertyChanged();
            }
        }
        public int AmntOfLetters { internal get; set; }
        internal string GuessingWord;
        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            set
            {
                _gamestatus = value;
                InvokePropertyChanged();
                InvokePropertyChanged("GameStatusDescription");
            }
        }
        public string GameMessage
        {
            get
            {
                InvokePropertyChanged();
                switch (GameStatus)
                {
                    case GameStatusEnum.Won:
                        return "You Won!";
                    case GameStatusEnum.Lost:
                        return "You Lost!" + Environment.NewLine + "the word was " + GuessingWord;
                    default:
                        return "";
                }
            }
        }
        public int picturenum
        {
            get => _picturenum;
            set
            {
                _picturenum = value;
                InvokePropertyChanged();
            }
        }
        public string ChooseNewWord()
        {
            GuessingWord = WordLst.Where(w => w.Length == AmntOfLetters).Random().ToLower();

            for (int i = 0; i < AmntOfLetters; i++)
            {
                TextBoxesLst.Add("");
            }

            return GuessingWord;
        }

        public void CheckWordIfLetter(string letter)
        {
            if (GuessingWord.Contains(letter.ToLower()))
            {
                for (int i = 0; i < GuessingWord.Length; i++)
                {
                    if (GuessingWord[i].ToString().ToLower() == letter.ToString())
                    {
                        TextBoxesLst[i] = letter;
                    }
                }
                CheckForWin();
            }
            else
            {
                NumOfTries--;
                picturenum--;
            }
            CheckForLose();
        }

        public void CheckForWin()
        {
            if (TextBoxesLst.All(t => t != ""))
            {
                GameStatus = GameStatusEnum.Won;
                Game game = new();
                game.EndGame();
            }
        }

        private void CheckForLose()
        {
            if (//picturenum == 1 && 
                NumOfTries == 0)
            {
                GameStatus = GameStatusEnum.Lost;
                //ClearScreen();
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
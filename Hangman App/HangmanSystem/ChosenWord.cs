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
        internal BindingList<String> ActiveTextBoxes { get; private set; } = new();


        public ChosenWord()
        {
            WordLst = GnuicWordsLst.Select(w => w.Value.ToString()).ToList();
        }
        
        public int AmntOfLetters { internal get; set; }
        internal string GuessingWord;
        
        public string ChooseNewWord()
        {
            GuessingWord = WordLst.Where(w => w.Length == AmntOfLetters).Random().ToLower();

            for (int i = 0; i < AmntOfLetters; i++)
            {
                ActiveTextBoxes.Add("");
            }

            InvokePropertyChanged("ActiveTextBoxes");
            return GuessingWord;
        }

        internal void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
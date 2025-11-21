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


        public ChosenWord()
        {
            WordLst = GnuicWordsLst.Select(w => w.Value.ToString()).ToList();
        }
        
        public int AmntOfLetters { internal get; set; }
        internal string GuessingWord;
        
        public string ChooseNewWord()
        {
            GuessingWord = WordLst.Where(w => w.Length == AmntOfLetters).Random().ToLower();
            InvokePropertyChanged("ActiveTextBoxes");
            return GuessingWord;
        }

        internal void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
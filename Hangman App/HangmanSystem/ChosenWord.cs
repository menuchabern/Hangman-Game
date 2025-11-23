using Common.Extensions;
using gnuciDictionary;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace HangmanSystem
{
    internal class ChosenWord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private List<Word> GnuicWordsLst = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        private List<String> WordLst = new();


        internal ChosenWord()
        {
            WordLst = GnuicWordsLst.Select(w => w.Value.ToString()).ToList();
        }
        
        internal int AmntOfLetters { get; set; }
        internal string GuessingWord;
        
        internal string ChooseNewWord()
        {
            GuessingWord = WordLst.Where(w => w.Length == AmntOfLetters).Random().ToLower();
            InvokePropertyChanged("ActiveTextBoxes");
            return GuessingWord;
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
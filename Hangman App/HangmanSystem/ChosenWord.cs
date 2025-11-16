using Common.Extensions;
using gnuciDictionary;
namespace HangmanSystem
{
    public class ChosenWord
    {
        Game game;
        private List<Word> GnuicWordsLst = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        private List<String> WordLst = new();
        public ChosenWord()
        {
            WordLst = GnuicWordsLst.Select(w => w.Value.ToString()).ToList();
        }
        public int AmntOfLetters { get; set; }
        internal string GuessingWord;

        public string ChooseNewWord()
        {
            GuessingWord = WordLst.Where(w => w.Length == AmntOfLetters).Random().ToLower();
            
            return GuessingWord;
        }

        private void CheckWordIfLetter(string letter)
        {
            if (GuessingWord.Contains(letter.ToLower()))
            {
                for (int i = 0; i < GuessingWord.Length; i++)
                {
                    if (GuessingWord[i].ToString().ToLower() == letter)
                    {
                        GuessingWord[i].Text = letter;
                    }
                }
                //CheckForWin();
            }
            else
            {
                numoftries--;
                lblTriesLeft.Text = numoftries.ToString() + " Tries Left";
                GetNextPicture();
            }
        }
    }
}
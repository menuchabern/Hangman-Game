using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class Letters : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _text = "";
        public string Text { get => _text; set { _text = value; InvokePropertyChanged(); } } 
        internal void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}

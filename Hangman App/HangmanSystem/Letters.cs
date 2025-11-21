using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HangmanSystem
{
    public class Letters : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private BorderStyle borderStyle;
        public BorderStyle BorderStyleProperty
        {
            get => borderStyle;
            set
            {
                if (borderStyle != value)
                {
                    borderStyle = value;
                    OnPropertyChanged(nameof(BorderStyleProperty));
                }
            }
        }

        internal void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}

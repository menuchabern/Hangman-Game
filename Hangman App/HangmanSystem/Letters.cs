using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HangmanSystem
{
    public class Letters : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _text = "";
        private System.Drawing.Color _backcolorwinforms;
        public string Text { get => _text; set { _text = value; InvokePropertyChanged(); } }
        public Microsoft.Maui.Graphics.Color MauiBackColor { get => ConvertToMauiColor(ActiveColor); }
        public System.Drawing.Color BackColorWinForms
        {
            get => _backcolorwinforms; set
            {
                _backcolorwinforms = value;
                InvokePropertyChanged();
                InvokePropertyChanged("MauiBackColor");
            }
        }
        public System.Drawing.Color ActiveColor = System.Drawing.Color.LightYellow;

        internal void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }
    }
}

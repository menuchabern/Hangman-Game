using HangmanSystem;

namespace HangmanMAUI;

public partial class HangmanGame : ContentPage
{
    List<Button> lstletterbtn;
    List<Entry> lsttxt;
    Game game = new();

    public HangmanGame()
	{
		InitializeComponent();
        lstletterbtn = new() { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };
        lstletterbtn.ForEach(b => b.IsEnabled = false);

        lsttxt = new() { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9 };
        BindingContext = game;
    }

    private bool CheckIfNumOfLettersValid()
    {
        bool b = true;
        bool correctnumber = int.TryParse(txtHowManyLetters.Text, out int amntofletters);
        if (amntofletters > 9)
        {
            DisplayAlert("Hangman", "Please choose a number less than or equal to 9", "OK");
            txtHowManyLetters.Text = "";
            return false;
        }
        else if (correctnumber == false || txtHowManyLetters.Text == "0")
        {
            txtHowManyLetters.Text = "";
            DisplayAlert("Hangman", "Please choose a valid number", "OK");
            return false;
        }
        return b;
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        int amntofletters;
        int.TryParse(txtHowManyLetters.Text, out amntofletters);
        if (CheckIfNumOfLettersValid() == false) return;
        game.StartGame(amntofletters);
        lstletterbtn.ForEach(b => b.IsEnabled = true);

        foreach (Entry item in lsttxt.Take(amntofletters))
        {
            int indexof = lsttxt.IndexOf(item);
            Letters letter = game.LetterBoxes[indexof];
        }
    }

    private void btn_Clicked(object sender, EventArgs e)
    {
        Button btnletter = (Button)sender;
        btnletter.IsEnabled = false;
        game.CheckWordIfLetter(btnletter.Text);

        if (game.GameMessage != "")
        {
            lstletterbtn.ForEach(b => b.IsEnabled = false);
        }
    }
}
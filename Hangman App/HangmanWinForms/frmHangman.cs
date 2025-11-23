using HangmanSystem;
namespace Hangman_App
{
    public partial class frmHangman : Form
    {
        List<Button> lstletterbtn;
        List<TextBox> lsttxt;
        Game game = new();

        public frmHangman()
        {
            InitializeComponent();
            lstletterbtn = new() { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };
            lsttxt = new() { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9 };
            
            lblMessage.DataBindings.Add("Text", game, "GameMessage");
            lblTriesLeft.DataBindings.Add("Text", game, "NumOfTriesDescription");
            picGallows.DataBindings.Add("ImageLocation", game, "PictureLocationWinForms");

            lstletterbtn.ForEach(b => b.Click += LetterBtn_Click);
            btnStart.Click += BtnStart_Click;
        }

        private bool CheckIfNumOfLettersValid()
        {
            bool b = true;
            bool correctnumber = int.TryParse(txtHowManyLetters.Text, out int amntofletters);
            if (amntofletters > 9)
            {
                MessageBox.Show("Please choose a number less than or equal to 9");
                txtHowManyLetters.Text = "";
                b = false;
            }
            else if (correctnumber == false || txtHowManyLetters.Text == "0")
            {
                txtHowManyLetters.Text = "";
                MessageBox.Show("Please choose a valid number");
                b = false;
            }
            return b;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            int amntofletters;
            int.TryParse(txtHowManyLetters.Text, out amntofletters);
            if (CheckIfNumOfLettersValid() == false) return;
            game.StartGame(amntofletters);
            lstletterbtn.ForEach(b => b.Enabled = true);

            foreach (TextBox item in lsttxt.Take(amntofletters))
            {
                Letters letter = game.LetterBoxes[lsttxt.IndexOf(item)];
                item.DataBindings.Clear();
                item.DataBindings.Add("Text", letter, "Text");
                item.DataBindings.Add("BackColor", letter, "BackColorWinForms");
            }
            btnStart.Enabled = false;
        }

        private void LetterBtn_Click(object? sender, EventArgs e)
        {
            Button btnletter = (Button)sender;
            btnletter.Enabled = false;
            game.CheckWordIfLetter(btnletter.Text);

            if (game.GameMessage != "")
            {
                lstletterbtn.ForEach(b => b.Enabled = false);
                btnStart.Enabled = true;
            }
        }
    }
}

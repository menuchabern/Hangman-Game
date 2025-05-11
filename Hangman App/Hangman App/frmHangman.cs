using Common.Extensions;
using gnuciDictionary;
namespace Hangman_App
{
    public partial class frmHangman : Form
    {
        List<Word> lstgnuciwords = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
        List<String> lstwords;
        List<Button> lstletterbtn;
        List<TextBox> lsttxt;
        List<TextBox> lstchosenword;
        string chosenword;
        int picturenumber = 14;
        int numoftries = 12;

        public frmHangman()
        {
            InitializeComponent();
            lstwords = lstgnuciwords.Select(w => w.Value.ToString()).ToList();
            lstletterbtn = new() { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };
            lsttxt = new() { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9 };

            lstletterbtn.ForEach(b => b.Click += LetterBtn_Click);

            btnStart.Click += BtnStart_Click;
        }

        //private void WinMode() { }
        private void ClearScreen()
        {
            lsttxt.ForEach(t =>
            {
                t.BorderStyle = BorderStyle.None;
                t.Text = "";
            });
            lstletterbtn.ForEach(b => b.Enabled = true);
            numoftries = 12;
            lblTriesLeft.Text = numoftries.ToString() + " Tries Left";
            picturenumber = 14;
            GetNextPicture();
        }

        private void GetWord()
        {
            ClearScreen();
            int.TryParse(txtHowManyLetters.Text, out int amntofletters);
            if (amntofletters > 9)
            {
                txtHowManyLetters.Text = "";
                MessageBox.Show("Please choose a number less than or equal to 9");
                return;
            }
            if (amntofletters == 0)
            {
                amntofletters = 9;
            }
            chosenword = lstwords.Where(w => w.Length == amntofletters).Random().ToLower();
            lstchosenword = lsttxt.Take(amntofletters).ToList();
            lstchosenword.ForEach(txt => txt.BorderStyle = BorderStyle.FixedSingle);
        }

        private void CheckIfLetter(Button btn)
        {
            if (chosenword.Contains(btn.Text.ToLower()))
            {
                string letter = btn.Text.ToString().ToLower();
                for (int i = 0; i < chosenword.Length; i++)
                {
                    if (chosenword[i].ToString().ToLower() == letter)
                    {
                        lstchosenword[i].Text = letter;
                    }
                }
                CheckForWin();
            }
            else
            {
                numoftries--;
                lblTriesLeft.Text = numoftries.ToString() + " Tries Left";
                GetNextPicture();
            }
        }

        private void CheckForLoose()
        {
            if (picturenumber == 1)
            {
                MessageBox.Show("YOU LOST" + Environment.NewLine + "The word was " + chosenword);
                ClearScreen();
            }
        }

        private void CheckForWin()
        {
            if (lstchosenword.All(t => t.Text != ""))
            {
                MessageBox.Show("YOU WON!!!!");
                ClearScreen();
            }
        }

        private void GetNextPicture()
        {
            picturenumber--;
            string piclocation = Application.StartupPath + @"pics\" + picturenumber.ToString() + ".png";
            picGallows.ImageLocation = piclocation;
            CheckForLoose();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            GetWord();

        }

        private void LetterBtn_Click(object? sender, EventArgs e)
        {
            Button btnletter = (Button)sender;
            btnletter.Enabled = false;
            CheckIfLetter(btnletter);

        }
    }
}

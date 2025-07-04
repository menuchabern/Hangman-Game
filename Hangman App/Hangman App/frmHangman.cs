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
        int revealsUsed = 0;

        public frmHangman()
        {
            InitializeComponent();
            lstwords = lstgnuciwords.Select(w => w.Value.ToString()).ToList();
            lstletterbtn = new() { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };
            lsttxt = new() { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9 };

            lstletterbtn.ForEach(b => b.Click += LetterBtn_Click);

            btnStart.Click += BtnStart_Click;
            btnReveal.Click += BtnReveal_Click;
            btnReveal.Enabled = false;
        }

        private void ClearScreen()
        {
            lsttxt.ForEach(t =>
            {
                t.BorderStyle = BorderStyle.None;
                t.Text = "";
            });
            lstletterbtn.ForEach(b => b.Enabled = true);
            picturenumber = 14;
            lstletterbtn.ForEach(b => b.Enabled = false);
            lblTriesLeft.Text = "";
            btnReveal.Enabled = false;
            revealsUsed = 0;
            GetNextPicture();
        }

        private void GetWord()
        {
            bool correctnumber = int.TryParse(txtHowManyLetters.Text, out int amntofletters);
            if (txtHowManyLetters.Text == "")
            {
                amntofletters = 9;
            }
            else if (amntofletters > 9)
            {
                txtHowManyLetters.Text = "";
                MessageBox.Show("Please choose a number less than or equal to 9");
                ClearScreen();
                return;
            }
            else if (correctnumber == false || txtHowManyLetters.Text == "0")
            {
                txtHowManyLetters.Text = "";
                MessageBox.Show("Please choose a valid number");
                ClearScreen();
                return;
            }
            lstletterbtn.ForEach(b => b.Enabled = true);
            btnReveal.Enabled = true;
            revealsUsed = 0;
            numoftries = 12;
            lblTriesLeft.Text = numoftries.ToString() + " Tries Left";
            chosenword = lstwords.Where(w => w.Length == amntofletters).Random().ToLower();
            lstchosenword = lsttxt.Take(amntofletters).ToList();
            lstchosenword.ForEach(txt => txt.BorderStyle = BorderStyle.FixedSingle);
        }

        private void CheckWordIfLetter(Button btn)
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
            CheckWordIfLetter(btnletter);

        }

        private void BtnReveal_Click(object? sender, EventArgs e)
        {
            if (revealsUsed >= 3)
            {
                btnReveal.Enabled = false;
                return;
            }
            var hidden = lstchosenword
                .Select((t, i) => new { TextBox = t, Index = i })
                .Where(x => x.TextBox.Text == "")
                .ToList();
            if (hidden.Count == 0)
            {
                return;
            }
            Random rnd = new();
            var revealIndex = hidden[rnd.Next(hidden.Count)].Index;
            char letter = chosenword[revealIndex];
            for (int i = 0; i < chosenword.Length; i++)
            {
                if (chosenword[i] == letter && lstchosenword[i].Text == "")
                {
                    lstchosenword[i].Text = letter.ToString();
                }
            }
            var btn = lstletterbtn.FirstOrDefault(b => b.Text.Equals(letter.ToString(), StringComparison.OrdinalIgnoreCase));
            if (btn != null)
            {
                btn.Enabled = false;
            }
            numoftries--;
            lblTriesLeft.Text = numoftries.ToString() + " Tries Left";
            GetNextPicture();
            CheckForWin();
            revealsUsed++;
            if (revealsUsed >= 3)
            {
                btnReveal.Enabled = false;
            }
        }
    }
}

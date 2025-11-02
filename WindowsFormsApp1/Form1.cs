using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Typing_Game : Form
    {
        private string[] words =
        {
            "fire", "water", "microphone", "background", "keyboard", "monitor", "mouse"
        };
        private int corr_count = 0;
        private int incorr_count = 0;
        private Random random = new Random();

        public Typing_Game()
        {
            InitializeComponent();
            LoadWord();
        }
        private void LoadWord()
        {
            string word = words[random.Next(words.Length)];
            Input.Text = word;
            no_matter.Clear();
            no_matter.Focus();

        }
        private void no_matter_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string usinp = no_matter.Text.ToLower();
                string currword = Input.Text.ToLower();

                if (usinp == currword)
                {
                    corr_count++;
                    correct_ones.Text = $"Correct words: {corr_count}";

                }
                else
                {
                    incorr_count++;
                    Wrong_ones.Text = $"InCorrect words: {incorr_count}";
                }
                LoadWord();
                no_matter.Focus();
            }
        }
    }
}

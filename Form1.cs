using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_word_game
{
    public partial class Form1 : Form
    {
        public int guess_count = 0;
        public Form1()
        {
            InitializeComponent();
            this.guess1_0.SelectAll();
            this.guess1_0.SelectionAlignment = HorizontalAlignment.Center;
            this.guess1_1.SelectAll();
            this.guess1_1.SelectionAlignment = HorizontalAlignment.Center;
            this.guess1_2.SelectAll();
            this.guess1_2.SelectionAlignment = HorizontalAlignment.Center;
            this.guess1_3.SelectAll();
            this.guess1_3.SelectionAlignment = HorizontalAlignment.Center;
            this.guess1_4.SelectAll();
            this.guess1_4.SelectionAlignment = HorizontalAlignment.Center;
            this.guess2_0.SelectAll();
            this.guess2_0.SelectionAlignment = HorizontalAlignment.Center;
            this.guess2_0.ReadOnly = true;
            this.guess2_0.SelectionLength = 0;
            this.guess2_1.SelectAll();
            this.guess2_1.SelectionAlignment = HorizontalAlignment.Center;
            this.guess2_1.ReadOnly = true;
            this.guess2_1.SelectionLength = 0;
            this.guess2_2.SelectAll();
            this.guess2_2.SelectionAlignment = HorizontalAlignment.Center;
            this.guess2_2.ReadOnly = true;
            this.guess2_2.SelectionLength = 0;
            this.guess2_3.SelectAll();
            this.guess2_3.SelectionAlignment = HorizontalAlignment.Center;
            this.guess2_3.ReadOnly = true;
            this.guess2_3.SelectionLength = 0;
            this.guess2_4.SelectAll();
            this.guess2_4.SelectionAlignment = HorizontalAlignment.Center;
            this.guess2_4.ReadOnly = true;
            this.guess2_4.SelectionLength = 0;
            this.guess3_0.SelectAll();
            this.guess3_0.SelectionAlignment = HorizontalAlignment.Center;
            this.guess3_0.ReadOnly = true;
            this.guess3_0.SelectionLength = 0;
            this.guess3_1.SelectAll();
            this.guess3_1.SelectionAlignment = HorizontalAlignment.Center;
            this.guess3_1.ReadOnly = true;
            this.guess3_1.SelectionLength = 0;
            this.guess3_2.SelectAll();
            this.guess3_2.SelectionAlignment = HorizontalAlignment.Center;
            this.guess3_2.ReadOnly = true;
            this.guess3_2.SelectionLength = 0;
            this.guess3_3.SelectAll();
            this.guess3_3.SelectionAlignment = HorizontalAlignment.Center;
            this.guess3_3.ReadOnly = true;
            this.guess3_3.SelectionLength = 0;
            this.guess3_4.SelectAll();
            this.guess3_4.SelectionAlignment = HorizontalAlignment.Center;
            this.guess3_4.ReadOnly = true;
            this.guess3_4.SelectionLength = 0;
            this.guess4_0.SelectAll();
            this.guess4_0.SelectionAlignment = HorizontalAlignment.Center;
            this.guess4_0.ReadOnly = true;
            this.guess4_0.SelectionLength = 0;
            this.guess4_1.SelectAll();
            this.guess4_1.SelectionAlignment = HorizontalAlignment.Center;
            this.guess4_1.ReadOnly = true;
            this.guess4_1.SelectionLength = 0;
            this.guess4_2.SelectAll();
            this.guess4_2.SelectionAlignment = HorizontalAlignment.Center;
            this.guess4_2.ReadOnly = true;
            this.guess4_2.SelectionLength = 0;
            this.guess4_3.SelectAll();
            this.guess4_3.SelectionAlignment = HorizontalAlignment.Center;
            this.guess4_3.ReadOnly = true;
            this.guess4_3.SelectionLength = 0;
            this.guess4_4.SelectAll();
            this.guess4_4.SelectionAlignment = HorizontalAlignment.Center;
            this.guess4_4.ReadOnly = true;
            this.guess4_4.SelectionLength = 0;
            this.guess5_0.SelectAll();
            this.guess5_0.SelectionAlignment = HorizontalAlignment.Center;
            this.guess5_0.ReadOnly = true;
            this.guess5_0.SelectionLength = 0;
            this.guess5_1.SelectAll();
            this.guess5_1.SelectionAlignment = HorizontalAlignment.Center;
            this.guess5_1.ReadOnly = true;
            this.guess5_1.SelectionLength = 0;
            this.guess5_2.SelectAll();
            this.guess5_2.SelectionAlignment = HorizontalAlignment.Center;
            this.guess5_2.ReadOnly = true;
            this.guess5_2.SelectionLength = 0;
            this.guess5_3.SelectAll();
            this.guess5_3.SelectionAlignment = HorizontalAlignment.Center;
            this.guess5_3.ReadOnly = true;
            this.guess5_3.SelectionLength = 0;
            this.guess5_4.SelectAll();
            this.guess5_4.SelectionAlignment = HorizontalAlignment.Center;
            this.guess5_4.ReadOnly = true;
            this.guess5_4.SelectionLength = 0;
            this.guess6_0.SelectAll();
            this.guess6_0.SelectionAlignment = HorizontalAlignment.Center;
            this.guess6_0.ReadOnly = true;
            this.guess6_0.SelectionLength = 0;
            this.guess6_1.SelectAll();
            this.guess6_1.SelectionAlignment = HorizontalAlignment.Center;
            this.guess6_1.ReadOnly = true;
            this.guess6_1.SelectionLength = 0;
            this.guess6_2.SelectAll();
            this.guess6_2.SelectionAlignment = HorizontalAlignment.Center;
            this.guess6_2.ReadOnly = true;
            this.guess6_2.SelectionLength = 0;
            this.guess6_3.SelectAll();
            this.guess6_3.SelectionAlignment = HorizontalAlignment.Center;
            this.guess6_3.ReadOnly = true;
            this.guess6_3.SelectionLength = 0;
            this.guess6_4.SelectAll();
            this.guess6_4.SelectionAlignment = HorizontalAlignment.Center;
            this.guess6_4.ReadOnly = true;
            this.guess6_4.SelectionLength = 0;
            guess1_letter_list = new RichTextBox[] { guess1_0, guess1_1, guess1_2, guess1_3, guess1_4 };
            guess2_letter_list = new RichTextBox[] { guess2_0, guess2_1, guess2_2, guess2_3, guess2_4 };
            guess3_letter_list = new RichTextBox[] { guess3_0, guess3_1, guess3_2, guess3_3, guess3_4 };
            guess4_letter_list = new RichTextBox[] { guess4_0, guess4_1, guess4_2, guess4_3, guess4_4 };
            guess5_letter_list = new RichTextBox[] { guess5_0, guess5_1, guess5_2, guess5_3, guess5_4 };
            guess6_letter_list = new RichTextBox[] { guess6_0, guess6_1, guess6_2, guess6_3, guess6_4 };
            alphabet = new Label[] { alphaA, alphaB, alphaC, alphaD,alphaE,alphaF,alphaG,alphaH,alphaI,alphaJ,alphaK, alphaL, alphaM, alphaN, alphaO, alphaP, alphaQ, alphaR, alphaS,alphaT, alphaU, alphaV, alphaW, alphaX, alphaY, alphaZ };
        }

        public int Check_Guess(int guess_count, RichTextBox[] guess_letters, RichTextBox[] guess_letters_next, string guess)
        {
            if (guess == secret_word)
            {
                guess_letters[0].BackColor = Color.ForestGreen;
                guess_letters[1].BackColor = Color.ForestGreen;
                guess_letters[2].BackColor = Color.ForestGreen;
                guess_letters[3].BackColor = Color.ForestGreen;
                guess_letters[4].BackColor = Color.ForestGreen;
                DialogResult result = MessageBox.Show("You won! Play again?", "♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
                guess_count++;
                return guess_count;
            }
            else
            {
                foreach (int i in Enumerable.Range(0, 5))
                {
                    if (guess[i] == secret_word[i])
                    {
                        guess_letters[i].BackColor = Color.ForestGreen;
                        foreach (Label letter in alphabet)
                        {
                            if (guess_letters[i].Text == letter.Text)
                            {
                                letter.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                    else if (secret_word.Contains(guess[i]))
                    {
                        guess_letters[i].BackColor = Color.Orange;
                        foreach (Label letter in alphabet)
                        {
                            if (guess_letters[i].Text == letter.Text)
                            {
                                letter.BackColor = Color.Orange;
                            }
                        }
                    }
                    else
                    {
                        guess_letters[i].BackColor = Color.Gray;
                        foreach (Label letter in alphabet)
                        {
                            if (guess_letters[i].Text == letter.Text)
                            {
                                letter.BackColor = Color.Gray;
                            }
                        }
                    }
                    guess_letters[i].ReadOnly = true;
                    guess_letters[i].SelectionLength = 0;
                    guess_letters_next[i].ReadOnly = false;
                    guess_letters_next[i].SelectionLength = 1;
                }
                guess_count++;
                if (guess_count == 6)
                {
                    DialogResult result = MessageBox.Show($"Out of guesses! The word was {secret_word}. Play again?", ":(:(:(:(:(:(:(:(:(:(", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (result == DialogResult.No)
                    {
                        Close();
                    }
                }
                return guess_count;
            }
        }
        private void Guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Blank input if it is a number
            if (!(Char.IsLetter(e.KeyChar)))
            {
                e.KeyChar = '\0';
            }

            //Convert all inputs to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar);

            //Autotab between input fields
            /*
            RichTextBox TB = (RichTextBox)sender;
            if (TB.Text.Length == 0)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (guess_count == 0)
            {
                string guess_string = guess1_0.Text + guess1_1.Text + guess1_2.Text + guess1_3.Text + guess1_4.Text;
                if (guess_string.Length < 5)
                {
                    MessageBox.Show("Fill out the boxes!");
                }
                else
                {
                    guess_count = Check_Guess(guess_count, guess1_letter_list, guess2_letter_list, guess_string);
                }
            }
            else if (guess_count == 1)
            {
                string guess_string = guess2_0.Text + guess2_1.Text + guess2_2.Text + guess2_3.Text + guess2_4.Text;
                if (guess_string.Length < 5)
                {
                    MessageBox.Show("Fill out the boxes!");
                }
                else
                {
                    guess_count = Check_Guess(guess_count, guess2_letter_list, guess3_letter_list, guess_string);
                }
            }
            else if (guess_count == 2)
            {
                string guess_string = guess3_0.Text + guess3_1.Text + guess3_2.Text + guess3_3.Text + guess3_4.Text;
                if (guess_string.Length < 5)
                {
                    MessageBox.Show("Fill out the boxes!");
                }
                else
                {
                    guess_count = Check_Guess(guess_count, guess3_letter_list, guess4_letter_list, guess_string);
                }
            }
            else if (guess_count == 3)
            {
                string guess_string = guess4_0.Text + guess4_1.Text + guess4_2.Text + guess4_3.Text + guess4_4.Text;
                if (guess_string.Length < 5)
                {
                    MessageBox.Show("Fill out the boxes!");
                }
                else
                {
                    guess_count = Check_Guess(guess_count, guess4_letter_list, guess5_letter_list, guess_string);
                }
            }
            else if (guess_count == 4)
            {
                string guess_string = guess5_0.Text + guess5_1.Text + guess5_2.Text + guess5_3.Text + guess5_4.Text;
                if (guess_string.Length < 5)
                {
                    MessageBox.Show("Fill out the boxes!");
                }
                else
                {
                    guess_count = Check_Guess(guess_count, guess5_letter_list, guess6_letter_list, guess_string);
                }
            }
            else if (guess_count == 5)
            {
                string guess_string = guess6_0.Text + guess6_1.Text + guess6_2.Text + guess6_3.Text + guess6_4.Text;
                if (guess_string.Length < 5)
                {
                    MessageBox.Show("Fill out the boxes!");
                }
                else
                {
                    guess_count = Check_Guess(guess_count, guess6_letter_list, guess6_letter_list, guess_string);
                }
            }
        }
    }
}
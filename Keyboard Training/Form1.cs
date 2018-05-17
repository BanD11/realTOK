using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.t.Interval = 1000;
            Global.t.Tick += new EventHandler(this.t_Tick);
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //Update Time
            if (Global.timerCount != Global.timeLimit)
            {
                if (Global.timeLimit == -1)
                {
                    Global.timerCount++;
                    DateTime lTime = Global.timerZeroTime.AddSeconds(Global.timerCount);
                    timerLabel.Text = string.Format("Time: {0}", lTime.ToString("HH:mm:ss"));
                }
                else
                {
                    Global.timerCount++;
                    DateTime lTime = Global.timerZeroTime.AddSeconds(Global.timeLimit - Global.timerCount);
                    timerLabel.Text = string.Format("Time: {0}", lTime.ToString("HH:mm:ss"));
                }
            }
            else
            {
                Win();
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Global.isWriting)
            {
                char pressedKey = e.KeyChar;
                if (Global.Text.Length > Global.allCharCounter)
                {
                    if (pressedKey == Global.Text[Global.allCharCounter])
                    {
                        if (pressedKey == (char)Keys.Return)
                        {
                            e.Handled = true;
                            Global.allCharCounter = Global.allCharCounter + 2;
                            Global.printableCharCounter++;
                        }
                        else
                        {
                            e.Handled = true;
                            richTextBox1.Select(0, (Global.printableCharCounter + 1));
                            richTextBox1.SelectionColor = Color.DarkSeaGreen;
                            Global.allCharCounter++;
                            Global.printableCharCounter++;
                            richTextBox1.Select(Global.printableCharCounter, 0);
                        }
                        if (Global.Text.Length == Global.allCharCounter)
                        {
                            Win();
                        }
                    }
                    else
                    {
                        Global.mistakes++;
                        mistakesText.Text = string.Format("Mistakes made:{0}", Global.mistakes);
                    }
                }
                else
                { }
            }
        }

        private void Win()
        {
            double CharPerMinute = ((Convert.ToDouble(Global.allCharCounter)) / ((Convert.ToDouble(Global.timerCount)) / 60.0));
            //double CharPerMinute = (Convert.ToDouble(Global.Text.Length)/5.75);
            //CharPerMinute = (5/7.4);
            resultsText.Text = string.Format("Your typing speed is {0} character per minute, error percentage is {1}%.", Math.Round(CharPerMinute, 0), Math.Round((((Convert.ToDouble(Global.mistakes)) / Global.allCharCounter) * 100), 2));
            resultsText.Show();

            Global.isWriting = false;
            Global.allCharCounter = 0;
            Global.printableCharCounter = 0;
            Global.t.Stop();
            Global.timerCount = 0;
            Global.isWriting = false;
            //richTextBox1.ReadOnly = false;
            goBackButton.Show();
            stopButton.Hide();
        }


        private void stringToTime()
        {
            bool isNumber = customTimeTextBox.Text.All(char.IsDigit) & customTimeTextBox.TextLength >= 1 & customTimeTextBox.TextLength <= 9;
            if (isNumber)
            {
                Global.timeLimit = Convert.ToInt32(customTimeTextBox.Text, 10);
                numberInputErrorText.Hide();
            }
            else
            {
                numberInputErrorText.Show();
            }
        }

        private void oneMinuteButton_Click(object sender, EventArgs e)
        {
            Global.timeLimit = 60;
            customTimeTextBox.Hide();
        }

        private void twoMinuteButton_Click(object sender, EventArgs e)
        {
            Global.timeLimit = 120;
            customTimeTextBox.Hide();
        }

        private void unlimitedTimeButton_Click(object sender, EventArgs e)
        {
            Global.timeLimit = -1;
            customTimeTextBox.Hide();
        }

        private void customTimeButton_Click(object sender, EventArgs e)
        {
            stringToTime();
            customTimeTextBox.Show();
        }

        private void customTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            stringToTime();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Global.isWriting == false)
            {
                if (Global.Text != "")
                {
                    selectTextText.Hide();
                    textSelectPanel.Hide();
                    timeSelectPanel.Hide();
                    timeSelectText.Hide();
                    okButton.Hide();
                    resultsText.Hide();
                    customTimeTextBox.Hide();

                    mistakesText.Show();
                    timerLabel.Show();
                    richTextBox1.Show();
                    stopButton.Show();

                    richTextBox1.Select(0, (richTextBox1.TextLength));
                    richTextBox1.SelectionColor = Color.Black;
                    richTextBox1.Select(0, 0);
                    richTextBox1.Text = Global.Text;
                    richTextBox1.ReadOnly = true;
                    Global.isWriting = true;
                    richTextBox1.Select();
                    Global.t.Start();
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Win();
            stopButton.Hide();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            selectTextText.Show();
            textSelectPanel.Show();
            timeSelectPanel.Show();
            timeSelectText.Show();
            okButton.Show();
            resultsText.Show();

            mistakesText.Hide();
            timerLabel.Hide();
            richTextBox1.Hide();
            stopButton.Hide();
            goBackButton.Hide();
            resultsText.Hide();

            timerLabel.Text = "Time: 00:00:00";
            Global.mistakes = 0;
            mistakesText.Text = "Mistakes made: 0";
        }

        private void text1Name_Click(object sender, EventArgs e)
        {
            Global.Text = MyText.text1;
        }

        private void text2Name_Click(object sender, EventArgs e)
        {
            Global.Text = MyText.text2;
        }

        private void text3Name_Click(object sender, EventArgs e)
        {
            Global.Text = MyText.text3;
        }

        
    }
}

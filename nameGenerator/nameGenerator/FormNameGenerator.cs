using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToggleButtonExample;

namespace nameGenerator
{
    public partial class FormNameGenerator : Form
    {
        public FormNameGenerator()
        {
            using (FormWaiting waiting = new FormWaiting(Wait))
            {
                waiting.ShowDialog(this);
            }
            CenterToScreen();
            InitializeComponent();
            Toggle toggleSwitch = new Toggle();
        }

        void Wait()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private static int i;
        private void button_generate_Click(object sender, EventArgs e)
        {
            i++;
            this.lbl_count.Text = "Deneme sayısı: " + i.ToString();
            if (comboBox1.SelectedIndex == 0)
            {
                this.textbox_name.Text = generateName(Convert.ToInt32(numericUpDown1.Value));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.textbox_name.Text = generateName2(Convert.ToInt32(numericUpDown1.Value));
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.textbox_name.Text = generateName3(Convert.ToInt32(numericUpDown1.Value));
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                this.textbox_name.Text = generateName4(Convert.ToInt32(numericUpDown1.Value));
                if (numericUpDown1.Value > 6)
                {
                    this.textbox_name.Text = textbox_name.Text.Remove(6);
                }
            }
            else
            {
                lbl_count.Text = "Deneme sayısı: 0";
                i = 0;
                this.textbox_name.Text = "Lütfen önce istediğiniz bir formatı seçin!";
            }

            if (this.textbox_name.Text == "enes")
            {
                button_generate.Enabled = false;
            }
        }

        public static string generateName(int length)
        {
            Random random = new Random();
            string[] quiet = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] loud = { "a", "e", "i", "o", "u" };
            string quiteLetter;
            string loudLetter;
            //int nameLength = 5;
            int i = 0;
            string name = "";
            while (i < length)
            {
                i += 1;
                int l1 = random.Next(quiet.Length);
                quiteLetter = (string)quiet[l1];
                name = name + quiteLetter;
                if (i == length)
                {
                    break;
                }
                else
                {
                    i += 1;
                    int l2 = random.Next(loud.Length);
                    loudLetter = (string)loud[l2];
                    name = name + loudLetter;
                    if (i == length)
                    {
                        break;
                    }
                }
            }
            return name;
        }

        public static string generateName2(int length)
        {
            Random random = new Random();
            string[] quiet = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] loud = { "a", "e", "i", "o", "u" };
            string quiteLetter;
            string loudLetter;
            //int nameLength = 5;
            int i = 0;
            string name = "";
            while (i < length)
            {
                i += 1;
                int l2 = random.Next(loud.Length);
                loudLetter = (string)loud[l2];
                name = name + loudLetter;
                if (i == length)
                {
                    break;
                }
                else
                {
                    i += 1;
                    int l1 = random.Next(quiet.Length);
                    quiteLetter = (string)quiet[l1];
                    name = name + quiteLetter;
                    if (i == length)
                    {
                        break;
                    }
                }
            }
            return name;
        }

        public static string generateName3(int length)
        {
            Random random = new Random();
            string[] quiet = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] loud = { "a", "e", "i", "o", "u" };
            string quiteLetter;
            string loudLetter;
            //int nameLength = 5;
            int i = 0;
            string name = "";
            while (i < length)
            {
                i += 1;
                int l1 = random.Next(loud.Length);
                loudLetter = (string)loud[l1];
                name = name + loudLetter;
                if (i == length)
                {
                    break;
                }
                else
                {
                    i += 1;
                    int l2 = random.Next(quiet.Length);
                    quiteLetter = (string)quiet[l2];
                    name = name + quiteLetter;
                    if (i == length)
                    {
                        break;
                    }
                    else
                    {
                        i += 1;
                        int l3 = random.Next(quiet.Length);
                        quiteLetter = (string)quiet[l3];
                        name = name + quiteLetter;
                        if (i == length)
                        {
                            break;
                        }
                        else
                        {
                            i += 1;
                            int l4 = random.Next(loud.Length);
                            loudLetter = (string)loud[l4];
                            name = name + loudLetter;
                            if (i == length)
                            {
                                break;
                            }
                            else
                            {
                                i += 1;
                                int l5 = random.Next(quiet.Length);
                                quiteLetter = (string)quiet[l5];
                                name = name + quiteLetter;
                                if (i == length)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return name;
        }

        public static string generateName4(int length)
        {
            Random random = new Random();
            string[] quiet = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] loud = { "a", "e", "i", "o", "u" };
            string quiteLetter;
            string loudLetter;
            //int nameLength = 5;
            int i = 0;
            string name = "";
            while (i < length)
            {
                i += 1;
                int l1 = random.Next(quiet.Length);
                quiteLetter = (string)quiet[l1];
                name = name + quiteLetter;
                if (i == length)
                {
                    break;
                }
                else
                {
                    i += 1;
                    int l2 = random.Next(loud.Length);
                    loudLetter = (string)loud[l2];
                    name = name + loudLetter;
                    if (i == length)
                    {
                        break;
                    }
                    else
                    {
                        i += 1;
                        int l3 = random.Next(quiet.Length);
                        quiteLetter = (string)quiet[l3];
                        name = name + quiteLetter;
                        if (i == length)
                        {
                            break;
                        }
                        else
                        {
                            i += 1;
                            int l4 = random.Next(quiet.Length);
                            quiteLetter = (string)quiet[l4];
                            name = name + quiteLetter;
                            if (i == length)
                            {
                                break;
                            }
                            else
                            {
                                i += 1;
                                int l5 = random.Next(loud.Length);
                                loudLetter = (string)loud[l5];
                                name = name + loudLetter;
                                if (i == length)
                                {
                                    break;
                                }
                                else
                                {
                                    i += 1;
                                    int l6 = random.Next(quiet.Length);
                                    quiteLetter = (string)quiet[l6];
                                    name = name + quiteLetter;
                                    if (i == length)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return name;
        }

        private void ceLearningToggle1_Click(object sender, EventArgs e)
        {
            if (toggleDark.IsOn == true)
            {
                this.BackColor = System.Drawing.Color.MidnightBlue;
                toggleDark.BorderColor = System.Drawing.Color.MidnightBlue;
                button_generate.ForeColor = System.Drawing.Color.MidnightBlue;
                button_generate.BackColor = System.Drawing.Color.AliceBlue;
                lbl_count.ForeColor = System.Drawing.Color.AliceBlue;
                lbl1.ForeColor = System.Drawing.Color.AliceBlue;
                lbl2.ForeColor = System.Drawing.Color.AliceBlue;
                comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
                comboBox1.BackColor = System.Drawing.Color.AliceBlue;
                numericUpDown1.ForeColor = System.Drawing.Color.AliceBlue;
                numericUpDown1.BackColor = System.Drawing.Color.MidnightBlue;
                textbox_name.ForeColor = System.Drawing.Color.AliceBlue;
                textbox_name.BackColor = System.Drawing.Color.MidnightBlue;
                radioButton_uCase.ForeColor = System.Drawing.Color.AliceBlue;
                radioButton_lCase.ForeColor = System.Drawing.Color.AliceBlue;
            }
            else if (toggleDark.IsOn == false)
            {
                this.BackColor = System.Drawing.Color.AliceBlue;
                toggleDark.BorderColor = System.Drawing.Color.AliceBlue;
                button_generate.ForeColor = System.Drawing.Color.AliceBlue;
                button_generate.BackColor = System.Drawing.Color.MidnightBlue;
                lbl_count.ForeColor = System.Drawing.Color.MidnightBlue;
                lbl1.ForeColor = System.Drawing.Color.MidnightBlue;
                lbl2.ForeColor = System.Drawing.Color.MidnightBlue;
                comboBox1.ForeColor = System.Drawing.Color.AliceBlue;
                comboBox1.BackColor = System.Drawing.Color.MidnightBlue;
                numericUpDown1.ForeColor = System.Drawing.Color.MidnightBlue;
                numericUpDown1.BackColor = System.Drawing.Color.AliceBlue;
                textbox_name.ForeColor = System.Drawing.Color.MidnightBlue;
                textbox_name.BackColor = System.Drawing.Color.AliceBlue;
                radioButton_uCase.ForeColor = System.Drawing.Color.MidnightBlue;
                radioButton_lCase.ForeColor = System.Drawing.Color.MidnightBlue;

            }
        }

        private void radioButton_lCase_CheckedChanged(object sender, EventArgs e)
        {
            textbox_name.CharacterCasing = CharacterCasing.Lower;
        }

        private void radioButton_uCase_CheckedChanged_1(object sender, EventArgs e)
        {
            textbox_name.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
